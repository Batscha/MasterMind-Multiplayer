namespace Mastermind_Multiplayer
{
    partial class Hauptmenü
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.timerTryConnect = new System.Windows.Forms.Timer(this.components);
            this.timerReceiveData = new System.Windows.Forms.Timer(this.components);
            this.Überschrift = new System.Windows.Forms.Label();
            this.ButtonJoinGame = new Bunifu.Framework.UI.BunifuTileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonSettings = new Bunifu.Framework.UI.BunifuTileButton();
            this.ButtonHost = new Bunifu.Framework.UI.BunifuTileButton();
            this.ButtonExit = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panelName = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelName.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(523, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 3;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(523, 271);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(171, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // timerTryConnect
            // 
            this.timerTryConnect.Interval = 200;
            this.timerTryConnect.Tick += new System.EventHandler(this.timerTryConnect_Tick);
            // 
            // timerReceiveData
            // 
            this.timerReceiveData.Tick += new System.EventHandler(this.timerReceiveData_Tick);
            // 
            // Überschrift
            // 
            this.Überschrift.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Überschrift.AutoSize = true;
            this.Überschrift.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Überschrift.ForeColor = System.Drawing.Color.LightGray;
            this.Überschrift.Location = new System.Drawing.Point(146, 292);
            this.Überschrift.Name = "Überschrift";
            this.Überschrift.Size = new System.Drawing.Size(206, 50);
            this.Überschrift.TabIndex = 10;
            this.Überschrift.Text = "Mastermind";
            // 
            // ButtonJoinGame
            // 
            this.ButtonJoinGame.BackColor = System.Drawing.Color.SlateBlue;
            this.ButtonJoinGame.color = System.Drawing.Color.SlateBlue;
            this.ButtonJoinGame.colorActive = System.Drawing.Color.MediumPurple;
            this.ButtonJoinGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonJoinGame.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ButtonJoinGame.ForeColor = System.Drawing.Color.White;
            this.ButtonJoinGame.Image = global::Mastermind_Multiplayer.Properties.Resources._006_password;
            this.ButtonJoinGame.ImagePosition = 20;
            this.ButtonJoinGame.ImageZoom = 50;
            this.ButtonJoinGame.LabelPosition = 41;
            this.ButtonJoinGame.LabelText = "Spiel betreten";
            this.ButtonJoinGame.Location = new System.Drawing.Point(912, 248);
            this.ButtonJoinGame.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonJoinGame.Name = "ButtonJoinGame";
            this.ButtonJoinGame.Size = new System.Drawing.Size(307, 227);
            this.ButtonJoinGame.TabIndex = 16;
            this.ButtonJoinGame.Click += new System.EventHandler(this.ButtonJoinGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Orchid;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 518);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.BackColor = System.Drawing.Color.OliveDrab;
            this.ButtonSettings.color = System.Drawing.Color.OliveDrab;
            this.ButtonSettings.colorActive = System.Drawing.Color.YellowGreen;
            this.ButtonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSettings.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ButtonSettings.ForeColor = System.Drawing.Color.White;
            this.ButtonSettings.Image = global::Mastermind_Multiplayer.Properties.Resources._012_settings;
            this.ButtonSettings.ImagePosition = 20;
            this.ButtonSettings.ImageZoom = 50;
            this.ButtonSettings.LabelPosition = 41;
            this.ButtonSettings.LabelText = "Einstellungen";
            this.ButtonSettings.Location = new System.Drawing.Point(732, 30);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(180, 153);
            this.ButtonSettings.TabIndex = 14;
            // 
            // ButtonHost
            // 
            this.ButtonHost.BackColor = System.Drawing.Color.LightSalmon;
            this.ButtonHost.color = System.Drawing.Color.LightSalmon;
            this.ButtonHost.colorActive = System.Drawing.Color.PeachPuff;
            this.ButtonHost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHost.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ButtonHost.ForeColor = System.Drawing.Color.White;
            this.ButtonHost.Image = global::Mastermind_Multiplayer.Properties.Resources._020_home;
            this.ButtonHost.ImagePosition = 20;
            this.ButtonHost.ImageZoom = 50;
            this.ButtonHost.LabelPosition = 41;
            this.ButtonHost.LabelText = "Spiel hosten";
            this.ButtonHost.Location = new System.Drawing.Point(912, 30);
            this.ButtonHost.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonHost.Name = "ButtonHost";
            this.ButtonHost.Size = new System.Drawing.Size(307, 218);
            this.ButtonHost.TabIndex = 13;
            this.ButtonHost.Click += new System.EventHandler(this.ButtonHost_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.IndianRed;
            this.ButtonExit.color = System.Drawing.Color.IndianRed;
            this.ButtonExit.colorActive = System.Drawing.Color.LightCoral;
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExit.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Image = global::Mastermind_Multiplayer.Properties.Resources.Button_Close;
            this.ButtonExit.ImagePosition = 20;
            this.ButtonExit.ImageZoom = 50;
            this.ButtonExit.LabelPosition = 41;
            this.ButtonExit.LabelText = "Beenden";
            this.ButtonExit.Location = new System.Drawing.Point(732, 321);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(180, 154);
            this.ButtonExit.TabIndex = 12;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Client-IP:";
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(492, 70);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(208, 41);
            this.bunifuMetroTextbox1.TabIndex = 18;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.MediumOrchid;
            this.panelName.Controls.Add(this.labelName);
            this.panelName.Controls.Add(this.textBoxName);
            this.panelName.Location = new System.Drawing.Point(732, 183);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(180, 139);
            this.panelName.TabIndex = 21;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(9, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(91, 40);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(3, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(174, 35);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Hauptmenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 518);
            this.ControlBox = false;
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonJoinGame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonSettings);
            this.Controls.Add(this.ButtonHost);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.Überschrift);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSend);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Hauptmenü";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Load += new System.EventHandler(this.Codierer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Timer timerTryConnect;
        private System.Windows.Forms.Timer timerReceiveData;
        private System.Windows.Forms.Label Überschrift;
        private Bunifu.Framework.UI.BunifuTileButton ButtonExit;
        private Bunifu.Framework.UI.BunifuTileButton ButtonHost;
        private Bunifu.Framework.UI.BunifuTileButton ButtonSettings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTileButton ButtonJoinGame;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
    }
}