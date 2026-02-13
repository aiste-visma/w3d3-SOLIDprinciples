using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    internal class AuditLogger : IOrderObserver
    {
        private ILogger _logger;
        public AuditLogger(ILogger logger)
        {
            _logger = logger;
        }
        public void Update(Order order)
        {
            if (order.CustomerEmail != null)
            {
                _logger.Log($"Logging order {order.Id}.");
            }
        }
    }
}
