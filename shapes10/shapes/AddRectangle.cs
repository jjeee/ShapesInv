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
    public partial class AddRectangle : Form
    {
        double area, perimeter;
        private List<Shape> shapeList;

        public AddRectangle(List<Shape> shapeList)
        {
            InitializeComponent();
            this.shapeList = shapeList;
        }

        void CalcArea()
        {
            double num1 = 0, num2 = 0, sub = 0;
            if ((double.TryParse(tbxSide1.Text, out num1)) && (double.TryParse(tbxSide2.Text, out num2)))
            {
                if (num1 != 0 && num2 != 0)
                {
                    sub = num1 * num2;
                    lblArea.Text = sub.ToString();
                    area = sub;
                }
            }
        }

        void CalcPerimeter()
        {
            double num1 = 0, num2 = 0, sub = 0;
            if ((double.TryParse(tbxSide1.Text, out num1)) && (double.TryParse(tbxSide2.Text, out num2)))
            {
                if (num1 != 0 && num2 != 0)
                {
                    sub = (num1 * 2) + (num2 * 2);
                    lblPerimeter.Text = sub.ToString();
                    perimeter = sub;
                }
            }
        }
        
        private void tbxSide2_TextChanged_1(object sender, EventArgs e)
        {
            CalcArea();
            CalcPerimeter();
        }

        private void tbxSide1_TextChanged_1(object sender, EventArgs e)
        {
            CalcArea();
            CalcPerimeter();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            shapeList.Add(new Rectangle(area, perimeter));
            Close();
        }
    }
}
