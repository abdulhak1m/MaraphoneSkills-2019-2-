namespace WSR_1
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.info_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Timer = new System.Windows.Forms.Panel();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.show_password = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            this.info_panel.SuspendLayout();
            this.pnl_Timer.SuspendLayout();
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topPanel.Controls.Add(this.Close);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(858, 25);
            this.topPanel.TabIndex = 0;
            // 
            // info_panel
            // 
            this.info_panel.Controls.Add(this.pictureBox2);
            this.info_panel.Controls.Add(this.label1);
            this.info_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_panel.Location = new System.Drawing.Point(0, 25);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(858, 90);
            this.info_panel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(281, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "MaraphoneSkills 2019";
            // 
            // pnl_Timer
            // 
            this.pnl_Timer.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_Timer.Controls.Add(this.lbl_Timer);
            this.pnl_Timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Timer.Location = new System.Drawing.Point(0, 444);
            this.pnl_Timer.Name = "pnl_Timer";
            this.pnl_Timer.Size = new System.Drawing.Size(858, 42);
            this.pnl_Timer.TabIndex = 5;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Timer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Timer.ForeColor = System.Drawing.Color.White;
            this.lbl_Timer.Location = new System.Drawing.Point(0, 0);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(858, 42);
            this.lbl_Timer.TabIndex = 6;
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Login
            // 
            this.pnl_Login.Controls.Add(this.label3);
            this.pnl_Login.Controls.Add(this.label2);
            this.pnl_Login.Controls.Add(this.panel2);
            this.pnl_Login.Controls.Add(this.btn_cancel);
            this.pnl_Login.Controls.Add(this.panel1);
            this.pnl_Login.Controls.Add(this.Password);
            this.pnl_Login.Controls.Add(this.Username);
            this.pnl_Login.Controls.Add(this.show_password);
            this.pnl_Login.Controls.Add(this.btn_login);
            this.pnl_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Login.ForeColor = System.Drawing.Color.White;
            this.pnl_Login.Location = new System.Drawing.Point(0, 115);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(858, 329);
            this.pnl_Login.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(273, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 5);
            this.panel2.TabIndex = 8;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(304, 233);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(109, 39);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(273, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 5);
            this.panel1.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Location = new System.Drawing.Point(273, 189);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(281, 20);
            this.Password.TabIndex = 6;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Location = new System.Drawing.Point(273, 128);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(281, 20);
            this.Username.TabIndex = 7;
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_login.Location = new System.Drawing.Point(419, 233);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(109, 39);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Войти";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(272, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Окно Аторизации пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(140, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(578, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пожалуйста, авторизуйтесь в системе используя ваш Email и пароль.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // show_password
            // 
            this.show_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_password.FlatAppearance.BorderSize = 0;
            this.show_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_password.Image = global::WSR_1.Properties.Resources.icons8_visible_filled_16;
            this.show_password.Location = new System.Drawing.Point(560, 184);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(25, 25);
            this.show_password.TabIndex = 5;
            this.show_password.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Image = global::WSR_1.Properties.Resources.icons8_shutdown_16;
            this.Close.Location = new System.Drawing.Point(833, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 25);
            this.Close.TabIndex = 1;
            this.Close.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WSR_1.Properties.Resources.icons8_exercise_32;
            this.pictureBox2.Location = new System.Drawing.Point(12, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 486);
            this.Controls.Add(this.pnl_Login);
            this.Controls.Add(this.pnl_Timer);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.topPanel.ResumeLayout(false);
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            this.pnl_Timer.ResumeLayout(false);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topPanel;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Timer;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button show_password;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

