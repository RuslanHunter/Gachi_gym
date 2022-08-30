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

namespace Gachi_gym
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void DataGridGachi_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {

        }

        private void Button_add(object sender, RoutedEventArgs e)
        {
            var ListOfGachi = new List<GachiDB>();

            var GachiMen = new GachiDB()
            {
                Exercise_id = Convert.ToInt32(id_tb.Text),
                ExerciseName = Nametb.Text,
                IsDone = false,
                Repetition = Convert.ToInt32(Repetition_tb.Text),
                Approach = Convert.ToInt32(Approach_tb.Text) 
            };
            ListOfGachi.Add(GachiMen);
            
            DataGridGachi.ItemsSource = ListOfGachi;
        }

        private void Button_del(object sender, RoutedEventArgs e)
        {
            var ListOfGachi = new List<GachiDB>();
            if (DataGridGachi.SelectedItem is GachiDB selectedgachi)
            {
                GachiDB gac = ListOfGachi.Where(c => c.Exercise_id == selectedgachi.Exercise_id).First();
            }
        }

        private void Button_red(object sender, RoutedEventArgs e)
        {
            var ListOfGachi = new List<GachiDB>();
            if (DataGridGachi.SelectedItem is GachiDB selectedgachi)
            {
                var GachiMen = new GachiDB()
                {
                    Exercise_id = Convert.ToInt32(id_tb.Text),
                    ExerciseName = Nametb.Text,
                    IsDone = false,
                    Repetition = Convert.ToInt32(Repetition_tb.Text),
                    Approach = Convert.ToInt32(Approach_tb.Text)
                };
                ListOfGachi.Add(GachiMen);
            }
        }
    }
}
