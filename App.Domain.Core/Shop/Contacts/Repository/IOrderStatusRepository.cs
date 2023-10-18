using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Contacts.Repository
{
    public interface IOrderStatusRepository
    {
        Task<int> Add(OrderStatusInputDto orderStatus, CancellationToken cancellationToken);
        Task<int> Update(int id, OrderStatusInputDto orderStatus, CancellationToken cancellationToken);
        Task<bool> Delete(int id, CancellationToken cancellationToken);
        Task<OrderStatusOutputDto> GetById(int id, CancellationToken cancellationToken);
        Task<List<OrderStatusOutputDto>> GetAll(CancellationToken cancellationToken);
    }
}
