namespace MSPaint
{
    partial class frmNhap
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
            this.txtNhapLieu = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNhapLieu
            // 
            this.txtNhapLieu.Location = new System.Drawing.Point(13, 14);
            this.txtNhapLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNhapLieu.Multiline = true;
            this.txtNhapLieu.Name = "txtNhapLieu";
            this.txtNhapLieu.Size = new System.Drawing.Size(334, 93);
            this.txtNhapLieu.TabIndex = 0;
            this.txtNhapLieu.Enter += new System.EventHandler(this.txtNhapLieu_Enter);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(244, 131);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 42);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 202);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNhapLieu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNhap_FormClosing);
            this.Enter += new System.EventHandler(this.txtNhapLieu_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtNhapLieu;
        private System.Windows.Forms.Button btnOK;
    }
}