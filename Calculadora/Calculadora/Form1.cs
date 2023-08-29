using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1 = 0,valor2= 0;
        string operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "0"; 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            TxtResultado.Text += "9";
        }

        private void btndot_Click(object sender, EventArgs e)
        { 
             TxtResultado.Text += ".";
        }

        private void btnequals_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(TxtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                TxtResultado.Text = Convert.ToString(valor1+valor2);
                operacao = "";
                labelUltimoNumero.Text = "";
            }
            if(operacao == "SUB")
            {
                TxtResultado.Text = Convert.ToString(valor1 - valor2);
                operacao = "";
                labelUltimoNumero.Text = "";
            }
            if (operacao == "MULT")
            {
                TxtResultado.Text = Convert.ToString(valor1 * valor2);
                operacao = "";
                labelUltimoNumero.Text = "";
            }
            if (operacao == "DIV")
            {
                TxtResultado.Text = Convert.ToString(valor1 / valor2);
                operacao = "";
                labelUltimoNumero.Text = "";
            }
            if(operacao == "QUADRADO")
            {
                TxtResultado.Text = Convert.ToString(Math.Pow(valor1,valor2));
                operacao = "";
                labelUltimoNumero.Text = "";
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToDouble(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "SUB";
                labelUltimoNumero.Text = Convert.ToString(valor1);
                labelUltimoNumero.Text += "-";  
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro,não clique duas vezes seguidas! \nNão sei como resolver!!", "Deu ruim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToDouble(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "MULT";
                labelUltimoNumero.Text = Convert.ToString(valor1);
                labelUltimoNumero.Text += "X";
            }
            catch(Exception error)
            {
                MessageBox.Show("Erro,não clique duas vezes seguidas! \nNão sei como resolver!!", "Deu ruim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToDouble(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "DIV";
                labelUltimoNumero.Text = Convert.ToString(valor1);
                labelUltimoNumero.Text += "/";
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro,não clique duas vezes seguidas! \nNão sei como resolver!!", "Deu ruim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = 0;
                operacao = "";
                TxtResultado.Text = "";
                labelUltimoNumero.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro,não clique duas vezes seguidas! \nNão sei como resolver!!", "Deu ruim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = "";
        }

        private void btnquare_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToDouble(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "QUADRADO";
                labelUltimoNumero.Text = Convert.ToString(valor1);
                labelUltimoNumero.Text += "^";
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro,não clique duas vezes seguidas! \nNão sei como resolver!!", "Deu ruim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnsqurt_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToDouble(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = Convert.ToString(Math.Sqrt(valor1));
                labelUltimoNumero.Text = "";
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro,não clique duas vezes seguidas! \nNão sei como resolver!!", "Deu ruim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = Convert.ToDouble(TxtResultado.Text, CultureInfo.InvariantCulture);
                TxtResultado.Text = "";
                operacao = "SOMA";
                labelUltimoNumero.Text = Convert.ToString(valor1);
                labelUltimoNumero.Text += "+";
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro,não clique duas vezes seguidas! \nNão sei como resolver!!", "Deu ruim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
