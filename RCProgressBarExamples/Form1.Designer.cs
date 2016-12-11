namespace RCProgressBarExamples
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
            this.roundCorneredProgressBar3 = new RoundCorneredProgressBar.RoundCorneredProgressBar();
            this.roundCorneredProgressBar2 = new RoundCorneredProgressBar.RoundCorneredProgressBar();
            this.roundCorneredProgressBar1 = new RoundCorneredProgressBar.RoundCorneredProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundCorneredProgressBar3
            // 
            this.roundCorneredProgressBar3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.roundCorneredProgressBar3.Location = new System.Drawing.Point(12, 155);
            this.roundCorneredProgressBar3.Name = "roundCorneredProgressBar3";
            this.roundCorneredProgressBar3.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.roundCorneredProgressBar3.ProgressBarColor = System.Drawing.Color.Lime;
            this.roundCorneredProgressBar3.ProgressFont = new System.Drawing.Font("Lucida Handwriting", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundCorneredProgressBar3.ProgressFontColor = System.Drawing.Color.Black;
            this.roundCorneredProgressBar3.Size = new System.Drawing.Size(377, 27);
            this.roundCorneredProgressBar3.TabIndex = 2;
            this.roundCorneredProgressBar3.TabStop = false;
            this.roundCorneredProgressBar3.Value = 100;
            // 
            // roundCorneredProgressBar2
            // 
            this.roundCorneredProgressBar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.roundCorneredProgressBar2.Location = new System.Drawing.Point(12, 50);
            this.roundCorneredProgressBar2.Name = "roundCorneredProgressBar2";
            this.roundCorneredProgressBar2.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundCorneredProgressBar2.ProgressBarColor = System.Drawing.Color.Aqua;
            this.roundCorneredProgressBar2.ProgressFont = new System.Drawing.Font("Monotype Corsiva", 35.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundCorneredProgressBar2.ProgressFontColor = System.Drawing.Color.Black;
            this.roundCorneredProgressBar2.Size = new System.Drawing.Size(377, 99);
            this.roundCorneredProgressBar2.TabIndex = 1;
            this.roundCorneredProgressBar2.TabStop = false;
            this.roundCorneredProgressBar2.Value = 70;
            // 
            // roundCorneredProgressBar1
            // 
            this.roundCorneredProgressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roundCorneredProgressBar1.Location = new System.Drawing.Point(12, 12);
            this.roundCorneredProgressBar1.Name = "roundCorneredProgressBar1";
            this.roundCorneredProgressBar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.roundCorneredProgressBar1.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundCorneredProgressBar1.ProgressFont = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.roundCorneredProgressBar1.ProgressFontColor = System.Drawing.Color.Black;
            this.roundCorneredProgressBar1.Size = new System.Drawing.Size(377, 32);
            this.roundCorneredProgressBar1.TabIndex = 0;
            this.roundCorneredProgressBar1.TabStop = false;
            this.roundCorneredProgressBar1.Value = 67;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 349);
            this.Controls.Add(this.roundCorneredProgressBar3);
            this.Controls.Add(this.roundCorneredProgressBar2);
            this.Controls.Add(this.roundCorneredProgressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundCorneredProgressBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundCorneredProgressBar.RoundCorneredProgressBar roundCorneredProgressBar1;
        private RoundCorneredProgressBar.RoundCorneredProgressBar roundCorneredProgressBar2;
        private RoundCorneredProgressBar.RoundCorneredProgressBar roundCorneredProgressBar3;
    }
}

