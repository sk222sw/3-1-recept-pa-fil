using FiledRecipes.Domain;
using FiledRecipes.App.Mvp;
using FiledRecipes.Properties;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FiledRecipes.Views
{
    /// <summary>
    /// 
    /// </summary>
    public class RecipeView : ViewBase, IRecipeView
    {
        public void Show(IRecipe recipe)
        {
            Console.Clear();
            Header = recipe.Name;
            ShowHeaderPanel();
            Console.WriteLine();
            Console.WriteLine("Ingredienser");
            Console.WriteLine("-------------");
            foreach (IIngredient ingredients in recipe.Ingredients)
            {
                Console.WriteLine(ingredients);
            }
            Console.WriteLine();
            Console.WriteLine("Instruktioner");
            Console.WriteLine("-------------");
            foreach (string instructions in recipe.Instructions)
            {
                Console.WriteLine(instructions);
            }
            //throw new NotImplementedException();
        }

        public void Show(IEnumerable<IRecipe> recipes)
        {
            foreach (IRecipe recipe in recipes)
            {
                Show(recipe);

            }
            //throw new NotImplementedException();
        }
    }
}
