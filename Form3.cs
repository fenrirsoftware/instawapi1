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
    public partial class Form3 : Form
    {
        string selectedUsername;
        long selectedId;
        public IInstaApi getApi;
        public bool takip;


        public Form3()
        {
            InitializeComponent();
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Kullanıcı Adı", 200);
            listView1.Columns.Add("Adı", 200);


            yenile();





        }

        private async void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            main.Visible = true;


            try
            {

                var imgGet = await getApi.GetUserInfoByUsernameAsync(listView1.SelectedItems[0].Text);
                profil.Load(imgGet.Value.ProfilePicUrl);
                this.selectedUsername = listView1.SelectedItems[0].Text;
                this.selectedId = imgGet.Value.Pk;
                this.kadi.Text = imgGet.Value.Username;
                this.bio.Text = imgGet.Value.Biography;





            }
            catch
            {



            }







        }

        private async void button1_Click(object sender, EventArgs e)
        {

            await getApi.BlockUserAsync(selectedId);
            MessageBox.Show("Engelleme Başarılı");
            this.main.Visible = false;
            yenile();
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            this.main.Visible = false;

            yenile();



        }

        public async void yenile()
        {

            listView1.Items.Clear();



            if (takip)
            {

                var followSend = await getApi.GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(999999));
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;


                var goen = followSend.Value.ToArray();

                foreach (var value in goen)
                {

                    String[] epGoen = { value.UserName, value.FullName };

                    var listViewItem = new ListViewItem(epGoen);
                    listView1.Items.Add(listViewItem);


                }
            }
            else
            {
                var apGet = await getApi.GetCurrentUserAsync();
                var followSend = await getApi.GetUserFollowingAsync(apGet.Value.UserName, PaginationParameters.MaxPagesToLoad(999999));
                listView1.View = View.Details;
                listView1.GridLines = true;
                listView1.FullRowSelect = true;


                var goen = followSend.Value.ToArray();

                foreach (var value in goen)
                {

                    String[] epGoen = { value.UserName, value.FullName };

                    var listViewItem = new ListViewItem(epGoen);
                    listView1.Items.Add(listViewItem);


                }

            }









        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void button3_Click(object sender, EventArgs e)
        {



        }

        private void profil_Click(object sender, EventArgs e)
        {

        }
    }
}
