namespace WinDuplicados
{
    partial class Principal
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
            label1 = new Label();
            Directorio = new TextBox();
            Buscar = new Button();
            label2 = new Label();
            ListaArchivos = new ListView();
            ListaUbicaciones = new ListView();
            label3 = new Label();
            Mensaje = new Label();
            Cerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Directorio";
            // 
            // Directorio
            // 
            Directorio.Location = new Point(77, 6);
            Directorio.Name = "Directorio";
            Directorio.ReadOnly = true;
            Directorio.Size = new Size(814, 23);
            Directorio.TabIndex = 1;
            // 
            // Buscar
            // 
            Buscar.Location = new Point(897, 6);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(75, 23);
            Buscar.TabIndex = 2;
            Buscar.Text = "BUSCAR";
            Buscar.UseVisualStyleBackColor = true;
            Buscar.Click += BUSCAR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 3;
            label2.Text = "Archivos con duplicados";
            // 
            // ListaArchivos
            // 
            ListaArchivos.Location = new Point(10, 77);
            ListaArchivos.Name = "ListaArchivos";
            ListaArchivos.Size = new Size(334, 650);
            ListaArchivos.TabIndex = 4;
            ListaArchivos.UseCompatibleStateImageBehavior = false;
            // 
            // ListaUbicaciones
            // 
            ListaUbicaciones.Location = new Point(350, 77);
            ListaUbicaciones.Name = "ListaUbicaciones";
            ListaUbicaciones.Size = new Size(622, 650);
            ListaUbicaciones.TabIndex = 6;
            ListaUbicaciones.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 59);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 5;
            label3.Text = "Ubicaciones";
            // 
            // Mensaje
            // 
            Mensaje.AutoSize = true;
            Mensaje.Location = new Point(12, 737);
            Mensaje.Name = "Mensaje";
            Mensaje.Size = new Size(51, 15);
            Mensaje.TabIndex = 7;
            Mensaje.Text = "Mensaje";
            // 
            // Cerrar
            // 
            Cerrar.Location = new Point(897, 733);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(75, 23);
            Cerrar.TabIndex = 8;
            Cerrar.Text = "CERRAR";
            Cerrar.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 761);
            Controls.Add(Cerrar);
            Controls.Add(Mensaje);
            Controls.Add(ListaUbicaciones);
            Controls.Add(label3);
            Controls.Add(ListaArchivos);
            Controls.Add(label2);
            Controls.Add(Buscar);
            Controls.Add(Directorio);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinDuplicados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Directorio;
        private Button Buscar;
        private Label label2;
        private ListView ListaArchivos;
        private ListView ListaUbicaciones;
        private Label label3;
        private Label Mensaje;
        private Button Cerrar;
    }
}
