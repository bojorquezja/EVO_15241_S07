// Use EmailNotification CASO INVERSION DE DEPENDENCIA

using DIP3;

EmailNotification email = new EmailNotification();
SmsNotification sms = new SmsNotification();

var orderProcessor = new OrderProcessor(sms);
orderProcessor.ProcessOrder();