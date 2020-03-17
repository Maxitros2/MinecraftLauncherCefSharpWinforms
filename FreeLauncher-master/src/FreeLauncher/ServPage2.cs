using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FreeLauncher.Forms;
using dotMCLauncher.Networking;
using System.Net;

namespace FreeLauncher
{
    public partial class ServPage2 : UserControl
    {
        public UserManager _userManager;
        public ServPage2()
        {
            
            InitializeComponent();
        }
        public void addAcc(String nickname, string password, bool lic)
        {
            
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += delegate {
                User user = new User
                {
                    Username = textBox1.Text
                };
                if (textBox2.PasswordChar!='*')
                {
                    user.Type = "offline";
                    if (_userManager.Accounts.ContainsKey(user.Username))
                    {
                        _userManager.Accounts[user.Username] = user;
                    }
                    else
                    {
                        _userManager.Accounts.Add(user.Username, user);
                    }
                    _userManager.SelectedUsername = user.Username;
                   // SaveUsers();
                   // UpdateUsers();
                    return;
                }
                AuthManager auth = new AuthManager
                {
                    Email = textBox1.Text,
                    Password = textBox2.Text
                };
                try
                {
                    auth.Login();
                    user.Type = auth.IsLegacy ? "legacy" : "mojang";
                    user.AccessToken = auth.AccessToken;
                    user.ClientToken = auth.ClientToken;
                    user.Uuid = auth.Uuid;
                    user.UserProperties = auth.UserProperties;
                    if (_userManager.Accounts.ContainsKey(user.Username))
                    {
                        _userManager.Accounts[user.Username] = user;
                    }
                    else
                    {
                        _userManager.Accounts.Add(user.Username, user);
                    }
                    _userManager.SelectedUsername = user.Username;
                }
                catch (WebException ex)
                {
                    if (ex.Status != WebExceptionStatus.ProtocolError)
                    {
                        return;
                    }
                    MessageBox.Show("Извините, введен неверный пароль");
                    return;
                }
                /*
                Invoke(new Action(() => {
                    SaveUsers();
                    UpdateUsers();
                    UsernameTextBox.Clear();
                    PasswordTextBox.Clear();
                }));
                */
            };
            /*
            bgw.RunWorkerCompleted += delegate {
                UsernameTextBox.Enabled = true;
                YesNoToggleSwitch.Enabled = true;
                ControlBox = true;
                AddUserButton.Text = _configuration.Localization.AddNewUserButton;
                YesNoToggleSwitch_ValueChanged(this, EventArgs.Empty);
            };
            */
            bgw.RunWorkerAsync();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== "E-mail адрес аккаунта")
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "Пароль аккаунта(если необходим)")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
            }
           
        }
    }
}
