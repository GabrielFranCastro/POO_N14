using System;
using System.Windows.Forms;

namespace AppLista3
{
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float valorCompra = float.Parse(txtVlrCompra.Text);
            float valorEntrada = float.Parse(txtVlrEntrada.Text);
            int numParcelas = int.Parse(txtNparcelas.Text);
            float valorparcela;

            valorparcela = (valorCompra - valorEntrada) / numParcelas;


            lblResultado.Text = "O valor de parcelas será: " + valorparcela;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVlrCompra.Clear();
            txtVlrEntrada.Clear();
            txtNparcelas.Clear();
            lblResultado.Text = "";
        }
    }
}
