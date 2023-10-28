namespace ConexionAPIRickYMorty
{
    partial class VistaDetalladaPersonaje
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
            fotoPersonaje = new PictureBox();
            lblNombre = new Label();
            genero = new PictureBox();
            status = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTipo = new Label();
            lblEspecie = new Label();
            ((System.ComponentModel.ISupportInitialize)fotoPersonaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)status).BeginInit();
            SuspendLayout();
            // 
            // fotoPersonaje
            // 
            fotoPersonaje.Location = new Point(231, 22);
            fotoPersonaje.Name = "fotoPersonaje";
            fotoPersonaje.Size = new Size(200, 200);
            fotoPersonaje.TabIndex = 0;
            fotoPersonaje.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(216, 246);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 30);
            lblNombre.TabIndex = 1;
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // genero
            // 
            genero.Location = new Point(213, 433);
            genero.Name = "genero";
            genero.Size = new Size(43, 43);
            genero.TabIndex = 2;
            genero.TabStop = false;
            // 
            // status
            // 
            status.Location = new Point(167, 233);
            status.Name = "status";
            status.Size = new Size(43, 43);
            status.TabIndex = 3;
            status.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 318);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Tipo: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 376);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Especie:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 446);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 7;
            label4.Text = "Género:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(216, 318);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(0, 20);
            lblTipo.TabIndex = 8;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(213, 376);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(0, 20);
            lblEspecie.TabIndex = 9;
            // 
            // VistaDetalladaPersonaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 616);
            Controls.Add(lblEspecie);
            Controls.Add(lblTipo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(status);
            Controls.Add(genero);
            Controls.Add(lblNombre);
            Controls.Add(fotoPersonaje);
            Name = "VistaDetalladaPersonaje";
            Text = "VistaDetalladaPersonaje";
            ((System.ComponentModel.ISupportInitialize)fotoPersonaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)genero).EndInit();
            ((System.ComponentModel.ISupportInitialize)status).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox fotoPersonaje;
        private Label lblNombre;
        private PictureBox genero;
        private PictureBox status;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTipo;
        private Label lblEspecie;
    }
}