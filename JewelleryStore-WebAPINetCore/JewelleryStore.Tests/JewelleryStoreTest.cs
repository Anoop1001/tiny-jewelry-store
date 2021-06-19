using JewelleryStore.Business;
using JewelleryStore.Data;
using JewelleryStore.Models;
using JewelleryStore.SDK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace JewelleryStore.Tests
{
    [TestClass]
    public class JewelleryStoreTest
    {
        private readonly CustomerController customerController;
        private readonly CustomerRepository customerCredentialsRepository;
        private readonly CustomerManager customerManager;
        private readonly PriceCalculatorService priceCalculatorService;
        public JewelleryStoreTest()
        {
            customerCredentialsRepository = new CustomerRepository();
            customerManager = new CustomerManager(customerCredentialsRepository);
            priceCalculatorService = new PriceCalculatorService(customerCredentialsRepository);
            customerController = new CustomerController(customerManager, priceCalculatorService);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task Login_When_Invalid_CredentialsPassed_Returns_Null()
        {
            var Customer = await customerController.Login(new CustomerLoginModel { Name = "WrongName", Password = "WrongCredentials" });
        }

        [TestMethod]
        public async Task<CustomerCredentials> Login_When_Valid_CredentialsPassed_Returns_Customer()
        {
            var customer = await customerController.Login(new CustomerLoginModel { Name = "Anoop", Password = "PasswordForAnoop1" });
            Assert.AreEqual(customer.Name, "Anoop");
            return customer;
        }

        [TestMethod]
        public async Task<CustomerCredentials> Login_When_Valid_CredentialsPassed_Returns_PrevilegedCustomer()
        {
            var customer = await customerController.Login(new CustomerLoginModel { Name = "Anoop2", Password = "PasswordForAnoop2" });
            Assert.AreEqual(customer.Name, "Anoop2");
            return customer;
        }

        [TestMethod]
        public async Task Get_Price_When_Valid_CustomerId_Jewellery_Returns_TotalPrice()
        {
            var customer = await Login_When_Valid_CredentialsPassed_Returns_Customer();
            var totalPrice = await customerController.CalculatePrice(customer.Id, JewelleryFactory.CreateGoldJewellery(100, 10) as Gold);
            Assert.AreEqual(totalPrice, 1000);
        }

        [TestMethod]
        public async Task Get_Price_When_Valid_PrevilegeCustomerId_Jewellery_Returns_TotalPrice()
        {
            var loggedInCustomer = await Login_When_Valid_CredentialsPassed_Returns_PrevilegedCustomer();
            var customer = (await customerController.GetCustomer(loggedInCustomer.Id)) as PrevilegedCustomer;
            var totalPrice = await customerController.CalculatePrice(customer.Id, JewelleryFactory.CreateGoldJewellery(100, 10) as Gold);
            Assert.AreEqual(totalPrice, (100 * 10) - (10* customer.Discount));
        }

        [TestMethod]
        public async Task Get_ZeroPrice_When_Valid_PrevilegeCustomerId_Jewellery_Returns_TotalPrice()
        {
            var loggedInCustomer = await Login_When_Valid_CredentialsPassed_Returns_PrevilegedCustomer();
            var customer = (await customerController.GetCustomer(loggedInCustomer.Id)) as PrevilegedCustomer;
            var totalPrice = await customerController.CalculatePrice(customer.Id, JewelleryFactory.CreateGoldJewellery() as Gold);
            Assert.AreEqual(totalPrice, 0);
        }
    }
}
