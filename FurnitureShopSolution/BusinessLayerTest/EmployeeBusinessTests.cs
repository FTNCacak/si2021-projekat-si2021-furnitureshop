using BussniessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.Interfaces.Repository;
using Shared.Models;
using System;
using NUnit;
using System.Collections.Generic;

namespace BusinessLayerTest
{
    [TestClass]
    public class EmployeeBusinessTests
    {
        private Mock<IEmployeeRepository> mockEmployeeRepository = new Mock<IEmployeeRepository>();

        private Employee employee = new Employee
        {
            EmployeeID = 1234,
            Name = "Employee Employovic",
            Email = "asd@gmail.com",
            PhoneNumber = 063123123,
            Address = "Adresa 23",
            Username = "employeeeet",
            Password = "123123",
            Role = "",
            ManagerID = 8888
        };


        private List<Employee> listOfEmployees = new List<Employee>();
        private EmployeeBusiness employeeBusiness;

        public EmployeeBusinessTests()
        {
            listOfEmployees.Add(employee);
            listOfEmployees.Add(new Employee
            {
                EmployeeID = 2,
                Name = "Aleksandar Sutic",
                Email = "coica@gmail.com",
                PhoneNumber = 063123123,
                Address = "Adresa 23",
                Username = "aleksandar21",
                Password = "123123",
                Role = "Admininstrator",
                ManagerID = 21
            });
            listOfEmployees.Add(new Employee
            {
                EmployeeID = 2,
                Name = "Uros Mitrovic",
                Email = "kuki@gmail.com",
                PhoneNumber = 063123123,
                Address = "Adresa 23",
                Username = "clicker",
                Password = "123909093#21",
                Role = "Other Role",
                ManagerID = 21
            });
        }
        [TestMethod]
        public void IsEmployeeInserted()    //done
        {
            //arrange
            mockEmployeeRepository.Setup(x => x.InsertEmployee(employee)).Returns(1);
            this.employeeBusiness = new EmployeeBusiness(mockEmployeeRepository.Object);
            //act
            var result = employeeBusiness.InsertEmployee(employee);
            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetAllEmployeesTest()   //done
        {
            mockEmployeeRepository.Setup(x => x.GetAllEmployees()).Returns(listOfEmployees);
            this.employeeBusiness = new EmployeeBusiness(mockEmployeeRepository.Object);

            var result = employeeBusiness.GetAllEmployees();

            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void IsEmployeeUpdated()
        {
            //arrange
            mockEmployeeRepository.Setup(x => x.UpdateEmployee(employee)).Returns(1);
            this.employeeBusiness = new EmployeeBusiness(mockEmployeeRepository.Object);
            //act
            var result = employeeBusiness.UpdateEmployee(employee);
            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void IsEmployeeDeleted()
        {
            //arrange
            mockEmployeeRepository.Setup(x => x.DeleteEmplyee(employee.EmployeeID)).Returns(1);
            this.employeeBusiness = new EmployeeBusiness(mockEmployeeRepository.Object);
            //act
            var result = employeeBusiness.DeleteEmployee(employee.EmployeeID);
            //assert
            Assert.AreEqual(1, result);
        }
    }
}
