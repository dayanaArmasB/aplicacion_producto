namespace utp.industrial.view
{
    partial class FrmArray01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArray1 = new System.Windows.Forms.TextBox();
            this.btnAgregarArray1 = new System.Windows.Forms.Button();
            this.txtElementoArray1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtArray2 = new System.Windows.Forms.TextBox();
            this.btnAgregarArray2 = new System.Windows.Forms.Button();
            this.txtElementoArray2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArray1);
            this.groupBox1.Controls.Add(this.btnAgregarArray1);
            this.groupBox1.Controls.Add(this.txtElementoArray1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(70, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primer Array";
            // 
            // txtArray1
            // 
            this.txtArray1.Location = new System.Drawing.Point(25, 73);
            this.txtArray1.Name = "txtArray1";
            this.txtArray1.Size = new System.Drawing.Size(376, 23);
            this.txtArray1.TabIndex = 3;
            // 
            // btnAgregarArray1
            // 
            this.btnAgregarArray1.Location = new System.Drawing.Point(265, 22);
            this.btnAgregarArray1.Name = "btnAgregarArray1";
            this.btnAgregarArray1.Size = new System.Drawing.Size(136, 23);
            this.btnAgregarArray1.TabIndex = 2;
            this.btnAgregarArray1.Text = "Agregar";
            this.btnAgregarArray1.UseVisualStyleBackColor = true;
            this.btnAgregarArray1.Click += new System.EventHandler(this.btnAgregarArray1_Click);
            // 
            // txtElementoArray1
            // 
            this.txtElementoArray1.Location = new System.Drawing.Point(126, 22);
            this.txtElementoArray1.Name = "txtElementoArray1";
            this.txtElementoArray1.Size = new System.Drawing.Size(129, 23);
            this.txtElementoArray1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Elemento:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtArray2);
            this.groupBox2.Controls.Add(this.btnAgregarArray2);
            this.groupBox2.Controls.Add(this.txtElementoArray2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(67, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Segundo Array";
            // 
            // txtArray2
            // 
            this.txtArray2.Location = new System.Drawing.Point(28, 62);
            this.txtArray2.Name = "txtArray2";
            this.txtArray2.Size = new System.Drawing.Size(376, 23);
            this.txtArray2.TabIndex = 3;
            // 
            // btnAgregarArray2
            // 
            this.btnAgregarArray2.Location = new System.Drawing.Point(268, 23);
            this.btnAgregarArray2.Name = "btnAgregarArray2";
            this.btnAgregarArray2.Size = new System.Drawing.Size(136, 23);
            this.btnAgregarArray2.TabIndex = 2;
            this.btnAgregarArray2.Text = "Agregar";
            this.btnAgregarArray2.UseVisualStyleBackColor = true;
            this.btnAgregarArray2.Click += new System.EventHandler(this.btnAgregarArray2_Click);
            // 
            // txtElementoArray2
            // 
            this.txtElementoArray2.Location = new System.Drawing.Point(129, 23);
            this.txtElementoArray2.Name = "txtElementoArray2";
            this.txtElementoArray2.Size = new System.Drawing.Size(129, 23);
            this.txtElementoArray2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese Elemento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(67, 318);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(426, 23);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 400);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sobrecarga de operadores - clases";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtArray1;
        private Button btnAgregarArray1;
        private TextBox txtElementoArray1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtArray2;
        private Button btnAgregarArray2;
        private TextBox txtElementoArray2;
        private Button btnSumar;
    }
}