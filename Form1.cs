using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstaSharper;
using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;


namespace instawapi1
{
    public partial class login : Form




    {

        private UserSessionData user = new UserSessionData();
        private string username;
        private string pass;
        private IInstaApi api;



        public login()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (userInput.Text == "" || passInput.Text == "")
            {

                MessageBox.Show("BOŞ ALAN BIRAKMAYINIZ");


            }
            else
            {

                this.username = userInput.Text;
                this.pass = passInput.Text;
                user.UserName = username;
                user.Password = pass;
                loginBtn.Enabled = false;
                loginBtn.Text = "Giriş yapılıyor...";
                Login();

               



            }




        }


        public async void Login()
        {


            Cursor = Cursors.WaitCursor;
            api = InstaApiBuilder.CreateBuilder().SetUser(user).Build();
            var loginIns = await api.LoginAsync();



            if (loginIns.Succeeded)
            {

                var getUser = await api.GetCurrentUserAsync();
                var getUserFollow = await api.GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(9000000));
                var getUserFollowing = await api.GetUserFollowingAsync(getUser.Value.UserName, PaginationParameters.MaxPagesToLoad(9000000));
                var getUserExtre1 = await api.GetUserMediaAsync(getUser.Value.UserName, PaginationParameters.MaxPagesToLoad(9000000));

                try
                {
                    loginBtn.Enabled = true;
                    loginBtn.Text = "Giriş yap";
                    var newFrm = new Form2();
                    newFrm.titleUs = getUser.Value.UserName + " Hoşgeldiniz";
                    newFrm.getApi = api;
                    newFrm.image = getUser.Value.ProfilePicture;



                    newFrm.username.Text = getUser.Value.UserName;
                    newFrm.takipedilensayisi.Text = getUserFollowing.Value.Count.ToString();
                    newFrm.takipcisayi.Text = getUserFollow.Value.Count.ToString();

                    newFrm.media.Text = getUserExtre1.Value.Count.ToString();
                    newFrm.mail.Text = getUser.Value.Email;

                    Cursor = Cursors.Default;

                    newFrm.Show();
                    this.Hide();


                }
                catch
                {





                }










            }
            else
            {

                MessageBox.Show("Başarısız giriş");
                loginBtn.Enabled = true;
                loginBtn.Text = "Giriş yap";
                Cursor = Cursors.Default;
            }


        }


    }
}
