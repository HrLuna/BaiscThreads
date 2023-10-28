using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicThreads
{
    public partial class frmBasicThread : Form
    {
        private Thread ThreadA, ThreadB;
        public frmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine(" -Before Starting Thread- ");
            ThreadStart thread = new ThreadStart(MyThreadClass.Thread1);

            ThreadA = new Thread(thread);
            ThreadB = new Thread(thread);
            
            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";
            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine(" -End of Thread- ");
            lblThread.Text = " -End of Thread- ";
        }
    }
}
