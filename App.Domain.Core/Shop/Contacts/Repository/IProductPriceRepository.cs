using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Contacts.Repository
{
    public interface IProductPriceRepository
    {
        Task<int> Add(ProductPriceInputDto productPrice, CancellationToken cancellationToken);
        Task<int> Update(int id, ProductPriceInputDto productPrice, CancellationToken cancellationToken);
        Task<bool> Delete(int id, CancellationToken cancellationToken);
        Task<ProductPriceOutputDto> GetById(int id, CancellationToken cancellationToken);
        Task<List<ProductPriceOutputDto>> GetAll(CancellationToken cancellationToken);
    }
}
