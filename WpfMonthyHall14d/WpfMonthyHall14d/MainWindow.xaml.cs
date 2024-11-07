using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfMonthyHall14d.mvvm.viewmodel;

namespace WpfMonthyHall14d
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MonthyViewModel();
        }

        private void minGomb_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowState=WindowState.Minimized;
        }

        private void maxGomb_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            } else
            {
                WindowState = WindowState.Maximized;
            }
        }

        private void closeGomb_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void rectHeader_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void buttonClick(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            var vm=DataContext as MonthyViewModel;
            var aktButton=(Button)sender;
            var buttonNum=aktButton.Content.ToString().Substring(0,1);
            var aktButtonPos = Convert.ToInt32(buttonNum)-1;
            bool isChange = false;

            if (vm.GameState == 0)
            {
                var nyitoPos=random.Next(0,vm.GameImages.Count);
                while (nyitoPos==vm.carPos || nyitoPos==aktButtonPos) {
                    nyitoPos = random.Next(0, vm.GameImages.Count);
                }

                if (nyitoPos == 0)
                {
                    vm.Door1.FrontImage.Source = vm.Door1.BackImage.Source;
                    ajto1.IsEnabled = false;
                    vm.selectedDoor = aktButtonPos;
                }
                else if (nyitoPos == 1) { 
                    vm.Door2.FrontImage.Source= vm.Door2.BackImage.Source;
                    ajto2.IsEnabled = false;
                    vm.selectedDoor = aktButtonPos;
                } else {
                    vm.Door3.FrontImage.Source = vm.Door3.BackImage.Source;
                    ajto3.IsEnabled = false;
                    vm.selectedDoor = aktButtonPos;
                }


            }

            if (vm.GameState == 1)
            {
                vm.Door1.FrontImage.Source = vm.Door1.BackImage.Source;
                vm.Door2.FrontImage.Source = vm.Door2.BackImage.Source;
                vm.Door3.FrontImage.Source = vm.Door3.BackImage.Source;

                if (aktButtonPos != vm.selectedDoor)
                {
                    isChange = true;
                }

                if (vm.carPos==aktButtonPos)
                {
                    //MessageBox.Show("Tiéd az autó");
                    vm.GameStatus = "Tiéd az autó!";
                    if (isChange) {
                        vm.WinWithChange++;
                        vm.Win++;
                    } else
                    {
                        vm.WinWithoutChange++;
                        vm.Win++;
                    }
                    
                } else
                {
                    //MessageBox.Show("Sajnos nem a tiéd az autó");
                    vm.GameStatus = "Sajnos nem a tiéd az autó!";
                    if (!isChange)
                    {
                        vm.LoseWithoutChange++;
                        vm.Lose++;
                    }
                    else
                    {
                        vm.LoseWithChange++;
                        vm.Lose++;
                    }
                }
                ajto1.IsEnabled = false;
                ajto2.IsEnabled = false;
                ajto3.IsEnabled = false;
            }

            vm.GameState = 1;
        }

        private void newGame_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as MonthyViewModel;
            vm.SetGame();
            vm.GameStatus = "";
            ajto1.IsEnabled = true;
            ajto2.IsEnabled = true;
            ajto3.IsEnabled = true;
        }
    }
}