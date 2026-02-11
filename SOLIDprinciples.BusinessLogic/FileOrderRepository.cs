using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class FileOrderRepository : IOrderRepository
    {
        public void SaveOrder(Order order)
        {
            File.AppendAllText("orders.txt", order.Id + Environment.NewLine);
        }
    }
}
