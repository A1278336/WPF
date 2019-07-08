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

namespace AutoCreateDataGrid
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        int rowNum = 0;
        int columnNum = 0;
        IList<int> CellList = new List<int>{1,2};
        
        
        public string RowNum { get; set; }
        public string ColumnNum { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateDataGrid(int row, int column)
        {
            for (int i = 0; i < column; i++)
            {
                DataGridTemplateColumn item = new DataGridTemplateColumn();
                item.CellTemplate = new DataTemplate();
                Binding dgBinding = new Binding(String.Format("CellList[{0}]",i));
                createDataGrid.SetBinding(DataGrid.ItemsSourceProperty, dgBinding);
                item.Header = i;
                item.MinWidth = 45;
                createDataGrid.Columns.Add(item);
                createDataGrid.ItemsSource = CellList;

            }
            
            MessageBox.Show("DataGrid作成します。", "", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RowNum = this.NameOfColumn.Text;
            ColumnNum = this.NameOfColumn.Text;
            if(RowNum != null && ColumnNum != null)
            {
                if (int.TryParse(RowNum, out rowNum) && int.TryParse(ColumnNum, out columnNum))
                {
                    CreateDataGrid(rowNum, columnNum);
                    
                }
                else
                {
                    MessageBox.Show("数値を入力してくだい！","確認",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
        }
    }
}
