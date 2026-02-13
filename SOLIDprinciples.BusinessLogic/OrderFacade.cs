using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class OrderFacade
    {
        private readonly IPaymentStrategyFactory _payment;
        private readonly IOrderRepository _persistOrder;
        private readonly ILogger _logger;
        private IValidateOrder _validateOrder;
        private PaymentPipeline _paymentPipeline;

        private OrderService _orderService;

        public OrderFacade()
        {

            AppSettings.Instance().EnablePaymentLogging = false;
            _logger = new ConsoleLogger();
            _persistOrder = new FileOrderRepository();
            _validateOrder = new OrderValidation();
            _payment = new PaymentStrategyFactory();


            var publisher = new OrderEventPublisher();
            var emailNotifier = new EmailNotifier(_logger);
            var auditLogger = new AuditLogger(_logger);
            publisher.Attach(emailNotifier);
            publisher.Attach(auditLogger);

            _paymentPipeline = new PaymentPipeline(_logger);


            _orderService = new OrderService(
                 _persistOrder, _logger, _validateOrder, publisher);
                        
        }
        public async Task ProcessOrder(Order order)
        {
            var _paymentStrategy = _payment.GetPaymentStrategy(order, _logger);
            

            var _timingDecorator = new PaymentTimingDecorator(_paymentStrategy, _logger);
            var _loggingDecorator = new PaymentLoggingDecorator(_timingDecorator, _logger);


            await _paymentPipeline.Execute(order.Total);
            _orderService.ProcessOrder(order, _loggingDecorator);
        }

    } 
}
