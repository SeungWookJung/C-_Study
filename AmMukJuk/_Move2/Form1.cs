using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Move2
{
    public partial class Form1 : Form
    {
        int x = 10, y = 10;
        int radius = 15;
        Timer timer = new Timer();


        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender,EventArgs e)
        {
            x += 10;
            DetectBoundary();
            Invalidate();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    x -= 10;
                    break;
                case Keys.Right:
                    x += 10;
                    break;
                case Keys.Up:
                    y -= 10;
                    break;
                case Keys.Down:
                    y += 10;
                    break;
                case Keys.Enter:
                    timer.Start();
                    break;
            }

            DetectBoundary();
            Invalidate();
        }
        void DetectBoundary()
        {
            if (x < 0)
                x += 10;
            else if (x > ClientRectangle.Right - radius * 2)
                x -= 10;
            if (y < 0)
                y += 10;
            else if (y > ClientRectangle.Bottom - radius * 2)
                y -= 10;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.DarkBlue, 5);
            e.Graphics.DrawEllipse(pen, x, y, radius * 2, radius * 2);
        }
    }
}
