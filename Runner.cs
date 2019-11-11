using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSR_1
{
    public partial class Runner : Form
    {
        public Runner()
        {
            InitializeComponent();
            LocationForm();
            PasswordBox(Password, show_password);
            PasswordBox(ConfirmPassword, show_ConfirmPassword);

            Username.Text = "Введите Email!";
            Username.ForeColor = Color.SteelBlue;

            Password.Text = "Введите пароль!";
            Password.UseSystemPasswordChar = false;
            Password.ForeColor = Color.SteelBlue;

            ConfirmPassword.Text = "Введите пароль!";
            ConfirmPassword.UseSystemPasswordChar = false;
            ConfirmPassword.ForeColor = Color.SteelBlue;

            txt_Name.Text = "Введите имя!";
            txt_Name.ForeColor = Color.SteelBlue;


            Surname.Text = "Введите фамилию!";
            Surname.ForeColor = Color.SteelBlue;

            Sex.SelectedIndex = 0;
            Sex.ForeColor = Color.SteelBlue;

            cmb_Country.SelectedIndex = 0;
            cmb_Country.ForeColor = Color.SteelBlue;
            // закрытие формы
            Close.Click += (s, e) => { Close(); };
            // сравниваю пароли
            ConfirmPassword.TextChanged += (s, e) => { if(Password.Text != "Введите пароль!" || Password.Text != "") Check(); };
            Password.TextChanged += (s, e) => { if (ConfirmPassword.Text != "" || ConfirmPassword.Text != "Введите пароль!") Check(); };
        }
        private void LocationForm()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
        private void new_Runner_Load(object sender, EventArgs e)
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

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Введите Email!")
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Введите Email!";
                Username.ForeColor = Color.SteelBlue;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Введите пароль!")
            {
                Password.UseSystemPasswordChar = false;
                Password.Text = "";
                Password.ForeColor = Color.Black;
            }
        }
        // приватный пароль
        private void PasswordBox(TextBox text, Button btn)
        {
            text.TextChanged += (s, e) => { text.UseSystemPasswordChar = true; };
            btn.MouseDown += (s, e) => { text.UseSystemPasswordChar = false; };
            btn.MouseUp += (s, e) =>
            {
                if (text.Text == "Введите пароль!")
                    text.UseSystemPasswordChar = false;
                else
                    text.UseSystemPasswordChar = true;
            };
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

        private void ConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (ConfirmPassword.Text == "Введите пароль!")
            {
                ConfirmPassword.Text = "";
                ConfirmPassword.UseSystemPasswordChar = false;
                ConfirmPassword.ForeColor = Color.Black;
            }
        }

        private void ConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (ConfirmPassword.Text == "")
            {
                ConfirmPassword.Text = "Введите пароль!";
                ConfirmPassword.UseSystemPasswordChar = false;
                ConfirmPassword.ForeColor = Color.SteelBlue;
            }
        }

        private void Name_Enter(object sender, EventArgs e)
        {
            if(txt_Name.Text == "Введите имя!")
            {
                txt_Name.Text = "";
                txt_Name.ForeColor = Color.Black;
            }
        }

        private void Name_Leave(object sender, EventArgs e)
        {
            if(txt_Name.Text == "")
            {
                txt_Name.Text = "Введите имя!";
                txt_Name.ForeColor = Color.SteelBlue;
            }
        }

        private void Surname_Enter(object sender, EventArgs e)
        {
            if (Surname.Text == "Введите фамилию!")
            {
                Surname.Text = "";
                Surname.ForeColor = Color.Black;
            }
        }

        private void Surname_Leave(object sender, EventArgs e)
        {
            if (Surname.Text == "")
            {
                Surname.Text = "Введите фамилию!";
                Surname.ForeColor = Color.SteelBlue;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if(pictureBox1.Image == null)
            {
                using(Font font = new Font("Century Gothic", 20))
                {
                    e.Graphics.DrawString("Фото", font, Brushes.SteelBlue, new Point(2, 2));
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите покинуть окно Регистрации?",
                "Уведомление системы!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                ActiveForm.Hide();
                Home home = new Home();
                home.ShowDialog();
                Close();
            }
        }
        OpenFileDialog file = new OpenFileDialog();
        // метод чтения изображений
        private void Open()
        {
            try
            {
                file.InitialDirectory = @"C:\Users\magom\Pictures";
                file.Filter = "Image Files (*.BMP;*.PNG;*.JPG;*.GIF)|*.BMP;*.PNG;*.JPG;*.GIF| All Files(*.*)|*.*";
                file.FilterIndex = 2;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(file.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.BorderStyle = BorderStyle.Fixed3D;
                    lbl_PictureName.Text = file.SafeFileName.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Уведомление об ошибке!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            Open();
        }

        private async void btn_done_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] a = ms.GetBuffer();
            ms.Close();
            try
            {
                if(Username.Text == "Введите Email!" && Password.Text == "Введите пароль!" &&
                    txt_Name.Text == "Введите имя!" && Surname.Text == "Введите фамилию!" &&
                    Sex.SelectedIndex == 0 && cmb_Country.SelectedIndex == 0)
                {

                    MessageBox.Show("Чтобы зарегистрироваться в системе, необходимо заполнить все поля " +
                        "надлежащим образом. " +
                        "Пожалуйста, заполните все поля соответствующими данными и повторите попытку " +
                        "регистрации в системе.", "Уведомление системы!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Regex emailRegex = new Regex(@"\w{2,10}@\w{2,10}.\w{2,10}");
                    Match emailMatch = emailRegex.Match(Username.Text);
                    if (emailMatch.Value == "")
                        MessageBox.Show("Не корректный формат Email!", "Уведомление системы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        bool digit = false;
                        bool spec = false;
                        bool lowChar = false;

                        for(int i = 0; i < Password.TextLength; i++)
                        {
                            if (char.IsDigit(Password.Text[i]))
                            {
                                digit = true;
                                break;
                            }
                        }
                        for(int i = 0; i < Password.TextLength; i++)
                        {
                            if (char.IsLower(Password.Text[i]))
                            {
                                lowChar = true;
                                break;
                            }
                        }
                        for(int i = 0; i < Password.TextLength; i++)
                        {
                            if(Password.Text[i] == '#' || Password.Text[i] == '$' || Password.Text[i] == '%' || Password.Text[i] == '^' || Password.Text[i] == '!' || Password.Text[i] == '@')
                            {
                                spec = true;
                                break;
                            }
                        }
                        if(Password.TextLength < 6 || !spec || !digit || !lowChar)
                            MessageBox.Show("Некорректный формат пароля! Длина пароля " +
                                "доложно быть не менее 6-ти символов, из которых " +
                                "должна быть, как минимум одна буква нижнего регистра, одна цифра " +
                                "и одна из следующих символов #,$,%,^,!,@", "Уведомление системы!", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        DateTime dateOfBirth = Convert.ToDateTime(dtp_DateOfBirth.Value);
                        if(DateTime.Now.Year - dateOfBirth.Year < 10)
                            MessageBox.Show("Внимание! На момент регистрации Бегуна, его возраст должен " +
                                "составлять не менее 1-ти лет", "Уведомление системы!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            using (SqlConnection connection = new SqlConnection(Connection.GetString()))
                            {
                                await connection.OpenAsync();
                                string query = "INSERT INTO Runner VALUES (@e, @p, @n, @s, @g, @pn, @img, @d, @cn)";
                                SqlCommand cmd = new SqlCommand(query, connection);
                                cmd.Parameters.AddWithValue("@e", Username.Text);
                                cmd.Parameters.AddWithValue("@p", Password.Text);
                                cmd.Parameters.AddWithValue("@n", txt_Name.Text);
                                cmd.Parameters.AddWithValue("@s", Surname.Text);
                                cmd.Parameters.AddWithValue("@pn", lbl_PictureName.Text);
                                cmd.Parameters.AddWithValue("@img", a);
                                cmd.Parameters.AddWithValue("@d", dtp_DateOfBirth.Value);
                                cmd.Parameters.AddWithValue("@cn", cmb_Country.Text);
                                await cmd.ExecuteNonQueryAsync();
                                MessageBox.Show("Success");
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Уведомление системы об ошибке SQL!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Check()
        {
            if (Password.Text != "Введите пароль!" && ConfirmPassword.Text != "Введите пароль!")
            {
                if (Password.Text != ConfirmPassword.Text)
                {
                    lbl_Error.Text = "Внимание, пароли не совпадают!";
                    btn_done.Enabled = false;
                }
                else
                {
                    lbl_Error.Text = "";
                    btn_done.Enabled = true;
                }
            }
        }
    }
}
