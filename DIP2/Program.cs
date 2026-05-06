// Use EmailNotification CASO INYECCION DE DEPENDENCIA
using DIP;
EmailNotification email = new EmailNotification();
var orderProcessor = new OrderProcessor(email);
orderProcessor.ProcessOrder();