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
        private ILogger _logger;
        public Notification(ILogger logger) 
        {
            _logger = logger;
        }
        public void Notify(Order order)
        {
            if (order.CustomerEmail != null)
            {
                _logger.Log($"Email sent to {order.CustomerEmail}");
            }
        }
    }
}
