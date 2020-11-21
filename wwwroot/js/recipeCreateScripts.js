var nextIngredientId = 1;
function addIngredientFields() {
    var target = document.getElementById("RecipeIngredientsPane");

    var newNode = document.createElement("div");
    newNode.id = "Ingredients_" + nextIngredientId;

    var nameField = document.createElement("input");
    nameField.id = "Ingredients_" + nextIngredientId + "_Name";
    nameField.placeholder = "Ingredient Name";
    nameField.type = "text";
    nameField.name = "Ingredients[" + nextIngredientId + "].Name";

    var measurementField = document.createElement("input");
    measurementField.id = "Ingredients_" + nextIngredientId + "_Measurement";
    measurementField.placeholder = "Ingredient Measurement";
    measurementField.type = "text";
    measurementField.name = "Ingredients[" + nextIngredientId + "].Measurement";

    newNode.append(nameField, measurementField);

    target.appendChild(newNode);
    nextIngredientId++;
}