
namespace Pong
{
    partial class Form1
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
            this.paddlePlayer = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.paddleCPU = new System.Windows.Forms.PictureBox();
            this.scoreP = new System.Windows.Forms.Label();
            this.scoreC = new System.Windows.Forms.Label();
            this.gameTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.paddlePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // paddlePlayer
            // 
            this.paddlePlayer.BackColor = System.Drawing.Color.Lime;
            this.paddlePlayer.Location = new System.Drawing.Point(12, 186);
            this.paddlePlayer.Name = "paddlePlayer";
            this.paddlePlayer.Size = new System.Drawing.Size(25, 125);
            this.paddlePlayer.TabIndex = 0;
            this.paddlePlayer.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(350, 250);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // paddleCPU
            // 
            this.paddleCPU.BackColor = System.Drawing.Color.Red;
            this.paddleCPU.Location = new System.Drawing.Point(745, 230);
            this.paddleCPU.Name = "paddleCPU";
            this.paddleCPU.Size = new System.Drawing.Size(25, 125);
            this.paddleCPU.TabIndex = 2;
            this.paddleCPU.TabStop = false;
            // 
            // scoreP
            // 
            this.scoreP.AutoSize = true;
            this.scoreP.BackColor = System.Drawing.Color.Transparent;
            this.scoreP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.scoreP.ForeColor = System.Drawing.Color.Lime;
            this.scoreP.Location = new System.Drawing.Point(142, 26);
            this.scoreP.Name = "scoreP";
            this.scoreP.Size = new System.Drawing.Size(36, 26);
            this.scoreP.TabIndex = 3;
            this.scoreP.Text = "00";
            // 
            // scoreC
            // 
            this.scoreC.AutoSize = true;
            this.scoreC.BackColor = System.Drawing.Color.Transparent;
            this.scoreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.scoreC.ForeColor = System.Drawing.Color.Red;
            this.scoreC.Location = new System.Drawing.Point(606, 26);
            this.scoreC.Name = "scoreC";
            this.scoreC.Size = new System.Drawing.Size(36, 26);
            this.scoreC.TabIndex = 4;
            this.scoreC.Text = "00";
            // 
            // gameTime
            // 
            this.gameTime.Enabled = true;
            this.gameTime.Interval = 20;
            this.gameTime.Tick += new System.EventHandler(this.timerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.scoreC);
            this.Controls.Add(this.scoreP);
            this.Controls.Add(this.paddleCPU);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddlePlayer);
            this.Name = "Form1";
            this.Text = "Pong Game 1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.downPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.upPress);
            ((System.ComponentModel.ISupportInitialize)(this.paddlePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paddlePlayer;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox paddleCPU;
        private System.Windows.Forms.Label scoreP;
        private System.Windows.Forms.Label scoreC;
        private System.Windows.Forms.Timer gameTime;
    }
}

