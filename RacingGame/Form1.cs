using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RacingGame
{
    public partial class Form1 : Form
    {
        static Pen myPen = new Pen(Color.Black, 3);

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Timer paintTimer = new Timer();
            paintTimer.Interval = 50;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = panel1.CreateGraphics();

            var outsideBound = new Boundaries(190, 60, 1000, 600);
            var insideBound = new Boundaries(465, 250, 430, 200);
            var spaceShip1 = new SpaceShip(1, 650, 480);
            var spaceShip2 = new SpaceShip(2, 650, 540);
            
            g.DrawRectangle(myPen, outsideBound.StartPoint, outsideBound.EndPoint, outsideBound.Width, outsideBound.Height);
            g.DrawRectangle(myPen, insideBound.StartPoint, insideBound.EndPoint, insideBound.Width, insideBound.Height);

            g.DrawImage(spaceShip1.ShipImage[spaceShip1.Position], 650, 480);
            g.DrawImage(spaceShip2.ShipImage[spaceShip1.Position], 650, 540);

        }

    }
}
