using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Luz_MVVM_2.Models
{
    public class ClienteModel : ModelBase
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; OnPropertyChanged("Nome"); }
        }
    }
}
