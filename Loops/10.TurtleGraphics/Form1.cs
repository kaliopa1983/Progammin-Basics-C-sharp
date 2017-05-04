using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _10.TurtleGraphics
{
    public partial class FormTurtleGraphics : Form
    {
        public FormTurtleGraphics()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;

            Turtle.Delay = 200;

            // Draw a equilateral triangle
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            // Draw a line in the triangle
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }


        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            for (int i = 0; i <= 6; i++)
            {
                Turtle.Rotate(60);
                Turtle.Forward(100);
            }
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            Turtle.PenColor = Color.Green;
            for (int i = 0; i <= 5; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(144);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Blue;
            Turtle.Delay = 200;
            for (int i = 0; i < 20; i++)
            {
                Turtle.Forward(100);
                Turtle.Rotate(60);
                ;
                for (int n = 0; n < i; n = n + 1)
                {
                    Turtle.Forward(10);
                }

            }

        }

        private void buttonSun_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            for (int i = 0; i < 36; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(170);
            }
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            for (int i = 0; i < 22; i++)
            {
                Turtle.Forward(100);
                Turtle.Rotate(120);

                for (int n = 0; n < i; n++)
                {
                    Turtle.Forward(10);
                }
            }
            for (int i = 0; i < 22; i++)
            {
                Turtle.Forward(100);
                Turtle.Rotate(120);

                for (int n = 0; n < i; n++)
                {
                    Turtle.Forward(10);
                }
            }
            for (int i = 0; i < 22; i++)
            {
                Turtle.Forward(100);
                Turtle.Rotate(120);

                for (int n = 0; n < i; n++)
                {
                    Turtle.Forward(10);
                }
            }
        }
    }
}





