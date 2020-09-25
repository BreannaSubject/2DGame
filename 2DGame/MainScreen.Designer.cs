namespace _2DGame
{
    partial class MainScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.instrustionsLabel = new System.Windows.Forms.Label();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkCyan;
            this.titleLabel.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(900, 85);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Water World";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instrustionsLabel
            // 
            this.instrustionsLabel.AutoSize = true;
            this.instrustionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrustionsLabel.Location = new System.Drawing.Point(28, 95);
            this.instrustionsLabel.Name = "instrustionsLabel";
            this.instrustionsLabel.Size = new System.Drawing.Size(839, 16);
            this.instrustionsLabel.TabIndex = 1;
            this.instrustionsLabel.Text = "Avoid crabs to complete the game. Use your arrow keys to move your charcter. Powe" +
    "r-ups will spawn randomly, so keep an eye out for them. ";
            this.instrustionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spaceLabel
            // 
            this.spaceLabel.AutoSize = true;
            this.spaceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceLabel.Location = new System.Drawing.Point(208, 451);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(451, 29);
            this.spaceLabel.TabIndex = 2;
            this.spaceLabel.Text = "Press Space to move onto the Game. ";
            this.spaceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Controls.Add(this.spaceLabel);
            this.Controls.Add(this.instrustionsLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(900, 500);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainScreen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instrustionsLabel;
        private System.Windows.Forms.Label spaceLabel;
    }
}
