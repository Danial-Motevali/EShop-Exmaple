using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Contacts.Repository
{
    public interface IProductInventoryRepository
    {
        Task<int> Add(ProductInventoryInputDto productInventory, CancellationToken cancellationToken);
        Task<int> Update(int id, ProductInventoryInputDto productInventory, CancellationToken cancellationToken);
        Task<bool> Delete(int id, CancellationToken cancellationToken);
        Task<ProductInventoryOutputDto> GetById(int id, CancellationToken cancellationToken);
        Task<List<ProductInventoryOutputDto>> GetAll(CancellationToken cancellationToken);
    }
}
