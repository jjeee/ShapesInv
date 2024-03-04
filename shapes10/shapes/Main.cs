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
    public partial class Main : Form
    {
        List<Shape> shapeList;

        public Main()
        {
            InitializeComponent();
            shapeList = new List<Shape>();
        }

        private void listBoxUpdate()
        {
            listBox2.Items.Clear();
            foreach (Shape item in shapeList)
            {
                if (item.ShapeItem == "Square" || item.ShapeItem == "Circle")
                {
                    string listitem2 = item.Area.ToString("f2") + "\t" + item.Perimeter.ToString("f2") + "\t" + item.ShapeItem + "\t\t" + item.TimeStamp;
                    listBox2.Items.Add(listitem2);
                }
                else
                {
                    string listitem = item.Area.ToString("f2") + "\t" + item.Perimeter.ToString("f2") + "\t" + item.ShapeItem + "\t" + item.TimeStamp;
                    listBox2.Items.Add(listitem);
                }
                
            }
        }

        private void updateCount()
        {

            int cTri = 0, cSq = 0, cCir = 0, cRec = 0;
            foreach (Shape item in shapeList)
            {

                if (item.ShapeItem.ToString() == "Right Triangle")
                {
                    cTri += 1;
                }
                else if (item.ShapeItem.ToString() == "Square")
                {
                    cSq += 1;
                }
                else if (item.ShapeItem.ToString() == "Circle")
                {
                    cCir += 1;
                }
                else if (item.ShapeItem.ToString() == "Rectangle")
                {
                    cRec += 1;
                }
            }
        
            lblCountRightTriangles.Text = cTri.ToString();
            lblCountSquares.Text = cSq.ToString();
            lblCountCircles.Text = cCir.ToString();
            lblCountRectangles.Text = cRec.ToString();
        }
        
        private void rbtnRightTriange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRightTriangle.Checked)
            {
                AddRightTriangle frmTriangle = new AddRightTriangle(shapeList);
                frmTriangle.ShowDialog();
                rbtnRightTriangle.Checked = false;
            }
            listBoxUpdate();
            updateCount();
        }

        
        private void rbtnSquare_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSquare.Checked)
            {
                AddSquare frmSquare = new AddSquare(shapeList);
                frmSquare.ShowDialog();
                rbtnSquare.Checked = false;
            }
            listBoxUpdate();
            updateCount();
        }

        private void rbtnRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRectangle.Checked)
            {
                AddRectangle frmRectangle = new AddRectangle(shapeList);
                frmRectangle.ShowDialog();
                rbtnRectangle.Checked = false;
            }listBoxUpdate();
            updateCount();
        }

        private void rbtnCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCircle.Checked)
            {
                AddCircle frmCircle = new AddCircle(shapeList);
                frmCircle.ShowDialog();
                rbtnCircle.Checked = false;
            }listBoxUpdate();
            updateCount();
        }

        private void rbtnSortByArea_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            shapeList.Sort((a,b)=>-1*a.Area.CompareTo(b.Area));
            foreach(Shape thing in shapeList)
            {
                string listitem = thing.Area.ToString("f2") + "\t" + thing.Perimeter.ToString("f2") + "\t" + thing.ShapeItem;
                listBox1.Items.Add(listitem);
            }
        }

        private void rbtnSortByPerimeter_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            shapeList.Sort((a, b) => -1 * a.Perimeter.CompareTo(b.Perimeter));
            foreach (Shape thing in shapeList)
            {
                string listitem = thing.Area.ToString("f2") + "\t" + thing.Perimeter.ToString("f2") + "\t" + thing.ShapeItem;
                listBox1.Items.Add(listitem);
            }
        }
    }
}
