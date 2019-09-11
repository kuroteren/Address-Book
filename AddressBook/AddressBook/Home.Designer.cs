namespace AddressBook
{
    partial class frm_Home
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
            this.cbo_Fav = new System.Windows.Forms.ComboBox();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_All = new System.Windows.Forms.Button();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.btn_View = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_Fav
            // 
            this.cbo_Fav.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbo_Fav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Fav.FormattingEnabled = true;
            this.cbo_Fav.Location = new System.Drawing.Point(171, 62);
            this.cbo_Fav.Name = "cbo_Fav";
            this.cbo_Fav.Size = new System.Drawing.Size(161, 32);
            this.cbo_Fav.TabIndex = 14;
            this.cbo_Fav.Text = "Favorites";
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Settings.Location = new System.Drawing.Point(345, 173);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(140, 135);
            this.btn_Settings.TabIndex = 13;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(178, 173);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(138, 135);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add Contact";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_All
            // 
            this.btn_All.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_All.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_All.Location = new System.Drawing.Point(12, 173);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(137, 135);
            this.btn_All.TabIndex = 11;
            this.btn_All.Text = "All Contacts";
            this.btn_All.UseVisualStyleBackColor = false;
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Menu.Location = new System.Drawing.Point(165, 9);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(167, 33);
            this.lbl_Menu.TabIndex = 15;
            this.lbl_Menu.Text = "Main Menu";
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.Location = new System.Drawing.Point(204, 110);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(87, 23);
            this.btn_View.TabIndex = 16;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // frm_Home
            // 
            this.AcceptButton = this.btn_All;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(497, 340);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.lbl_Menu);
            this.Controls.Add(this.cbo_Fav);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_All);
            this.Name = "frm_Home";
            this.Text = "Address Book";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Fav;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Button btn_View;
    }
}

