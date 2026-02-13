using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class EmailNotifier : IOrderObserver
    {
        private ILogger _logger;
        public EmailNotifier(ILogger logger) 
        {
            _logger = logger;
        }
        public void Update(Order order)
        {
            if (order.CustomerEmail != null)
            {
                _logger.Log($"Email sent to {order.CustomerEmail}");
            }
        }
    }
}
