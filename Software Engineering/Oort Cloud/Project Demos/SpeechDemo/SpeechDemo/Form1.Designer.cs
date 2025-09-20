namespace SpeechDemo
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
            this.speakIt = new System.Windows.Forms.Button();
            this.Batlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // speakIt
            // 
            this.speakIt.Location = new System.Drawing.Point(99, 109);
            this.speakIt.Name = "speakIt";
            this.speakIt.Size = new System.Drawing.Size(75, 23);
            this.speakIt.TabIndex = 0;
            this.speakIt.Text = "Speak It";
            this.speakIt.UseVisualStyleBackColor = true;
            this.speakIt.Click += new System.EventHandler(this.speakIt_Click);
            // 
            // Batlabel
            // 
            this.Batlabel.AutoSize = true;
            this.Batlabel.Location = new System.Drawing.Point(87, 162);
            this.Batlabel.Name = "Batlabel";
            this.Batlabel.Size = new System.Drawing.Size(101, 13);
            this.Batlabel.TabIndex = 1;
            this.Batlabel.Text = "The Battery is Dead";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.Batlabel);
            this.Controls.Add(this.speakIt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button speakIt;
        private System.Windows.Forms.Label Batlabel;
    }
}

