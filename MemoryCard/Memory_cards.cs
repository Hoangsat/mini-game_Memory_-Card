using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCard
{
    public partial class Memory_cards : Form
    {
        static Random rand = new Random();
        int[] cards = new int[16];
        public Memory_cards()
        {
            InitializeComponent();
            init_game();
        }

        private void menu_game_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void menu_help_game_rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("need change box)");
        }

        private void menu_help_about_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
               @"This game is my fist game or secons", "About Game", MessageBoxButtons.YesNo);
            if(dr == DialogResult.No)
                Close();
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            int nr = int.Parse (((PictureBox)sender).Tag.ToString());
            MessageBox.Show(nr.ToString());
            

        }
        private void init_game()
        {
            for (int i = 0; i <cards.Length; i++)
                cards[i] = i%(cards.Length/2)+1;
            for (int i = 0; i < 100; i++)
                shuffle_card();
            for (int i = 0; i < cards.Length; i++)
                load_picture(i, cards[i]);

        }
        private void shuffle_card()
        {
            int a = rand.Next(0, cards.Length);
            int b = rand.Next(0, cards.Length);
            if(a == b)
                return;
            int x;
            x= cards[a];
            cards[a] = cards[b];
            cards[b] = x;
        }
         private void load_picture (int picture,int image)
        {
            get_picture_box(picture).Image = get_image(image);
        }
           
        private PictureBox get_picture_box(int picture)
        {
            switch (picture)
            {
                case 0: return pictureBox0;
                case 1: return pictureBox1;
                case 2: return pictureBox2;
                case 3: return pictureBox3;
                case 4: return pictureBox4;
                case 5: return pictureBox5;
                case 6: return pictureBox6;
                case 7: return pictureBox7;
                case 8: return pictureBox8;
                case 9: return pictureBox9;
                case 10: return pictureBox10;
                case 11: return pictureBox11;
                case 12: return pictureBox12;
                case 13: return pictureBox13;
                case 14: return pictureBox14;
                case 15: return pictureBox15;
                default: return null;
            }
            
        }
        private Image get_image (int image)
        {
            switch (image)
            {
                case 0: return Properties.Resources._0;
                case 1: return Properties.Resources._1;
                case 2: return Properties.Resources._2;
                case 3: return Properties.Resources._3;
                case 4: return Properties.Resources._4;
                case 5: return Properties.Resources._5;
                case 6: return Properties.Resources._6;
                case 7: return Properties.Resources._7;
                case 8: return Properties.Resources._8;
                    default: return null;   
            }
        }

        private void menu_game_new_Click(object sender, EventArgs e)
        {
            init_game();
        }
    }
}
