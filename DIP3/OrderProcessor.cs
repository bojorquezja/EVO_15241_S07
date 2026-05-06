using DIP3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP3 {
    internal class OrderProcessor {
        private readonly INotification _Notif;
        public OrderProcessor(INotification notif) {
            _Notif = notif;
        }
        public void ProcessOrder() {
            // Order processing logic
            Console.WriteLine("Order processed.");
            // Send notification
            _Notif.Send("Your order has been processed.");
        }
    }
}
