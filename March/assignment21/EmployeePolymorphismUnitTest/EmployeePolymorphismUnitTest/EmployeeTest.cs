using EmployeePolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismUnitTest
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void ItShouldValidateEmployee()
        {
            int exceptedId = 1001;
            string exceptedName = "Ekta";
            double exceptedBasic = 20000;
            Employee emp = new Employee(1001, "Ekta", 20000);
            int actualId = emp.ID;
            string actualName = emp.Name;
            double actualBasic = emp.Basic;
            Assert.AreEqual(exceptedId, actualId);
            Assert.AreEqual(exceptedName, actualName);
            Assert.AreEqual(exceptedBasic, actualBasic);
        }
        [TestMethod]
        public void ItShouldCalculateTheAnnualSalary()
        {
            double exceptedSalary = 240000;
            Employee emp = new Employee(1001, "Ekta", 20000);

            double actualSalary = emp.CalculateAnnualSalary();
            Assert.AreEqual(exceptedSalary, actualSalary);


        }
        [TestMethod]
        public void ItShouldValidateTheManagerAnnualSalary()
        {
            double exceptedSalary = 624000;
            Manager manager = new Manager(1002, "Ankit", 20000);
            double actualSalary = manager.CalculateAnnualSalary();
            Assert.AreEqual(exceptedSalary, actualSalary);
        }
        [TestMethod]
        public void ItShouldValidateTheDeveloperAnnualSalary()
        {
            double exceptedSalary = 228000;
            Developer developer = new Developer(1003, "Aditiya", 10000);
            double actualSalary = developer.CalculateAnnualSalary();
            //Assert.IsTrue(actualSalary > exceptedSalary);
            Assert.AreEqual(exceptedSalary, actualSalary);
        }
        [TestMethod]
        public void ItSholudValidateTheQualityAnalystAnnualSalary()
        {
            double exceptedSalary = 504000;
            QualityAnalyst qualityAnalyst = new QualityAnalyst(1003, "Subran", 30000);
            double actualSalary= qualityAnalyst.CalculateAnnualSalary();
            Assert.AreEqual(exceptedSalary,actualSalary);
        }

    }
}
