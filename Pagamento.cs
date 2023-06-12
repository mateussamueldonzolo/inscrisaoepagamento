using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLP_P1
{
    class Pagamento
    {
        private string _pagar { get; set; }

        private string _mesesPagos;

        public string MesesPagos
        {
            get { return _mesesPagos; }
            set { _mesesPagos = value; }
        }
    }
}
