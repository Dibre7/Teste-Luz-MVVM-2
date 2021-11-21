using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Luz_MVVM_2.Models
{
    
    public class FuncionarioModel : ModelBase //herda
    {
        private string nome;
        private string idade;
        private string setor;
        private string pis;

        public string Nome
        {
            get { return nome; }
            set { nome = value; OnPropertyChanged("Nome"); }
        }

        public string Idade
        {
            get { return idade; }
            set { idade = value; OnPropertyChanged("Idade"); }
        }
        public string Setor
        {
            get { return setor; }
            set { setor = value; OnPropertyChanged("Setor"); }
        }
        public string Pis
        {
            get { return pis; }
            set { pis = value; OnPropertyChanged("Pis"); }
        }
    }
}
