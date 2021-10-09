using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Basica_P1 {
    public partial class Calculadora_Basica : Form {
        public Calculadora_Basica() {
            InitializeComponent();
        }

        // Fields
        private float x;
        private float y;
        private float result;

        //Tratamento do inputs
        private void txt_Inputs(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '.') {
                e.KeyChar = ',';
            }

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',');

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1)) {
                e.Handled = true;
            }
        }

        // Pegar os valores dos inputs
        private void GetValues() {
            x = float.Parse(txt_FirstNumber.Text);
            y = float.Parse(txt_SecondNumber.Text);
        }

        // Mostrar resultado
        private void ShowResult(float x, float y, float res, string op) {
            MessageBox.Show($"{x} {op} {y} = {res}", "Resultado da Operação");
        }

        // Selecionar a operação e realizá-la
        private void btn_Calculate_Click(object sender, EventArgs e) {
            GetValues();

            if (rd_Addition.Checked) {
                result = x + y;
                ShowResult(x, y, result, "+");
            } else if (rd_Subtraction.Checked) {
                result = x - y;
                ShowResult(x, y, result, "-");
            } else if (rd_Multiplication.Checked) {
                result = x * y;
                ShowResult(x, y, result, "x");
            } else if (rd_Division.Checked) {
                if (y != 0) {
                    result = x / y;
                    ShowResult(x, y, result, "÷");
                } else {
                    MessageBox.Show("Não é possível realizar uma divisão por zero!", "ERROR");
                }
                
            } else {
                MessageBox.Show("Operação Inválida :(","Erro");
            }
        }

        // Limpar inputs
        private void btn_Clean_Click(object sender, EventArgs e) {
            txt_FirstNumber.Text = "";
            txt_SecondNumber.Text = "";
        }
    }
}
