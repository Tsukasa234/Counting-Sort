namespace CountingSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvOrdenar.Columns.Add("Number", "Número");
        }

        //int numero;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Leer el número del TextBox como string
            string input = txtNumero.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                // Agregar el número como una nueva fila al DataGridView
                dgvOrdenar.Rows.Add(input);
                txtNumero.Clear(); // Limpiar el TextBox
                txtNumero.Focus(); // Enfocar de nuevo el TextBox
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Obtener los números del DataGridView
            string[] arr = dgvOrdenar.Rows
                .Cast<DataGridViewRow>()
                .Where(row => row.Cells[0].Value != null)
                .Select(row => row.Cells[0].Value.ToString())
                .ToArray();

            int[] intArr = Array.ConvertAll(arr, int.Parse);
            CountingSort(intArr);

            // Limpiar el DataGridView y volver a agregar los números ordenados
            dgvOrdenar.Rows.Clear();
            foreach (var number in intArr)
            {
                dgvOrdenar.Rows.Add(number.ToString());
            }
        }

        private void CountingSort(int[] arr)
        {
            if (arr.Length == 0) return;

            int max = arr.Max();
            int[] count = new int[max + 1];

            // Contar ocurrencias
            foreach (var number in arr)
            {
                count[number]++;
            }

            // Calcular posiciones acumulativas
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            // Construir la lista ordenada
            int[] sortedArr = new int[arr.Length];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                sortedArr[count[arr[i]] - 1] = arr[i];
                count[arr[i]]--;
            }

            // Copiar la lista ordenada al arreglo original
            Array.Copy(sortedArr, arr, arr.Length);
        }
    }
}
