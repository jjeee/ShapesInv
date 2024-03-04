using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapes
{
    public partial class AddRightTriangle : Form
    {
        double area, perimeter;
        private List<Shape> shapeList;

        public AddRightTriangle(List<Shape> shapeList)
        {
            InitializeComponent();
            this.shapeList = shapeList;
        }

        void CalcHypotenuse()
        {
            double num1 = 0, num2 = 0, sub=0;
            if ((double.TryParse(tbxSide1.Text, out num1))&&(double.TryParse(tbxSide2.Text,out num2)))
                if (num1 != 0&&num2!=0)
                {
                    sub = Math.Sqrt((Math.Pow(num1, 2)) + (Math.Pow(num2, 2)));
                    lblHypotenuse.Text = sub.ToString();
                }
        }

        void CalcArea()
        {
            double num1 = 0, num2 = 0, sub = 0;
            if ((double.TryParse(tbxSide1.Text, out num1)) && (double.TryParse(tbxSide2.Text, out num2)))
                if (num1 != 0 && num2 != 0)
                {
                    sub = ((num1 * num2)/2);
                    lblArea.Text = sub.ToString();
                    area= sub;
                }
        }

        void CalcPerimeter()
        {
            double num1 = 0, num2 = 0, sub = 0;
            if ((double.TryParse(tbxSide1.Text, out num1)) && (double.TryParse(tbxSide2.Text, out num2)))
                if (num1 != 0 && num2 != 0)
                {
                    sub = num1+num2+ Math.Sqrt((Math.Pow(num1, 2)) + (Math.Pow(num2, 2)));
                    lblPerimeter.Text = sub.ToString();
                    perimeter = sub;
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            shapeList.Add(new RightTri(area,perimeter));
            Close();
        }
        private void tbxSide1_TextChanged(object sender, EventArgs e)
        {
            CalcHypotenuse();
            CalcArea();
            CalcPerimeter();
        }   

        private void tbxSide2_TextChanged(object sender, EventArgs e)
        {
            CalcHypotenuse();
            CalcArea();
            CalcPerimeter();
        }
    }
}
