namespace AddressBook
{
    partial class frm_AllContcats
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.cbo_Contacts = new System.Windows.Forms.ComboBox();
            this.btn_View = new System.Windows.Forms.Button();
            this.txt_Filter = new System.Windows.Forms.TextBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(12, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(172, 31);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "All Contacts";
            // 
            // btn_Home
            // 
            this.btn_Home.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Location = new System.Drawing.Point(317, 9);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(95, 42);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // cbo_Contacts
            // 
            this.cbo_Contacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_Contacts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbo_Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Contacts.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbo_Contacts.FormattingEnabled = true;
            this.cbo_Contacts.Items.AddRange(new object[] {
            "Contact 1",
            "Contact 2",
            "Contact 3"});
            this.cbo_Contacts.Location = new System.Drawing.Point(90, 140);
            this.cbo_Contacts.Name = "cbo_Contacts";
            this.cbo_Contacts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbo_Contacts.Size = new System.Drawing.Size(244, 251);
            this.cbo_Contacts.TabIndex = 4;
            this.cbo_Contacts.Text = "Select a Contact";
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.Location = new System.Drawing.Point(161, 429);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(87, 23);
            this.btn_View.TabIndex = 5;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // txt_Filter
            // 
            this.txt_Filter.Location = new System.Drawing.Point(61, 86);
            this.txt_Filter.Name = "txt_Filter";
            this.txt_Filter.Size = new System.Drawing.Size(158, 20);
            this.txt_Filter.TabIndex = 6;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filter.Location = new System.Drawing.Point(288, 84);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(75, 23);
            this.btn_Filter.TabIndex = 7;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // frm_AllContcats
            // 
            this.AcceptButton = this.btn_Filter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.btn_Home;
            this.ClientSize = new System.Drawing.Size(424, 464);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.txt_Filter);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.cbo_Contacts);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.lbl_Title);
            this.Name = "frm_AllContcats";
            this.Text = "All Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Home;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ComboBox cbo_Contacts;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.TextBox txt_Filter;
        private System.Windows.Forms.Button btn_Filter;
    }
}