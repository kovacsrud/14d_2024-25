using PropertyChanged;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WpfMonthyHall14d.mvvm.model;

namespace WpfMonthyHall14d.mvvm.viewmodel
{
    [AddINotifyPropertyChangedInterface]
    public class MonthyViewModel
    {
        string doorPath = Path.Combine(Environment.CurrentDirectory,"mvvm/pictures/base_door.jpg");
        string goatPath = Path.Combine(Environment.CurrentDirectory, "mvvm/pictures/base_goat.jpg");
        string carPath = Path.Combine(Environment.CurrentDirectory, "mvvm/pictures/base_car1.jpg");

        public int carPos;
        public int selectedDoor;

        public List<GameImage> GameImages { get; set; }= new List<GameImage>();
        public GameImage Door1 { get; set; }
        public GameImage Door2 { get; set; }
        public GameImage Door3 { get; set; }

        public int GameState { get; set; }

        public int Win { get; set; }
        public int WinWithChange { get; set; }
        public int WinWithoutChange { get; set; }
        public int Lose { get; set; }
        public int LoseWithChange { get; set; }
        public int LoseWithoutChange { get; set; }
        public string GameStatus { get; set; }

        Random random = new Random();

        public MonthyViewModel()
        {
            SetGame();
        }

        public void SetGame()
        {
            GameImages.Clear();

            GameImages.Add(new GameImage(
                new Image { Source=new BitmapImage(new Uri(doorPath)) },
                new Image { Source = new BitmapImage(new Uri(goatPath)) }));

            GameImages.Add(new GameImage(
                new Image { Source = new BitmapImage(new Uri(doorPath)) },
                new Image { Source = new BitmapImage(new Uri(goatPath)) }));

            GameImages.Add(new GameImage(
                new Image { Source = new BitmapImage(new Uri(doorPath)) },
                new Image { Source = new BitmapImage(new Uri(goatPath)) }));

            GameState = 0;
            carPos=random.Next(0,GameImages.Count);
            GameImages[carPos].BackImage.Source=new BitmapImage(new Uri(carPath));

            Door1 = GameImages[0];
            Door2 = GameImages[1];
            Door3 = GameImages[2];

        }
    }
}
