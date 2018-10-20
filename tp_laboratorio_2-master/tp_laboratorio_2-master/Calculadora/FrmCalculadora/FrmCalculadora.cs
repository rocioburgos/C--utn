using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace FrmCalculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
            cmbOperar.Items.Add("+");
            cmbOperar.Items.Add("-");
            cmbOperar.Items.Add("*");
            cmbOperar.Items.Add("/");
            this.cmbOperar.SelectedItem = "+";
            this.cmbOperar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Calculadora calculadora = new Calculadora();


            Numero numeroUno = new Numero(this.txtNumero1.Text);
            Numero numeroDos = new Numero(this.txtNumero2.Text);
            string operador = cmbOperar.Text;

            double resultado = calculadora.Operar(numeroUno, numeroDos, operador);

           resultado=Math.Round(resultado, 2);
            this.label1.Text = resultado.ToString();

            
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.label1.Text = "";
            this.cmbOperar.SelectedItem = "+";
        }
    }
}
