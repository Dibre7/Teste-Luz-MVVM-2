using CommandMvvM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Teste_Luz_MVVM_2.Models;

namespace Teste_Luz_MVVM_2.ViewModels
{
    public class ViewModelDetalhe : ViewModelBase
    {
        public FuncionarioModel Funcionario { get; set; }
        public Command<Window> ConfirmarCommand { get; set; }

        public ViewModelDetalhe()
        {
            ConfirmarCommand = new Command<Window>(Confirmar);
        }

        private void Confirmar(Window obj)
        {
            obj.DialogResult = true; // definindo que o valor do Dialog seja verdadeiro

            obj.Close();
        }
    }
}
