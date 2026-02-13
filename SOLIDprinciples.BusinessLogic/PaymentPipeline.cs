using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class PaymentPipeline
    {
        private PaymentValidationStep validationStep;
        private PaymentExecutionStep executionStep;
        private PaymentAuditStep auditingStep;
        private ILogger logger;

        public PaymentPipeline(ILogger logger)
        {
            this.logger = logger;
            validationStep = new PaymentValidationStep();
            executionStep = new PaymentExecutionStep(logger);
            auditingStep = new PaymentAuditStep(logger);

            List<IPaymentStep> steps = [validationStep, executionStep, auditingStep];
        }

        public async Task Execute(decimal amount)
        {
            await validationStep.Handle(amount, () => executionStep.Handle(amount, () => (auditingStep.Handle(amount, () => Task.CompletedTask))));
        }


    }
}
