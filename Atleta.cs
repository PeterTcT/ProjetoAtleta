using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private double altura;
        private double peso;
        private int idade;

        public string Nome { get => nome; set { if (value != string.Empty) { nome = value; } else { throw new Exception("O nome não pode ser vazio!"); } } }
        
        public double Altura { get => altura; set { if (value > 0) { altura = value; } else { throw new Exception("A altura não deve ser negativa!"); } } }
        public double Peso { get => peso; set { if (value > 0) { peso = value; } else { throw new Exception("O peso não deve ser negativo!"); } } }
        public int Idade { get => idade; set { if (value > 0) { idade = value; } else { throw new Exception("A idade não deve ser negativa!"); } } }

        public double CalculaIMC()
        {
            return peso / Math.Pow(altura, 2);
        }
    }
}
