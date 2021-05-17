
namespace Adventure_Game
{
    partial class AdventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdventureGame));
            this.outputLabel = new System.Windows.Forms.Label();
            this.bottomLabel = new System.Windows.Forms.Label();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.option3Button = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.option2Button = new System.Windows.Forms.Button();
            this.option1Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.outputLabel.Font = new System.Drawing.Font("BankGothic Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Black;
            this.outputLabel.Location = new System.Drawing.Point(-1, -2);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(437, 63);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "outputLabel";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomLabel
            // 
            this.bottomLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.bottomLabel.Font = new System.Drawing.Font("Dutch801 XBd BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLabel.ForeColor = System.Drawing.Color.Black;
            this.bottomLabel.Location = new System.Drawing.Point(-1, 372);
            this.bottomLabel.Name = "bottomLabel";
            this.bottomLabel.Size = new System.Drawing.Size(437, 40);
            this.bottomLabel.TabIndex = 1;
            this.bottomLabel.Text = "THE AMAZING RACE";
            this.bottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.White;
            this.option1Label.Location = new System.Drawing.Point(73, 249);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(335, 23);
            this.option1Label.TabIndex = 5;
            this.option1Label.Text = "option1Label";
            this.option1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.White;
            this.option2Label.Location = new System.Drawing.Point(73, 293);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(335, 23);
            this.option2Label.TabIndex = 6;
            this.option2Label.Text = "option2Label";
            this.option2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.Color.White;
            this.option3Label.Location = new System.Drawing.Point(73, 333);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(335, 23);
            this.option3Label.TabIndex = 8;
            this.option3Label.Text = "option3Label";
            this.option3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // option3Button
            // 
            this.option3Button.BackColor = System.Drawing.Color.Black;
            this.option3Button.BackgroundImage = global::Adventure_Game.Properties.Resources.blue_button;
            this.option3Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option3Button.FlatAppearance.BorderSize = 0;
            this.option3Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.option3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3Button.Location = new System.Drawing.Point(12, 318);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(55, 51);
            this.option3Button.TabIndex = 7;
            this.option3Button.UseVisualStyleBackColor = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox.Image = global::Adventure_Game.Properties.Resources.amazing_race_logo;
            this.imageBox.Location = new System.Drawing.Point(24, 79);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(384, 149);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 4;
            this.imageBox.TabStop = false;
            // 
            // option2Button
            // 
            this.option2Button.BackColor = System.Drawing.Color.Black;
            this.option2Button.BackgroundImage = global::Adventure_Game.Properties.Resources.green_button;
            this.option2Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option2Button.FlatAppearance.BorderSize = 0;
            this.option2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.Location = new System.Drawing.Point(12, 278);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(55, 51);
            this.option2Button.TabIndex = 3;
            this.option2Button.UseVisualStyleBackColor = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.Black;
            this.option1Button.BackgroundImage = global::Adventure_Game.Properties.Resources.button;
            this.option1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option1Button.FlatAppearance.BorderSize = 0;
            this.option1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.Location = new System.Drawing.Point(12, 234);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(55, 51);
            this.option1Button.TabIndex = 2;
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // AdventureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.bottomLabel);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdventureGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Amazing Race Adventure Game";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label bottomLabel;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Label option3Label;
    }
}

