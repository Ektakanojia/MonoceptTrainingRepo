using AccountPolymorphismApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp
{
    [TestClass]
     public class CurrentTest
    {
        [TestMethod]
        public void ItShouldWithDrawTheAmountFromTheAccountIfAvialabeBalanceMinusWithdrawAmonutIsGreaterThanOverDraft()
        {
            int exceptedBalance = 10000;
            CurrentAccount currentAccount = new CurrentAccount(1001, 20000, "Ekta");
            currentAccount.Withdraw(10000);
            double actualBalance= currentAccount.Balance;
            Assert.AreEqual(exceptedBalance, actualBalance);
        }

        [TestMethod]
        public void ItShouldWithDrawTheAmountFromCurrentAccountIfTheNameAndAccountNoWillBeSame()
        {
            double exceptedBalance = 1000;
            string exceptedName = "Ankit";
            int exceptedAccountNumber = 1002;
            CurrentAccount currentAccount = new CurrentAccount(1002, 3000, "Ankit");
            currentAccount.Withdraw(2000);
            double actualBalance = currentAccount.Balance;
            string  actualName = currentAccount.Name;
             double actualAccountNo = currentAccount.Accountno;
           
        }
    }
}
