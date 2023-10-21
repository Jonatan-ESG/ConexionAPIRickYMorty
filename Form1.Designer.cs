namespace ConexionAPIRickYMorty
{
    partial class Form1
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
            button1 = new Button();
            contenedorPersonajes = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(47, 34);
            button1.Name = "button1";
            button1.Size = new Size(169, 43);
            button1.TabIndex = 0;
            button1.Text = "Otener Personajes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contenedorPersonajes
            // 
            contenedorPersonajes.Location = new Point(36, 98);
            contenedorPersonajes.Name = "contenedorPersonajes";
            contenedorPersonajes.Size = new Size(1272, 792);
            contenedorPersonajes.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 902);
            Controls.Add(contenedorPersonajes);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel contenedorPersonajes;
    }
}