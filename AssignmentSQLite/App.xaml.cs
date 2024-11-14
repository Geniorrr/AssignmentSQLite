using AssignmentSQLite.Repository;
using AssignmentSQLite.view;
using Microsoft.Maui.Controls;

namespace AssignmentSQLite
    {
        public partial class App : Application
        {
            public static CarRepository _carRepo { get; private set; }

            public App()
            {
                InitializeComponent();
                _carRepo = new CarRepository();

                MainPage = new CarPage();
            }
        }
    }
