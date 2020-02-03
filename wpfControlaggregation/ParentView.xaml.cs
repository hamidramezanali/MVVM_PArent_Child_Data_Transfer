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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfControlaggregation
{
    /// <summary>
    /// Interaction logic for ParentView.xaml
    /// </summary>
    public partial class ParentView : UserControl
    {
        public ParentView()
        {
            InitializeComponent();
            ParentViewModel vm =(ParentViewModel) this.DataContext;
            UserControl2 uc2 = new UserControl2();
            uc2.DataContext = new ChildViewModel();
            st1.Children.Add(uc2);
            UserControl2 uc3 = new UserControl2();
            uc3.DataContext = new ChildViewModel(vm.mylaststring);
            st1.Children.Add(uc3);
        }
    }
}
