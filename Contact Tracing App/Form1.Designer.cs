
namespace Contact_Tracing_App
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
            this.F_name = new System.Windows.Forms.TextBox();
            this.L_name = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.mobNum = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.RichTextBox();
            this.F_nameLabel = new System.Windows.Forms.Label();
            this.L_nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.mobNumLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.import = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // F_name
            // 
            this.F_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_name.Location = new System.Drawing.Point(12, 33);
            this.F_name.Name = "F_name";
            this.F_name.Size = new System.Drawing.Size(146, 26);
            this.F_name.TabIndex = 0;
            this.F_name.TextChanged += new System.EventHandler(this.F_name_TextChanged);
            // 
            // L_name
            // 
            this.L_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_name.Location = new System.Drawing.Point(164, 33);
            this.L_name.Name = "L_name";
            this.L_name.Size = new System.Drawing.Size(262, 26);
            this.L_name.TabIndex = 1;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(12, 91);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(196, 26);
            this.email.TabIndex = 2;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // mobNum
            // 
            this.mobNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobNum.Location = new System.Drawing.Point(214, 91);
            this.mobNum.Name = "mobNum";
            this.mobNum.Size = new System.Drawing.Size(126, 26);
            this.mobNum.TabIndex = 3;
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(12, 155);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(414, 68);
            this.address.TabIndex = 4;
            this.address.Text = "";
            // 
            // F_nameLabel
            // 
            this.F_nameLabel.AutoSize = true;
            this.F_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_nameLabel.Location = new System.Drawing.Point(8, 10);
            this.F_nameLabel.Name = "F_nameLabel";
            this.F_nameLabel.Size = new System.Drawing.Size(90, 20);
            this.F_nameLabel.TabIndex = 5;
            this.F_nameLabel.Text = "First Name:";
            // 
            // L_nameLabel
            // 
            this.L_nameLabel.AutoSize = true;
            this.L_nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_nameLabel.Location = new System.Drawing.Point(160, 10);
            this.L_nameLabel.Name = "L_nameLabel";
            this.L_nameLabel.Size = new System.Drawing.Size(90, 20);
            this.L_nameLabel.TabIndex = 6;
            this.L_nameLabel.Text = "Last Name:";
            this.L_nameLabel.Click += new System.EventHandler(this.L_nameLabel_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(12, 68);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 20);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = "E-mail:";
            // 
            // mobNumLabel
            // 
            this.mobNumLabel.AutoSize = true;
            this.mobNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobNumLabel.Location = new System.Drawing.Point(210, 68);
            this.mobNumLabel.Name = "mobNumLabel";
            this.mobNumLabel.Size = new System.Drawing.Size(119, 20);
            this.mobNumLabel.TabIndex = 8;
            this.mobNumLabel.Text = "Mobile Number:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(178, 132);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(72, 20);
            this.addressLabel.TabIndex = 9;
            this.addressLabel.Text = "Address:";
            this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(12, 238);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(206, 29);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(346, 91);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(80, 26);
            this.age.TabIndex = 11;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(346, 68);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(42, 20);
            this.ageLabel.TabIndex = 12;
            this.ageLabel.Text = "Age:";
            // 
            // import
            // 
            this.import.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import.Location = new System.Drawing.Point(220, 238);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(206, 29);
            this.import.TabIndex = 13;
            this.import.Text = "Import File";
            this.import.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 279);
            this.Controls.Add(this.import);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.age);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.mobNumLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.L_nameLabel);
            this.Controls.Add(this.F_nameLabel);
            this.Controls.Add(this.address);
            this.Controls.Add(this.mobNum);
            this.Controls.Add(this.email);
            this.Controls.Add(this.L_name);
            this.Controls.Add(this.F_name);
            this.Name = "Form1";
            this.Text = "Contact Tracing App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox F_name;
        private System.Windows.Forms.TextBox L_name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox mobNum;
        private System.Windows.Forms.RichTextBox address;
        private System.Windows.Forms.Label F_nameLabel;
        private System.Windows.Forms.Label L_nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label mobNumLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button import;
    }
}

