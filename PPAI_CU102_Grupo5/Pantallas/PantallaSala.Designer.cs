
namespace PPAI_CU102_Grupo5.Pantallas
{
    partial class PantallaSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaSala));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblCapacidad = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(338, 23);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // LblCapacidad
            // 
            this.LblCapacidad.AutoSize = true;
            this.LblCapacidad.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCapacidad.Location = new System.Drawing.Point(181, 230);
            this.LblCapacidad.Name = "LblCapacidad";
            this.LblCapacidad.Size = new System.Drawing.Size(259, 32);
            this.LblCapacidad.TabIndex = 8;
            this.LblCapacidad.Text = "Capacidad de la sede : ";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCantidad.Location = new System.Drawing.Point(165, 166);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(290, 30);
            this.LblCantidad.TabIndex = 7;
            this.LblCantidad.Text = "Cantidad actual de visitantes :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(638, 487);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PantallaSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 480);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LblCapacidad);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PantallaSala";
            this.Text = "PantallaSala";
            this.Load += new System.EventHandler(this.PantallaSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LblCapacidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}