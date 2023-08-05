using RegistrationForm.FormModels.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace RegistrationForm.Tests.TestCases
{
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private static string type = "Exception";

        public BoundaryTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task<bool> ValidRegisterDataFormModel_NameIsNotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            var formModel = new RegisterDataFormModel
            {
                Name = "",
                Email = "john@gmail.com",
                Age = 30,
                MobileNumber = "1234567892",
                Address = "aaaaaaaaaa"
            };
            var validationContext = new ValidationContext(formModel, null, null);
            var validationResults = new List<ValidationResult>();

            //Action
            try
            {
                var isValid = Validator.TryValidateObject(formModel, validationContext, validationResults, true);

                //Assertion
                if (!isValid)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> ValidRegisterDataFormModel_AgeIsNotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            var formModel = new RegisterDataFormModel
            {
                Name = "john",
                Email = "john@gmail.com",
                Age = 0,
                MobileNumber = "1234567890",
                Address = "123 Main St"
            };
            var validationContext = new ValidationContext(formModel, null, null);
            var validationResults = new List<ValidationResult>();

            //Action
            try
            {
                var isValid = Validator.TryValidateObject(formModel, validationContext, validationResults, true);

                //Assertion
                if (!isValid)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> ValidRegisterDataFormModel_MobileNumberIsNotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            var formModel = new RegisterDataFormModel
            {
                Name = "john",
                Email = "john@gmail.com",
                Age = 30,
                MobileNumber = "12",
                Address = "123 Main St"
            };
            var validationContext = new ValidationContext(formModel, null, null);
            var validationResults = new List<ValidationResult>();

            //Action
            try
            {
                var isValid = Validator.TryValidateObject(formModel, validationContext, validationResults, true);

                //Assertion
                if (!isValid)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> ValidRegisterDataFormModel_AddressIsNotNull()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();
            var formModel = new RegisterDataFormModel
            {
                Name = "john",
                Email = "john@gmail.com",
                Age = 30,
                MobileNumber = "1234567892",
                Address = ""
            };
            var validationContext = new ValidationContext(formModel, null, null);
            var validationResults = new List<ValidationResult>();

            //Action
            try
            {
                var isValid = Validator.TryValidateObject(formModel, validationContext, validationResults, true);

                //Assertion
                if (!isValid)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }
    }
}
