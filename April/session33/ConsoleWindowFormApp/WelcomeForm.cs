using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleWindowFormApp
{
    internal class WelcomeForm : Form

    {
        public WelcomeForm()
        {
            this.Text = "Ekta's form";
            this.Width = 500;
            this.Height = 500;

            Button btnHello = new Button();
            btnHello.Text = "Hello";
            btnHello.Click += GodListner;
            btnHello.Click += DevilListner;

            this.Controls.Add(btnHello);

        }

        public void GodListner(object sender, EventArgs e)
        {
            Console.WriteLine("God is Listening");
        }

        public void DevilListner(object sender, EventArgs e)
        {
            Console.WriteLine("Devil is Listening");
        }
    }
}
