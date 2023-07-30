using Menu.Class;
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
            //Create a StackPanel and put it on the grid.(1,1)
            StackPanel dynamicStackPanel = new StackPanel();
               

            // TEST --- Recipe newRecipe = new Recipe("Carbonara", "Traditional Italian dish", "Spaghetti, Tuorli, Guanciale, Pecorino romano, Pepe nero", 15);
            //Create a object Recipe and upload a textblocks
            Recipe newRecipe = new Recipe(tbFormName.Text, tbFormDescription.Text, tbFormIngredients.Text, int.Parse(tbFormTime.Text));
            var bc = new BrushConverter();
            spRecipe.Background = (Brush)bc.ConvertFrom("#FFFFFF");
            tbName.Text = newRecipe.Name;
            tbDescription.Text = newRecipe.Description;
            tbIngredients.Text = newRecipe.Ingredients;
            tbTime.Text = newRecipe.PreparationTime.ToString();
        }
    }
}
