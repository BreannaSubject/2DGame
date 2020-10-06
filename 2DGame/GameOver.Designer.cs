namespace _2DGame
{
    partial class GameOver
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.gameOverTitle = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Cyan;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(395, 294);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 40);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.Enter += new System.EventHandler(this.exitButton_Enter);
            // 
            // gameOverTitle
            // 
            this.gameOverTitle.BackColor = System.Drawing.Color.DarkCyan;
            this.gameOverTitle.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverTitle.Location = new System.Drawing.Point(0, 0);
            this.gameOverTitle.Name = "gameOverTitle";
            this.gameOverTitle.Size = new System.Drawing.Size(900, 85);
            this.gameOverTitle.TabIndex = 1;
            this.gameOverTitle.Text = "Game Over";
            this.gameOverTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.Cyan;
            this.playAgainButton.FlatAppearance.BorderSize = 0;
            this.playAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.playAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.playAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgainButton.Location = new System.Drawing.Point(395, 178);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(85, 40);
            this.playAgainButton.TabIndex = 2;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            this.playAgainButton.Enter += new System.EventHandler(this.playAgainButton_Enter);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = global::_2DGame.Properties.Resources.Water_World;
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.gameOverTitle);
            this.Controls.Add(this.exitButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GameOver";
            this.Size = new System.Drawing.Size(900, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label gameOverTitle;
        private System.Windows.Forms.Button playAgainButton;
    }
}
