namespace MSPaint
{
    partial class frmMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStyle = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtBeDayNet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnString = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnTri = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCir = new System.Windows.Forms.Button();
            this.pnVe = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblLenh = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnPicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnVe.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnVe);
            this.splitContainer1.Size = new System.Drawing.Size(1062, 554);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnPicture);
            this.splitContainer2.Panel2.Controls.Add(this.btnString);
            this.splitContainer2.Panel2.Controls.Add(this.btnLine);
            this.splitContainer2.Panel2.Controls.Add(this.btnTri);
            this.splitContainer2.Panel2.Controls.Add(this.btnPen);
            this.splitContainer2.Panel2.Controls.Add(this.btnRec);
            this.splitContainer2.Panel2.Controls.Add(this.btnSquare);
            this.splitContainer2.Panel2.Controls.Add(this.btnCir);
            this.splitContainer2.Size = new System.Drawing.Size(180, 554);
            this.splitContainer2.SplitterDistance = 121;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStyle);
            this.groupBox1.Controls.Add(this.btnColor);
            this.groupBox1.Controls.Add(this.txtBeDayNet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // btnStyle
            // 
            this.btnStyle.Location = new System.Drawing.Point(6, 85);
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.Size = new System.Drawing.Size(168, 23);
            this.btnStyle.TabIndex = 3;
            this.btnStyle.Text = "TextStyle";
            this.btnStyle.UseVisualStyleBackColor = true;
            this.btnStyle.Click += new System.EventHandler(this.btnStyle_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(6, 56);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(168, 23);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtBeDayNet
            // 
            this.txtBeDayNet.Location = new System.Drawing.Point(93, 23);
            this.txtBeDayNet.Name = "txtBeDayNet";
            this.txtBeDayNet.Size = new System.Drawing.Size(81, 20);
            this.txtBeDayNet.TabIndex = 1;
            this.txtBeDayNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "LineWidth:";
            // 
            // btnString
            // 
            this.btnString.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnString.Location = new System.Drawing.Point(22, 296);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(140, 42);
            this.btnString.TabIndex = 6;
            this.btnString.Text = "Text";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnLine
            // 
            this.btnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLine.Location = new System.Drawing.Point(22, 63);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(140, 42);
            this.btnLine.TabIndex = 5;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnTri
            // 
            this.btnTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTri.Location = new System.Drawing.Point(22, 248);
            this.btnTri.Margin = new System.Windows.Forms.Padding(2);
            this.btnTri.Name = "btnTri";
            this.btnTri.Size = new System.Drawing.Size(140, 42);
            this.btnTri.TabIndex = 4;
            this.btnTri.Text = "Triangle";
            this.btnTri.UseVisualStyleBackColor = true;
            this.btnTri.Click += new System.EventHandler(this.btnTri_Click);
            // 
            // btnPen
            // 
            this.btnPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPen.Location = new System.Drawing.Point(22, 16);
            this.btnPen.Margin = new System.Windows.Forms.Padding(2);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(140, 42);
            this.btnPen.TabIndex = 0;
            this.btnPen.Text = "Pen";
            this.btnPen.UseVisualStyleBackColor = true;
            this.btnPen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRec
            // 
            this.btnRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRec.Location = new System.Drawing.Point(22, 110);
            this.btnRec.Margin = new System.Windows.Forms.Padding(2);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(140, 42);
            this.btnRec.TabIndex = 1;
            this.btnRec.Text = "Rectangle";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(22, 156);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(2);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(140, 42);
            this.btnSquare.TabIndex = 2;
            this.btnSquare.Text = "Square";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnCir
            // 
            this.btnCir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCir.Location = new System.Drawing.Point(22, 202);
            this.btnCir.Margin = new System.Windows.Forms.Padding(2);
            this.btnCir.Name = "btnCir";
            this.btnCir.Size = new System.Drawing.Size(140, 42);
            this.btnCir.TabIndex = 3;
            this.btnCir.Text = "Circle";
            this.btnCir.UseVisualStyleBackColor = true;
            this.btnCir.Click += new System.EventHandler(this.btnCir_Click);
            // 
            // pnVe
            // 
            this.pnVe.BackColor = System.Drawing.Color.Black;
            this.pnVe.Controls.Add(this.btnReset);
            this.pnVe.Controls.Add(this.lblLenh);
            this.pnVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnVe.Location = new System.Drawing.Point(0, 0);
            this.pnVe.Margin = new System.Windows.Forms.Padding(2);
            this.pnVe.Name = "pnVe";
            this.pnVe.Size = new System.Drawing.Size(879, 554);
            this.pnVe.TabIndex = 0;
            this.pnVe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnVe_MouseDown);
            this.pnVe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnVe_MouseMove);
            this.pnVe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnVe_MouseUp);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(792, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 37);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblLenh
            // 
            this.lblLenh.AutoSize = true;
            this.lblLenh.BackColor = System.Drawing.SystemColors.Control;
            this.lblLenh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLenh.Location = new System.Drawing.Point(24, 16);
            this.lblLenh.Name = "lblLenh";
            this.lblLenh.Size = new System.Drawing.Size(18, 15);
            this.lblLenh.TabIndex = 0;
            this.lblLenh.Text = "...";
            // 
            // btnPicture
            // 
            this.btnPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicture.Location = new System.Drawing.Point(22, 344);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(140, 42);
            this.btnPicture.TabIndex = 7;
            this.btnPicture.Text = "Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 554);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "MS Paint";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnVe.ResumeLayout(false);
            this.pnVe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnVe;
        private System.Windows.Forms.Button btnTri;
        private System.Windows.Forms.Button btnCir;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStyle;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtBeDayNet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLenh;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}