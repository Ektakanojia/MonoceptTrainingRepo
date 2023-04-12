using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDesignPattern.Model
{
    internal abstract class OrderProcess
    {
        public bool isGift;

        public abstract void doSelect();

        public abstract void doPayment();

        public  void giftWrap()
        {
            try
            {
                Console.WriteLine("Gift wrap successful");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gift wrap unsuccessful");
                Console.WriteLine(ex.Message);
            }
        }

        public abstract void doDelivery();

        public  void processOrder(bool isGift)
        {
            doSelect();
            doPayment();
            if (isGift)
            {
                giftWrap();
            }
            doDelivery();
        }
    }
}
