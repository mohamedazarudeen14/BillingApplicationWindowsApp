using System;
using System.Windows.Forms;

namespace AOneStoreBillingSystem
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //if(!IsAnotherProcessRunning())
            //{
                Application.Run(new HomePage());
            //}
            //else
            //{
            //    MessageBox.Show("Another Instance Of This Application Running");
            //    Application.Exit();
            //}
        }

        //private static bool IsAnotherProcessRunning()
        //{
        //    Process[] process = Process.GetProcessesByName("AOneStoreBillingSystem");
        //    if(process.Length > 0)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
