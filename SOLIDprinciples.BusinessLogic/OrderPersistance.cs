using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class OrderPersistence
    {
        private readonly IOrderRepository _orderRepository;
        public OrderPersistence(IOrderRepository orderRepository) 
        {
         _orderRepository = orderRepository;   
        }
        public void PersistOrder(Order order)
        {
            _orderRepository.SaveOrder(order);
        }
    }
}
