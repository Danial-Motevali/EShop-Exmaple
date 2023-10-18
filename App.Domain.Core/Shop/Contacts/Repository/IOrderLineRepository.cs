using App.Domain.Core.Shop.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Shop.Contacts.Repository
{
    public interface IOrderLineRepository
    {
        Task<int> Add(OrderLineInputDto orderLine, CancellationToken cancellationToken);
        Task<int> Update(int id, OrderLineInputDto orderLine, CancellationToken cancellationToken);
        Task<bool> Delete(int id, CancellationToken cancellationToken);
        Task<OrderLineOutputDto> GetById(int id, CancellationToken cancellationToken);
        Task<List<OrderLineOutputDto>> GetAll(CancellationToken cancellationToken);
    }
}
