using App.Domain.Core.Shop.Contacts.AppService;
using App.Domain.Core.Shop.Contacts.Services;
using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Shop
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductService _productService;

        public ProductAppService(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<GeneralOutputDto> Add(ProductInputDto productInput, CancellationToken cancellationToken)
        {
            var product = await _productService.Add(productInput, cancellationToken);
            string msg = null;
            if (product == 0)
            {
                msg = "Product NotCreated";
            }
            else
            {
                msg = "Product Created";
            }

            return new GeneralOutputDto()
            {
                Id = product,
                Messeage = msg
            };
        }

        public async Task<GeneralOutputDto> Delete(int id, CancellationToken cancellationToken)
        {
            var product = await _productService.Delete(id, cancellationToken);
            string msg = null;
            if (product == null)
            {
                msg = "Product NotCreated";
            }
            else
            {
                msg = "Product Created";
            }

            return new GeneralOutputDto()
            {
                Id = id,
                Messeage = msg
            };
        }

        public async Task<List<ProductOutputDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _productService.GetAll(cancellationToken);
        }

        public async Task<ProductOutputDto> GetById(int id, CancellationToken cancellationToken)
        {
            return await _productService.GetById(id, cancellationToken);
        }

        public async Task<GeneralOutputDto> Update(int id, ProductInputDto productInput, CancellationToken cancellationToken)
        {
            var product = await _productService.Update(id, productInput, cancellationToken);
            string msg = null;
            if (product == 0)
            {
                msg = "Product NotCreated";
            }
            else
            {
                msg = "Product Created";
            }

            return new GeneralOutputDto()
            {
                Id = product,
                Messeage = msg
            };
        }
    }
}
