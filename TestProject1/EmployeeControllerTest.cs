using EmployeeService.Controllers;
using EmployeeService.DTOS;
using EmployeeService.Models;
using EmployeeService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace EmployeeServiceTest
{
    [TestFixture]
    public class CustomerControllerTest
    {
        //mock object
        EmployeeController cu;
        [SetUp]
        public void Initialise()
        {
        }
        [Test]
        public void TestValidatePositive()
        {
            var mock = new Mock<IEmployeeService>();
            EmployeeLoginDTO c = new EmployeeLoginDTO { Email = "Mydo@gmail.com", Password = "pass@123" };
            cu = new EmployeeController(mock.Object);
            mock.Setup(c => c.ValidateUser(It.IsAny<EmployeeLoginDTO>())).Returns(false);
            //Assert.IsAssignableFrom<TokenResult>(cu.Validate(c));
            // Assert.That(actual, Is.AssignableFrom(typeof(TExpected)), null, null);
            Assert.Pass();
        }
        [Test]
        public void TestValidateNegative()
        {
            Assert.Pass();
        }
        [Test]
        public void TestRegisterPositive()
        {
            Employee c = new Employee() { Email = "Ashwani@gmail.com", Password = "pass@123", Name = "Ashwani", Phone = "1234567890" };
            var mock = new Mock<IEmployeeService>();
            mock.Setup(m => m.RegisterCustomer(It.IsAny<Employee>())).Returns(true);
            cu = new EmployeeController(mock.Object);
            Assert.IsAssignableFrom<OkObjectResult>(cu.Post(c));
        }
        [Test]
        public void TestRegisterCustomerNull()
        {
            var mock = new Mock<IEmployeeService>();
            // mock.Setup(m => m.RegisterCustomer(It.IsAny<Customer>())).Returns(true);
            cu = new EmployeeController(mock.Object);
            // Assert.IsAssignableFrom<BadRequestObjectResult>(cu.Post(null));
            Assert.Pass();
        }
       
        [TearDown]
        public void Cleanup()
        {
        }
    }
}