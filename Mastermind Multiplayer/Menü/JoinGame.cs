using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mastermind_Multiplayer
{
    public partial class JoinGame : MetroFramework.Forms.MetroForm
    {
        public JoinGame()
        {
            InitializeComponent();
        }
        Hauptmenü HM = new Hauptmenü();
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (textBoxIP.Text != "")
            {
                HM.JoinGame(textBoxIP.Text);
            }
            else
            {
                HM.JoinGame("localhost");
            }
        }
    }
}
