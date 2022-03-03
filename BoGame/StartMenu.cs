using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoGame
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            Flappy_Min gameWindow = new Flappy_Min();
            gameWindow.Show();
        }
    }
}
