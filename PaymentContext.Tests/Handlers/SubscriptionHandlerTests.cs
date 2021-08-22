using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();

            command.FirstName = "Matheus";
            command.LastName = "Willian";
            command.Document = "99999999999";
            command.Email = "mtswill@mtswill";
            command.BarCode = "123456789";
            command.BoletoNumber = "123456789";
            command.PaymentNumber = "123456";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "Matheus";
            command.PayerDocument = "12345678900";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "mtswill@mtswill";
            command.Street = "Rua";
            command.AddressNumber = "135";
            command.Neighborhood = "Bairro";
            command.City = "Cidade";
            command.State = "SP";
            command.Country = "Brasil";
            command.ZipCode = "123456789";

            handler.Handle(command);
            Assert.AreEqual(false, handler);
        }
    }
}