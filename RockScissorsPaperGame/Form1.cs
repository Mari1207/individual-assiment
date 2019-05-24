using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockScissorsPaperGame
{
    public partial class text : Form
    {
        Random random = new Random();
        int humanChoice;
        int computer_Choice;
        public text()
        {
            InitializeComponent();
        }

        private void BtnRock_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\Projects\RockScissorsPapers Object ver\RockScissorsPaperGame\RockScissorsPaperGame\image\gu.jpg ");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            humanChoice = 1;
            computerChoice();
            checkWinner();
        }

        private void BtnScissors_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\Projects\RockScissorsPapers Object ver\RockScissorsPaperGame\RockScissorsPaperGame\image\choki.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            humanChoice = 2;
            computerChoice();
            checkWinner();
        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(@"C:\Projects\RockScissorsPapers Object ver\RockScissorsPaperGame\RockScissorsPaperGame\image\par.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            humanChoice = 3;
            computerChoice();
            checkWinner();
        }
        public void computerChoice()
        {
            int computer_choice = random.Next(0, 3);
            switch (computer_choice)
            {
                case 1:
                    pictureBox2.Image = new Bitmap(@"C:\Projects\RockScissorsPapers Object ver\RockScissorsPaperGame\RockScissorsPaperGame\image\gu.jpg");
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox2.Image = new Bitmap(@"C:\Projects\RockScissorsPapers Object ver\RockScissorsPaperGame\RockScissorsPaperGame\image\choki.jpg");
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox2.Image = new Bitmap(@"C:\Projects\RockScissorsPapers Object ver\RockScissorsPaperGame\RockScissorsPaperGame\image\par.jpg");
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
            //checkWinner

        }
        public void checkWinner()
        {
            if (humanChoice == computer_Choice)
                label6.Text = "Tie";
            else if ((humanChoice - computer_Choice) % 3 == 0)
                label6.Text = "You win";
            else label6.Text = "Computer win";

        }

        private void Text_Load(object sender, EventArgs e)
        {

        }
    }
}
