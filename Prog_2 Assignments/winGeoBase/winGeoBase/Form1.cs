using System;
using System.Windows.Forms;

namespace winGeoBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cuboid myCuboid = new Cuboid
                              {
                                  Density = 1.5,
                                  Depth = 27,
                                  Height = 9.5,
                                  Width = 13
                              };

            double area = myCuboid.Area();
            double volume = myCuboid.Volume();

            Sphere mySphere = new Sphere();
            mySphere.Density = 1.5;
            mySphere.Radius = 2.5;
            double area1 = mySphere.Area();
            double volume2 = mySphere.Volume();
        }
    }
}