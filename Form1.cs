using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Form1 : Form
    {
        Atleta atleta = new Atleta();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            validadores(txt_nome.Text,txt_idade.Text,txt_peso.Text,txt_altura.Text);
        }


        void validadores(String nome,String idade,string peso,String altura)
        {

            try
            {
                atleta.Nome = nome;
                atleta.Idade = int.Parse(idade);
                atleta.Peso = double.Parse(peso);
                atleta.Altura = double.Parse(altura);
                lbl_imc.Text ="IMC: " + atleta.CalculaIMC().ToString("F5");
            }
            catch(NotFiniteNumberException)
            {
                MessageBox.Show("Insira valores que sejam números!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
