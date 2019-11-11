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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            LocationForm();

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
        private void btn_WantRunner_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            RunnerSelect select = new RunnerSelect();
            select.ShowDialog();
            Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                DateTime maraphoneTime = new DateTime(2020, 5, 10, 6, 0, 0);
                TimeSpan totalTime = maraphoneTime - DateTime.Now;
                lbl_Timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов " + totalTime.Minutes + " минут и " + totalTime.Seconds + " секунд до страта Марафона";

            }).Start();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }
    }
}
