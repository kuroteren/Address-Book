namespace AddressBook
{
    partial class ViewContact
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
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_Relationship = new System.Windows.Forms.TextBox();
            this.lbl_CellPhone = new System.Windows.Forms.Label();
            this.txt_CellPhone = new System.Windows.Forms.MaskedTextBox();
            this.txt_WorkPhone = new System.Windows.Forms.MaskedTextBox();
            this.txt_HomePhone = new System.Windows.Forms.MaskedTextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.chk_favorite = new System.Windows.Forms.CheckBox();
            this.lbl_WorkPhone = new System.Windows.Forms.Label();
            this.lbl_HomePhone = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Relationship = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.chk_Secure = new System.Windows.Forms.CheckBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(12, 64);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 0;
            this.txt_FirstName.Text = "First";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(164, 64);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 20);
            this.txt_LastName.TabIndex = 1;
            this.txt_LastName.Text = "Last";
            // 
            // txt_Relationship
            // 
            this.txt_Relationship.Location = new System.Drawing.Point(12, 383);
            this.txt_Relationship.Name = "txt_Relationship";
            this.txt_Relationship.Size = new System.Drawing.Size(252, 20);
            this.txt_Relationship.TabIndex = 6;
            // 
            // lbl_CellPhone
            // 
            this.lbl_CellPhone.AutoSize = true;
            this.lbl_CellPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CellPhone.Location = new System.Drawing.Point(460, 139);
            this.lbl_CellPhone.Name = "lbl_CellPhone";
            this.lbl_CellPhone.Size = new System.Drawing.Size(83, 16);
            this.lbl_CellPhone.TabIndex = 6;
            this.lbl_CellPhone.Text = "Cell Phone";
            // 
            // txt_CellPhone
            // 
            this.txt_CellPhone.Location = new System.Drawing.Point(12, 136);
            this.txt_CellPhone.Mask = "(999) 000-0000";
            this.txt_CellPhone.Name = "txt_CellPhone";
            this.txt_CellPhone.Size = new System.Drawing.Size(252, 20);
            this.txt_CellPhone.TabIndex = 2;
            // 
            // txt_WorkPhone
            // 
            this.txt_WorkPhone.Location = new System.Drawing.Point(12, 207);
            this.txt_WorkPhone.Mask = "(999) 000-0000";
            this.txt_WorkPhone.Name = "txt_WorkPhone";
            this.txt_WorkPhone.Size = new System.Drawing.Size(252, 20);
            this.txt_WorkPhone.TabIndex = 3;
            // 
            // txt_HomePhone
            // 
            this.txt_HomePhone.Location = new System.Drawing.Point(12, 270);
            this.txt_HomePhone.Mask = "(999) 000-0000";
            this.txt_HomePhone.Name = "txt_HomePhone";
            this.txt_HomePhone.Size = new System.Drawing.Size(252, 20);
            this.txt_HomePhone.TabIndex = 4;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(12, 455);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(252, 20);
            this.txt_Address.TabIndex = 7;
            // 
            // chk_favorite
            // 
            this.chk_favorite.AutoSize = true;
            this.chk_favorite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_favorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_favorite.Location = new System.Drawing.Point(12, 519);
            this.chk_favorite.Name = "chk_favorite";
            this.chk_favorite.Size = new System.Drawing.Size(138, 20);
            this.chk_favorite.TabIndex = 8;
            this.chk_favorite.Text = "Favorite Contact";
            this.chk_favorite.UseVisualStyleBackColor = true;
            // 
            // lbl_WorkPhone
            // 
            this.lbl_WorkPhone.AutoSize = true;
            this.lbl_WorkPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WorkPhone.Location = new System.Drawing.Point(460, 208);
            this.lbl_WorkPhone.Name = "lbl_WorkPhone";
            this.lbl_WorkPhone.Size = new System.Drawing.Size(92, 16);
            this.lbl_WorkPhone.TabIndex = 12;
            this.lbl_WorkPhone.Text = "Work Phone";
            // 
            // lbl_HomePhone
            // 
            this.lbl_HomePhone.AutoSize = true;
            this.lbl_HomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HomePhone.Location = new System.Drawing.Point(460, 271);
            this.lbl_HomePhone.Name = "lbl_HomePhone";
            this.lbl_HomePhone.Size = new System.Drawing.Size(97, 16);
            this.lbl_HomePhone.TabIndex = 13;
            this.lbl_HomePhone.Text = "Home Phone";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(460, 456);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(66, 16);
            this.lbl_Address.TabIndex = 14;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Relationship
            // 
            this.lbl_Relationship.AutoSize = true;
            this.lbl_Relationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Relationship.Location = new System.Drawing.Point(460, 384);
            this.lbl_Relationship.Name = "lbl_Relationship";
            this.lbl_Relationship.Size = new System.Drawing.Size(95, 16);
            this.lbl_Relationship.TabIndex = 15;
            this.lbl_Relationship.Text = "Relationship";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(336, 12);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(99, 38);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(444, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(99, 38);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Btn_Home
            // 
            this.Btn_Home.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.Location = new System.Drawing.Point(549, 12);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(99, 38);
            this.Btn_Home.TabIndex = 12;
            this.Btn_Home.Text = "Back";
            this.Btn_Home.UseVisualStyleBackColor = true;
            this.Btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(12, 329);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(252, 20);
            this.txt_Email.TabIndex = 5;
            // 
            // chk_Secure
            // 
            this.chk_Secure.AutoSize = true;
            this.chk_Secure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chk_Secure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Secure.Location = new System.Drawing.Point(444, 519);
            this.chk_Secure.Name = "chk_Secure";
            this.chk_Secure.Size = new System.Drawing.Size(130, 20);
            this.chk_Secure.TabIndex = 9;
            this.chk_Secure.Text = "Secure Contact";
            this.chk_Secure.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(460, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 16);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Name";
            // 
            // ViewContact
            // 
            this.AcceptButton = this.btn_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.Btn_Home;
            this.ClientSize = new System.Drawing.Size(674, 567);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.chk_Secure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Relationship);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_HomePhone);
            this.Controls.Add(this.lbl_WorkPhone);
            this.Controls.Add(this.chk_favorite);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_HomePhone);
            this.Controls.Add(this.txt_WorkPhone);
            this.Controls.Add(this.txt_CellPhone);
            this.Controls.Add(this.lbl_CellPhone);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Relationship);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Name = "ViewContact";
            this.Text = "Contact";
            this.Load += new System.EventHandler(this.ViewContact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Relationship;
        private System.Windows.Forms.Label lbl_CellPhone;
        private System.Windows.Forms.MaskedTextBox txt_CellPhone;
        private System.Windows.Forms.MaskedTextBox txt_WorkPhone;
        private System.Windows.Forms.MaskedTextBox txt_HomePhone;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.CheckBox chk_favorite;
        private System.Windows.Forms.Label lbl_WorkPhone;
        private System.Windows.Forms.Label lbl_HomePhone;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Relationship;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.CheckBox chk_Secure;
        private System.Windows.Forms.Label lblName;
    }
}