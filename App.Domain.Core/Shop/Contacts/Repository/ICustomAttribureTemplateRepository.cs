using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Contacts.Repository
{
    public interface ICustomAttribureTemplateRepository
    {
        Task<int> Add(CustomAttribureTemplateInputDto customAttribureTemplate, CancellationToken cancellationToken);
        Task<int> Update(int id, CustomAttribureTemplateInputDto customAttribureTemplate, CancellationToken cancellationToken);
        Task<bool> Delete(int id, CancellationToken cancellationToken);
        Task<CustomAttribureTemplateOututDto> GetById(int id, CancellationToken cancellationToken);
        Task<List<CustomAttribureTemplateOututDto>> GetAll(CancellationToken cancellationToken);
    }
}
