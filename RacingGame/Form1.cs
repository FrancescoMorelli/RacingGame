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
        Boundaries outsideBound = new Boundaries(190, 60, 1000, 600);
        Boundaries insideBound = new Boundaries(465, 250, 430, 200);
        SpaceShip spaceShip1 = new SpaceShip(1, 650, 480);
        SpaceShip spaceShip2 = new SpaceShip(2, 650, 540);

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Timer PaintTimer = new Timer();
            PaintTimer.Enabled = true;
            PaintTimer.Interval = 50;
            PaintTimer.Start();
            PaintTimer.Tick += new EventHandler(PaintTimer_Tick);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = panel1.CreateGraphics();


            g.DrawRectangle(myPen, outsideBound.StartPoint, outsideBound.EndPoint, outsideBound.Width, outsideBound.Height);
            g.DrawRectangle(myPen, insideBound.StartPoint, insideBound.EndPoint, insideBound.Width, insideBound.Height);

            g.DrawImage(spaceShip1.ShipImage[spaceShip1.Position], spaceShip1.StartPositionX, spaceShip1.StartPositionY);
            g.DrawImage(spaceShip2.ShipImage[spaceShip2.Position], spaceShip2.StartPositionX, spaceShip2.StartPositionY);

        }

        private void PaintTimer_Tick(object sender, EventArgs e)
        {
            Movement.Move(spaceShip1);
            Movement.Move(spaceShip2);
            panel1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down)
                Movement.Rotation(spaceShip1, e);

            else if (e.KeyCode == Keys.D ||
                e.KeyCode == Keys.A ||
                e.KeyCode == Keys.S ||
                e.KeyCode == Keys.W)
                Movement.Rotation(spaceShip2, e);

        }

    }
}
