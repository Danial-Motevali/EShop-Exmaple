using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Contacts.Repository
{
    public interface IProductCustomAttributeRepository
    {
        Task<int> Add(ProductCustomAttributeInputDto productCustomAttribute, CancellationToken cancellationToken);
        Task<int> Update(int id, ProductCustomAttributeInputDto productCustomAttribute, CancellationToken cancellationToken);
        Task<bool> Delete(int id, CancellationToken cancellationToken);
        Task<ProductCustomAttributeOutputDto> GetById(int id, CancellationToken cancellationToken);
        Task<List<ProductCustomAttributeOutputDto>> GetAll(CancellationToken cancellationToken);
    }
}
