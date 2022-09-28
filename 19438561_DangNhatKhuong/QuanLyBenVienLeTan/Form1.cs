using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenhNhanObject;

namespace QuanLyBenVienLeTan
{
    public partial class Form1 : Form
    {
        MessageQueue queue = null;
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            string path = @".\private$\phongkehoach";
            //string path = @"hbmnl\private$\phongkehoach";
            if (MessageQueue.Exists(path))
            {
                queue = new MessageQueue(path, QueueAccessMode.Send);
            }
            else
                queue = MessageQueue.Create(path, true);
            queue.Label = "queue cho phong ke hoach";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ma = textma.Text;
            string cmnd = textcmnd.Text;
            string ten = textten.Text;
            string diachi = richdiachi.Text;
            BenhNhan benNhan = new BenhNhan(ma,cmnd,ten,diachi);
            MessageQueueTransaction transaction = new MessageQueueTransaction();
            transaction.Begin();
            queue.Send(benNhan, transaction);
            transaction.Commit();

        }

        private void textcmnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
