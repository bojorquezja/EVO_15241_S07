using DIP3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP3 {
    internal class EmailNotification : INotification {
        public void Send(string message) {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}
