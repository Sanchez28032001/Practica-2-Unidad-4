namespace Practica_2_Unidad_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            desactivarControles();
        }
        private Double monto;

        private void activarControles()
        {
            txtCliente.Enabled = false;
            txtMonto.Enabled = false;
            button1.Enabled = false;

            button2.Enabled = true;
            button3.Enabled = true;

        }

        private void desactivarControles()
        {
            txtCliente.Enabled = true;
            txtMonto.Enabled = true;
            button1.Enabled = true;

            button2.Enabled = false;
            button3.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cliente;

            cliente = txtCliente.Text;
            monto = Convert.ToDouble(txtMonto.Text);

            if (monto > 0)
            {
                activarControles();
            }
            else
            {
                MessageBox.Show("El monto debe ser mayor que cero", "Gestion de ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Double leer(string mensaje)
        {
            Double cantidad;
            cantidad = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese monto a " + mensaje, "Gestion de ahorros ", "0", 100, 0));
            return cantidad;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double deposito;
            deposito = leer("Depositar");
            monto = monto + deposito;
            listBox1.Items.Add(deposito);
            mostrar();

        }
        private void mostrar()
        {
            txtSaldo.Text = Convert.ToString(monto);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double retiro;
            retiro = leer("Retirar");

            if (retiro <= monto)
            {
                monto = monto - retiro;
                listBox2.Items.Add(retiro);
                mostrar();
            }
            else
            {
                MessageBox.Show("La cantidad de retiro es mayor al monto disponible", "Gestion de ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtMonto.Clear();
            txtSaldo.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            desactivarControles();
        }
    }
}