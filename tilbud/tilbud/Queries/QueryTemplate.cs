//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;

//namespace tilbud.Queries
//{
//    public class RecipeQuery
//    {
//        public bool LoadTimeStamp { get; set; } = false;
//        public bool LoadName { get; set; } = false;
//        public bool LoadCategory { get; set; } = false;
//        public bool LoadDirections { get; set; } = false;
//        public bool LoadServings { get; set; } = false;
//        public bool LoadPrice { get; set; } = false;
//        public bool LoadIngredientList { get; set; } = false;
//        public bool LoadSubscriptions { get; set; } = false;

//        public async Task<IEnumerable<Recipes>> Execute(prj4databaseContext context)
//        {
//            switch (LoadTimeStamp)
//            {
//                case true:
//                    switch (LoadName)
//                    {
//                        case true:
//                            switch (LoadCategory)
//                            {
//                                case true:
//                                    switch (LoadDirections)
//                                    {
//                                        case true:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true: 
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                        case false:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                    }
//                                    break;
//                                case false:
//                                    switch (LoadDirections)
//                                    {
//                                        case true:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                        case false:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                    }
//                                    break;
//                            }
//                            break;
//                        case false:
//                            switch (LoadCategory)
//                            {
//                                case true:
//                                    switch (LoadDirections)
//                                    {
//                                        case true:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                        case false:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                    }
//                                    break;
//                                case false:
//                                    switch (LoadDirections)
//                                    {
//                                        case true:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                        case false:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                    }
//                                    break;
//                            }
//                            break;
//                    }
//                    break;
//                case false:
//                    switch (LoadName)
//                    {
//                        case true:
//                            switch (LoadCategory)
//                            {
//                                case true:
//                                    switch (LoadDirections)
//                                    {
//                                        case true:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                        case false:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                    }
//                                    break;
//                                case false:
//                                    switch (LoadDirections)
//                                    {
//                                        case true:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                        case false:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                    }
//                                    break;
//                            }
//                            break;
//                        case false:
//                            switch (LoadCategory)
//                            {
//                                case true:
//                                    switch (LoadDirections)
//                                    {
//                                        case true:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                        case false:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                    }
//                                    break;
//                                case false:
//                                    switch (LoadDirections)
//                                    {
//                                        case true:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                        case false:
//                                            switch (LoadServings)
//                                            {
//                                                case true:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                                case false:
//                                                    switch (LoadPrice)
//                                                    {
//                                                        case true:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                        case false:
//                                                            switch (LoadIngredientList)
//                                                            {
//                                                                case true:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                                case false:
//                                                                    switch (LoadSubscriptions)
//                                                                    {
//                                                                        case true:
//                                                                            break;
//                                                                        case false:
//                                                                            break;
//                                                                    }
//                                                                    break;
//                                                            }
//                                                            break;
//                                                    }
//                                                    break;
//                                            }
//                                            break;
//                                    }
//                                    break;
//                            }
//                            break;
//                    }
//                    break;
//            }
//        }

//    }
//}
