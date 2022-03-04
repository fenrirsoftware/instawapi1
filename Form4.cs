using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using InstaSharper;
using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;



namespace instawapi1
{
    public partial class Form4 : Form
    {

        public IInstaApi getApi;
        string gizliMi;
        InstaSharper.Classes.Models.InstaUserShort[] varList;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            saniyebekle.Value = 10;
            takipcisienaz.Value = 50;
            listView1.Columns.Add("İşlem", 500);
            listView1.View = View.Details;
            listView1.GridLines = true;

            listView1.FullRowSelect = true;
            this.lood.Load("https://media.tenor.com/images/6c2333c1083c8ceba94e4b121ddec8b5/tenor.gif");
            this.lood.Visible = false;
            this.lood.SizeMode = PictureBoxSizeMode.AutoSize;

            kullanicinintakipcileri.Columns.Add("Kullanıcı adı", 500);
            kullanicinintakipcileri.View = View.Details;
            kullanicinintakipcileri.GridLines = true;

            kullanicinintakipcileri.FullRowSelect = true;





        }

        private async void button1_Click(object sender, EventArgs e)
        {

            this.lood.Visible = true;
            this.takipcisayisi.Text = "YÜKLENİYOR";
            this.takipettikleri.Text = "YÜKLENİYOR";
            this.kadi.Text = "YÜKLENİYOR";
            this.hesapgizlimi.Text = "YÜKLENİYOR";

            var getUser = await getApi.GetUserAsync(textBox1.Text);
            var getUserFol = await getApi.GetUserFollowersAsync(textBox1.Text, PaginationParameters.MaxPagesToLoad(9999));
            var getUserFols = await getApi.GetUserFollowingAsync(textBox1.Text, PaginationParameters.MaxPagesToLoad(9999));
            if (getUser.Succeeded)
            {
                this.lood.Visible = false;
                this.groupBox1.Visible = true;
                this.profil.Load(getUser.Value.ProfilePicture);
                this.kadi.Text = getUser.Value.UserName.ToString();
                if (getUser.Value.IsPrivate.ToString() == "False")
                {

                    this.gizliMi = "Hesap gizli değil";
                    this.takipcisayisi.Text = getUserFol.Value.Count.ToString() + " Takipçi";
                    this.takipettikleri.Text = getUserFols.Value.Count.ToString() + " Takip edilen";
                    this.takipcisayisi.Visible = true;
                    this.takipettikleri.Visible = true;
                    kullanicinintakipcileri.Visible = true;
                    groupBox2.Visible = true;
                    kullanicinintakipcileri.Items.Clear();

                    varList = getUserFol.Value.ToArray();

                    foreach (var val in varList)
                    {

                        kullanicinintakipcileri.Items.Add(val.UserName);



                    }


                }
                else
                {
                    this.gizliMi = "Hesap gizli";
                    this.takipcisayisi.Visible = false;
                    this.takipettikleri.Visible = false;
                    kullanicinintakipcileri.Visible = false;
                    groupBox2.Visible = false;
                    MessageBox.Show("GİZLİ HESAPLARDA TAKİP İŞLEMİ YAPAMAZSINIZ!");


                }
                this.hesapgizlimi.Text = gizliMi;


                listView1.Items.Add("Hesap detayları getirildi " + textBox1.Text);


            }
            else
            {
                this.lood.Visible = false;
                this.groupBox1.Visible = false;
                listView1.Items.Add("Hesap Araması Yapıldı ve Hesap Bulunamadı " + textBox1.Text);
                MessageBox.Show("Böyle bir hesap bulunamadı");

            }


        }

        private void lood_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {




            int mil = Convert.ToInt32(saniyebekle.Value) * 1000;
            int takipcisiEnaz = Convert.ToInt32(takipcisienaz.Value);

            foreach (var val in varList)
            {

                var getUserCheckFor = await getApi.GetUserFollowersAsync(val.UserName, PaginationParameters.MaxPagesToLoad(9999));


                if (checkBox1.Checked)
                {

                    if (getUserCheckFor.Value.Count > takipcisiEnaz)
                    {

                        await getApi.FollowUserAsync(val.Pk);
                        Thread.Sleep(mil);
                        listView1.Items.Add("Kullanıcı takip edildi " + val.UserName.ToString());


                    }
                    else
                    {

                        listView1.Items.Add("Kullanıcı takip edilmedi çünkü takipçi sayısı min seçilenden az " + val.UserName.ToString());

                    }




                }
                else
                {

                    if (val.IsPrivate)
                    {
                        listView1.Items.Add("Kullanıcı takip edilmedi çünkü gizli " + val.UserName.ToString());

                    }
                    else
                    {
                        if (getUserCheckFor.Value.Count < takipcisiEnaz)
                        {

                            listView1.Items.Add("Kullanıcı takip edilmedi çünkü takipçi sayısı min seçilenden az " + val.UserName.ToString());


                        }
                        else
                        {
                            await getApi.FollowUserAsync(val.Pk);
                            Thread.Sleep(mil);
                            listView1.Items.Add("Kullanıcı takip edildi " + val.UserName.ToString());


                        }


                    }


                }






            }


        }
    }
}
