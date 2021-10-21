using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankInter.Funcinários
{
    public class Diretor
    {
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public double Salario { get; set; }


            public double GetBonificacao()
            {
                return Salario * 1;
            }
        
    }
}
