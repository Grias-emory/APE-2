using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo9_Ape2_ManejoDeMatrices
{
    public partial class Ejercicio1 : Form
    {
        private double[,] matriz;

        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void InicializarDataGridViewEntrada(int filas, int columnas)
        {
            dgvEntrada.ColumnCount = columnas;
            dgvEntrada.RowCount = filas;

            for (int i = 0; i < columnas; i++)
                dgvEntrada.Columns[i].Width = 40;

            for (int i = 0; i < filas; i++)
                dgvEntrada.Rows[i].Height = 30;
        }

        private void IngresarValoresDesdeDataGridView()
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (double.TryParse(dgvEntrada.Rows[i].Cells[j].Value?.ToString(), out double valor))
                        matriz[i, j] = valor;
                    else
                        matriz[i, j] = 0;
                }
            }
        }

        private void ImprimirMatrizEnDataGridView(DataGridView dgv, double[,] mat)
        {
            int filas = mat.GetLength(0);
            int columnas = mat.GetLength(1);

            dgv.ColumnCount = columnas;
            dgv.RowCount = filas;

            for (int i = 0; i < columnas; i++)
                dgv.Columns[i].Width = 40;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    dgv.Rows[i].Cells[j].Value = mat[i, j].ToString("0.##");
                }
            }
        }

        private double[,] CalcularInversa(double[,] matriz)
        {
            int n = matriz.GetLength(0);
            double[,] resultado = new double[n, n];
            double[,] temp = (double[,])matriz.Clone();
            double[,] identidad = new double[n, n];

            for (int i = 0; i < n; i++)
                identidad[i, i] = 1;

            for (int i = 0; i < n; i++)
            {
                double divisor = temp[i, i];
                if (divisor == 0) throw new InvalidOperationException("La matriz no es invertible.");

                for (int j = 0; j < n; j++)
                {
                    temp[i, j] /= divisor;
                    identidad[i, j] /= divisor;
                }

                for (int k = 0; k < n; k++)
                {
                    if (k == i) continue;
                    double factor = temp[k, i];
                    for (int j = 0; j < n; j++)
                    {
                        temp[k, j] -= factor * temp[i, j];
                        identidad[k, j] -= factor * identidad[i, j];
                    }
                }
            }

            return identidad;
        }

        private double SumarDiagonalPrincipal(double[,] matriz)
        {
            int min = Math.Min(matriz.GetLength(0), matriz.GetLength(1));
            double suma = 0;
            for (int i = 0; i < min; i++)
                suma += matriz[i, i];
            return suma;
        }

        private double SumarDiagonalSecundaria(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double suma = 0;
            for (int i = 0; i < Math.Min(filas, columnas); i++)
                suma += matriz[i, columnas - 1 - i];
            return suma;
        }

        

        

        

        

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFilas.Text, out int filas) &&
                int.TryParse(txtColumnas.Text, out int columnas) &&
                filas > 0 && columnas > 0)
            {
                matriz = new double[filas, columnas];
                InicializarDataGridViewEntrada(filas, columnas);
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para filas y columnas.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (matriz == null)
            {
                MessageBox.Show("Primero crea la matriz.");
                return;
            }

            IngresarValoresDesdeDataGridView();
            ImprimirMatrizEnDataGridView(dgvSalida, matriz);


        }

        private void LimpiarMatrices()
        {
            dgvEntrada.Columns.Clear();
            dgvEntrada.Rows.Clear();
            dgvSalida.Columns.Clear();
            dgvSalida.Rows.Clear();
            dgvInversa.Columns.Clear();
            dgvInversa.Rows.Clear();

            lblDiag1.Text="";
            lblDiag2.Text = "";
            lblDiagInv1.Text = "";
            lblDiagInv2.Text = "";

            txtFilas.Clear();
            txtColumnas.Clear();

            matriz = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarMatrices();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (matriz == null)
            {
                MessageBox.Show("Primero crea la matriz.");
                return;
            }

            IngresarValoresDesdeDataGridView();
            ImprimirMatrizEnDataGridView(dgvSalida, matriz);

            lblDiag1.Text = $"Suma de la Diagonal Principal de la Matriz Normal: {SumarDiagonalPrincipal(matriz):0.##}";
            lblDiag2.Text = $"Suma de la Diagonal Secundaria de la Matriz Normal: {SumarDiagonalSecundaria(matriz):0.##}";

            // Solo si es cuadrada
            if (matriz.GetLength(0) == matriz.GetLength(1))
            {
                try
                {
                    double[,] inversa = CalcularInversa(matriz);
                    ImprimirMatrizEnDataGridView(dgvInversa, inversa);
                    lblDiagInv1.Text = $"Suma de la Diagonal Principal de la Matriz Invertida: {SumarDiagonalPrincipal(inversa):0.##}";
                    lblDiagInv2.Text = $"Suma de la Diagonal Secundaria de la Matriz Invertida: {SumarDiagonalSecundaria(inversa):0.##}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al calcular la inversa: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("La matriz no es cuadrada, no se puede invertir.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Abre Form2
            Portada portada = new Portada();
            portada.ShowDialog();

            // Muestra de nuevo Form1 cuando se cierre Form2
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mensaje = "INSTRUCCIONES DE USO - EJERCICIO - MANEJO DE MATRICES\n\n" +
                     "1. Ingrese el número de filas y columnas en los campos correspondientes.\n" +
                     "2. Haga clic en el botón 'Crear' para generar la estructura de la matriz de entrada.\n" +
                     "3. Ingrese los valores numéricos dentro del DataGridView generado.\n" +
                     "4. Haga clic en el botón 'Guardar e Imprimir' para:\n" +
                     "   - Almacenar los valores en una matriz interna.\n" +
                     "   - Mostrar la matriz original.\n" +
                     "5. Haga clic en el botón 'Calcular' para:\n" +
                     "   - Calcular y mostrar la matriz inversa (solo si es posible).\n" +
                     "   - Mostrar las sumas de las diagonales principales y \n" +
                     "     secundarias de ambas matrices (original e inversa).\n" +
                     "6. Puede hacer clic en el botón 'Limpiar' para reiniciar el formulario.\n" +
                     "7. Puede hacer clic en el botón 'Regresar' para regresar ala pagina principal.\n\n" +
                     "Nota: Para invertir la matriz, esta debe ser cuadrada (misma cantidad de filas y columnas) " +
                     "y no debe ser singular (es decir, debe tener determinante distinto de cero).";

            MessageBox.Show(mensaje, "Ayuda - Ejercicio1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

