
namespace Sakk_Alkalmazás_2._0
{
    partial class InGameForm
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
            this.nextMove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RTBMosse = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextMove
            // 
            this.nextMove.Location = new System.Drawing.Point(68, 21);
            this.nextMove.Name = "nextMove";
            this.nextMove.Size = new System.Drawing.Size(124, 23);
            this.nextMove.TabIndex = 0;
            this.nextMove.Text = "Prossima Mossa";
            this.nextMove.UseVisualStyleBackColor = true;
            this.nextMove.Click += new System.EventHandler(this.nextMove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = " Indietro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RTBMosse
            // 
            this.RTBMosse.Location = new System.Drawing.Point(633, 81);
            this.RTBMosse.Name = "RTBMosse";
            this.RTBMosse.Size = new System.Drawing.Size(100, 482);
            this.RTBMosse.TabIndex = 3;
            this.RTBMosse.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "MOSSE:";
            // 
            // InGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTBMosse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextMove);
            this.Name = "InGameForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InGameForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextMove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox RTBMosse;
        private System.Windows.Forms.Label label1;
    }
}

