using AccountPolymorphismApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp
{
    [TestClass]
     public class SavingTest
    {
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ItShouldThrowExceptionIfMinBalanceIsNotMaintanceAndTryToWithDrawAmount()
        {
            double exceptedBalance = 700;
            SavingAccount savingAccount = new SavingAccount(1001, 800, "Ekta");
            savingAccount.Withdraw(100);
            double actualBalance= savingAccount.Balance;
            Assert.AreEqual(exceptedBalance, actualBalance);
        }
        [TestMethod]
        public void ItShouldThrowExceptionIfMinBalanceAviableAfterDrwaingAmount()
        {
            double exceptedBalance = 1000;
            SavingAccount savingAccount = new SavingAccount(1001, 1200, "Ekta");
            savingAccount.Withdraw(200);
            double actualBalance= savingAccount.Balance;
            Assert.AreEqual(exceptedBalance, actualBalance);

        }
        [TestMethod]
        public void ShouldWithDrawAmountFromTheAccount()
        {
            double exceptedBalance = 1200;
            SavingAccount savingAccount = new SavingAccount(1001, 2000, "Ekta");
            savingAccount.Withdraw(800);
            double actualBalance= savingAccount.Balance;
            Assert.AreEqual(exceptedBalance, actualBalance);    

        }
    }
}
