using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonPatternApp.Model
{
    public class DataService:Form
    {
        private static DataService _instance;
        public DataService()
        {
            Console.WriteLine("data service created");
            this.Text = "Ekta's form";
            this.Width = 500;
            this.Height = 500;

            Button btnHello = new Button();
            btnHello.Text = "Hello";
            btnHello.Click += ((a, b) =>
            {
                MessageBox.Show("Hello there");
            }
            );

            //introducing the thread that stop blocking the whole application
            Button btnWithThreadOne = new Button();
            btnWithThreadOne.Text = "Thread one";
            btnWithThreadOne.Location = new System.Drawing.Point(300, 1);

            btnWithThreadOne.Click += ((a, b) =>
            {
                Thread t = new Thread(DoSomething); t.Start();

            });

            Button btnWithThreadTwo = new Button();
            btnWithThreadTwo.Text = "Thread two";
            btnWithThreadTwo.Location = new System.Drawing.Point(400, 1);

            btnWithThreadTwo.Click += ((a, b) => {
             Thread  v= new Thread(DoSomething); v.Start();
            
            });

            Button btnWithThreadThree = new Button();
            btnWithThreadThree.Text = "Thread three";
            btnWithThreadThree.Location = new System.Drawing.Point(500, 1);

            btnWithThreadThree.Click += ((a, b) =>
            {

                Thread w = new Thread(DoSomething); w.Start();
            });

            this.Controls.Add( btnHello );
            this.Controls.Add( btnWithThreadOne );
            this.Controls.Add ( btnWithThreadTwo );
            this.Controls.Add( btnWithThreadThree );
        }
        public void DoSomething()
        {
            while (true)
            {
                Console.WriteLine("Processing Data By" + this.GetHashCode());
            }
            
        }
        public static DataService GetInstance()
        {
            if(_instance==null)
            {
                _instance = new DataService();
            }
            return _instance;
        }
    }
}
