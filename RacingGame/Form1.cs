using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RacingGame
{
    public partial class Form1 : Form
    {
        static Pen myPen = new Pen(Color.Black, 3);
        Rectangle outsideBound = new Rectangle(190, 60, 1000, 600);
        Rectangle insideBound = new Rectangle(465, 250, 430, 200);
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

            g.DrawRectangle(myPen, outsideBound);
            g.DrawRectangle(myPen, insideBound);

            g.DrawImage(spaceShip1.ShipImage[spaceShip1.Position], spaceShip1.PositionX, spaceShip1.PositionY);
            g.DrawImage(spaceShip2.ShipImage[spaceShip2.Position], spaceShip2.PositionX, spaceShip2.PositionY);

        }

        private void PaintTimer_Tick(object sender, EventArgs e)
        {
            Mechanics.Move(spaceShip1);
            Mechanics.Move(spaceShip2);
            Mechanics.Collision(spaceShip1, outsideBound, insideBound);
            Mechanics.Collision(spaceShip2, outsideBound, insideBound);
            panel1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Left ||
                e.KeyCode == Keys.Up ||
                e.KeyCode == Keys.Down)
                Mechanics.Rotation(spaceShip1, e);

            else if (e.KeyCode == Keys.D ||
                e.KeyCode == Keys.A ||
                e.KeyCode == Keys.S ||
                e.KeyCode == Keys.W)
                Mechanics.Rotation(spaceShip2, e);

        }

        //Method to remove the application flickering when redrawing the panel.
        protected override CreateParams CreateParams
        {
            get
            {
                // Activate double buffering at the form level.  All child controls will be double buffered as well.
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                return cp;
            }
        }


    }
}
