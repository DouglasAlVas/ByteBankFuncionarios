using ByteBankInter.Funcinários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankInter
{
    class GerenciadorBonificacao
    {
        private double _totalBonificacao = 0;
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public void Registrar (Diretor diretor)
        {
            _totalBonificacao += diretor.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
