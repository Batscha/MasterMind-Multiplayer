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
    public partial class HostGame : MetroFramework.Forms.MetroForm
    {
        public HostGame()
        {
            InitializeComponent();
        }
        Hauptmenü HM = new Hauptmenü();
        private void buttonHost_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (textBoxIP.Text != "")
            {
                HM.HostGame(textBoxIP.Text);
            }
            else
            {
                HM.HostGame("localhost");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bunifuCheckboxCodierer_OnChange(object sender, EventArgs e)
        {
            Variablen.Spieler = "Codierer";
            if (bunifuCheckboxCodierer.Checked)
            {
                bunifuCheckboxRater.Checked = false;
            }
            else
            {
                bunifuCheckboxCodierer.Checked = true;
            }
        }

        private void bunifuCheckboxRater_OnChange(object sender, EventArgs e)
        {
            Variablen.Spieler = "Rater";
            if (bunifuCheckboxRater.Checked)
            {
                bunifuCheckboxCodierer.Checked = false;
            }
            else
            {
                bunifuCheckboxRater.Checked = true;
            }
        }
    }
}
