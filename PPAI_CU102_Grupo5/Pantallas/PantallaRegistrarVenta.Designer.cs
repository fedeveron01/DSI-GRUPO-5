
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
            this.CBTarifas = new System.Windows.Forms.ComboBox();
            this.TxtTarifas = new System.Windows.Forms.Label();
            this.BtnOpcionRegistrarVentaEntrada = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBTarifas
            // 
            this.CBTarifas.FormattingEnabled = true;
            this.CBTarifas.Location = new System.Drawing.Point(327, 157);
            this.CBTarifas.Name = "CBTarifas";
            this.CBTarifas.Size = new System.Drawing.Size(166, 23);
            this.CBTarifas.TabIndex = 0;
            this.CBTarifas.Visible = false;
            // 
            // TxtTarifas
            // 
            this.TxtTarifas.AutoSize = true;
            this.TxtTarifas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtTarifas.Location = new System.Drawing.Point(247, 156);
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
            this.BtnOpcionRegistrarVentaEntrada.Location = new System.Drawing.Point(327, 103);
            this.BtnOpcionRegistrarVentaEntrada.Name = "BtnOpcionRegistrarVentaEntrada";
            this.BtnOpcionRegistrarVentaEntrada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnOpcionRegistrarVentaEntrada.Size = new System.Drawing.Size(157, 37);
            this.BtnOpcionRegistrarVentaEntrada.TabIndex = 2;
            this.BtnOpcionRegistrarVentaEntrada.Text = "Registrar Venta de entrada";
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // PantallaRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnOpcionRegistrarVentaEntrada);
            this.Controls.Add(this.TxtTarifas);
            this.Controls.Add(this.CBTarifas);
            this.Controls.Add(this.menuStrip1);
            this.Name = "PantallaRegistrarVenta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

