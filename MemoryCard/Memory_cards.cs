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
        public Memory_cards()
        {
            InitializeComponent();
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
    }
}
