using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls;

namespace AutoPointUA.ViewModels
{
    public class AnnouncementViewModel
    {
        public ObservableCollection<Car> Cars { get; set; }
        public ICommand SelectCommand { get; }

        public AnnouncementViewModel()
        {
            Cars = new ObservableCollection<Car>
                {
                    new Car { Name = "Toyota Corolla", Year = 2020, Mileage = 50000, Price = 450000, ImageURL = "/Assets/Image/Toyota.jpg" },
                    new Car { Name = "Honda Civic", Year = 2019, Mileage = 60000, Price = 470000, ImageURL = "/Assets/Image/Honda.jpg" },
                    new Car { Name = "Ford Focus", Year = 2021, Mileage = 30000, Price = 500000, ImageURL = "/Assets/Image/Ford.jpg" },
                    new Car { Name = "BMW 3 Series", Year = 2018, Mileage = 70000, Price = 750000, ImageURL = "/Assets/Image/BMW.jpg" },
                    new Car { Name = "Audi A4", Year = 2020, Mileage = 45000, Price = 800000, ImageURL = "/Assets/Image/Audi.jpg" },
                    new Car { Name = "Mercedes-Benz C-Class", Year = 2019, Mileage = 55000, Price = 900000, ImageURL = "/Assets/Image/MercedesBenz.jpg" },
                    new Car { Name = "Nissan Altima", Year = 2021, Mileage = 35000, Price = 480000, ImageURL = "/Assets/Image/Nissan.jpg" },
                    new Car { Name = "Mazda 6", Year = 2019, Mileage = 50000, Price = 500000, ImageURL = "/Assets/Image/Mazda.jpg" },
                    new Car { Name = "Chevrolet Malibu", Year = 2020, Mileage = 40000, Price = 520000, ImageURL = "/Assets/Image/Chevrolet.jpg" },
                    new Car { Name = "Volkswagen Passat", Year = 2018, Mileage = 65000, Price = 600000, ImageURL = "/Assets/Image/Volkswagen.jpg" },
                    new Car { Name = "Volvo S60", Year = 2019, Mileage = 50000, Price = 850000, ImageURL = "/Assets/Image/Volvo.jpg" },
                    new Car { Name = "Tesla Model 3", Year = 2021, Mileage = 25000, Price = 1200000, ImageURL = "/Assets/Image/Tesla.jpg" },
                    new Car { Name = "Lexus IS", Year = 2020, Mileage = 40000, Price = 950000, ImageURL = "/Assets/Image/Lexus.jpg" },
                    new Car { Name = "Jeep Grand Cherokee", Year = 2019, Mileage = 60000, Price = 1100000, ImageURL = "/Assets/Image/Jeep.jpg" },
                    new Car { Name = "Porsche 911", Year = 2017, Mileage = 70000, Price = 2500000, ImageURL = "/Assets/Image/Porsche.jpg" },
                    new Car { Name = "Ferrari F8", Year = 2022, Mileage = 10000, Price = 5000000, ImageURL = "/Assets/Image/Ferrari.jpg" },
                    new Car { Name = "Lamborghini Huracan", Year = 2021, Mileage = 15000, Price = 7000000, ImageURL = "/Assets/Image/Lamborghini.jpg" }
                };

            SelectCommand = new RelayCommand<Car>(SelectCar);
        }

        private void SelectCar(Car selectedCar)
        {
            // Логіка вибору автомобіля
            var dialog = new ContentDialog
            {
                Title = "Вибір автомобіля",
                Content = $"Ви обрали: {selectedCar.Name} ({selectedCar.Year})",
                CloseButtonText = "ОК"
            };
            _ = dialog.ShowAsync();
        }
    }

    public class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
    }

    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _execute;
        private readonly Func<T, bool> _canExecute;

        public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => _canExecute == null || _canExecute((T)parameter);

        public void Execute(object parameter) => _execute((T)parameter);
    }
}
