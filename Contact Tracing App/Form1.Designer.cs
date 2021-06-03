
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.F_nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // F_name
            // 
            this.F_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_name.Location = new System.Drawing.Point(12, 33);
            this.F_name.Name = "F_name";
            this.F_name.Size = new System.Drawing.Size(114, 26);
            this.F_name.TabIndex = 0;
            this.F_name.TextChanged += new System.EventHandler(this.F_name_TextChanged);
            // 
            // L_name
            // 
            this.L_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_name.Location = new System.Drawing.Point(132, 33);
            this.L_name.Name = "L_name";
            this.L_name.Size = new System.Drawing.Size(210, 26);
            this.L_name.TabIndex = 1;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(12, 82);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(196, 26);
            this.email.TabIndex = 2;
            // 
            // mobNum
            // 
            this.mobNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobNum.Location = new System.Drawing.Point(214, 82);
            this.mobNum.Name = "mobNum";
            this.mobNum.Size = new System.Drawing.Size(126, 26);
            this.mobNum.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 135);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(328, 52);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 235);
            this.Controls.Add(this.F_nameLabel);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label F_nameLabel;
    }
}

