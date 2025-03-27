using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3_EPI_Funcionario
{
    public partial class appForm3 : Form
    {
        public appForm3()
        {
            InitializeComponent();
        }

        private void CalcularBnt_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = nomeTxt.Text;
                int faltas = Convert.ToInt32(faltasTxt.Text);
                int salario = Convert.ToInt32(salarioTxt.Text);
                salarioFinalTxt.Text = "";

                if (checkEPI.Checked == true)
                {
                    int salarioFinal = salario + 500;
                    salarioFinalTxt.Text = $"";
                    salarioFinalTxt.Text = $"{salarioFinal}";
                    MessageBox.Show($"Nome: {nome} \n Faltas: {faltas} \n Salário: {salario} \n Salario final: {salarioFinal} \n Continue usando o EPI!");
                    return;

                }
                else
                {
                    int salarioFinal = salario;
                    salarioFinalTxt.Text = $"";
                    salarioFinalTxt.Text = $"{salarioFinal}";
                    MessageBox.Show($"Nome: {nome} \n Faltas: {faltas} \n Salário: {salario} \n Salario final: {salarioFinal} \n Favor utilizar o EPI...");
                    return;
                }
            }
            catch (Exception error)
            {
                salarioFinalTxt.Text = $"";
                MessageBox.Show("Houve um erro " + error);
            }
        }
    }
}
