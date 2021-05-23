
namespace TrexGame
{
    partial class Trex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trex));
            this.floor = new System.Windows.Forms.PictureBox();
            this.t_rex = new System.Windows.Forms.PictureBox();
            this.obstacle_1 = new System.Windows.Forms.PictureBox();
            this.obstacle_2 = new System.Windows.Forms.PictureBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_rex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle_2)).BeginInit();
            this.SuspendLayout();
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Black;
            this.floor.Location = new System.Drawing.Point(1, 430);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(647, 50);
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            // 
            // t_rex
            // 
            this.t_rex.Image = global::TrexGame.Properties.Resources.running;
            this.t_rex.Location = new System.Drawing.Point(109, 386);
            this.t_rex.Name = "t_rex";
            this.t_rex.Size = new System.Drawing.Size(40, 43);
            this.t_rex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.t_rex.TabIndex = 1;
            this.t_rex.TabStop = false;
            // 
            // obstacle_1
            // 
            this.obstacle_1.Image = global::TrexGame.Properties.Resources.obstacle_1;
            this.obstacle_1.Location = new System.Drawing.Point(329, 386);
            this.obstacle_1.Name = "obstacle_1";
            this.obstacle_1.Size = new System.Drawing.Size(23, 46);
            this.obstacle_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle_1.TabIndex = 2;
            this.obstacle_1.TabStop = false;
            this.obstacle_1.Tag = "obstacle";
            // 
            // obstacle_2
            // 
            this.obstacle_2.Image = global::TrexGame.Properties.Resources.obstacle_2;
            this.obstacle_2.Location = new System.Drawing.Point(538, 397);
            this.obstacle_2.Name = "obstacle_2";
            this.obstacle_2.Size = new System.Drawing.Size(32, 33);
            this.obstacle_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle_2.TabIndex = 3;
            this.obstacle_2.TabStop = false;
            this.obstacle_2.Tag = "obstacle";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_score.Location = new System.Drawing.Point(12, 29);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(106, 24);
            this.lbl_score.TabIndex = 4;
            this.lbl_score.Text = "Score: 0";
            // 
            // gametimer
            // 
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.GameEvent);
            // 
            // Trex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 478);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.obstacle_2);
            this.Controls.Add(this.obstacle_1);
            this.Controls.Add(this.t_rex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Trex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T-Rex Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_rex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox floor;
        private System.Windows.Forms.PictureBox t_rex;
        private System.Windows.Forms.PictureBox obstacle_1;
        private System.Windows.Forms.PictureBox obstacle_2;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Timer gametimer;
    }
}

