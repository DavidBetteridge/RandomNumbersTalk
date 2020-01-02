namespace ShowMiddleSquareMethod
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartingValue = new System.Windows.Forms.TextBox();
            this.cmdNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seed:";
            // 
            // txtStartingValue
            // 
            this.txtStartingValue.Location = new System.Drawing.Point(254, 40);
            this.txtStartingValue.Name = "txtStartingValue";
            this.txtStartingValue.Size = new System.Drawing.Size(375, 46);
            this.txtStartingValue.TabIndex = 1;
            // 
            // cmdNext
            // 
            this.cmdNext.Location = new System.Drawing.Point(656, 37);
            this.cmdNext.Name = "cmdNext";
            this.cmdNext.Size = new System.Drawing.Size(280, 49);
            this.cmdNext.TabIndex = 2;
            this.cmdNext.Text = "Next Value";
            this.cmdNext.UseVisualStyleBackColor = true;
            this.cmdNext.Click += new System.EventHandler(this.cmdNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 1385);
            this.Controls.Add(this.cmdNext);
            this.Controls.Add(this.txtStartingValue);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Middle Square Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartingValue;
        private System.Windows.Forms.Button cmdNext;
    }
}

