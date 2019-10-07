using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaParlour
{
    public partial class Form1 : Form
    {
        const double TOPPING = 1.25;
        const double BASE_PRICE = 7;

        double numOfToppings, total;

        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Graphics g = this.CreateGraphics();
            ////brushes and stuff
            //SolidBrush DesignBrush = new SolidBrush(Color.Red);
            //SolidBrush drawBrush = new SolidBrush(Color.Black);
            //SolidBrush textBrush = new SolidBrush(Color.LightGray);
            //SolidBrush GraphicsBrush = new SolidBrush(Color.LightGray);
            //Pen drawPen = new Pen(Color.Red, 10);
            //Font drawFont = new Font("Consolas", 16, FontStyle.Bold);

            ////main graphics
            //g.FillRectangle(DesignBrush, 0, 100, 200, 100);
            //g.FillRectangle(DesignBrush, 0, 100, 200, 100);
            //g.FillRectangle(drawBrush, 0, 0, 1000, 100);
            //g.DrawString("SSS Pizza Parlour", drawFont, textBrush, 300, 40);
            //g.FillRectangle(GraphicsBrush, 10, 100, 200, 500);

            
            
        }

        private void Toppings_Click(object sender, EventArgs e)
        {


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //get value from input box and place in numOfToppings
            numOfToppings = Convert.ToDouble(toppingsInput.Text);
            
            //calculate total = base price + topping price * number of toppings
            total = BASE_PRICE + TOPPING * numOfToppings; 
            
            //display total
            calculation.Text = "The total is " + total.ToString("C"); 
        }
    }
}  
