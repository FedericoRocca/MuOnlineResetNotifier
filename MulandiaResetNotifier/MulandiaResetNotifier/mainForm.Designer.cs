namespace MulandiaResetNotifier
{
    partial class mainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPretxb = new System.Windows.Forms.Label();
            this.lblPosttxb = new System.Windows.Forms.Label();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Mulandia Reset Notifier";
            this.notifyIcon.Visible = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.asdToolStripMenuItem1});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(107, 48);
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.asdToolStripMenuItem.Text = "Abrir";
            this.asdToolStripMenuItem.Click += new System.EventHandler(this.asdToolStripMenuItem_Click);
            // 
            // asdToolStripMenuItem1
            // 
            this.asdToolStripMenuItem1.Name = "asdToolStripMenuItem1";
            this.asdToolStripMenuItem1.Size = new System.Drawing.Size(106, 22);
            this.asdToolStripMenuItem1.Text = "Cerrar";
            this.asdToolStripMenuItem1.Click += new System.EventHandler(this.asdToolStripMenuItem1_Click);
            // 
            // lblPretxb
            // 
            this.lblPretxb.AutoSize = true;
            this.lblPretxb.Location = new System.Drawing.Point(12, 9);
            this.lblPretxb.Name = "lblPretxb";
            this.lblPretxb.Size = new System.Drawing.Size(102, 13);
            this.lblPretxb.TabIndex = 2;
            this.lblPretxb.Text = "Controlar reset cada";
            // 
            // lblPosttxb
            // 
            this.lblPosttxb.AutoSize = true;
            this.lblPosttxb.Location = new System.Drawing.Point(171, 9);
            this.lblPosttxb.Name = "lblPosttxb";
            this.lblPosttxb.Size = new System.Drawing.Size(44, 13);
            this.lblPosttxb.TabIndex = 3;
            this.lblPosttxb.Text = "Minutos";
            // 
            // nudTimer
            // 
            this.nudTimer.Location = new System.Drawing.Point(120, 7);
            this.nudTimer.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimer.Name = "nudTimer";
            this.nudTimer.Size = new System.Drawing.Size(45, 20);
            this.nudTimer.TabIndex = 4;
            this.nudTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTimer.ValueChanged += new System.EventHandler(this.timerChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 33);
            this.Controls.Add(this.nudTimer);
            this.Controls.Add(this.lblPosttxb);
            this.Controls.Add(this.lblPretxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Mulandia Reset Notifier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClose);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClose);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem1;
        private System.Windows.Forms.Label lblPretxb;
        private System.Windows.Forms.Label lblPosttxb;
        private System.Windows.Forms.NumericUpDown nudTimer;
    }
}

