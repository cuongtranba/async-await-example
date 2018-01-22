using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //No async
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < 1000000000; i++)
        //    {

        //    }
        //    textBox1.Text = "done............";
        //}
        //Async cpu-bound
        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    await Task.Run(() =>
        //    {
        //        for (int i = 0; i < 1000000000; i++)
        //        {

        //        }
        //    });
        //    textBox1.Text = "done............";
        //}
        //Async void
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        LongWork();
        //    }
        //    catch (Exception exception)
        //    {
        //        throw exception;
        //    }

        //}

        //public async void LongWork()
        //{
        //    await Task.Run(() =>
        //    {
        //        for (int i = 0; i < 1000000000; i++)
        //        {

        //        }
        //    });
        //    throw new Exception("long work error");
        //}
        //TODO dead lock
        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 1000000000; i++)
                {

                }
            });
            textBox1.Text = "done............";
        }
    }
}
