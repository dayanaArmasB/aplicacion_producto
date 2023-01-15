namespace utp.industrial.view
{
    partial class FrmArray03
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.gbOrdenamiento = new System.Windows.Forms.GroupBox();
            this.txtInsercion = new System.Windows.Forms.TextBox();
            this.btnInserción = new System.Windows.Forms.Button();
            this.txtSeleccion = new System.Windows.Forms.TextBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.txtBurbuja = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gbOrdenamiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tamaño del array: ";
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(126, 42);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(100, 23);
            this.txtTamanio.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(241, 44);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.AcceptsReturn = true;
            this.txtMostrar.Location = new System.Drawing.Point(31, 78);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(285, 23);
            this.txtMostrar.TabIndex = 3;
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.Location = new System.Drawing.Point(6, 22);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(75, 23);
            this.btnBurbuja.TabIndex = 4;
            this.btnBurbuja.Text = "Burbuja";
            this.btnBurbuja.UseVisualStyleBackColor = true;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click);
            // 
            // gbOrdenamiento
            // 
            this.gbOrdenamiento.Controls.Add(this.txtInsercion);
            this.gbOrdenamiento.Controls.Add(this.btnInserción);
            this.gbOrdenamiento.Controls.Add(this.txtSeleccion);
            this.gbOrdenamiento.Controls.Add(this.btnSeleccion);
            this.gbOrdenamiento.Controls.Add(this.txtBurbuja);
            this.gbOrdenamiento.Controls.Add(this.btnBurbuja);
            this.gbOrdenamiento.Location = new System.Drawing.Point(29, 117);
            this.gbOrdenamiento.Name = "gbOrdenamiento";
            this.gbOrdenamiento.Size = new System.Drawing.Size(306, 144);
            this.gbOrdenamiento.TabIndex = 5;
            this.gbOrdenamiento.TabStop = false;
            this.gbOrdenamiento.Text = "Ordenamiento";
            // 
            // txtInsercion
            // 
            this.txtInsercion.Location = new System.Drawing.Point(93, 75);
            this.txtInsercion.Name = "txtInsercion";
            this.txtInsercion.Size = new System.Drawing.Size(194, 23);
            this.txtInsercion.TabIndex = 9;
            // 
            // btnInserción
            // 
            this.btnInserción.Location = new System.Drawing.Point(6, 77);
            this.btnInserción.Name = "btnInserción";
            this.btnInserción.Size = new System.Drawing.Size(75, 23);
            this.btnInserción.TabIndex = 8;
            this.btnInserción.Text = "Inserción";
            this.btnInserción.UseVisualStyleBackColor = true;
            this.btnInserción.Click += new System.EventHandler(this.btnInserción_Click);
            // 
            // txtSeleccion
            // 
            this.txtSeleccion.Location = new System.Drawing.Point(93, 48);
            this.txtSeleccion.Name = "txtSeleccion";
            this.txtSeleccion.Size = new System.Drawing.Size(194, 23);
            this.txtSeleccion.TabIndex = 7;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(6, 50);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccion.TabIndex = 6;
            this.btnSeleccion.Text = "Selección";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // txtBurbuja
            // 
            this.txtBurbuja.Location = new System.Drawing.Point(93, 20);
            this.txtBurbuja.Name = "txtBurbuja";
            this.txtBurbuja.Size = new System.Drawing.Size(194, 23);
            this.txtBurbuja.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(506, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(391, 45);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 23);
            this.txtBuscar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 402);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbOrdenamiento);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtTamanio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOrdenamiento.ResumeLayout(false);
            this.gbOrdenamiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtTamanio;
        private Button btnGenerar;
        private TextBox txtMostrar;
        private Button btnBurbuja;
        private GroupBox gbOrdenamiento;
        private TextBox txtBurbuja;
        private TextBox txtSeleccion;
        private Button btnSeleccion;
        private TextBox txtInsercion;
        private Button btnInserción;
        private Button btnBuscar;
        private TextBox txtBuscar;
    }
}