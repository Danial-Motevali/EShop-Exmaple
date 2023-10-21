using App.Domain.Core.Shop.Contacts.Repository;
using App.Domain.Core.Shop.Contacts.Services;
using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Shop
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int> Add(ProductInputDto productInput, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetById(productInput.Id, cancellationToken);
            if (product != null)
            {
                return await _productRepository.Add(productInput, cancellationToken);
            }

            return 0;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetById(id, cancellationToken);
            if (product != null)
            {
                return await _productRepository.Delete(id, cancellationToken);

                return true;
            }

            return false;
        }

        public async Task<List<ProductOutputDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _productRepository.GetAll(cancellationToken);
        }

        public async Task<ProductOutputDto> GetById(int id, CancellationToken cancellationToken)
        {
            return await _productRepository.GetById(id, cancellationToken);
        }

        public async Task<int> Update(int id, ProductInputDto productInput, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetById(id, cancellationToken);
            if (product != null)
            {
                return await _productRepository.Add(productInput, cancellationToken);
            }

            return 0;
        }
    }
}
