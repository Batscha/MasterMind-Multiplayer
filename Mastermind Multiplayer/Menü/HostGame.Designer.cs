namespace Mastermind_Multiplayer
{
    partial class HostGame
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
            this.labelClientIP = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.buttonHost = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.bunifuCheckboxCodierer = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckboxRater = new Bunifu.Framework.UI.BunifuCheckbox();
            this.labelCodierer = new System.Windows.Forms.Label();
            this.labelRater = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelClientIP
            // 
            this.labelClientIP.AutoSize = true;
            this.labelClientIP.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientIP.Location = new System.Drawing.Point(23, 77);
            this.labelClientIP.Name = "labelClientIP";
            this.labelClientIP.Size = new System.Drawing.Size(110, 37);
            this.labelClientIP.TabIndex = 0;
            this.labelClientIP.Text = "Client IP";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIP.Location = new System.Drawing.Point(139, 77);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(275, 43);
            this.textBoxIP.TabIndex = 1;
            // 
            // buttonHost
            // 
            this.buttonHost.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHost.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHost.Location = new System.Drawing.Point(217, 200);
            this.buttonHost.Name = "buttonHost";
            this.buttonHost.Size = new System.Drawing.Size(197, 40);
            this.buttonHost.TabIndex = 2;
            this.buttonHost.Text = "Spiel hosten";
            this.buttonHost.UseVisualStyleBackColor = false;
            this.buttonHost.Click += new System.EventHandler(this.buttonHost_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(14, 200);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(197, 40);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // bunifuCheckboxCodierer
            // 
            this.bunifuCheckboxCodierer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckboxCodierer.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckboxCodierer.Checked = true;
            this.bunifuCheckboxCodierer.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckboxCodierer.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckboxCodierer.Location = new System.Drawing.Point(48, 129);
            this.bunifuCheckboxCodierer.Name = "bunifuCheckboxCodierer";
            this.bunifuCheckboxCodierer.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckboxCodierer.TabIndex = 5;
            this.bunifuCheckboxCodierer.OnChange += new System.EventHandler(this.bunifuCheckboxCodierer_OnChange);
            // 
            // bunifuCheckboxRater
            // 
            this.bunifuCheckboxRater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckboxRater.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckboxRater.Checked = false;
            this.bunifuCheckboxRater.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckboxRater.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckboxRater.Location = new System.Drawing.Point(48, 163);
            this.bunifuCheckboxRater.Name = "bunifuCheckboxRater";
            this.bunifuCheckboxRater.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckboxRater.TabIndex = 6;
            this.bunifuCheckboxRater.OnChange += new System.EventHandler(this.bunifuCheckboxRater_OnChange);
            // 
            // labelCodierer
            // 
            this.labelCodierer.AutoSize = true;
            this.labelCodierer.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodierer.Location = new System.Drawing.Point(74, 123);
            this.labelCodierer.Name = "labelCodierer";
            this.labelCodierer.Size = new System.Drawing.Size(90, 30);
            this.labelCodierer.TabIndex = 7;
            this.labelCodierer.Text = "Codierer";
            // 
            // labelRater
            // 
            this.labelRater.AutoSize = true;
            this.labelRater.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.labelRater.Location = new System.Drawing.Point(74, 156);
            this.labelRater.Name = "labelRater";
            this.labelRater.Size = new System.Drawing.Size(59, 30);
            this.labelRater.TabIndex = 8;
            this.labelRater.Text = "Rater";
            // 
            // HostGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 253);
            this.Controls.Add(this.labelRater);
            this.Controls.Add(this.labelCodierer);
            this.Controls.Add(this.bunifuCheckboxRater);
            this.Controls.Add(this.bunifuCheckboxCodierer);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonHost);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.labelClientIP);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HostGame";
            this.Resizable = false;
            this.Text = "Spiel hosten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientIP;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button buttonHost;
        private System.Windows.Forms.Button buttonCancel;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckboxCodierer;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckboxRater;
        private System.Windows.Forms.Label labelCodierer;
        private System.Windows.Forms.Label labelRater;
    }
}