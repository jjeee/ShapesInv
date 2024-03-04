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
    public partial class AddCircle : Form
    {
        double area, perimeter;
        private List<Shape> shapeList;

        public AddCircle(List<Shape> shapeList)
        {
            InitializeComponent();
            this.shapeList = shapeList;
        }

        void CalcArea()
        {
            double num1 = 0, sub = 0;
            if (double.TryParse(tbxRadius.Text, out num1))
                if (num1 != 0 )
                {
                    sub = Math.PI*(num1);
                    lblArea.Text = sub.ToString();
                    area = sub;
                }
        }

        void CalcPerimeter()
        {
            double num1 = 0,  sub = 0;
            if (double.TryParse(tbxRadius.Text, out num1))
                if (num1 != 0 )
                {
                    sub = (2*Math.PI*num1);
                    lblPerimeter.Text = sub.ToString();
                    perimeter =sub;
                }
        }

        private void tbxRadius_TextChanged(object sender, EventArgs e)
        {
            CalcArea();
            CalcPerimeter();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            shapeList.Add(new Circle(area, perimeter));
            Close();
        }
    }
}
