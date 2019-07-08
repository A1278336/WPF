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

namespace MultiDataGrid
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        IList<Vmodel> vmodelsList = new List<Vmodel>
        {
            new Vmodel{AAAA="1111",aaaa="2222",BBBB="3333",bbbb="4444"}
            ,new Vmodel{AAAA="0001",aaaa="0002",BBBB="0003",bbbb="0004"}
        };


        public MainWindow()
        {
            InitializeComponent();
            this.datagrid_1.ItemsSource = vmodelsList;
        }

        class Vmodel
        {
            public string AAAA { get; set; }
            public string aaaa { get; set; }
            public string BBBB { get; set; }
            public string bbbb { get; set; }
        }
    }
}
