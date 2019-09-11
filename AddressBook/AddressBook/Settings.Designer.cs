namespace AddressBook
{
    partial class frm_Settings
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
            this.chk_Last = new System.Windows.Forms.CheckBox();
            this.chk_First = new System.Windows.Forms.CheckBox();
            this.lbl_AZLast = new System.Windows.Forms.Label();
            this.lbl_AZFirst = new System.Windows.Forms.Label();
            this.lbl_Settings = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chk_Last
            // 
            this.chk_Last.AutoSize = true;
            this.chk_Last.BackColor = System.Drawing.Color.White;
            this.chk_Last.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_Last.Location = new System.Drawing.Point(389, 215);
            this.chk_Last.Name = "chk_Last";
            this.chk_Last.Size = new System.Drawing.Size(13, 12);
            this.chk_Last.TabIndex = 12;
            this.chk_Last.UseVisualStyleBackColor = false;
            this.chk_Last.CheckedChanged += new System.EventHandler(this.chk_Last_CheckedChanged);
            // 
            // chk_First
            // 
            this.chk_First.AutoSize = true;
            this.chk_First.BackColor = System.Drawing.Color.White;
            this.chk_First.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_First.Location = new System.Drawing.Point(389, 145);
            this.chk_First.Name = "chk_First";
            this.chk_First.Size = new System.Drawing.Size(13, 12);
            this.chk_First.TabIndex = 11;
            this.chk_First.UseVisualStyleBackColor = false;
            this.chk_First.CheckedChanged += new System.EventHandler(this.chk_First_CheckedChanged);
            // 
            // lbl_AZLast
            // 
            this.lbl_AZLast.AutoSize = true;
            this.lbl_AZLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AZLast.Location = new System.Drawing.Point(24, 207);
            this.lbl_AZLast.Name = "lbl_AZLast";
            this.lbl_AZLast.Size = new System.Drawing.Size(196, 24);
            this.lbl_AZLast.TabIndex = 9;
            this.lbl_AZLast.Text = "Order by Last Name";
            // 
            // lbl_AZFirst
            // 
            this.lbl_AZFirst.AutoSize = true;
            this.lbl_AZFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AZFirst.Location = new System.Drawing.Point(24, 137);
            this.lbl_AZFirst.Name = "lbl_AZFirst";
            this.lbl_AZFirst.Size = new System.Drawing.Size(199, 24);
            this.lbl_AZFirst.TabIndex = 8;
            this.lbl_AZFirst.Text = "Order by First Name";
            // 
            // lbl_Settings
            // 
            this.lbl_Settings.AutoSize = true;
            this.lbl_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Settings.Location = new System.Drawing.Point(148, 9);
            this.lbl_Settings.Name = "lbl_Settings";
            this.lbl_Settings.Size = new System.Drawing.Size(128, 33);
            this.lbl_Settings.TabIndex = 7;
            this.lbl_Settings.Text = "Settings";
            this.lbl_Settings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Home.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(346, 12);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(95, 42);
            this.btn_Home.TabIndex = 14;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(291, 271);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(111, 20);
            this.txt_Password.TabIndex = 15;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_Password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password:";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(135, 329);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(183, 68);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frm_Settings
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.btn_Home;
            this.ClientSize = new System.Drawing.Size(453, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.chk_Last);
            this.Controls.Add(this.chk_First);
            this.Controls.Add(this.lbl_AZLast);
            this.Controls.Add(this.lbl_AZFirst);
            this.Controls.Add(this.lbl_Settings);
            this.Name = "frm_Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frm_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chk_Last;
        private System.Windows.Forms.CheckBox chk_First;
        private System.Windows.Forms.Label lbl_AZLast;
        private System.Windows.Forms.Label lbl_AZFirst;
        private System.Windows.Forms.Label lbl_Settings;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
    }
}