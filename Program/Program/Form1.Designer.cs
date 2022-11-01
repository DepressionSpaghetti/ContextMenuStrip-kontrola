namespace ContextMenuStrip_kontrola
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
            this.components = new System.ComponentModel.Container();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.ctxtMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoNaDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoNaLijevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.ContextMenuStrip = this.ctxtMenu1;
            this.txtBox1.Location = new System.Drawing.Point(12, 106);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(132, 20);
            this.txtBox1.TabIndex = 0;
            // 
            // txtBox2
            // 
            this.txtBox2.ContextMenuStrip = this.ctxtMenu1;
            this.txtBox2.Location = new System.Drawing.Point(253, 106);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(132, 20);
            this.txtBox2.TabIndex = 1;
            // 
            // ctxtMenu1
            // 
            this.ctxtMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoNaDesnoToolStripMenuItem,
            this.desnoNaLijevoToolStripMenuItem});
            this.ctxtMenu1.Name = "ctxtMenu1";
            this.ctxtMenu1.Size = new System.Drawing.Size(181, 70);
            this.ctxtMenu1.Text = "Context menu";
            // 
            // lijevoNaDesnoToolStripMenuItem
            // 
            this.lijevoNaDesnoToolStripMenuItem.Name = "lijevoNaDesnoToolStripMenuItem";
            this.lijevoNaDesnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lijevoNaDesnoToolStripMenuItem.Text = "Lijevo na desno";
            this.lijevoNaDesnoToolStripMenuItem.Click += new System.EventHandler(this.lijevoNaDesnoToolStripMenuItem_Click);
            // 
            // desnoNaLijevoToolStripMenuItem
            // 
            this.desnoNaLijevoToolStripMenuItem.Name = "desnoNaLijevoToolStripMenuItem";
            this.desnoNaLijevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.desnoNaLijevoToolStripMenuItem.Text = "Desno na lijevo";
            this.desnoNaLijevoToolStripMenuItem.Click += new System.EventHandler(this.desnoNaLijevoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 191);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ctxtMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.ContextMenuStrip ctxtMenu1;
        private System.Windows.Forms.ToolStripMenuItem lijevoNaDesnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoNaLijevoToolStripMenuItem;
    }
}

