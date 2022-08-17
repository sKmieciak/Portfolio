namespace WarcabyPortfolio
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
            this.G = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.counterR = new System.Windows.Forms.Label();
            this.CounterG = new System.Windows.Forms.Label();
            this.czerwony = new System.Windows.Forms.TextBox();
            this.zielony = new System.Windows.Forms.TextBox();
            this.W = new System.Windows.Forms.Panel();
            this.labelpa = new System.Windows.Forms.Label();
            this.labelw = new System.Windows.Forms.Label();
            this.labelwin = new System.Windows.Forms.Label();
            this.W.SuspendLayout();
            this.SuspendLayout();
            // 
            // G
            // 
            this.G.BackColor = System.Drawing.Color.Gray;
            this.G.Location = new System.Drawing.Point(10, 10);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(484, 447);
            this.G.TabIndex = 0;
            this.G.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(582, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "CZERWONI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(597, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "ZIELONI";
            // 
            // counterR
            // 
            this.counterR.AutoSize = true;
            this.counterR.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.counterR.ForeColor = System.Drawing.Color.Red;
            this.counterR.Location = new System.Drawing.Point(616, 128);
            this.counterR.Name = "counterR";
            this.counterR.Size = new System.Drawing.Size(91, 57);
            this.counterR.TabIndex = 3;
            this.counterR.Text = "12";
            this.counterR.Click += new System.EventHandler(this.counterR_Click);
            // 
            // CounterG
            // 
            this.CounterG.AutoSize = true;
            this.CounterG.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CounterG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CounterG.Location = new System.Drawing.Point(616, 352);
            this.CounterG.Name = "CounterG";
            this.CounterG.Size = new System.Drawing.Size(91, 57);
            this.CounterG.TabIndex = 4;
            this.CounterG.Text = "12";
            // 
            // czerwony
            // 
            this.czerwony.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.czerwony.Location = new System.Drawing.Point(583, 62);
            this.czerwony.Name = "czerwony";
            this.czerwony.Size = new System.Drawing.Size(156, 35);
            this.czerwony.TabIndex = 5;
            this.czerwony.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.czerwony_KeyPress);
            // 
            // zielony
            // 
            this.zielony.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zielony.Location = new System.Drawing.Point(583, 281);
            this.zielony.Name = "zielony";
            this.zielony.Size = new System.Drawing.Size(156, 35);
            this.zielony.TabIndex = 6;
            this.zielony.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.czerwony_KeyPress);
            // 
            // W
            // 
            this.W.BackColor = System.Drawing.Color.Goldenrod;
            this.W.Controls.Add(this.labelwin);
            this.W.Controls.Add(this.labelpa);
            this.W.Controls.Add(this.labelw);
            this.W.Dock = System.Windows.Forms.DockStyle.Fill;
            this.W.Location = new System.Drawing.Point(0, 0);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(837, 538);
            this.W.TabIndex = 7;
            // 
            // labelpa
            // 
            this.labelpa.AutoSize = true;
            this.labelpa.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelpa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelpa.Location = new System.Drawing.Point(127, 312);
            this.labelpa.Name = "labelpa";
            this.labelpa.Size = new System.Drawing.Size(352, 57);
            this.labelpa.TabIndex = 1;
            this.labelpa.Text = "PLAY AGAIN";
            this.labelpa.UseWaitCursor = true;
            this.labelpa.Click += new System.EventHandler(this.labelpa_Click);
            // 
            // labelw
            // 
            this.labelw.AutoSize = true;
            this.labelw.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelw.ForeColor = System.Drawing.SystemColors.Control;
            this.labelw.Location = new System.Drawing.Point(90, 181);
            this.labelw.Name = "labelw";
            this.labelw.Size = new System.Drawing.Size(650, 145);
            this.labelw.TabIndex = 0;
            this.labelw.Text = "You win!";
            this.labelw.UseWaitCursor = true;
            // 
            // labelwin
            // 
            this.labelwin.AutoSize = true;
            this.labelwin.Font = new System.Drawing.Font("Verdana", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelwin.ForeColor = System.Drawing.SystemColors.Control;
            this.labelwin.Location = new System.Drawing.Point(221, 62);
            this.labelwin.Name = "labelwin";
            this.labelwin.Size = new System.Drawing.Size(338, 145);
            this.labelwin.TabIndex = 2;
            this.labelwin.Text = "RED";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 538);
            this.Controls.Add(this.W);
            this.Controls.Add(this.zielony);
            this.Controls.Add(this.czerwony);
            this.Controls.Add(this.CounterG);
            this.Controls.Add(this.counterR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.G);
            this.Name = "Form1";
            this.Text = "Warcaby";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.W.ResumeLayout(false);
            this.W.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel G;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label counterR;
        private System.Windows.Forms.Label CounterG;
        private System.Windows.Forms.TextBox czerwony;
        private System.Windows.Forms.TextBox zielony;
        private System.Windows.Forms.Panel W;
        private System.Windows.Forms.Label labelpa;
        private System.Windows.Forms.Label labelw;
        private System.Windows.Forms.Label labelwin;
    }
}

