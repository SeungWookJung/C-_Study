using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint +=Form1_Paint;
            
        }
        public void Form1_Paint(object sender,PaintEventArgs e)
        {
            /*Graphics g = e.Graphics;
            g.DrawString("Hellow World", Font, Brushes.DarkBlue, 200, 100);*/
            StringFormat sf = new StringFormat();
            Graphics g = e.Graphics;

            sf.Alignment = StringAlignment.Near;
            g.DrawString("오른쪽 정렬", Font, Brushes.GreenYellow, 100, 10, sf);

            sf.Alignment = StringAlignment.Center;
            g.DrawString("중앙", Font, Brushes.DarkBlue, 100, 30, sf);

            sf.Alignment = StringAlignment.Far;
            g.DrawString("왼쪽 정렬", Font, Brushes.OrangeRed, 100, 50, sf);

            sf.Alignment = StringAlignment.Near;
            g.DrawString("오른쪽 정렬", Font, Brushes.GreenYellow, 100, 10, sf);
        }
    }
}
