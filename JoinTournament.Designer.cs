namespace Poker_Holdem
{
    partial class JoinTournament
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
            this.Tournament1 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tournament1
            // 
            this.Tournament1.Location = new System.Drawing.Point(93, 114);
            this.Tournament1.Name = "Tournament1";
            this.Tournament1.Size = new System.Drawing.Size(94, 23);
            this.Tournament1.TabIndex = 0;
            this.Tournament1.Text = "Tournament 1";
            this.Tournament1.UseVisualStyleBackColor = true;
            this.Tournament1.Click += new System.EventHandler(this.Tournament1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(197, 227);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // JoinTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.Tournament1);
            this.Name = "JoinTournament";
            this.Text = "JoinTournament";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Tournament1;
        private System.Windows.Forms.Button buttonExit;
    }
}