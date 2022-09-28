namespace pryRodriguezSP2A
{
    partial class frmRegistro
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
            this.cmrTipos = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.cboPersonas = new System.Windows.Forms.ComboBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.mcrAdicionales = new System.Windows.Forms.GroupBox();
            this.chkTelevisor = new System.Windows.Forms.CheckBox();
            this.chkHeladera = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.mcrPago = new System.Windows.Forms.GroupBox();
            this.cboTarjetas = new System.Windows.Forms.ComboBox();
            this.lblTarjetas = new System.Windows.Forms.Label();
            this.optTarjetas = new System.Windows.Forms.RadioButton();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.mcrTtitular = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmrTipos.SuspendLayout();
            this.mcrAdicionales.SuspendLayout();
            this.mcrPago.SuspendLayout();
            this.mcrTtitular.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmrTipos
            // 
            this.cmrTipos.Controls.Add(this.txtDias);
            this.cmrTipos.Controls.Add(this.cboPersonas);
            this.cmrTipos.Controls.Add(this.lblDias);
            this.cmrTipos.Controls.Add(this.lblPersonas);
            this.cmrTipos.Controls.Add(this.cboTipo);
            this.cmrTipos.Controls.Add(this.lblTipo);
            this.cmrTipos.Location = new System.Drawing.Point(41, 44);
            this.cmrTipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmrTipos.Name = "cmrTipos";
            this.cmrTipos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmrTipos.Size = new System.Drawing.Size(627, 98);
            this.cmrTipos.TabIndex = 0;
            this.cmrTipos.TabStop = false;
            this.cmrTipos.Text = "Tipos de Cabañas";
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Location = new System.Drawing.Point(523, 47);
            this.txtDias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(76, 20);
            this.txtDias.TabIndex = 5;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // cboPersonas
            // 
            this.cboPersonas.Enabled = false;
            this.cboPersonas.FormattingEnabled = true;
            this.cboPersonas.Location = new System.Drawing.Point(325, 45);
            this.cboPersonas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPersonas.Name = "cboPersonas";
            this.cboPersonas.Size = new System.Drawing.Size(92, 21);
            this.cboPersonas.TabIndex = 4;
            this.cboPersonas.SelectedIndexChanged += new System.EventHandler(this.cboPersonas_SelectedIndexChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Enabled = false;
            this.lblDias.Location = new System.Drawing.Point(464, 50);
            this.lblDias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 3;
            this.lblDias.Text = "Dias";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Enabled = false;
            this.lblPersonas.Location = new System.Drawing.Point(236, 47);
            this.lblPersonas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblPersonas.TabIndex = 2;
            this.lblPersonas.Text = "Personas";
            this.lblPersonas.Click += new System.EventHandler(this.lblPersonas_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(77, 47);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(92, 21);
            this.cboTipo.TabIndex = 1;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(16, 47);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(33, 13);
            this.lblTipo.TabIndex = 0;
            this.lblTipo.Text = "Tipos";
            // 
            // mcrAdicionales
            // 
            this.mcrAdicionales.Controls.Add(this.chkTelevisor);
            this.mcrAdicionales.Controls.Add(this.chkHeladera);
            this.mcrAdicionales.Controls.Add(this.chkCocina);
            this.mcrAdicionales.Enabled = false;
            this.mcrAdicionales.Location = new System.Drawing.Point(41, 229);
            this.mcrAdicionales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mcrAdicionales.Name = "mcrAdicionales";
            this.mcrAdicionales.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mcrAdicionales.Size = new System.Drawing.Size(200, 141);
            this.mcrAdicionales.TabIndex = 1;
            this.mcrAdicionales.TabStop = false;
            this.mcrAdicionales.Text = "Adicionales";
            // 
            // chkTelevisor
            // 
            this.chkTelevisor.AutoSize = true;
            this.chkTelevisor.Location = new System.Drawing.Point(5, 120);
            this.chkTelevisor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTelevisor.Name = "chkTelevisor";
            this.chkTelevisor.Size = new System.Drawing.Size(69, 17);
            this.chkTelevisor.TabIndex = 2;
            this.chkTelevisor.Text = "Televisor";
            this.chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            this.chkHeladera.AutoSize = true;
            this.chkHeladera.Location = new System.Drawing.Point(5, 78);
            this.chkHeladera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkHeladera.Name = "chkHeladera";
            this.chkHeladera.Size = new System.Drawing.Size(69, 17);
            this.chkHeladera.TabIndex = 1;
            this.chkHeladera.Text = "Heladera";
            this.chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(5, 31);
            this.chkCocina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(59, 17);
            this.chkCocina.TabIndex = 0;
            this.chkCocina.Text = "Cocina";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // mcrPago
            // 
            this.mcrPago.Controls.Add(this.cboTarjetas);
            this.mcrPago.Controls.Add(this.lblTarjetas);
            this.mcrPago.Controls.Add(this.optTarjetas);
            this.mcrPago.Controls.Add(this.optEfectivo);
            this.mcrPago.Enabled = false;
            this.mcrPago.Location = new System.Drawing.Point(345, 229);
            this.mcrPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mcrPago.Name = "mcrPago";
            this.mcrPago.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mcrPago.Size = new System.Drawing.Size(294, 148);
            this.mcrPago.TabIndex = 2;
            this.mcrPago.TabStop = false;
            this.mcrPago.Text = "Forma de pago";
            // 
            // cboTarjetas
            // 
            this.cboTarjetas.FormattingEnabled = true;
            this.cboTarjetas.Location = new System.Drawing.Point(140, 92);
            this.cboTarjetas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTarjetas.Name = "cboTarjetas";
            this.cboTarjetas.Size = new System.Drawing.Size(126, 21);
            this.cboTarjetas.TabIndex = 3;
            // 
            // lblTarjetas
            // 
            this.lblTarjetas.AutoSize = true;
            this.lblTarjetas.Location = new System.Drawing.Point(138, 54);
            this.lblTarjetas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarjetas.Name = "lblTarjetas";
            this.lblTarjetas.Size = new System.Drawing.Size(45, 13);
            this.lblTarjetas.TabIndex = 2;
            this.lblTarjetas.Text = "Tarjetas";
            // 
            // optTarjetas
            // 
            this.optTarjetas.AutoSize = true;
            this.optTarjetas.Location = new System.Drawing.Point(5, 119);
            this.optTarjetas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optTarjetas.Name = "optTarjetas";
            this.optTarjetas.Size = new System.Drawing.Size(58, 17);
            this.optTarjetas.TabIndex = 1;
            this.optTarjetas.TabStop = true;
            this.optTarjetas.Text = "Tarjeta";
            this.optTarjetas.UseVisualStyleBackColor = true;
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Location = new System.Drawing.Point(5, 52);
            this.optEfectivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(64, 17);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.optEfectivo_CheckedChanged);
            // 
            // mcrTtitular
            // 
            this.mcrTtitular.Controls.Add(this.txtTelefono);
            this.mcrTtitular.Controls.Add(this.txtNombre);
            this.mcrTtitular.Controls.Add(this.lblTelefono);
            this.mcrTtitular.Controls.Add(this.lblNombre);
            this.mcrTtitular.Location = new System.Drawing.Point(41, 435);
            this.mcrTtitular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mcrTtitular.Name = "mcrTtitular";
            this.mcrTtitular.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mcrTtitular.Size = new System.Drawing.Size(642, 98);
            this.mcrTtitular.TabIndex = 3;
            this.mcrTtitular.TabStop = false;
            this.mcrTtitular.Text = "Titular de la Reserva";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(110, 74);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(518, 20);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 28);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(518, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(20, 80);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 32);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(644, 557);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 32);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 599);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.mcrTtitular);
            this.Controls.Add(this.mcrPago);
            this.Controls.Add(this.mcrAdicionales);
            this.Controls.Add(this.cmrTipos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegistro";
            this.Text = "Reservas de Cabañas";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.cmrTipos.ResumeLayout(false);
            this.cmrTipos.PerformLayout();
            this.mcrAdicionales.ResumeLayout(false);
            this.mcrAdicionales.PerformLayout();
            this.mcrPago.ResumeLayout(false);
            this.mcrPago.PerformLayout();
            this.mcrTtitular.ResumeLayout(false);
            this.mcrTtitular.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cmrTipos;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.ComboBox cboPersonas;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.GroupBox mcrAdicionales;
        private System.Windows.Forms.CheckBox chkTelevisor;
        private System.Windows.Forms.CheckBox chkHeladera;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.GroupBox mcrPago;
        private System.Windows.Forms.ComboBox cboTarjetas;
        private System.Windows.Forms.Label lblTarjetas;
        private System.Windows.Forms.RadioButton optTarjetas;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.GroupBox mcrTtitular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
    }
}

