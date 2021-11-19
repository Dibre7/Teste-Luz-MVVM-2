using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Teste_Luz_MVVM_2.ViewModels;

namespace Teste_Luz_MVVM_2
{
    /// <summary>
    /// Lógica interna para AdicionarView.xaml
    /// </summary>
    public partial class AdicionarView : Window
    {
        public AdicionarView(ViewModelDetalhe vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
