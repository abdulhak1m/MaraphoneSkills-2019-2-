namespace WSR_1
{
    partial class Runner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Runner));
            this.info_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pnl_Timer = new System.Windows.Forms.Panel();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.dtp_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmb_Country = new System.Windows.Forms.ComboBox();
            this.Sex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Surname = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.show_ConfirmPassword = new System.Windows.Forms.Button();
            this.show_password = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Button();
            this.lbl_PictureName = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.info_panel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.pnl_Timer.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // info_panel
            // 
            this.info_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.info_panel.Controls.Add(this.pictureBox2);
            this.info_panel.Controls.Add(this.label1);
            this.info_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_panel.Location = new System.Drawing.Point(0, 25);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(881, 90);
            this.info_panel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(292, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "MaraphoneSkills 2019";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topPanel.Controls.Add(this.Close);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(881, 25);
            this.topPanel.TabIndex = 5;
            // 
            // pnl_Timer
            // 
            this.pnl_Timer.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_Timer.Controls.Add(this.lbl_Timer);
            this.pnl_Timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Timer.Location = new System.Drawing.Point(0, 604);
            this.pnl_Timer.Name = "pnl_Timer";
            this.pnl_Timer.Size = new System.Drawing.Size(881, 42);
            this.pnl_Timer.TabIndex = 11;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Timer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Timer.ForeColor = System.Drawing.Color.White;
            this.lbl_Timer.Location = new System.Drawing.Point(0, 0);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(881, 42);
            this.lbl_Timer.TabIndex = 6;
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.lbl_Error);
            this.pnl_Main.Controls.Add(this.lbl_PictureName);
            this.pnl_Main.Controls.Add(this.dtp_DateOfBirth);
            this.pnl_Main.Controls.Add(this.pictureBox1);
            this.pnl_Main.Controls.Add(this.cmb_Country);
            this.pnl_Main.Controls.Add(this.Sex);
            this.pnl_Main.Controls.Add(this.label3);
            this.pnl_Main.Controls.Add(this.panel8);
            this.pnl_Main.Controls.Add(this.label2);
            this.pnl_Main.Controls.Add(this.panel6);
            this.pnl_Main.Controls.Add(this.panel5);
            this.pnl_Main.Controls.Add(this.panel4);
            this.pnl_Main.Controls.Add(this.panel3);
            this.pnl_Main.Controls.Add(this.panel2);
            this.pnl_Main.Controls.Add(this.panel7);
            this.pnl_Main.Controls.Add(this.panel1);
            this.pnl_Main.Controls.Add(this.Surname);
            this.pnl_Main.Controls.Add(this.txt_Name);
            this.pnl_Main.Controls.Add(this.ConfirmPassword);
            this.pnl_Main.Controls.Add(this.Password);
            this.pnl_Main.Controls.Add(this.Username);
            this.pnl_Main.Controls.Add(this.show_ConfirmPassword);
            this.pnl_Main.Controls.Add(this.show_password);
            this.pnl_Main.Controls.Add(this.btn_browse);
            this.pnl_Main.Controls.Add(this.btn_Cancel);
            this.pnl_Main.Controls.Add(this.btn_done);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 115);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(881, 489);
            this.pnl_Main.TabIndex = 12;
            // 
            // dtp_DateOfBirth
            // 
            this.dtp_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DateOfBirth.Location = new System.Drawing.Point(592, 344);
            this.dtp_DateOfBirth.Name = "dtp_DateOfBirth";
            this.dtp_DateOfBirth.Size = new System.Drawing.Size(205, 27);
            this.dtp_DateOfBirth.TabIndex = 18;
            this.dtp_DateOfBirth.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // cmb_Country
            // 
            this.cmb_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Country.FormattingEnabled = true;
            this.cmb_Country.Items.AddRange(new object[] {
            "Выберите страну"});
            this.cmb_Country.Location = new System.Drawing.Point(592, 390);
            this.cmb_Country.Name = "cmb_Country";
            this.cmb_Country.Size = new System.Drawing.Size(205, 29);
            this.cmb_Country.TabIndex = 16;
            // 
            // Sex
            // 
            this.Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sex.FormattingEnabled = true;
            this.Sex.Items.AddRange(new object[] {
            "Выберите пол",
            "Мужской",
            "Женский",
            "Нариман"});
            this.Sex.Location = new System.Drawing.Point(85, 340);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(281, 29);
            this.Sex.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(126, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(629, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пожалуйста, заполните все необходимые поля, чтобы зарегистрироваться \r\nв системе." +
    ".";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Location = new System.Drawing.Point(592, 425);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(205, 5);
            this.panel8.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(338, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Регистрация Бегуна";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(85, 370);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 5);
            this.panel6.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(85, 318);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 5);
            this.panel5.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(85, 273);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 5);
            this.panel4.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(85, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 5);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(85, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 5);
            this.panel2.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(592, 265);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(205, 5);
            this.panel7.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(85, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 5);
            this.panel1.TabIndex = 15;
            // 
            // Surname
            // 
            this.Surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Surname.Location = new System.Drawing.Point(85, 299);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(281, 20);
            this.Surname.TabIndex = 14;
            this.Surname.Enter += new System.EventHandler(this.Surname_Enter);
            this.Surname.Leave += new System.EventHandler(this.Surname_Leave);
            // 
            // txt_Name
            // 
            this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Name.Location = new System.Drawing.Point(85, 254);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(281, 20);
            this.txt_Name.TabIndex = 14;
            this.txt_Name.Enter += new System.EventHandler(this.Name_Enter);
            this.txt_Name.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPassword.Location = new System.Drawing.Point(85, 205);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(281, 20);
            this.ConfirmPassword.TabIndex = 14;
            this.ConfirmPassword.Enter += new System.EventHandler(this.ConfirmPassword_Enter);
            this.ConfirmPassword.Leave += new System.EventHandler(this.ConfirmPassword_Leave);
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Location = new System.Drawing.Point(85, 153);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(281, 20);
            this.Password.TabIndex = 14;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Location = new System.Drawing.Point(85, 104);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(281, 20);
            this.Username.TabIndex = 14;
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            this.Username.Leave += new System.EventHandler(this.Username_Leave);
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_browse.FlatAppearance.BorderSize = 0;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.Location = new System.Drawing.Point(645, 283);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(109, 29);
            this.btn_browse.TabIndex = 13;
            this.btn_browse.Text = "Обзор";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(447, 425);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(109, 39);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_done.FlatAppearance.BorderSize = 0;
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_done.ForeColor = System.Drawing.Color.White;
            this.btn_done.Location = new System.Drawing.Point(325, 425);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(109, 39);
            this.btn_done.TabIndex = 13;
            this.btn_done.Text = "Готово";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(592, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 166);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // show_ConfirmPassword
            // 
            this.show_ConfirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_ConfirmPassword.FlatAppearance.BorderSize = 0;
            this.show_ConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_ConfirmPassword.Image = global::WSR_1.Properties.Resources.icons8_visible_filled_16;
            this.show_ConfirmPassword.Location = new System.Drawing.Point(372, 200);
            this.show_ConfirmPassword.Name = "show_ConfirmPassword";
            this.show_ConfirmPassword.Size = new System.Drawing.Size(25, 25);
            this.show_ConfirmPassword.TabIndex = 12;
            this.show_ConfirmPassword.UseVisualStyleBackColor = false;
            // 
            // show_password
            // 
            this.show_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_password.FlatAppearance.BorderSize = 0;
            this.show_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_password.Image = global::WSR_1.Properties.Resources.icons8_visible_filled_16;
            this.show_password.Location = new System.Drawing.Point(372, 151);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(25, 25);
            this.show_password.TabIndex = 12;
            this.show_password.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WSR_1.Properties.Resources.icons8_exercise_32;
            this.pictureBox2.Location = new System.Drawing.Point(29, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Image = global::WSR_1.Properties.Resources.icons8_shutdown_16;
            this.Close.Location = new System.Drawing.Point(856, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 25);
            this.Close.TabIndex = 1;
            this.Close.UseVisualStyleBackColor = false;
            // 
            // lbl_PictureName
            // 
            this.lbl_PictureName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_PictureName.Location = new System.Drawing.Point(588, 241);
            this.lbl_PictureName.Name = "lbl_PictureName";
            this.lbl_PictureName.Size = new System.Drawing.Size(209, 21);
            this.lbl_PictureName.TabIndex = 19;
            // 
            // lbl_Error
            // 
            this.lbl_Error.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(82, 131);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(284, 19);
            this.lbl_Error.TabIndex = 20;
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Runner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 646);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Timer);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Runner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.new_Runner_Load);
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.pnl_Timer.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Panel pnl_Timer;
        private System.Windows.Forms.Label lbl_Timer;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Button show_password;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Surname;
        private new System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.ComboBox Sex;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Button show_ConfirmPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker dtp_DateOfBirth;
        private System.Windows.Forms.ComboBox cmb_Country;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_PictureName;
        private System.Windows.Forms.Label lbl_Error;
    }
}