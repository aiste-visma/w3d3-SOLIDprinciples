using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class Notification : ISendEmail
    {
        public void Notify(Order order)
        {
            if (order.CustomerEmail != null)
            {
                Console.WriteLine($"Email sent to {order.CustomerEmail}");
            }
        }
    }
}
