namespace WindowsFormApp
{
    partial class Form1
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
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labelPhoneNo = new System.Windows.Forms.Label();
            this.textPhoneNo = new System.Windows.Forms.TextBox();
            this.labelEmailID = new System.Windows.Forms.Label();
            this.textEmailID = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(115, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(351, 32);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(192, 20);
            this.textName.TabIndex = 1;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(115, 82);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(351, 75);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(192, 78);
            this.textAddress.TabIndex = 1;
            // 
            // labelPhoneNo
            // 
            this.labelPhoneNo.AutoSize = true;
            this.labelPhoneNo.Location = new System.Drawing.Point(115, 182);
            this.labelPhoneNo.Name = "labelPhoneNo";
            this.labelPhoneNo.Size = new System.Drawing.Size(58, 13);
            this.labelPhoneNo.TabIndex = 2;
            this.labelPhoneNo.Text = "Phone No.";
            // 
            // textPhoneNo
            // 
            this.textPhoneNo.Location = new System.Drawing.Point(351, 175);
            this.textPhoneNo.Name = "textPhoneNo";
            this.textPhoneNo.Size = new System.Drawing.Size(198, 20);
            this.textPhoneNo.TabIndex = 3;
            // 
            // labelEmailID
            // 
            this.labelEmailID.AutoSize = true;
            this.labelEmailID.Location = new System.Drawing.Point(115, 225);
            this.labelEmailID.Name = "labelEmailID";
            this.labelEmailID.Size = new System.Drawing.Size(43, 13);
            this.labelEmailID.TabIndex = 2;
            this.labelEmailID.Text = "EmailID";
            // 
            // textEmailID
            // 
            this.textEmailID.Location = new System.Drawing.Point(351, 218);
            this.textEmailID.Name = "textEmailID";
            this.textEmailID.Size = new System.Drawing.Size(198, 20);
            this.textEmailID.TabIndex = 3;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(396, 292);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(85, 26);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textEmailID);
            this.Controls.Add(this.labelEmailID);
            this.Controls.Add(this.textPhoneNo);
            this.Controls.Add(this.labelPhoneNo);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labelPhoneNo;
        private System.Windows.Forms.TextBox textPhoneNo;
        private System.Windows.Forms.Label labelEmailID;
        private System.Windows.Forms.TextBox textEmailID;
        private System.Windows.Forms.Button save;
    }
}

