using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Form_Test
{
    public partial class Form1 : Form
    {
        StringBuilder strInput =new StringBuilder(100);
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.KeyPress += Form1_KeyPress;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\b')
            {
                int index = strInput.Length - 1;
                if (index >= 0)
                    strInput.Remove(index, 1);
            }
            else
                strInput.Append(e.KeyChar);
            Invalidate();
        }
        private void Form1_Paint(object sender,PaintEventArgs e)
        {

            TextFormatFlags flags = TextFormatFlags.WordBreak;
            string str = strInput.ToString();

            TextRenderer.DrawText(e.Graphics, str, Font, ClientRectangle, Color.Blue, flags);

            /*Graphics g = e.Graphics;
            g.DrawString(strInput, Font, Brushes.Green, 10, 10);*/
        }
    }
}
