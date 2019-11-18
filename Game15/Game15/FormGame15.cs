using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game15
{
    public partial class Game15 : Form
    {
        Game myGame;
        int size = 3;
        Image[,] img;
        PictureBox[,] box;
        int click1 = 999;
        int click2 = 999;
        bool stepOne = true;

        public Game15()
        {
            InitializeComponent();
        }
            
        private void начатьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            myGame = new Game(size);
            cropImage();
            initPictures();
            myGame.start();
            myGame.mixTails();
            RefreshTiles();
        }

        private void initPictures()
        {
            int w, h;

            w = panel1.Width / size;
            h = panel1.Height / size;                     
            
            panel1.Controls.Clear();
            box = new PictureBox[size, size];
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                {
                    PictureBox pb = new PictureBox();

                    pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    pb.Location = new System.Drawing.Point(x * w, y * h);
                    pb.Size = new System.Drawing.Size(w, h);
                    pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    pb.Tag = y * size + x;
                    pb.Click += new System.EventHandler(this.pictureBox1_Click);

                    panel1.Controls.Add(pb);
                    box[x, y] = pb;
                }
        }

        private void cropImage()
        {
            img = new Image[size, size];
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    img[x, y] = getImagePart(x, y);
        }

        private Bitmap getImagePart(int x, int y)
        {
            Bitmap bitmap = Properties.Resources.NY_pic;
            int w, h;
            w = bitmap.Width / size;
            h = bitmap.Height / size;
            Rectangle cropPart = new Rectangle(x * w, y * h, w, h);
            Bitmap target = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(target);
            g.DrawImage(
                bitmap, 
                new Rectangle(0, 0, target.Width, target.Height),
                cropPart,
                GraphicsUnit.Pixel);
            return target;
        }


        private void RefreshTiles()
        {
            for (int p = 0; p < size * size; p++)
            {
                int nmb = myGame.get_number(p);
                box[p % size, p / size].Image = img[nmb % size, nmb / size];
            }
        }

        private void Game15_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void MixTailsToolStripMenuItem_Click(object sender, EventArgs e)
        {     
                RefreshTiles();
        }

        private void menu_level3_Click(object sender, EventArgs e)
        {
            size = 3;
            StartGame();
        }

        private void menu_level4_Click(object sender, EventArgs e)
        {
            size = 4;
            StartGame();
        }

        private void menu_level5_Click(object sender, EventArgs e)
        {
            size = 5;
            StartGame();
        }

        private void menu_level6_Click(object sender, EventArgs e)
        {
            size = 6;
            StartGame();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (stepOne)
            {
                click1 = int.Parse((((PictureBox)sender).Tag).ToString());
                stepOne = false;
            }                
            else
            {
                click2 = int.Parse((((PictureBox)sender).Tag).ToString());
                stepOne = true;
            }

            if (click1 != 999 & click2 != 999)
            {            
                myGame.swapPictures(click1, click2);
                RefreshTiles();

                click1 = 999;
                click2 = 999;
            }

            if (myGame.checkToEndGame())
                MessageBox.Show("Поздравляем! Картинка сложена!");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
