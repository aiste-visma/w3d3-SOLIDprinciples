using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class OrderValidation : IValidateOrder
    {
        public void ValidateOrder(Order order)
        {
            if (order == null)
                throw new Exception("Order is null");

        }
    }
}
