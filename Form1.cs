using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FrmBasicThread1
{
    public partial class Form1 : Form
    {

        private Thread Thread_1, Thread_2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delthreadStart = new ThreadStart(MythreadClass.threads);

            Thread_1 = new Thread(delthreadStart);
            Thread_1.Name = "Thread A";
            Thread_2 = new Thread(delthreadStart);
            Thread_2.Name = "Thread B";

            Thread_1.Start();
            Thread_2.Start();

            Thread_1.Join();
            Thread_2.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = ("-End of Thread-");

        }
    }
}
