﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuisAriaFE
{
	public static class Constants
    {
        private static string BaseUrl = "http://cuisariabe.azurewebsites.net/";

        // URL of Recipe Services
        public static string SharedRcpUrl = BaseUrl + "GetSharedRecipes/{0}";
        public static string MyRcpUrl = BaseUrl + "GetMyRecipes/{0}";
        public static string FavRcpUrl = BaseUrl + "GetFavRecipes/{0}";
        public static string RcpUrl = BaseUrl + "GetRecipe/{0}";
        public static string RcpStepsUrl = BaseUrl + "GetRecipeSteps/{0}";
        public static string RcpAddEditUrl = BaseUrl + "AddEditRecipe";

        public static string UserByNameUrl = BaseUrl + "GetUserByName/{0}";

        // URL for GetMenu // USAGE: Set MenuID = 0 to get current menu or menuId to get specific menu
        public static string MenuRcpUrl = BaseUrl + "GetMenu/{0}/{1}";

        // URL for AddEditMenu // USAGE: Pass a JSON object of type AddEditGetMenu
        public static string AddEditMenuUrl = BaseUrl + "AddMenuRecipe";

        // URL for Add/Edit User // USAGE: Set Id = 0 to add a user // Set Id = userID to edit user data
        public static string UserAddEditUrl = BaseUrl + "AddEditUser";

        // URL to toggle shared recipes // USAGE: Passing a recipeID toggles bit
        public static string ToggleShareUrl = BaseUrl + "ShareRecipeToggle/{0}";

        // URL to toggle user favorite recipes // USAGE: Passing a userID and recipeID toggles bit
        public static string ToggleFavUrl = BaseUrl + "FavRecipeToggle/{0}/{1}";

        // URL to get shopping list // USAGE: Passing a UserId retrieves shoppinglist
        public static string ShopListUrl = BaseUrl + "GetShoppingList/{0}";

        // URL to add a shopping list // USAGE: Pass /UserId/Menu to add a Menu to a ShoppingList
        public static string AddEditShopListUrl = BaseUrl + "AddEditShoppingList/{0}/{1}";

        // Credentials that are hard coded //
        public static string RecipeTestID = "47";
        public static string UserTestID = "48";
        // public static string UserTestID = Data.CABEServices.UserDetails.ID.ToString();
        public static string OwnerTestID = "48";
        // public static string OwnerTestID = Data.CABEServices.UserDetails.ID.ToString();
        public static string MenuId = "0";

        // Fraction conversion list
        public static string[] FracList = { "1/8", "1/4", "3/8", "1/2", "5/8", "3/4", "7/8" };
    }
}