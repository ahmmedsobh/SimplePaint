using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class Form1 : Form
    {
        Brush PaintBrush = new SolidBrush(Color.FromName("Red"));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // mouse left button paint 
            if(e.Button == MouseButtons.Left)
            {
                //create paint graphic object
                Graphics graphics = this.CreateGraphics();
                // create ellipse fill it red color
                graphics.FillEllipse(PaintBrush, e.X, e.Y, trBrushSize.Value, trBrushSize.Value);
            }
            // mouse right button eraser
            else if (e.Button == MouseButtons.Right)
            {
                // create eraser brush
                Brush b1 = new SolidBrush(this.BackColor);
                //create eraser graphic object
                Graphics graphics = this.CreateGraphics();
                // create ellipse fill it red color
                graphics.FillEllipse(b1, e.X, e.Y, 20, 20);
            }
           

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // get brush color from color dialog
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                // send color to paint brush
                PaintBrush = new SolidBrush(cd.Color);
                // change button color to selected color
                button1.BackColor = cd.Color;
            }
        }
    }
}
