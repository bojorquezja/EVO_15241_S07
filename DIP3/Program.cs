// Use EmailNotification CASO INVERSION DE DEPENDENCIA

using DIP3;

EmailNotification email = new EmailNotification();
SmsNotification sms = new SmsNotification();
WspNotification wsp = new WspNotification();

var orderProcessor = new OrderProcessor(wsp);
orderProcessor.ProcessOrder();