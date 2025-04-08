namespace Examen_Tercer_parcial
{
    partial class Inicio
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
            this.dGVlatablita = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.btnAgreagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVlatablita)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVlatablita
            // 
            this.dGVlatablita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVlatablita.Location = new System.Drawing.Point(38, 30);
            this.dGVlatablita.Name = "dGVlatablita";
            this.dGVlatablita.Size = new System.Drawing.Size(524, 206);
            this.dGVlatablita.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(265, 255);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(71, 27);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(53, 318);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre";
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(38, 334);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(72, 20);
            this.txtNombre1.TabIndex = 3;
            // 
            // btnAgreagar
            // 
            this.btnAgreagar.Location = new System.Drawing.Point(220, 318);
            this.btnAgreagar.Name = "btnAgreagar";
            this.btnAgreagar.Size = new System.Drawing.Size(71, 27);
            this.btnAgreagar.TabIndex = 4;
            this.btnAgreagar.Text = "Agregar ";
            this.btnAgreagar.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgreagar);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dGVlatablita);
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dGVlatablita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVlatablita;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Button btnAgreagar;
    }
}