using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace Mastermind_Multiplayer
{
    public partial class Hauptmenü : MetroFramework.Forms.MetroForm
    {
        Server server;
        string ClientToHostIP = "localhost";
        Client client;
        int clientport;
        public static Socket socket;
        public IPEndPoint remoteIpEndPoint;

        public Hauptmenü()
        {
            InitializeComponent();
            Überschrift.Parent = pictureBox1;
            Transition.run(pictureBox1, "BackColor", Color.White, new TransitionType_Linear(1000)); //
            Transition.run(Überschrift, "ForeColor", Color.Black, new TransitionType_Linear(1000));
            Transition t = new Transition(new TransitionType_EaseInEaseOut(1000));
            t.add(Überschrift, "Top", 11);
            t.run();
            Timer disable = new Timer();
            disable.Interval = 1000;
            disable.Tick += Disable_Tick;
            disable.Enabled = true;
        }

        public void HostGame(string IP) //Erstelle Server
        {
            server = new Server(1000);
        }

        public void JoinGame(string IP) // Erstelle Client
        {
            client = new Client(IP, 1000);
            timerReceiveData.Enabled = true;
        }



        private void Disable_Tick(object sender, EventArgs e)
        {
            Überschrift.Parent = this;
            pictureBox1.Hide();
            Transition t = new Transition(new TransitionType_EaseInEaseOut(3000));
            t.add(ButtonSettings, "Top", 65); t.add(ButtonSettings, "Left", -1);
            t.add(ButtonHost, "Top", 65); t.add(ButtonHost, "Left", 179);
            t.add(ButtonExit, "Top", 217 + 139); t.add(ButtonExit, "Left", -1);
            t.add(panelName, "Top", 217); t.add(panelName, "Left", -1);
            t.add(ButtonJoinGame, "Top", 65 + 218); t.add(ButtonJoinGame, "Left", 179);

            t.run();
            ((Timer)sender).Enabled = false;
        }

        private void Codierer_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            textBoxName.Text = "Spieler" + Convert.ToString(rnd.Next(1000) + 1);
        }

        public static void GimmeFeedBack(string IP,string Port)
        {
            MessageBox.Show("Server erkennt Verindung");
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(textBox1.Text);
            server.send(bytes);
        }

        private void timerReceiveData_Tick(object sender, EventArgs e)
        {

            byte[] array = client.receive();

            if (array != null)
            {
                try
                {

                    string something = System.Text.Encoding.ASCII.GetString(array);
                    MessageBox.Show(something);
                    //switch (something)
                    //{
                    //    case "":
                    //        break;
                    //}
                }
                catch (Exception EX)
                {
                    MessageBox.Show("Fehler! : " + EX.Message);
                }
            }
        }

        private void timerTryConnect_Tick(object sender, EventArgs e)
        {
            try
            {
                 Client client = new Client(ClientToHostIP, clientport);
                 socket = client.socket;
                 this.client = client;
                 timerTryConnect.Enabled = false;
                 timerReceiveData.Enabled = true;
                 MessageBox.Show("Rater connected");
            }
            catch
            {
            }
        }


        private void ButtonHost_Click(object sender, EventArgs e)
        {
            HostGame HG = new HostGame();
            HG.ShowDialog();
            //Transition ta = new Transition(new TransitionType_Linear(3000));
            //ta.add(Überschrift, "Text", "Spiel hosten");
            //ta.run();
        }

        private void ButtonJoinGame_Click(object sender, EventArgs e)
        {
            JoinGame JG = new JoinGame();
            JG.ShowDialog();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
