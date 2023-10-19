using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Contacts.AppService
{
    public interface IProductAppService
    {
        Task<int> Add(ProductInputDto productInput, CancellationToken cancellationToken);

        Task<int> Update(int id, ProductInputDto productInput, CancellationToken cancellationToken);

        Task<bool> Delete(int id, CancellationToken cancellationToken);

        Task<ProductOutputDto> GetById(int id, CancellationToken cancellationToken);

        Task<List<ProductOutputDto>> GetAll(CancellationToken cancellationToken);
    }
}
