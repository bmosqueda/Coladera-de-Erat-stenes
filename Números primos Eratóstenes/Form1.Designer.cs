namespace Números_primos_Eratóstenes
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
            this.txtPrimos = new System.Windows.Forms.RichTextBox();
            this.btnPrimos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrimos
            // 
            this.txtPrimos.Location = new System.Drawing.Point(25, 25);
            this.txtPrimos.Name = "txtPrimos";
            this.txtPrimos.Size = new System.Drawing.Size(287, 460);
            this.txtPrimos.TabIndex = 0;
            this.txtPrimos.Text = "";
            // 
            // btnPrimos
            // 
            this.btnPrimos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrimos.Location = new System.Drawing.Point(328, 179);
            this.btnPrimos.Name = "btnPrimos";
            this.btnPrimos.Size = new System.Drawing.Size(142, 128);
            this.btnPrimos.TabIndex = 1;
            this.btnPrimos.Text = "Número primos menores a 1000";
            this.btnPrimos.UseVisualStyleBackColor = true;
            this.btnPrimos.Click += new System.EventHandler(this.btnPrimos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 512);
            this.Controls.Add(this.btnPrimos);
            this.Controls.Add(this.txtPrimos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Coladera de Eratóstenes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPrimos;
        private System.Windows.Forms.Button btnPrimos;
    }
}

