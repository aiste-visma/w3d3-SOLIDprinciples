using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class OrderPersistence
    {
        public void PersistOrder(Order order)
        {
            File.AppendAllText("orders.txt", order.Id + Environment.NewLine);
        }
    }
}
