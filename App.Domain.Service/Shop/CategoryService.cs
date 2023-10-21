using App.Domain.Core.Shop.Contacts.Repository;
using App.Domain.Core.Shop.Contacts.Services;
using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Service.Shop
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<int> Add(CategoryInputDto categoryInput, CancellationToken cancellationToken)
        {
            var product = await _categoryRepository.GetById(categoryInput.Id, cancellationToken);
            if (product != null)
            {
                return await _categoryRepository.Add(categoryInput, cancellationToken);
            }

            return 0;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var product = await _categoryRepository.GetById(id, cancellationToken);
            if (product != null)
            {
                return await _categoryRepository.Delete(id, cancellationToken);
            }

            return false;
        }

        public async Task<List<CategoryOutputDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _categoryRepository.GetAll(cancellationToken);
        }

        public async Task<CategoryOutputDto> GetById(int id, CancellationToken cancellationToken)
        {
            return await _categoryRepository.GetById(id, cancellationToken);
        }

        public async Task<int> Update(int id, CategoryInputDto categoryInput, CancellationToken cancellationToken)
        {
            var product = await _categoryRepository.GetById(id, cancellationToken);
            if (product != null)
            {
                return await _categoryRepository.Add(categoryInput, cancellationToken);
            }

            return 0;
        }
    }
}
