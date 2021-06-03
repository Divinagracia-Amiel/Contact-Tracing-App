
namespace Contact_Tracing_App
{
    partial class importDataForm
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
            this.imp_submitBtn = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.imp_data = new System.Windows.Forms.RichTextBox();
            this.imp_dataLabel = new System.Windows.Forms.Label();
            this.import_method = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // imp_submitBtn
            // 
            this.imp_submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imp_submitBtn.Location = new System.Drawing.Point(12, 238);
            this.imp_submitBtn.Name = "imp_submitBtn";
            this.imp_submitBtn.Size = new System.Drawing.Size(206, 29);
            this.imp_submitBtn.TabIndex = 11;
            this.imp_submitBtn.Text = "Import";
            this.imp_submitBtn.UseVisualStyleBackColor = true;
            this.imp_submitBtn.Click += new System.EventHandler(this.imp_submitBtn_Click);
            // 
            // export
            // 
            this.export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export.Location = new System.Drawing.Point(224, 238);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(206, 29);
            this.export.TabIndex = 12;
            this.export.Text = "Return to Trace Form";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // imp_data
            // 
            this.imp_data.Location = new System.Drawing.Point(12, 45);
            this.imp_data.Name = "imp_data";
            this.imp_data.ReadOnly = true;
            this.imp_data.Size = new System.Drawing.Size(414, 187);
            this.imp_data.TabIndex = 13;
            this.imp_data.Text = "";
            // 
            // imp_dataLabel
            // 
            this.imp_dataLabel.AutoSize = true;
            this.imp_dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imp_dataLabel.Location = new System.Drawing.Point(94, 9);
            this.imp_dataLabel.Name = "imp_dataLabel";
            this.imp_dataLabel.Size = new System.Drawing.Size(252, 31);
            this.imp_dataLabel.TabIndex = 14;
            this.imp_dataLabel.Text = "Contact Information";
            // 
            // import_method
            // 
            this.import_method.DefaultExt = "\"txt\"";
            this.import_method.FileName = "                                                                                 " +
    "          ";
            this.import_method.FilterIndex = 2;
            this.import_method.InitialDirectory = "C:\\Users\\Amiel Divinagracia\\source\\repos\\Contact Tracing App\\Contact Tracing App\\" +
    "bin\\Debug";
            this.import_method.RestoreDirectory = true;
            this.import_method.FileOk += new System.ComponentModel.CancelEventHandler(this.import_method_FileOk);
            // 
            // importDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 279);
            this.Controls.Add(this.imp_dataLabel);
            this.Controls.Add(this.imp_data);
            this.Controls.Add(this.export);
            this.Controls.Add(this.imp_submitBtn);
            this.Name = "importDataForm";
            this.Text = "Import Contact Tracing File";
            this.Load += new System.EventHandler(this.importDataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button imp_submitBtn;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.RichTextBox imp_data;
        private System.Windows.Forms.Label imp_dataLabel;
        private System.Windows.Forms.OpenFileDialog import_method;
    }
}