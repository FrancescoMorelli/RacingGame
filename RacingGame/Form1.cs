using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RacingGame
{
    public partial class Form1 : Form
    {
        //Really ugle way to load an Image, TO BE CHANGED
        Image backGround = Image.FromFile(Convert.ToString(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))) + @"\BackGroundImage\galaxy.jpg");
        static Pen myPen = new Pen(Color.White, 3);
        static Brush myBrush = new SolidBrush(Color.White);
        static Font myFont = new Font("Times New Roman", 16);

        Rectangle outsideBound = new Rectangle(190, 60, 1000, 600);
        Rectangle insideBound = new Rectangle(465, 250, 430, 200);
        Rectangle startLine = new Rectangle(695, 450, 1, 210);
        Rectangle middleCheckPoint = new Rectangle(695, 100, 1, 210);

        SpaceShip spaceShip1 = new SpaceShip(1, 650, 480);
        SpaceShip spaceShip2 = new SpaceShip(2, 650, 540);

        static bool checkPointP1, checkPointP2;

        public Form1()
        {
            
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Timer paintTimer = new Timer();
            paintTimer.Enabled = true;
            paintTimer.Interval = 50;
            paintTimer.Start();
            paintTimer.Tick += new EventHandler(PaintTimer_Tick);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            panel1.BackgroundImage = backGround;

            //Boundaries
            g.DrawRectangle(myPen, outsideBound);
            g.DrawRectangle(myPen, insideBound);

            //Starting line
            g.DrawLine(myPen, 695, 450, 695, 660);

            g.DrawImage(spaceShip1.ShipImage[spaceShip1.Position], spaceShip1.PositionX, spaceShip1.PositionY);
            g.DrawImage(spaceShip2.ShipImage[spaceShip2.Position], spaceShip2.PositionX, spaceShip2.PositionY);

            g.DrawString($"Player1\nLap Count: {spaceShip1.LapCount}\nSpeed: {spaceShip1.Speed}", myFont, myBrush, 20, 130);
            g.DrawString($"Player2\nLap Count: {spaceShip2.LapCount}\nSpeed: {spaceShip2.Speed}", myFont, myBrush, 1200, 130);
        }

        private void PaintTimer_Tick(object sender, EventArgs e)
        {
            Mechanics.Move(spaceShip1);
            Mechanics.Move(spaceShip2);
            checkPointP1 = Mechanics.LapCount(spaceShip1, startLine, middleCheckPoint, checkPointP1);
            checkPointP2 = Mechanics.LapCount(spaceShip2, startLine, middleCheckPoint, checkPointP2);
            Collisions.Walls(spaceShip1, outsideBound, insideBound);
            Collisions.Walls(spaceShip2, outsideBound, insideBound);
            Collisions.Players(spaceShip1, spaceShip2);
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
