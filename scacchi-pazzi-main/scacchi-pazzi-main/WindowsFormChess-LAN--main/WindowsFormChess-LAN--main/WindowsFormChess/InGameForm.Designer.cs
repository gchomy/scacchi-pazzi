
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InGameForm));
            this.nextMove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RTBMosse = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextMove
            // 
            this.nextMove.Location = new System.Drawing.Point(51, 17);
            this.nextMove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextMove.Name = "nextMove";
            this.nextMove.Size = new System.Drawing.Size(93, 19);
            this.nextMove.TabIndex = 0;
            this.nextMove.Text = "Prossima Mossa";
            this.nextMove.UseVisualStyleBackColor = true;
            this.nextMove.Click += new System.EventHandler(this.nextMove_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = " Indietro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RTBMosse
            // 
            this.RTBMosse.Location = new System.Drawing.Point(475, 66);
            this.RTBMosse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RTBMosse.Name = "RTBMosse";
            this.RTBMosse.Size = new System.Drawing.Size(76, 392);
            this.RTBMosse.TabIndex = 3;
            this.RTBMosse.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MOSSE:";
            // 
            // InGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RTBMosse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextMove);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InGameForm";
            this.Text = "LanChess";
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

