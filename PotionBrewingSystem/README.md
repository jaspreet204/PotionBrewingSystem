# Potion Brewing System

## Project Description

Potion Brewing System is a Windows Forms application developed using C# and .NET 8.

The application allows users to manage ingredients, create potion recipes, and brew potions. It uses a SQLite database to store ingredients, recipes, and brewed potions.

The main goal of this project is to practice Windows Forms, database operations, and event handling.

## Technologies Used

- C#
- .NET 8
- Windows Forms
- SQLite
- Entity Framework Core
- Visual Studio

## Features

### 1. Ingredient Management
- Add new ingredients.
- View available ingredients.
- Update ingredient information.
- Delete ingredients that are not used in active recipes.
- Manage ingredient stock quantities.

### 2. Recipe Management
- Create new potion recipes.
- Select ingredients for each recipe.
- Set the required quantity of each ingredient.
- Set the brewing duration.
- View saved recipes.

### 3. Potion Brewing
- Select a saved recipe.
- Check ingredient availability.
- Start brewing a potion.
- Display brewing progress using a progress bar.
- Automatically reduce ingredient stock after brewing.
- Save brewed potions to the database.
- Display brewed potions in a table.

## Database

The application uses SQLite with Entity Framework Core.

The database contains four main tables:

1. Ingredients
2. Recipes
3. RecipeIngredients
4. BrewedPotions

The database is created automatically when the application starts.

## How to Run the Project

1. Download or extract the project ZIP file.
2. Open the solution file in Visual Studio.
3. Restore the required NuGet packages.
4. Build the solution.
5. Press F5 to run the application.

## How to Use

1. Open Manage Ingredients and add ingredients with stock quantities.
2. Open Manage Recipes and create a potion recipe.
3. Select the ingredients and quantities needed for the recipe.
4. Save the recipe.
5. Open Brew Potions.
6. Select a recipe and click Start Brewing.
7. Wait for the progress bar to complete.
8. View the brewed potion in the table.

## Example

**Potion Name:** Healing Potion

**Ingredient:** Unicorn Hair

**Quantity Required:** 2

**Brewing Duration:** 5 seconds

If 20 Unicorn Hair ingredients are available, brewing one potion reduces the stock to 18.

## Current Limitations

This version focuses on the main working features.

The following features are not implemented:

- Dashboard and reports
- Updating existing recipes
- Retiring recipes
- Consuming brewed potions

## Conclusion

This project helped me understand how to create a Windows Forms application using C# and connect it to a SQLite database.

I also practiced using buttons, ComboBoxes, DataGridViews, progress bars, event handlers, and database operations.