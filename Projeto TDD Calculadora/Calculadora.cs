using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_TDD_Calculadora
{
    public class Calculadora
    {
        private List<string> Historico = new List<string>();
        private string data;

        public Calculadora(string data)
        {
            this.data = data;
        }

        public int Somar (int n1, int n2)
        {
            Historico.Insert(0,"Soma realizada. Data: " + data);
            return n1 + n2;
        }

        public int Subtrair (int n1, int n2)
        {
            Historico.Insert(0, "Subtrãção realizada. Data: " + data);
            return n1 - n2;
        }

        public int Multiplicar (int n1, int n2)
        {
            Historico.Insert(0, "Multiplicação realizada. Data: " + data);
            return n1 * n2;
        }

        public int Dividir (int n1, int n2)
        {
            Historico.Insert(0, "Divisão realizada. Data: " + data);
            return n1 / n2;
        }

        public List<string> ListarHistorico ()
        {
            return Historico.GetRange(0, 3);
        }
    }
}
