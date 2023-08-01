using Menu.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListViewGridViewSample();
            /*
            string recipeName = "Carbonara";
            string recipeDescription = "Traditional Italian dish";
            //Ingredients have to be array
            string recipeIngredients = "Spaghetti, Tuorli ,Guanciale, Pecorino romano,Pepe nero";
            int recipeTime = 15;

            Recipe newRecipe = new Recipe(recipeName, recipeDescription, recipeIngredients, recipeTime);
            */

        }


        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {


            // TEST --- Recipe newRecipe = new Recipe("Carbonara", "Traditional Italian dish", "Spaghetti, Tuorli, Guanciale, Pecorino romano, Pepe nero", 15);
            
            //Create a object Recipe
            InitializeComponent();

            List<Recipe> items = (List<Recipe>)spRecipe.ItemsSource;
            items.Add(new Recipe { Name = tbFormName.Text, Description = tbFormDescription.Text, Ingredients = tbFormIngredients.Text, PreparationTime = int.Parse(tbFormTime.Text)});
            spRecipe.ItemsSource = items;

            //Update ListView
            ICollectionView view = CollectionViewSource.GetDefaultView(spRecipe.ItemsSource);
            view.Refresh();

        }

        public void ListViewGridViewSample()
        {
            InitializeComponent();
            List<Recipe> items = new List<Recipe>();
            items.Add(new Recipe() { Name = "John Doe", Description = "dasda", Ingredients = "carot", PreparationTime=15 });
            items.Add(new Recipe() { Name = "Jane Doe", Description = "gfdgdfg", Ingredients = "apple", PreparationTime = 10 });
            items.Add(new Recipe() { Name = "Sammy Doe", Description = "fsdfsd", Ingredients = "fish", PreparationTime = 8 });
            spRecipe.ItemsSource = items;
        }
    }
}
