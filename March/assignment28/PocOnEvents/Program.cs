using PocOnEvents.Model;

namespace PocOnEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.OnCreated += Email.Send;
            order.OnCreated += Sms.Send;

            order.Create();

        }
    }
}