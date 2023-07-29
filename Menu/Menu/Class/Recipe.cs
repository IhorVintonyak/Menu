using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Class
{
    internal class Recipe
    {
        private string name;
        private string description;
        private string[] ingredients;
        private int preparationTime;

        public Recipe()
        {
            this.Name = "Unknown";
            this.Description = "Unknown";
            this.PreparationTime = 0;
        }

        public Recipe(string name, string description, string[] ingredients, int preparationTime)
        {
            this.Name = name;
            this.Description = description;
            this.Ingredients = ingredients;
            this.PreparationTime = preparationTime;
        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string[] Ingredients { get => ingredients; set => ingredients = value; }
        public int PreparationTime { get => preparationTime; set => preparationTime = value; }


    }
}
