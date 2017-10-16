namespace PongGame
{
    partial class WindowMain
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
            this.PanelBox = new System.Windows.Forms.Panel();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.TimerBallMovement = new System.Windows.Forms.Timer(this.components);
            this.PicBoxBall = new PongGame.Ball();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.PanelPaddle = new System.Windows.Forms.Panel();
            this.PanelBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBall)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBox
            // 
            this.PanelBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelBox.Controls.Add(this.PanelPaddle);
            this.PanelBox.Controls.Add(this.PicBoxBall);
            this.PanelBox.Location = new System.Drawing.Point(12, 12);
            this.PanelBox.Name = "PanelBox";
            this.PanelBox.Size = new System.Drawing.Size(385, 394);
            this.PanelBox.TabIndex = 0;
            this.PanelBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBox_MouseMove);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(412, 12);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(82, 23);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // TimerBallMovement
            // 
            this.TimerBallMovement.Tick += new System.EventHandler(this.TimerBallMovement_Tick);
            // 
            // PicBoxBall
            // 
            this.PicBoxBall.Image = global::PongGame.Properties.Resources.BallImg;
            this.PicBoxBall.Location = new System.Drawing.Point(97, 95);
            this.PicBoxBall.Name = "PicBoxBall";
            this.PicBoxBall.Size = new System.Drawing.Size(39, 38);
            this.PicBoxBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxBall.TabIndex = 1;
            this.PicBoxBall.TabStop = false;
            this.PicBoxBall.Vx = 10D;
            this.PicBoxBall.Vy = 10D;
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(412, 42);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(82, 23);
            this.ButtonGenerate.TabIndex = 2;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // PanelPaddle
            // 
            this.PanelPaddle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelPaddle.Location = new System.Drawing.Point(147, 322);
            this.PanelPaddle.Name = "PanelPaddle";
            this.PanelPaddle.Size = new System.Drawing.Size(76, 17);
            this.PanelPaddle.TabIndex = 2;
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 418);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.PanelBox);
            this.Name = "WindowMain";
            this.Text = "Pong Game by Paula";
            this.PanelBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBox;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Timer TimerBallMovement;
        private Ball PicBoxBall;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Panel PanelPaddle;
    }
}

