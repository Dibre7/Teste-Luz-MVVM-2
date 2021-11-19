using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Luz_MVVM_2.Models
{
    public class IdadeModel : ModelBase
    {
        private string idade;

        public string Idade
        {
            get { return idade; }
            set { idade = value; OnPropertyChanged("Idade"); }
        }
    }
}
