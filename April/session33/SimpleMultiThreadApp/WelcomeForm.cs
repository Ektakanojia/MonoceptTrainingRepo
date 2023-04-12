using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMultiThreadApp
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
            btnHello.Click += ((a, b ) =>
            {
                MessageBox.Show("Hello there");
            }
            );

            Button btnPrint = new Button();
            btnPrint.Text = "Print Infinite";
            btnPrint.Location = new System.Drawing.Point(250, 0);
            btnPrint.Click += ((a, b) =>
            {
               PrintInfinity();


            });

            //introducing the thread that stop blocking the whole appl
            Button btnWithThread = new Button();
            btnWithThread.Text = "Non blocking/Async";
            btnWithThread.Location = new System.Drawing.Point(350, 1);

            btnWithThread.Click += ((a, b) =>
            {
                Thread t= new Thread(PrintInfinity); t.Start(); 

            });


            this.Controls.Add(btnHello); 
            this.Controls.Add(btnPrint);
            this.Controls.Add(btnWithThread);

        }
        public void PrintInfinity()
        {
            //DateTime startTime=DateTime.Now;
            //TimeSpan future = TimeSpan.FromMinutes(.15);
            while (true)
            // while(DateTime.Now.Subtract(startTime) < future)
            {
                Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
            }
        }

        
    }
}
