using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Contacts.Repository
{
    public interface IOrderRepository
    {
        Task<int> Add(OrderInputDto order, CancellationToken cancellationToken);
        Task<int> Update(int id, OrderInputDto order, CancellationToken cancellationToken);
        Task<bool> Delete(int id, CancellationToken cancellationToken);
        Task<OrderOutputDto> GetById(int id, CancellationToken cancellationToken);
        Task<List<OrderOutputDto>> GetAll(CancellationToken cancellationToken);
    }
}
