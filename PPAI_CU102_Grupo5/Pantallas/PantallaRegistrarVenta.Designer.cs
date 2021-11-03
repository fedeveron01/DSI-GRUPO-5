
namespace PPAI_CU102_Grupo5
{
    partial class PantallaRegistrarVenta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistrarVenta));
            this.CBTarifas = new System.Windows.Forms.ComboBox();
            this.TxtTarifas = new System.Windows.Forms.Label();
            this.BtnOpcionRegistrarVentaEntrada = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.NmbCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnConfirmarCantidad = new System.Windows.Forms.Button();
            this.LblMostrarCantidad = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.BtnConfirmarVenta = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CheckGuia = new System.Windows.Forms.CheckBox();
            this.LblMensajeEntradas = new System.Windows.Forms.Label();
            this.LblMensajeTarifas = new System.Windows.Forms.Label();
            this.BtnVolverCantidad = new System.Windows.Forms.Button();
            this.BtnVolverTarifas = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmbCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CBTarifas
            // 
            this.CBTarifas.FormattingEnabled = true;
            this.CBTarifas.Location = new System.Drawing.Point(229, 144);
            this.CBTarifas.Name = "CBTarifas";
            this.CBTarifas.Size = new System.Drawing.Size(337, 23);
            this.CBTarifas.TabIndex = 0;
            this.CBTarifas.Visible = false;
            this.CBTarifas.SelectedIndexChanged += new System.EventHandler(this.CBTarifas_SelectedIndexChanged);
            this.CBTarifas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CBTarifas_KeyUp);
            // 
            // TxtTarifas
            // 
            this.TxtTarifas.AutoSize = true;
            this.TxtTarifas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTarifas.Location = new System.Drawing.Point(151, 144);
            this.TxtTarifas.Name = "TxtTarifas";
            this.TxtTarifas.Size = new System.Drawing.Size(62, 20);
            this.TxtTarifas.TabIndex = 1;
            this.TxtTarifas.Text = "Tarifas : ";
            this.TxtTarifas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TxtTarifas.Visible = false;
            // 
            // BtnOpcionRegistrarVentaEntrada
            // 
            this.BtnOpcionRegistrarVentaEntrada.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnOpcionRegistrarVentaEntrada.Image = global::PPAI_CU102_Grupo5.Properties.Resources.registrar;
            this.BtnOpcionRegistrarVentaEntrada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpcionRegistrarVentaEntrada.Location = new System.Drawing.Point(303, 81);
            this.BtnOpcionRegistrarVentaEntrada.Name = "BtnOpcionRegistrarVentaEntrada";
            this.BtnOpcionRegistrarVentaEntrada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnOpcionRegistrarVentaEntrada.Size = new System.Drawing.Size(188, 37);
            this.BtnOpcionRegistrarVentaEntrada.TabIndex = 2;
            this.BtnOpcionRegistrarVentaEntrada.Text = "Registrar Venta de entrada";
            this.BtnOpcionRegistrarVentaEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOpcionRegistrarVentaEntrada.UseVisualStyleBackColor = false;
            this.BtnOpcionRegistrarVentaEntrada.Click += new System.EventHandler(this.BtnOpcionRegistrarVentaEntrada_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Inicio";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnConfirmar.Enabled = false;
            this.BtnConfirmar.Image = global::PPAI_CU102_Grupo5.Properties.Resources.confirmar;
            this.BtnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmar.Location = new System.Drawing.Point(317, 210);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnConfirmar.Size = new System.Drawing.Size(157, 35);
            this.BtnConfirmar.TabIndex = 4;
            this.BtnConfirmar.Text = "Confirmar Tarifa";
            this.BtnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Visible = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCantidad.Location = new System.Drawing.Point(182, 280);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(137, 20);
            this.LblCantidad.TabIndex = 6;
            this.LblCantidad.Text = "Cantidad entradas :";
            this.LblCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblCantidad.Visible = false;
            // 
            // NmbCantidad
            // 
            this.NmbCantidad.Location = new System.Drawing.Point(344, 282);
            this.NmbCantidad.Name = "NmbCantidad";
            this.NmbCantidad.Size = new System.Drawing.Size(120, 23);
            this.NmbCantidad.TabIndex = 7;
            this.NmbCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmbCantidad.Visible = false;
            this.NmbCantidad.ValueChanged += new System.EventHandler(this.NmbCantidad_ValueChanged);
            this.NmbCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NmbCantidad_KeyUp);
            // 
            // BtnConfirmarCantidad
            // 
            this.BtnConfirmarCantidad.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnConfirmarCantidad.Image = global::PPAI_CU102_Grupo5.Properties.Resources.confirmar;
            this.BtnConfirmarCantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmarCantidad.Location = new System.Drawing.Point(327, 326);
            this.BtnConfirmarCantidad.Name = "BtnConfirmarCantidad";
            this.BtnConfirmarCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnConfirmarCantidad.Size = new System.Drawing.Size(164, 37);
            this.BtnConfirmarCantidad.TabIndex = 8;
            this.BtnConfirmarCantidad.Text = "Confirmar Cantidad";
            this.BtnConfirmarCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmarCantidad.UseVisualStyleBackColor = false;
            this.BtnConfirmarCantidad.Visible = false;
            this.BtnConfirmarCantidad.Click += new System.EventHandler(this.BtnConfirmarCantidad_Click);
            // 
            // LblMostrarCantidad
            // 
            this.LblMostrarCantidad.AutoSize = true;
            this.LblMostrarCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMostrarCantidad.Location = new System.Drawing.Point(229, 121);
            this.LblMostrarCantidad.Name = "LblMostrarCantidad";
            this.LblMostrarCantidad.Size = new System.Drawing.Size(141, 20);
            this.LblMostrarCantidad.TabIndex = 9;
            this.LblMostrarCantidad.Text = "Cantidad entradas : ";
            this.LblMostrarCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblMostrarCantidad.Visible = false;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblPrecio.Location = new System.Drawing.Point(229, 170);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(151, 20);
            this.LblPrecio.TabIndex = 10;
            this.LblPrecio.Text = "Precio por entrada : $";
            this.LblPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblPrecio.Visible = false;
            // 
            // BtnConfirmarVenta
            // 
            this.BtnConfirmarVenta.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnConfirmarVenta.Image = global::PPAI_CU102_Grupo5.Properties.Resources.confirmar;
            this.BtnConfirmarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmarVenta.Location = new System.Drawing.Point(539, 134);
            this.BtnConfirmarVenta.Name = "BtnConfirmarVenta";
            this.BtnConfirmarVenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnConfirmarVenta.Size = new System.Drawing.Size(157, 33);
            this.BtnConfirmarVenta.TabIndex = 11;
            this.BtnConfirmarVenta.Text = "Confirmar venta";
            this.BtnConfirmarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConfirmarVenta.UseVisualStyleBackColor = false;
            this.BtnConfirmarVenta.Visible = false;
            this.BtnConfirmarVenta.Click += new System.EventHandler(this.BtnConfirmarVenta_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotal.Location = new System.Drawing.Point(229, 210);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(61, 20);
            this.LblTotal.TabIndex = 12;
            this.LblTotal.Text = "Total : $";
            this.LblTotal.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(358, 410);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(116, 28);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CheckGuia
            // 
            this.CheckGuia.AutoSize = true;
            this.CheckGuia.Location = new System.Drawing.Point(327, 188);
            this.CheckGuia.Name = "CheckGuia";
            this.CheckGuia.Size = new System.Drawing.Size(147, 19);
            this.CheckGuia.TabIndex = 15;
            this.CheckGuia.Text = "Incluir servicio de guía ";
            this.CheckGuia.UseVisualStyleBackColor = true;
            this.CheckGuia.Visible = false;
            // 
            // LblMensajeEntradas
            // 
            this.LblMensajeEntradas.AutoSize = true;
            this.LblMensajeEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LblMensajeEntradas.Location = new System.Drawing.Point(257, 308);
            this.LblMensajeEntradas.Name = "LblMensajeEntradas";
            this.LblMensajeEntradas.Size = new System.Drawing.Size(288, 15);
            this.LblMensajeEntradas.TabIndex = 16;
            this.LblMensajeEntradas.Text = "La cantidad de entradas ingresada debe ser mayor a 0";
            this.LblMensajeEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMensajeEntradas.Visible = false;
            // 
            // LblMensajeTarifas
            // 
            this.LblMensajeTarifas.AutoSize = true;
            this.LblMensajeTarifas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LblMensajeTarifas.Location = new System.Drawing.Point(287, 170);
            this.LblMensajeTarifas.Name = "LblMensajeTarifas";
            this.LblMensajeTarifas.Size = new System.Drawing.Size(204, 15);
            this.LblMensajeTarifas.TabIndex = 17;
            this.LblMensajeTarifas.Text = "Debe seleccionar una tarifa de la lista ";
            this.LblMensajeTarifas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMensajeTarifas.Visible = false;
            // 
            // BtnVolverCantidad
            // 
            this.BtnVolverCantidad.Image = global::PPAI_CU102_Grupo5.Properties.Resources.volver;
            this.BtnVolverCantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolverCantidad.Location = new System.Drawing.Point(229, 251);
            this.BtnVolverCantidad.Name = "BtnVolverCantidad";
            this.BtnVolverCantidad.Size = new System.Drawing.Size(164, 25);
            this.BtnVolverCantidad.TabIndex = 18;
            this.BtnVolverCantidad.Text = "Volver";
            this.BtnVolverCantidad.UseVisualStyleBackColor = true;
            this.BtnVolverCantidad.Visible = false;
            this.BtnVolverCantidad.Click += new System.EventHandler(this.BtnVolverCantidad_Click);
            // 
            // BtnVolverTarifas
            // 
            this.BtnVolverTarifas.Image = global::PPAI_CU102_Grupo5.Properties.Resources.volver;
            this.BtnVolverTarifas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolverTarifas.Location = new System.Drawing.Point(327, 369);
            this.BtnVolverTarifas.Name = "BtnVolverTarifas";
            this.BtnVolverTarifas.Size = new System.Drawing.Size(164, 25);
            this.BtnVolverTarifas.TabIndex = 19;
            this.BtnVolverTarifas.Text = "Volver";
            this.BtnVolverTarifas.UseVisualStyleBackColor = true;
            this.BtnVolverTarifas.Visible = false;
            this.BtnVolverTarifas.Click += new System.EventHandler(this.BtnVolverTarifas_Click);
            // 
            // PantallaRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVolverTarifas);
            this.Controls.Add(this.BtnVolverCantidad);
            this.Controls.Add(this.LblMensajeTarifas);
            this.Controls.Add(this.LblMensajeEntradas);
            this.Controls.Add(this.CheckGuia);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnConfirmarVenta);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblMostrarCantidad);
            this.Controls.Add(this.BtnConfirmarCantidad);
            this.Controls.Add(this.NmbCantidad);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.BtnOpcionRegistrarVentaEntrada);
            this.Controls.Add(this.TxtTarifas);
            this.Controls.Add(this.CBTarifas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PantallaRegistrarVenta";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmbCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBTarifas;
        private System.Windows.Forms.Label TxtTarifas;
        private System.Windows.Forms.Button BtnOpcionRegistrarVentaEntrada;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.NumericUpDown NmbCantidad;
        private System.Windows.Forms.Button BtnConfirmarCantidad;
        private System.Windows.Forms.Label LblMostrarCantidad;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Button BtnConfirmarVenta;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.CheckBox CheckGuia;
        private System.Windows.Forms.Label LblMensajeEntradas;
        private System.Windows.Forms.Label LblMensajeTarifas;
        private System.Windows.Forms.Button BtnVolverCantidad;
        private System.Windows.Forms.Button BtnVolverTarifas;
    }
}

