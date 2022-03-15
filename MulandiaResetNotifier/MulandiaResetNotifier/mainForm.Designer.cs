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
            this.lblPretxb = new System.Windows.Forms.Label();
            this.lblPosttxb = new System.Windows.Forms.Label();
            this.nudTimer = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.chkBoxSonidoNotificacion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPretxb
            // 
            this.lblPretxb.AutoSize = true;
            this.lblPretxb.Location = new System.Drawing.Point(94, 9);
            this.lblPretxb.Name = "lblPretxb";
            this.lblPretxb.Size = new System.Drawing.Size(102, 13);
            this.lblPretxb.TabIndex = 2;
            this.lblPretxb.Text = "Controlar reset cada";
            // 
            // lblPosttxb
            // 
            this.lblPosttxb.AutoSize = true;
            this.lblPosttxb.Location = new System.Drawing.Point(253, 9);
            this.lblPosttxb.Name = "lblPosttxb";
            this.lblPosttxb.Size = new System.Drawing.Size(44, 13);
            this.lblPosttxb.TabIndex = 3;
            this.lblPosttxb.Text = "Minutos";
            // 
            // nudTimer
            // 
            this.nudTimer.Location = new System.Drawing.Point(202, 7);
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
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Mulandia Reset Notifier";
            this.notifyIcon.Visible = true;
            // 
            // chkBoxSonidoNotificacion
            // 
            this.chkBoxSonidoNotificacion.AutoSize = true;
            this.chkBoxSonidoNotificacion.Checked = true;
            this.chkBoxSonidoNotificacion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxSonidoNotificacion.Location = new System.Drawing.Point(97, 33);
            this.chkBoxSonidoNotificacion.Name = "chkBoxSonidoNotificacion";
            this.chkBoxSonidoNotificacion.Size = new System.Drawing.Size(184, 17);
            this.chkBoxSonidoNotificacion.TabIndex = 6;
            this.chkBoxSonidoNotificacion.Text = "Reproducir sonido de notificación";
            this.chkBoxSonidoNotificacion.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 59);
            this.Controls.Add(this.chkBoxSonidoNotificacion);
            this.Controls.Add(this.nudTimer);
            this.Controls.Add(this.lblPosttxb);
            this.Controls.Add(this.lblPretxb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Mulandia Reset Notifier by Magus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClose);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formClose);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPretxb;
        private System.Windows.Forms.Label lblPosttxb;
        private System.Windows.Forms.NumericUpDown nudTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox chkBoxSonidoNotificacion;
    }
}

