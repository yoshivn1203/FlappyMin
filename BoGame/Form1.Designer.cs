namespace BoGame
{
    partial class Flappy_Min
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flappy_Min));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bottomPipe = new System.Windows.Forms.PictureBox();
            this.topPipe = new System.Windows.Forms.PictureBox();
            this.bottomPipe2 = new System.Windows.Forms.PictureBox();
            this.topPipe2 = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.Cloud2 = new System.Windows.Forms.PictureBox();
            this.Cloud1 = new System.Windows.Forms.PictureBox();
            this.Canabis1 = new System.Windows.Forms.PictureBox();
            this.canabis2 = new System.Windows.Forms.PictureBox();
            this.Canabis3 = new System.Windows.Forms.PictureBox();
            this.bottomPipe3 = new System.Windows.Forms.PictureBox();
            this.topPipe3 = new System.Windows.Forms.PictureBox();
            this.endText1 = new System.Windows.Forms.Label();
            this.scoreValue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canabis1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canabis2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canabis3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // bottomPipe
            // 
            this.bottomPipe.Image = ((System.Drawing.Image)(resources.GetObject("bottomPipe.Image")));
            this.bottomPipe.Location = new System.Drawing.Point(351, 372);
            this.bottomPipe.Name = "bottomPipe";
            this.bottomPipe.Size = new System.Drawing.Size(87, 221);
            this.bottomPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomPipe.TabIndex = 3;
            this.bottomPipe.TabStop = false;
            // 
            // topPipe
            // 
            this.topPipe.Image = ((System.Drawing.Image)(resources.GetObject("topPipe.Image")));
            this.topPipe.Location = new System.Drawing.Point(503, -6);
            this.topPipe.Name = "topPipe";
            this.topPipe.Size = new System.Drawing.Size(86, 221);
            this.topPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topPipe.TabIndex = 1;
            this.topPipe.TabStop = false;
            // 
            // bottomPipe2
            // 
            this.bottomPipe2.Image = global::BoGame.Properties.Resources.Untitled_2;
            this.bottomPipe2.Location = new System.Drawing.Point(768, 264);
            this.bottomPipe2.Name = "bottomPipe2";
            this.bottomPipe2.Size = new System.Drawing.Size(82, 291);
            this.bottomPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomPipe2.TabIndex = 6;
            this.bottomPipe2.TabStop = false;
            // 
            // topPipe2
            // 
            this.topPipe2.Image = global::BoGame.Properties.Resources.Untitled_3;
            this.topPipe2.Location = new System.Drawing.Point(969, -52);
            this.topPipe2.Name = "topPipe2";
            this.topPipe2.Size = new System.Drawing.Size(80, 225);
            this.topPipe2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topPipe2.TabIndex = 5;
            this.topPipe2.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(16, 219);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(65, 81);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-10, 552);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(624, 112);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // Cloud2
            // 
            this.Cloud2.Image = ((System.Drawing.Image)(resources.GetObject("Cloud2.Image")));
            this.Cloud2.Location = new System.Drawing.Point(693, 56);
            this.Cloud2.Name = "Cloud2";
            this.Cloud2.Size = new System.Drawing.Size(132, 84);
            this.Cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud2.TabIndex = 8;
            this.Cloud2.TabStop = false;
            // 
            // Cloud1
            // 
            this.Cloud1.Image = ((System.Drawing.Image)(resources.GetObject("Cloud1.Image")));
            this.Cloud1.Location = new System.Drawing.Point(210, 3);
            this.Cloud1.Name = "Cloud1";
            this.Cloud1.Size = new System.Drawing.Size(190, 125);
            this.Cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud1.TabIndex = 9;
            this.Cloud1.TabStop = false;
            // 
            // Canabis1
            // 
            this.Canabis1.Image = ((System.Drawing.Image)(resources.GetObject("Canabis1.Image")));
            this.Canabis1.Location = new System.Drawing.Point(164, 500);
            this.Canabis1.Name = "Canabis1";
            this.Canabis1.Size = new System.Drawing.Size(63, 53);
            this.Canabis1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Canabis1.TabIndex = 10;
            this.Canabis1.TabStop = false;
            // 
            // canabis2
            // 
            this.canabis2.Image = ((System.Drawing.Image)(resources.GetObject("canabis2.Image")));
            this.canabis2.Location = new System.Drawing.Point(969, 442);
            this.canabis2.Name = "canabis2";
            this.canabis2.Size = new System.Drawing.Size(84, 113);
            this.canabis2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.canabis2.TabIndex = 11;
            this.canabis2.TabStop = false;
            // 
            // Canabis3
            // 
            this.Canabis3.Image = ((System.Drawing.Image)(resources.GetObject("Canabis3.Image")));
            this.Canabis3.Location = new System.Drawing.Point(232, 473);
            this.Canabis3.Name = "Canabis3";
            this.Canabis3.Size = new System.Drawing.Size(64, 80);
            this.Canabis3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Canabis3.TabIndex = 12;
            this.Canabis3.TabStop = false;
            // 
            // bottomPipe3
            // 
            this.bottomPipe3.Image = global::BoGame.Properties.Resources.Untitled_2;
            this.bottomPipe3.Location = new System.Drawing.Point(1193, 429);
            this.bottomPipe3.Name = "bottomPipe3";
            this.bottomPipe3.Size = new System.Drawing.Size(82, 259);
            this.bottomPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bottomPipe3.TabIndex = 13;
            this.bottomPipe3.TabStop = false;
            // 
            // topPipe3
            // 
            this.topPipe3.Image = global::BoGame.Properties.Resources.Untitled_3;
            this.topPipe3.Location = new System.Drawing.Point(1359, -29);
            this.topPipe3.Name = "topPipe3";
            this.topPipe3.Size = new System.Drawing.Size(80, 329);
            this.topPipe3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topPipe3.TabIndex = 14;
            this.topPipe3.TabStop = false;
            // 
            // endText1
            // 
            this.endText1.BackColor = System.Drawing.Color.Green;
            this.endText1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.endText1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endText1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endText1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endText1.Location = new System.Drawing.Point(87, 184);
            this.endText1.Name = "endText1";
            this.endText1.Size = new System.Drawing.Size(442, 163);
            this.endText1.TabIndex = 15;
            this.endText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreValue
            // 
            this.scoreValue.BackColor = System.Drawing.Color.LightSalmon;
            this.scoreValue.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreValue.Location = new System.Drawing.Point(187, 582);
            this.scoreValue.Name = "scoreValue";
            this.scoreValue.Size = new System.Drawing.Size(158, 49);
            this.scoreValue.TabIndex = 16;
            this.scoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(155, 578);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Flappy_Min
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(609, 631);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scoreValue);
            this.Controls.Add(this.endText1);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Canabis3);
            this.Controls.Add(this.Canabis1);
            this.Controls.Add(this.bottomPipe);
            this.Controls.Add(this.topPipe);
            this.Controls.Add(this.topPipe3);
            this.Controls.Add(this.topPipe2);
            this.Controls.Add(this.bottomPipe2);
            this.Controls.Add(this.canabis2);
            this.Controls.Add(this.bottomPipe3);
            this.Controls.Add(this.Cloud1);
            this.Controls.Add(this.Cloud2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Flappy_Min";
            this.Text = "Flappy Min";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canabis1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canabis2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canabis3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox topPipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bottomPipe;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox topPipe2;
        private System.Windows.Forms.PictureBox bottomPipe2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox Cloud2;
        private System.Windows.Forms.PictureBox Cloud1;
        private System.Windows.Forms.PictureBox Canabis1;
        private System.Windows.Forms.PictureBox canabis2;
        private System.Windows.Forms.PictureBox Canabis3;
        private System.Windows.Forms.PictureBox bottomPipe3;
        private System.Windows.Forms.PictureBox topPipe3;
        private System.Windows.Forms.Label endText1;
        private System.Windows.Forms.Label scoreValue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

