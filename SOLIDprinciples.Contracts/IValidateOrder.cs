using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.Contracts
{
    public interface IValidateOrder
    {
        public void ValidateOrder(Order order);
    }
}
