using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Key_Down
{
    public partial class Form1 : Form
    {
        int x = 10, y = 10;
        int radius = 15;


        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:
                    x-= 10;
                    break;
                case Keys.Right:
                    x += 10;
                    break;
                case Keys.Up:
                    x -= 10;
                    break;
                case Keys.Down:
                    x += 10;
                    break;

            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.DarkBlue,5);
            e.Graphics.DrawEllipse(pen, x, y, radius * 2, radius * 2);
        }
    }
}
