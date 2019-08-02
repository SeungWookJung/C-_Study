using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Layout
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.Layout += Form1_Layout;
        }
        private void Form1_Layout(object sender,LayoutEventArgs e)
        {
            Invalidate();
        }
        private void Form1_Paint(object sender,PaintEventArgs e)
        {
            //Pen pen = new Pen(Brushes.DarkBlue, 10);

            /*Rectangle rc = ClientRectangle;
            rc.Inflate(-20, -20);

            Pen pen = new Pen(Brushes.Gold, 30);
            e.Graphics.DrawRectangle(pen, rc);

            rc.Inflate(-10, -10);
            e.Graphics.FillRectangle(Brushes.Purple, rc);*/

            Rectangle rc = ClientRectangle;
            rc.Inflate(-20, -20);

            Pen pen = new Pen(Brushes.Red, 30);
            e.Graphics.DrawEllipse(pen, rc);

            rc.Inflate(-10, -10);
            e.Graphics.FillEllipse(Brushes.Purple, rc);

        }
    }
}
