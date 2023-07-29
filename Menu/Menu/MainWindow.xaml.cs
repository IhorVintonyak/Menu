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


            string recipeName = "Carbonara";
            string recipeDescription = "Traditional Italian dish";
            string[] recipeIngredients = { "Spaghetti", "Tuorli ", "Guanciale", "Pecorino romano", "Pepe nero" };
            int recipeTime = 15;

            Recipe newRecipe = new Recipe(recipeName, recipeDescription, recipeIngredients, recipeTime);


            var bc = new BrushConverter();
            spRecipe.Background = (Brush)bc.ConvertFrom("#FFFFFF");
            tbName.Text = newRecipe.Name;
            tbDescription.Text = newRecipe.Description;
            tbIngredients.Text = newRecipe.Ingredients[0];
            tbTime.Text = newRecipe.PreparationTime.ToString();
        }
    }
}
