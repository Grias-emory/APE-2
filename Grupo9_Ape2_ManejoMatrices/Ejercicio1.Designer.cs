namespace Grupo9_Ape2_ManejoDeMatrices
{
    partial class Ejercicio1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.lblFilas = new System.Windows.Forms.Label();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dgvEntrada = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvSalida = new System.Windows.Forms.DataGridView();
            this.dgvInversa = new System.Windows.Forms.DataGridView();
            this.lblDiag1 = new System.Windows.Forms.Label();
            this.lblDiag2 = new System.Windows.Forms.Label();
            this.lblDiagInv1 = new System.Windows.Forms.Label();
            this.lblDiagInv2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInversa)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(953, 727);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Grupo9_Ape2_ManejoMatrices.Properties.Resources.FondoMatriz;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(953, 727);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Grupo9_Ape2_ManejoMatrices.Properties.Resources.FondoMatriz;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFilas);
            this.panel1.Controls.Add(this.txtColumnas);
            this.panel1.Controls.Add(this.lblFilas);
            this.panel1.Controls.Add(this.lblColumnas);
            this.panel1.Controls.Add(this.btnCrear);
            this.panel1.Controls.Add(this.dgvEntrada);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.dgvSalida);
            this.panel1.Controls.Add(this.dgvInversa);
            this.panel1.Controls.Add(this.lblDiag1);
            this.panel1.Controls.Add(this.lblDiag2);
            this.panel1.Controls.Add(this.lblDiagInv1);
            this.panel1.Controls.Add(this.lblDiagInv2);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 727);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "CALCULO MATRIZ";
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(123, 71);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(50, 26);
            this.txtFilas.TabIndex = 0;
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(327, 71);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(50, 26);
            this.txtColumnas.TabIndex = 1;
            // 
            // lblFilas
            // 
            this.lblFilas.AutoSize = true;
            this.lblFilas.Location = new System.Drawing.Point(28, 74);
            this.lblFilas.Name = "lblFilas";
            this.lblFilas.Size = new System.Drawing.Size(89, 20);
            this.lblFilas.TabIndex = 2;
            this.lblFilas.Text = "Nº de Filas:";
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.Location = new System.Drawing.Point(207, 74);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(105, 20);
            this.lblColumnas.TabIndex = 3;
            this.lblColumnas.Text = "Nº Columnas:";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(397, 66);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(124, 28);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "Crear Matriz";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dgvEntrada
            // 
            this.dgvEntrada.AllowUserToAddRows = false;
            this.dgvEntrada.AllowUserToDeleteRows = false;
            this.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrada.Location = new System.Drawing.Point(32, 112);
            this.dgvEntrada.Name = "dgvEntrada";
            this.dgvEntrada.RowHeadersWidth = 62;
            this.dgvEntrada.Size = new System.Drawing.Size(350, 200);
            this.dgvEntrada.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(397, 189);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar e Imprimir";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvSalida
            // 
            this.dgvSalida.AllowUserToAddRows = false;
            this.dgvSalida.AllowUserToDeleteRows = false;
            this.dgvSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalida.Location = new System.Drawing.Point(567, 112);
            this.dgvSalida.Name = "dgvSalida";
            this.dgvSalida.ReadOnly = true;
            this.dgvSalida.RowHeadersWidth = 62;
            this.dgvSalida.Size = new System.Drawing.Size(350, 200);
            this.dgvSalida.TabIndex = 7;
            // 
            // dgvInversa
            // 
            this.dgvInversa.AllowUserToAddRows = false;
            this.dgvInversa.AllowUserToDeleteRows = false;
            this.dgvInversa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInversa.Location = new System.Drawing.Point(32, 373);
            this.dgvInversa.Name = "dgvInversa";
            this.dgvInversa.ReadOnly = true;
            this.dgvInversa.RowHeadersWidth = 62;
            this.dgvInversa.Size = new System.Drawing.Size(350, 200);
            this.dgvInversa.TabIndex = 8;
            // 
            // lblDiag1
            // 
            this.lblDiag1.Location = new System.Drawing.Point(563, 397);
            this.lblDiag1.Name = "lblDiag1";
            this.lblDiag1.Size = new System.Drawing.Size(317, 20);
            this.lblDiag1.TabIndex = 9;
            // 
            // lblDiag2
            // 
            this.lblDiag2.Location = new System.Drawing.Point(563, 443);
            this.lblDiag2.Name = "lblDiag2";
            this.lblDiag2.Size = new System.Drawing.Size(317, 20);
            this.lblDiag2.TabIndex = 10;
            // 
            // lblDiagInv1
            // 
            this.lblDiagInv1.Location = new System.Drawing.Point(563, 484);
            this.lblDiagInv1.Name = "lblDiagInv1";
            this.lblDiagInv1.Size = new System.Drawing.Size(317, 20);
            this.lblDiagInv1.TabIndex = 11;
            // 
            // lblDiagInv2
            // 
            this.lblDiagInv2.Location = new System.Drawing.Point(563, 525);
            this.lblDiagInv2.Name = "lblDiagInv2";
            this.lblDiagInv2.Size = new System.Drawing.Size(317, 20);
            this.lblDiagInv2.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(421, 255);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 40);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(563, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Matriz A Normal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Matriz B Normal:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 597);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "Regresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(350, 597);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 40);
            this.button3.TabIndex = 21;
            this.button3.Text = "Ayuda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 650);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Autor: Grupo 9";
            // 
            // Ejercicio1
            // 
            this.ClientSize = new System.Drawing.Size(953, 727);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ejercicio1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInversa)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.Label lblFilas;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dgvEntrada;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvSalida;
        private System.Windows.Forms.DataGridView dgvInversa;
        private System.Windows.Forms.Label lblDiag1;
        private System.Windows.Forms.Label lblDiag2;
        private System.Windows.Forms.Label lblDiagInv1;
        private System.Windows.Forms.Label lblDiagInv2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}

