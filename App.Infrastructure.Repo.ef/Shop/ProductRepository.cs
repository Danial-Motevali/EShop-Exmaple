using App.Domain.Core.Shop.Contacts.Repository;
using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Repo.ef.Shop
{
    public class ProductRepository : IProductRepository
    {

        public Task<int> Add(ProductInputDto productInput, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductOutputDto>> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ProductOutputDto> GetById(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int id, ProductInputDto productInput, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
