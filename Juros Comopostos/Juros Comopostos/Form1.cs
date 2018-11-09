using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juros_Comopostos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float capitalInicial;
        Double tempo;
        Double montante;
        Double taxa;

        private void lblMontante_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ObterDados();
            montante = capitalInicial *Math.Pow((1+taxa/100),tempo);
            lblResultado.Text = montante.ToString();
            MessageBox.Show("Calculado Montante: " + montante);
            LimparDados();
        }

        void ObterDados()
        {
            capitalInicial = float.Parse(tbxCapital.Text);
            tempo = Convert.ToDouble(tbxTempo.Text);
            taxa = Convert.ToDouble(tbxTaxa.Text);


        }
        void LimparDados()
        {
            tbxCapital.Text = "";
            tbxTaxa.Text = "";
            tbxTempo.Text = "";

        }

    }
}
