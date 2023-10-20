using App.Domain.Core.Shop.Contacts.AppService;
using App.Domain.Core.Shop.Contacts.Repository;
using App.Domain.Core.Shop.Contacts.Services;
using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Shop
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryAppService _categoryAppService;
        public CategoryAppService(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }
        public async Task<int> Add(CategoryInputDto categoryInputDto, CancellationToken cancellationToken)
        {
            return await _categoryAppService.Add(categoryInputDto, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _categoryAppService.Delete(id, cancellationToken);
        }

        public async Task<List<CategoryOutputDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _categoryAppService.GetAll(cancellationToken);
        }

        public async Task<CategoryOutputDto> GetById(int id, CancellationToken cancellationToken)
        {
            return await _categoryAppService.GetById(id, cancellationToken);
        }

        public async Task<int> Update(int id, CategoryInputDto categoryInputDto, CancellationToken cancellationToken)
        {
            return await _categoryAppService.Update(id, categoryInputDto, cancellationToken);
        }
    }
}
