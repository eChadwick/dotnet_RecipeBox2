var nextIngredientId = 1;
function addIngredientFields() {
    var localNextId = nextIngredientId;
    var target = document.getElementById("RecipeIngredientsPane");

    var newNode = document.createElement("div");
    newNode.id = "Ingredients_" + nextIngredientId;

    var nameField = document.createElement("input");
    nameField.id = "Ingredients_" + nextIngredientId + "_Name";
    nameField.placeholder = "Ingredient";
    nameField.type = "text";
    nameField.name = "Ingredients[" + nextIngredientId + "].Name";
    nameField.className = "IngredientName";

    var measurementField = document.createElement("input");
    measurementField.id = "Ingredients_" + nextIngredientId + "_Measurement";
    measurementField.placeholder = "Amount";
    measurementField.type = "text";
    measurementField.name = "Ingredients[" + nextIngredientId + "].Measurement";
    measurementField.className = "IngredientMeasurement";

    var deleteButton = document.createElement("BUTTON");
    deleteButton.type = "button";
    deleteButton.innerHTML = "-";
    deleteButton.onclick = function () { removeIngredient(localNextId); };


    newNode.append(measurementField, nameField, deleteButton);

    target.appendChild(newNode);
    nextIngredientId++;
}

function removeIngredient( ingredientId ) {
    var target = document.getElementById("Ingredients_" + ingredientId);
    target.remove();
}