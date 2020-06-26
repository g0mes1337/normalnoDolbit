namespace DotaTinder
{
    partial class ShowUsr
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.CheckCarry = new System.Windows.Forms.RadioButton();
            this.CheckMid = new System.Windows.Forms.RadioButton();
            this.CheckOffline = new System.Windows.Forms.RadioButton();
            this.CheckSupport = new System.Windows.Forms.RadioButton();
            this.checkHardSupport = new System.Windows.Forms.RadioButton();
            this.CheckAll = new System.Windows.Forms.RadioButton();
            this.LoginUserOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRoleOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserLinkOut = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginUserOut,
            this.UserRoleOut,
            this.UserLinkOut});
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 308);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Личный кабинет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CheckCarry
            // 
            this.CheckCarry.AutoSize = true;
            this.CheckCarry.Location = new System.Drawing.Point(108, 313);
            this.CheckCarry.Name = "CheckCarry";
            this.CheckCarry.Size = new System.Drawing.Size(49, 17);
            this.CheckCarry.TabIndex = 9;
            this.CheckCarry.TabStop = true;
            this.CheckCarry.Text = "Carry";
            this.CheckCarry.UseVisualStyleBackColor = true;
            this.CheckCarry.CheckedChanged += new System.EventHandler(this.CheckCarry_CheckedChanged);
            // 
            // CheckMid
            // 
            this.CheckMid.AutoSize = true;
            this.CheckMid.Location = new System.Drawing.Point(163, 313);
            this.CheckMid.Name = "CheckMid";
            this.CheckMid.Size = new System.Drawing.Size(42, 17);
            this.CheckMid.TabIndex = 10;
            this.CheckMid.TabStop = true;
            this.CheckMid.Text = "Mid";
            this.CheckMid.UseVisualStyleBackColor = true;
            this.CheckMid.CheckedChanged += new System.EventHandler(this.CheckMid_CheckedChanged);
            // 
            // CheckOffline
            // 
            this.CheckOffline.AutoSize = true;
            this.CheckOffline.Location = new System.Drawing.Point(211, 313);
            this.CheckOffline.Name = "CheckOffline";
            this.CheckOffline.Size = new System.Drawing.Size(55, 17);
            this.CheckOffline.TabIndex = 11;
            this.CheckOffline.TabStop = true;
            this.CheckOffline.Text = "Offline";
            this.CheckOffline.UseVisualStyleBackColor = true;
            this.CheckOffline.CheckedChanged += new System.EventHandler(this.CheckOffline_CheckedChanged);
            // 
            // CheckSupport
            // 
            this.CheckSupport.AutoSize = true;
            this.CheckSupport.Location = new System.Drawing.Point(272, 313);
            this.CheckSupport.Name = "CheckSupport";
            this.CheckSupport.Size = new System.Drawing.Size(62, 17);
            this.CheckSupport.TabIndex = 12;
            this.CheckSupport.TabStop = true;
            this.CheckSupport.Text = "Support";
            this.CheckSupport.UseVisualStyleBackColor = true;
            this.CheckSupport.CheckedChanged += new System.EventHandler(this.CheckSupport_CheckedChanged);
            // 
            // checkHardSupport
            // 
            this.checkHardSupport.AutoSize = true;
            this.checkHardSupport.Location = new System.Drawing.Point(340, 313);
            this.checkHardSupport.Name = "checkHardSupport";
            this.checkHardSupport.Size = new System.Drawing.Size(88, 17);
            this.checkHardSupport.TabIndex = 13;
            this.checkHardSupport.TabStop = true;
            this.checkHardSupport.Text = "Hard Support";
            this.checkHardSupport.UseVisualStyleBackColor = true;
            this.checkHardSupport.CheckedChanged += new System.EventHandler(this.checkHardSupport_CheckedChanged);
            // 
            // CheckAll
            // 
            this.CheckAll.AutoSize = true;
            this.CheckAll.Location = new System.Drawing.Point(434, 313);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(36, 17);
            this.CheckAll.TabIndex = 14;
            this.CheckAll.TabStop = true;
            this.CheckAll.Text = "All";
            this.CheckAll.UseVisualStyleBackColor = true;
            this.CheckAll.CheckedChanged += new System.EventHandler(this.CheckAll_CheckedChanged);
            // 
            // LoginUserOut
            // 
            this.LoginUserOut.HeaderText = "Никнейм";
            this.LoginUserOut.Name = "LoginUserOut";
            this.LoginUserOut.Width = 177;
            // 
            // UserRoleOut
            // 
            this.UserRoleOut.HeaderText = "Позиция";
            this.UserRoleOut.Name = "UserRoleOut";
            this.UserRoleOut.Width = 177;
            // 
            // UserLinkOut
            // 
            this.UserLinkOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserLinkOut.HeaderText = "SteamLink";
            this.UserLinkOut.Name = "UserLinkOut";
            this.UserLinkOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserLinkOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UserLinkOut.Text = "Показать";
            this.UserLinkOut.ToolTipText = "Перейти к игроку";
            this.UserLinkOut.Width = 177;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(573, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CheckAll);
            this.Controls.Add(this.checkHardSupport);
            this.Controls.Add(this.CheckSupport);
            this.Controls.Add(this.CheckOffline);
            this.Controls.Add(this.CheckMid);
            this.Controls.Add(this.CheckCarry);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowUsr";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.ShowUsr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton CheckCarry;
        private System.Windows.Forms.RadioButton CheckMid;
        private System.Windows.Forms.RadioButton CheckOffline;
        private System.Windows.Forms.RadioButton CheckSupport;
        private System.Windows.Forms.RadioButton checkHardSupport;
        private System.Windows.Forms.RadioButton CheckAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginUserOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRoleOut;
        private System.Windows.Forms.DataGridViewButtonColumn UserLinkOut;
        private System.Windows.Forms.Button button1;
    }
}