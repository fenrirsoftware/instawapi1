using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using InstaSharper;
using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;

namespace instawapi1
{
    public partial class Form2 : Form
    {

        public string image;
        public string titleUs;
        public IInstaApi getApi;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.profilePhoto.Load(image);
            this.Text = titleUs;




        }

        private void button2_Click(object sender, EventArgs e)
        {


            var teGo = new Form3();
            teGo.getApi = getApi;
            teGo.takip = false;
            teGo.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {


            var teGo = new Form3();
            teGo.getApi = getApi;
            teGo.takip = true;
            teGo.Show();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm4 = new Form4();
            frm4.getApi = getApi;
            frm4.Show();
        }

        private void mail_Click(object sender, EventArgs e)
        {

        }

        private void profilePhoto_Click(object sender, EventArgs e)
        {

        }

        private void takipcisayi_Click(object sender, EventArgs e)
        {

        }

        private void takiped_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
