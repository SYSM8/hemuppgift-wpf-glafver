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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RowInput.Text) || string.IsNullOrWhiteSpace(ColumnInput.Text))
            {
                MessageBox.Show("Please enter values for both row and column.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!int.TryParse(RowInput.Text, out int row) || !int.TryParse(ColumnInput.Text, out int column))
            {
                MessageBox.Show("Please enter valid numeric values for row and column.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                RowInput.Clear();
                ColumnInput.Clear();
                return;
            }

            if (row >= 0 && row < DynamicGrid.RowDefinitions.Count &&
                column >= 0 && column < DynamicGrid.ColumnDefinitions.Count)
            {
                Button gridButton = new Button
                {
                    Content = $"Row {row}, Column {column}",
                    Background = Brushes.LightGreen,
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalAlignment = VerticalAlignment.Stretch,
                    Name = "btnGrid"
                };

                DynamicGrid.Children.Clear();
                Grid.SetRow(gridButton, row);
                Grid.SetColumn(gridButton, column);
                DynamicGrid.Children.Add(gridButton);

                RowInput.Clear();
                ColumnInput.Clear();
            }
            else
            {
                MessageBox.Show("Row or column is outside the grid's bounds.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                RowInput.Clear();
                ColumnInput.Clear();
            }
        }

    }
}
