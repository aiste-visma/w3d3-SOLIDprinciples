using SOLIDprinciples.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDprinciples.BusinessLogic
{
    public class OrderEventPublisher
    {
        private int State { get; set; } = 0;
        private List<IOrderObserver> observers = new List<IOrderObserver>();

        public void Attach(IOrderObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IOrderObserver observer)
        {
            observers.Remove(observer); 
        }

        public void Notify(Order order)
        {
            foreach(IOrderObserver o in observers)
            {
                o.Update(order);
            }
        }
    }
}
