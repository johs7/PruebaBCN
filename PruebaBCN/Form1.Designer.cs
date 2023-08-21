namespace PruebaBCN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCambioDia = new Guna.UI.WinForms.GunaButton();
            this.btnCambioMensual = new Guna.UI.WinForms.GunaButton();
            this.dgvCambio = new Guna.UI.WinForms.GunaDataGridView();
            this.ColYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTipoCambioDia = new System.Windows.Forms.Label();
            this.btnAgregarTcSistema = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCambioDia
            // 
            this.btnCambioDia.AnimationHoverSpeed = 0.07F;
            this.btnCambioDia.AnimationSpeed = 0.03F;
            this.btnCambioDia.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCambioDia.BorderColor = System.Drawing.Color.Black;
            this.btnCambioDia.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCambioDia.FocusedColor = System.Drawing.Color.Empty;
            this.btnCambioDia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCambioDia.ForeColor = System.Drawing.Color.White;
            this.btnCambioDia.Image = ((System.Drawing.Image)(resources.GetObject("btnCambioDia.Image")));
            this.btnCambioDia.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCambioDia.Location = new System.Drawing.Point(238, 24);
            this.btnCambioDia.Name = "btnCambioDia";
            this.btnCambioDia.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCambioDia.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCambioDia.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCambioDia.OnHoverImage = null;
            this.btnCambioDia.OnPressedColor = System.Drawing.Color.Black;
            this.btnCambioDia.Size = new System.Drawing.Size(211, 42);
            this.btnCambioDia.TabIndex = 0;
            this.btnCambioDia.Text = "Obtener tipo de cambio del día";
            this.btnCambioDia.Click += new System.EventHandler(this.btnCambioDia_Click);
            // 
            // btnCambioMensual
            // 
            this.btnCambioMensual.AnimationHoverSpeed = 0.07F;
            this.btnCambioMensual.AnimationSpeed = 0.03F;
            this.btnCambioMensual.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCambioMensual.BorderColor = System.Drawing.Color.Black;
            this.btnCambioMensual.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCambioMensual.FocusedColor = System.Drawing.Color.Empty;
            this.btnCambioMensual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCambioMensual.ForeColor = System.Drawing.Color.White;
            this.btnCambioMensual.Image = ((System.Drawing.Image)(resources.GetObject("btnCambioMensual.Image")));
            this.btnCambioMensual.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCambioMensual.Location = new System.Drawing.Point(12, 24);
            this.btnCambioMensual.Name = "btnCambioMensual";
            this.btnCambioMensual.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCambioMensual.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCambioMensual.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCambioMensual.OnHoverImage = null;
            this.btnCambioMensual.OnPressedColor = System.Drawing.Color.Black;
            this.btnCambioMensual.Size = new System.Drawing.Size(220, 42);
            this.btnCambioMensual.TabIndex = 1;
            this.btnCambioMensual.Text = "Obtener tipo de cambio mensual";
            this.btnCambioMensual.Click += new System.EventHandler(this.btnCambioMensual_Click_1);
            // 
            // dgvCambio
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvCambio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCambio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCambio.BackgroundColor = System.Drawing.Color.White;
            this.dgvCambio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCambio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCambio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCambio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCambio.ColumnHeadersHeight = 21;
            this.dgvCambio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColYear,
            this.ColMonth,
            this.ColDay,
            this.ColExchangeRate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCambio.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCambio.EnableHeadersVisualStyles = false;
            this.dgvCambio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvCambio.Location = new System.Drawing.Point(2, 113);
            this.dgvCambio.Name = "dgvCambio";
            this.dgvCambio.ReadOnly = true;
            this.dgvCambio.RowHeadersVisible = false;
            this.dgvCambio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCambio.Size = new System.Drawing.Size(796, 335);
            this.dgvCambio.TabIndex = 2;
            this.dgvCambio.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea;
            this.dgvCambio.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.dgvCambio.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCambio.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCambio.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCambio.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCambio.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCambio.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.dgvCambio.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.dgvCambio.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCambio.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCambio.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCambio.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCambio.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvCambio.ThemeStyle.ReadOnly = true;
            this.dgvCambio.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.dgvCambio.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCambio.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvCambio.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCambio.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCambio.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.dgvCambio.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ColYear
            // 
            this.ColYear.HeaderText = "Año";
            this.ColYear.Name = "ColYear";
            this.ColYear.ReadOnly = true;
            // 
            // ColMonth
            // 
            this.ColMonth.HeaderText = "Mes";
            this.ColMonth.Name = "ColMonth";
            this.ColMonth.ReadOnly = true;
            // 
            // ColDay
            // 
            this.ColDay.HeaderText = "Dia";
            this.ColDay.Name = "ColDay";
            this.ColDay.ReadOnly = true;
            // 
            // ColExchangeRate
            // 
            this.ColExchangeRate.HeaderText = "Tipo de cambio";
            this.ColExchangeRate.Name = "ColExchangeRate";
            this.ColExchangeRate.ReadOnly = true;
            // 
            // lblTipoCambioDia
            // 
            this.lblTipoCambioDia.AutoSize = true;
            this.lblTipoCambioDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCambioDia.Location = new System.Drawing.Point(12, 74);
            this.lblTipoCambioDia.Name = "lblTipoCambioDia";
            this.lblTipoCambioDia.Size = new System.Drawing.Size(66, 24);
            this.lblTipoCambioDia.TabIndex = 3;
            this.lblTipoCambioDia.Text = "label1";
            // 
            // btnAgregarTcSistema
            // 
            this.btnAgregarTcSistema.AnimationHoverSpeed = 0.07F;
            this.btnAgregarTcSistema.AnimationSpeed = 0.03F;
            this.btnAgregarTcSistema.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAgregarTcSistema.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarTcSistema.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAgregarTcSistema.FocusedColor = System.Drawing.Color.Empty;
            this.btnAgregarTcSistema.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgregarTcSistema.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTcSistema.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTcSistema.Image")));
            this.btnAgregarTcSistema.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAgregarTcSistema.Location = new System.Drawing.Point(455, 24);
            this.btnAgregarTcSistema.Name = "btnAgregarTcSistema";
            this.btnAgregarTcSistema.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAgregarTcSistema.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAgregarTcSistema.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAgregarTcSistema.OnHoverImage = null;
            this.btnAgregarTcSistema.OnPressedColor = System.Drawing.Color.Black;
            this.btnAgregarTcSistema.Size = new System.Drawing.Size(162, 42);
            this.btnAgregarTcSistema.TabIndex = 4;
            this.btnAgregarTcSistema.Text = "Agregar TC a sistema";
            this.btnAgregarTcSistema.Click += new System.EventHandler(this.btnAgregarTcSistema_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarTcSistema);
            this.Controls.Add(this.lblTipoCambioDia);
            this.Controls.Add(this.dgvCambio);
            this.Controls.Add(this.btnCambioMensual);
            this.Controls.Add(this.btnCambioDia);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnCambioDia;
        private Guna.UI.WinForms.GunaButton btnCambioMensual;
        private Guna.UI.WinForms.GunaDataGridView dgvCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExchangeRate;
        private System.Windows.Forms.Label lblTipoCambioDia;
        private Guna.UI.WinForms.GunaButton btnAgregarTcSistema;
    }
}

