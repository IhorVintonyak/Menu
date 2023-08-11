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
            items.Add(new Recipe() { Name = "Spaghetti all'Amatriciana", Description = "Famoso primo piatto nato ad Amatrice fosse il pasto principale dei pastori, ma originariamente era senza pomodoro e prendeva il nome di “gricia”.", Ingredients = "Spaghetti , Guanciale, Vino bianco, Pomodori pelati, Pecorino romano", PreparationTime= 10 });
            items.Add(new Recipe() { Name = "Gnocchi alla sorrentina", Description = "gnocchi così amato è il mix di sapori mediterranei, genuini e semplici", Ingredients = "Patate rosse , Uova, Farina, Passata di pomodoro, Basilico ", PreparationTime = 30 });
            items.Add(new Recipe() { Name = "Risotto al telefono", Description = ". Si ispira ad un piatto tipico della cucina laziale: i supplì al telefono.", Ingredients = "Riso vialone nano, Passata di pomodoro, Scalogno, Mozzarella ", PreparationTime = 8 });
            spRecipe.ItemsSource = items;
 
        }
    }
}
