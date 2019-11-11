namespace WSR_1
{
    partial class RunnerSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunnerSelect));
            this.info_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_Timer = new System.Windows.Forms.Panel();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.new_member = new System.Windows.Forms.Button();
            this.member = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.info_panel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.pnl_Timer.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // info_panel
            // 
            this.info_panel.Controls.Add(this.pictureBox2);
            this.info_panel.Controls.Add(this.label1);
            this.info_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_panel.Location = new System.Drawing.Point(0, 25);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(800, 90);
            this.info_panel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(252, 29);
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
            this.topPanel.Size = new System.Drawing.Size(800, 25);
            this.topPanel.TabIndex = 3;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_Timer
            // 
            this.pnl_Timer.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnl_Timer.Controls.Add(this.lbl_Timer);
            this.pnl_Timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Timer.Location = new System.Drawing.Point(0, 333);
            this.pnl_Timer.Name = "pnl_Timer";
            this.pnl_Timer.Size = new System.Drawing.Size(800, 42);
            this.pnl_Timer.TabIndex = 10;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Timer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Timer.ForeColor = System.Drawing.Color.White;
            this.lbl_Timer.Location = new System.Drawing.Point(0, 0);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(800, 42);
            this.lbl_Timer.TabIndex = 6;
            this.lbl_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.btn_Login);
            this.pnl_Main.Controls.Add(this.new_member);
            this.pnl_Main.Controls.Add(this.member);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 115);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(800, 218);
            this.pnl_Main.TabIndex = 11;
            // 
            // new_member
            // 
            this.new_member.BackColor = System.Drawing.Color.RoyalBlue;
            this.new_member.FlatAppearance.BorderSize = 0;
            this.new_member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_member.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_member.ForeColor = System.Drawing.Color.White;
            this.new_member.Location = new System.Drawing.Point(258, 103);
            this.new_member.Name = "new_member";
            this.new_member.Size = new System.Drawing.Size(287, 59);
            this.new_member.TabIndex = 13;
            this.new_member.Text = "Я новый участник";
            this.new_member.UseVisualStyleBackColor = false;
            this.new_member.Click += new System.EventHandler(this.new_member_Click);
            // 
            // member
            // 
            this.member.BackColor = System.Drawing.Color.RoyalBlue;
            this.member.FlatAppearance.BorderSize = 0;
            this.member.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.member.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.member.ForeColor = System.Drawing.Color.White;
            this.member.Location = new System.Drawing.Point(258, 21);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(287, 59);
            this.member.TabIndex = 14;
            this.member.Text = "Я ранее учавстововал";
            this.member.UseVisualStyleBackColor = false;
            this.member.Click += new System.EventHandler(this.member_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(709, 167);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(79, 39);
            this.btn_Login.TabIndex = 15;
            this.btn_Login.Text = "Войти";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Image = global::WSR_1.Properties.Resources.icons8_shutdown_16;
            this.Close.Location = new System.Drawing.Point(775, 0);
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
            // RunnerSelect
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Timer);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RunnerSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RunnerSelect_Load);
            this.info_panel.ResumeLayout(false);
            this.info_panel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.pnl_Timer.ResumeLayout(false);
            this.pnl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_Timer;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Button new_member;
        private System.Windows.Forms.Button member;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}