using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSPaint
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();      
        }
        bool drw;
        int BeDayNet;
        Color MauSac = Color.White;
        bool PenActive = false;
        bool RecActive = false;
        bool SquareActive = false;
        bool TriangleActive = false;
        bool LineActive = false;
        bool CircleActive = false;
        bool TextActive = false;
        bool PictureActive = false;
        int beginX, beginY;
        public static string ChuoiString = "";
        Font KieuChu = new Font("Arial", 16);
        Dictionary<int, int> ToaDo3DinhTamGiac = new Dictionary<int, int>();
        string PathPicture = "";
        private void pnVe_MouseDown(object sender, MouseEventArgs e)
        {
            drw = true;
            beginX = e.X;
            beginY = e.Y;
            if (TriangleActive)
            {
                ToaDo3DinhTamGiac.Add(beginX, beginY);
                if (ToaDo3DinhTamGiac.Count == 3)
                {
                    VeTamGiac();
                    ToaDo3DinhTamGiac.Clear();
                }                   
            }
            if (TextActive)
            {
                Graphics g = pnVe.CreateGraphics();
                SolidBrush drawBrush = new SolidBrush(MauSac);
                g.DrawString(ChuoiString, KieuChu, drawBrush, beginX, beginY);
                TextActive = false;
                lblLenh.Text = "Hãy chọn lại lệnh mới...";
            }
            
        }

        private void VeTamGiac()
        {
            Graphics g = pnVe.CreateGraphics();
            BeDayNet = int.Parse(txtBeDayNet.Text);
            Pen p = new Pen(MauSac, BeDayNet);
            Point point1;
            Point point2;
            point1 = new Point(ToaDo3DinhTamGiac.Keys.ElementAt(0),ToaDo3DinhTamGiac.Values.ElementAt(0));
            point2 = new Point(ToaDo3DinhTamGiac.Keys.ElementAt(1), ToaDo3DinhTamGiac.Values.ElementAt(1));
            g.DrawLine(p, point1, point2);
            point1 = new Point(ToaDo3DinhTamGiac.Keys.ElementAt(1), ToaDo3DinhTamGiac.Values.ElementAt(1));
            point2 = new Point(ToaDo3DinhTamGiac.Keys.ElementAt(2), ToaDo3DinhTamGiac.Values.ElementAt(2));
            g.DrawLine(p, point1, point2);
            point1 = new Point(ToaDo3DinhTamGiac.Keys.ElementAt(2), ToaDo3DinhTamGiac.Values.ElementAt(2));
            point2 = new Point(ToaDo3DinhTamGiac.Keys.ElementAt(0), ToaDo3DinhTamGiac.Values.ElementAt(0));
            g.DrawLine(p, point1, point2);
        }

        private void pnVe_MouseMove(object sender, MouseEventArgs e)
        {
            #region Pen - Vẽ tự do        
            if (drw == true && PenActive == true) // Vẽ tự do.
            {
                Graphics g = pnVe.CreateGraphics();
                BeDayNet = int.Parse(txtBeDayNet.Text);
                Pen p = new Pen(MauSac, BeDayNet);
                Point point1 = new Point(beginX, beginY);
                Point point2 = new Point(e.X, e.Y);
                g.DrawLine(p, point1, point2);
                beginX = e.X;
                beginY = e.Y;              
            }
            #endregion
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtBeDayNet.Text = "1"; // bề dày nét mặc định là 1.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReActiveAll();
            PenActive=true;
            lblLenh.Text = "Vẽ tự do...";
        }

        private void ReActiveAll()
        {
            LineActive = false;
            PenActive = false;
            RecActive = false;
            SquareActive = false;
            TriangleActive = false;
            CircleActive = false;
            TextActive = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReActiveAll();
            RecActive = true;
            lblLenh.Text = "Vẽ hình chữ nhật...\n Nhấp chuột vào điểm 1, giữ chuột, di chuyển đến điểm 2 và nhả chuột.";          
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            ReActiveAll();
            SquareActive = true;
            lblLenh.Text = "Vẽ hình vuông...\nNhấn chuột vào điểm 1, giữ chuột, đi chuyển đến điểm 2, nhả chuột.\nCạnh của hình vuông là khoảng cách từ điểm 1 đến điểm 2 theo phương X.";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
           
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                MauSac = colorDialog1.Color;
                btnColor.BackColor = MauSac;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTri_Click(object sender, EventArgs e)
        {
            ReActiveAll();
            TriangleActive = true;
            lblLenh.Text = "Vẽ tam giác...\nNhấp chuột vào 3 đỉnh của tam giác.";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReActiveAll();
            LineActive = true;
            lblLenh.Text = "Vẽ đường thẳng...\nNhấn vào điểm đầu, giữ chuột, di chuyển đến điểm cuối và nhả chuột ra.";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Graphics g = pnVe.CreateGraphics();
            g.Clear(Color.Black);        
        }

        private void btnCir_Click(object sender, EventArgs e)
        {
            ReActiveAll();
            CircleActive = true;
            lblLenh.Text = "Vẽ hình tròn...";

        }

        private void btnStyle_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = KieuChu;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                KieuChu = fontDialog1.Font;
            }
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            ReActiveAll();          
            lblLenh.Text = "Nhập nội dung vào sau đó tắt hợp thoại đi...";
            frmNhap frm = new frmNhap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                TextActive = true;
                lblLenh.Text = "Bạn đang viết chữ [" + ChuoiString + "]...Nhấp chọn điểm đặt chữ.";
            }
            
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            lblLenh.Text = "Chèn ảnh...\nChọn ảnh muốn chèn.";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                PathPicture = openFileDialog1.FileName;
            }
            lblLenh.Text = "Chèn ảnh...\nNhấp điểm đầu, giữ chuột và di chuyển đến điểm cuối, nhả chuột để xác định vùng đặt ảnh.";
            ReActiveAll();
            PictureActive=true;
        }

        private void pnVe_MouseUp(object sender, MouseEventArgs e)
        {
            #region Vẽ đường thẳng
            if (drw == true && LineActive == true)
            {
                Graphics g = pnVe.CreateGraphics();
                BeDayNet = int.Parse(txtBeDayNet.Text);
                Pen p = new Pen(MauSac, BeDayNet);
                Point point1 = new Point(beginX, beginY);
                Point point2 = new Point(e.X, e.Y);
                g.DrawLine(p, point1, point2);
            }
            #endregion
            #region vẽ hình chữ nhật
            if (drw == true && RecActive==true)//vẽ hình chữ nhật.
            {
                Graphics g = pnVe.CreateGraphics();
                BeDayNet = int.Parse(txtBeDayNet.Text);
                Pen p = new Pen(MauSac, BeDayNet);
                if (e.X > beginX && e.Y > beginY) //sang phải xuống dưới.
                {
                    g.DrawRectangle(p, beginX, beginY, Math.Abs(e.X - beginX), Math.Abs(e.Y - beginY));                   
                }
                if (e.X > beginX && e.Y < beginY) //sang phải lên trên.
                {
                    g.DrawRectangle(p, beginX, e.Y, Math.Abs(e.X - beginX), Math.Abs(e.Y - beginY));
                }
                if (e.X < beginX && e.Y > beginY) //sang trái xuống dưới.
                {
                    g.DrawRectangle(p, e.X, beginY, Math.Abs(e.X - beginX), Math.Abs(e.Y - beginY));
                }
                if (e.X < beginX && e.Y < beginY) //sang trái lên trên.
                {
                    g.DrawRectangle(p, e.X, e.Y, Math.Abs(e.X - beginX), Math.Abs(e.Y - beginY));
                }
             }
            #endregion
            #region vẽ hình vuông
            if (drw == true && SquareActive == true) // vẽ hình vuông
            {
                Graphics g = pnVe.CreateGraphics();
                BeDayNet = int.Parse(txtBeDayNet.Text);
                Pen p = new Pen(MauSac, BeDayNet);
                int canh = 0;
                canh = Math.Abs(e.X - beginX);
                if (e.X > beginX && e.Y > beginY) //sang phải xuống dưới.
                {
                    g.DrawRectangle(p, beginX, beginY, canh, canh);
                }
                if (e.X > beginX && e.Y < beginY) //sang phải lên trên.
                {
                    g.DrawRectangle(p, beginX, e.Y, canh, canh);
                }
                if (e.X < beginX && e.Y > beginY) //sang trái xuống dưới.
                {
                    g.DrawRectangle(p, e.X, beginY, canh, canh);
                }
                if (e.X < beginX && e.Y < beginY) //sang trái lên trên.
                {
                    g.DrawRectangle(p, e.X, e.Y, canh, canh);
                }
            }
            #endregion
            #region Vẽ hình tròn
            if (CircleActive)
            {
                Graphics g = pnVe.CreateGraphics();
                BeDayNet = int.Parse(txtBeDayNet.Text);
                Pen p = new Pen(MauSac, BeDayNet);
                int EndX = e.X;
                int EndY = e.Y;
                int BanKinh = (int)(Math.Sqrt((EndX - beginX) * (EndX - beginX) + (EndY - beginY) * (EndY - beginY)));
                g.DrawEllipse(p, beginX - BanKinh, beginY - BanKinh, BanKinh * 2, BanKinh * 2);
            }
            #endregion
            #region Vẽ picture
            if (PictureActive)
            {
                Image img = Image.FromFile(PathPicture);
                Graphics g = pnVe.CreateGraphics();
                g.DrawImage(img, beginX, beginY, e.X - beginX, e.Y - beginY);
                g.Dispose();
            }           
            #endregion
            drw = false;
            
        }

    }
}
