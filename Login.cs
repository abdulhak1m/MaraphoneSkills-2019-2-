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

namespace WSR_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LocationForm();

            // приватный ввод пароля
            PasswordBox();

            Username.Text = "Введите Email!";
            Username.ForeColor = Color.SteelBlue;

            Password.Text = "Введите пароль!";
            Password.UseSystemPasswordChar = false;
            Password.ForeColor = Color.SteelBlue;

            // закрытие формы
            Close.Click += (s, e) => { Close(); };
        }
        private void LocationForm()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
        // таймер до старта Марафона
        private void timer1_Tick(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                DateTime maraphoneTime = new DateTime(2020, 5, 10, 6, 0, 0);
                TimeSpan totalTime = maraphoneTime - DateTime.Now;
                lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов " + totalTime.Minutes + " минут и " + totalTime.Seconds + " секунд до страта Марафона";

            }).Start();
        }
        // приватный пароль
        private void PasswordBox()
        {
            Password.TextChanged += (s, e) => { Password.UseSystemPasswordChar = true; };
            show_password.MouseDown += (s, e) => { Password.UseSystemPasswordChar = false; };
            show_password.MouseUp += (s, e) => 
            {
                if (Password.Text == "Введите пароль!")
                    Password.UseSystemPasswordChar = false;
                else
                    Password.UseSystemPasswordChar = true;
            };
        }
        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Username_Enter(object sender, EventArgs e)
        {
            if(Username.Text == "Введите Email!")
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if(Username.Text == "")
            {
                Username.Text = "Введите Email!";
                Username.ForeColor = Color.SteelBlue;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if(Password.Text == "Введите пароль!")
            {
                Password.UseSystemPasswordChar = false;
                Password.Text = "";
                Password.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Введите пароль!";
                Password.UseSystemPasswordChar = false;
                Password.ForeColor = Color.SteelBlue;
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(Username.Text) && !string.IsNullOrEmpty(Password.Text))
                {

                }
                else
                    MessageBox.Show("Вы не ввели Email и Пароль! Без этих данных, мы не можем вас авторизовать! Пожалуйста, заполните эти поля!", "Уведомление системы!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Уведомление об ошибке!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Home home = new Home();
            home.ShowDialog();
            Close();
        }
    }
}
