using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreparationRoom
{

    class Program
    {
        /*
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
         */

        static void Main(string[] Args)
        {
            RemotingConfiguration.Configure("PreparationRoom.exe.config", false);
            Console.WriteLine("Press <Enter> to terminate.");

            Common.OrderList list = new Common.OrderList();
            list.OnPreparing += new Common.OrderEventHandler().HandleOnPreparing;

            //PreparationHandler e = new PreparationHandler();
            //list.OnNew += new Common.StatusChange(e.StartPreparationHandler);
            //list.OnNew += new Common.StatusChange(e.HandleOnPreparing);
            //list.OnNew += e.HandleOnPreparing;


            Console.ReadLine();
        }

        
    }
}
