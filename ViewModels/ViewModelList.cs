using CommandMvvM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_Luz_MVVM_2.Models;

namespace Teste_Luz_MVVM_2.ViewModels
{
    public class ViewModelList : ViewModelBase
    {

        public ObservableCollection<FuncionarioModel> Funcionarios { get; set; }
        public Command AdicionarCommand { get; set; }
        public Command<FuncionarioModel> EditarCommand { get; set; }
        public Command<FuncionarioModel> RemoverCommand { get; set; }

        public ViewModelList()
        {
            Funcionarios = new ObservableCollection<FuncionarioModel>();
            AdicionarCommand = new Command(Adicionar);
            EditarCommand = new Command<FuncionarioModel>(Editar);
            RemoverCommand = new Command<FuncionarioModel>(Remover);
        }

        private void Remover(FuncionarioModel model)
        {
            Funcionarios.Remove(model);
        }

        private void Editar(FuncionarioModel model)
        {
            //temporário
            var temporario = new FuncionarioModel { Nome = model.Nome , Idade = model.Idade, Setor = model.Setor, Pis = model.Pis};
              
            var vm = new ViewModelDetalhe { Funcionario = temporario };
            var view = new AdicionarView(vm);

            view.ShowDialog();

            if(view.DialogResult.HasValue && view.DialogResult == true) //verificar se concluiu
            {
                model.Nome = temporario.Nome;
                model.Idade = temporario.Idade;
                model.Setor = temporario.Setor;
                model.Pis = temporario.Pis;
            }
        }

        private void Adicionar()
        {

            var vm = new ViewModelDetalhe { Funcionario = new FuncionarioModel() }; //Instanciar a ViewModel Base
            var view = new AdicionarView(vm);                               //Instanciar a janela

            view.ShowDialog();

            Funcionarios.Add(vm.Funcionario);
        }
    }
}
