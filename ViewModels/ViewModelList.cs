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

        public ObservableCollection<ClienteModel> Clientes { get; set; }
        public Command AdicionarCommand { get; set; }
        public Command<ClienteModel> EditarCommand { get; set; }
        public Command<ClienteModel> RemoverCommand { get; set; }

        public ViewModelList()
        {
            Clientes = new ObservableCollection<ClienteModel>();
            AdicionarCommand = new Command(Adicionar);
            EditarCommand = new Command<ClienteModel>(Editar);
            RemoverCommand = new Command<ClienteModel>(Remover);
        }

        private void Remover(ClienteModel model)
        {
            Clientes.Remove(model);
        }

        private void Editar(ClienteModel model)
        {
            //temporário
            var temporario = new ClienteModel { Nome = model.Nome };

            var vm = new ViewModelDetalhe { Cliente = temporario };
            var view = new AdicionarView(vm);

            view.ShowDialog();

            if(view.DialogResult.HasValue && view.DialogResult == true)
            {
                model.Nome = temporario.Nome;
            }
        }

        private void Adicionar()
        {
            var vm = new ViewModelDetalhe { Cliente = new ClienteModel() };
            var view = new AdicionarView(vm);

            view.ShowDialog();

            Clientes.Add(vm.Cliente);
        }
    }
}
