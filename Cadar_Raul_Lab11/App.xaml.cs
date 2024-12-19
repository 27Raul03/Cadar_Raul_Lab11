using Cadar_Raul_Lab11.Data;


namespace Cadar_Raul_Lab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }

        public App()
        {
            InitializeComponent();

            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());

        }
    }
}
