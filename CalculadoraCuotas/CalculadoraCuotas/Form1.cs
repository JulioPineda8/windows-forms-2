namespace CalculadoraCuotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtMonto.Text);
            double interes = double.Parse(txtInteres.Text);
            double plazo = double.Parse(txtCuotas.Text);
            interes = interes / 100;

            double cuotaMensual = (monto * (interes * Math.Pow(1 + interes, plazo))) / (Math.Pow(1 + interes, plazo) - 1);
            cuotaMensual = Math.Round(cuotaMensual, 2);
            txtResultado.Text = cuotaMensual.ToString();
        }
    }
}
