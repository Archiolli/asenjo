using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANCO
{
    class ClassC
    {
        public int saldo;

        public ClassC(int saldo)
        {
            this.saldo = saldo;
        }
        public double getSaldo()
        {
            return this.saldo;
        }

        public void setSaldo(int saldo)
        {
            this.saldo = saldo;
        }
    }
}
