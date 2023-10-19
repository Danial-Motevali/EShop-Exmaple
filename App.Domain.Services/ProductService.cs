using App.Domain.Core.Shop.Contacts.Repository;
using App.Domain.Core.Shop.Contacts.Services;
using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> Add(ProductInputDto productInput, CancellationToken cancellationToken)
        {
            var product = await _repository.GetById(productInput.Id, cancellationToken);
            if (product != null) 
            {
                await _repository.Add(productInput, cancellationToken);
            }

            return 0;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var product = await _repository.GetById(id, cancellationToken);
            if(product != null)
            {
                await _repository.Delete(id, cancellationToken);

                return true;
            }

            return false;
        }

        public Task<List<ProductOutputDto>> GetAll(CancellationToken cancellationToken)
        {
            return _repository.GetAll(cancellationToken);
        }

        public Task<ProductOutputDto> GetById(int id, CancellationToken cancellationToken)
        {
            return _repository.GetById(id, cancellationToken);
        }

        public async Task<int> Update(int id, ProductInputDto productInput, CancellationToken cancellationToken)
        {
            var product = await _repository.GetById(id, cancellationToken);
            if (product != null)
            {
                await _repository.Update(id, productInput, cancellationToken);
            }

            return 0;
        }
    }
}
