namespace HigherLower
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
            this.pbNextCard = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.cmdHigher = new System.Windows.Forms.Button();
            this.cmdLower = new System.Windows.Forms.Button();
            this.cmdSame = new System.Windows.Forms.Button();
            this.pbBack3 = new System.Windows.Forms.PictureBox();
            this.pbBack2 = new System.Windows.Forms.PictureBox();
            this.pbPreviousCard = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNextCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviousCard)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNextCard
            // 
            this.pbNextCard.Location = new System.Drawing.Point(310, 47);
            this.pbNextCard.Name = "pbNextCard";
            this.pbNextCard.Size = new System.Drawing.Size(185, 205);
            this.pbNextCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbNextCard.TabIndex = 0;
            this.pbNextCard.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.Location = new System.Drawing.Point(41, 43);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(185, 205);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBack.TabIndex = 1;
            this.pbBack.TabStop = false;
            // 
            // cmdHigher
            // 
            this.cmdHigher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHigher.Location = new System.Drawing.Point(408, 461);
            this.cmdHigher.Name = "cmdHigher";
            this.cmdHigher.Size = new System.Drawing.Size(145, 51);
            this.cmdHigher.TabIndex = 2;
            this.cmdHigher.Text = "Higher";
            this.cmdHigher.UseVisualStyleBackColor = true;
            this.cmdHigher.Click += new System.EventHandler(this.cmdHigher_Click);
            // 
            // cmdLower
            // 
            this.cmdLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLower.Location = new System.Drawing.Point(54, 461);
            this.cmdLower.Name = "cmdLower";
            this.cmdLower.Size = new System.Drawing.Size(146, 51);
            this.cmdLower.TabIndex = 3;
            this.cmdLower.Text = "Lower";
            this.cmdLower.UseVisualStyleBackColor = true;
            this.cmdLower.Click += new System.EventHandler(this.cmdLower_Click);
            // 
            // cmdSame
            // 
            this.cmdSame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSame.Location = new System.Drawing.Point(231, 461);
            this.cmdSame.Name = "cmdSame";
            this.cmdSame.Size = new System.Drawing.Size(154, 51);
            this.cmdSame.TabIndex = 4;
            this.cmdSame.Text = "Same";
            this.cmdSame.UseVisualStyleBackColor = true;
            this.cmdSame.Click += new System.EventHandler(this.cmdSame_Click);
            // 
            // pbBack3
            // 
            this.pbBack3.Location = new System.Drawing.Point(47, 50);
            this.pbBack3.Name = "pbBack3";
            this.pbBack3.Size = new System.Drawing.Size(185, 205);
            this.pbBack3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBack3.TabIndex = 5;
            this.pbBack3.TabStop = false;
            // 
            // pbBack2
            // 
            this.pbBack2.Location = new System.Drawing.Point(54, 57);
            this.pbBack2.Name = "pbBack2";
            this.pbBack2.Size = new System.Drawing.Size(185, 205);
            this.pbBack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbBack2.TabIndex = 6;
            this.pbBack2.TabStop = false;
            // 
            // pbPreviousCard
            // 
            this.pbPreviousCard.Location = new System.Drawing.Point(304, 40);
            this.pbPreviousCard.Name = "pbPreviousCard";
            this.pbPreviousCard.Size = new System.Drawing.Size(185, 205);
            this.pbPreviousCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPreviousCard.TabIndex = 7;
            this.pbPreviousCard.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(679, 134);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(107, 128);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 102);
            this.label1.TabIndex = 9;
            this.label1.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbBack2);
            this.Controls.Add(this.pbBack3);
            this.Controls.Add(this.cmdSame);
            this.Controls.Add(this.cmdLower);
            this.Controls.Add(this.cmdHigher);
            this.Controls.Add(this.pbBack);
            this.Controls.Add(this.pbNextCard);
            this.Controls.Add(this.pbPreviousCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNextCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviousCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNextCard;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.Button cmdHigher;
        private System.Windows.Forms.Button cmdLower;
        private System.Windows.Forms.Button cmdSame;
        private System.Windows.Forms.PictureBox pbBack3;
        private System.Windows.Forms.PictureBox pbBack2;
        private System.Windows.Forms.PictureBox pbPreviousCard;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label1;
    }
}

