using System.Collections.Generic;
using UnityEngine;
using UnnyNet.Models;

public class DataEditorExample : MonoBehaviour
{
    private const string YOUR_GAME_ID = "3ba357ae-03e9-11eb-be4f-0684909fddca";
    private const string YOUR_PUBLIC_KEY = "<>";

    private Dictionary<Item, int> _itemsStorage;
    
    private void Start()
    {
        UnnyNet.Main.Init(new UnnyNet.AppConfig
        {
            ApiGameId = YOUR_GAME_ID,
            PublicKey = YOUR_PUBLIC_KEY,
            OnReadyCallback = responseData =>
            {
                Debug.Log("UnnyNet Initialized: " + responseData.Success);
                PrintAllData();
                InitializeStorage();
            },
            Environment = UnnyNet.Constants.Environment.Development
        });
    }

    private void InitializeStorage()
    {
        _itemsStorage = new Dictionary<Item, int>();
        var items = UnnyNet.DataEditor.Items;
        foreach (var item in items)
            _itemsStorage.Add(item, 0);
    }

    private void OnGUI()
    {
        if (!UnnyNet.Storage.Initialized)
            return;

        RenderItems();
        RenderRecipes();
    }

    private void RenderItems()
    {
        Rect rect = new Rect(100, 100, 100, 50);
        GUI.color = Color.yellow;
        GUI.Label(rect, "ITEMS:");
        rect.y += rect.height;
        GUI.color = Color.white;
        
        var items = UnnyNet.DataEditor.Items;
        foreach (var item in items)
        {
            int itemsCount = _itemsStorage[item];
            GUI.Label(rect, item.Name + ": " + itemsCount);
            var btnRect = rect;
            btnRect.x += btnRect.width;
            if (GUI.Button(btnRect, "ADD"))
                AddItem(item);

            rect.y += rect.height * 1.2f;
        }
    }

    private void RenderRecipes()
    {
        Rect rect = new Rect(400, 100, 100, 50);
        GUI.color = Color.yellow;
        GUI.Label(rect, "RECIPES:");
        rect.y += rect.height;
        GUI.color = Color.white;
        
        var recipes = UnnyNet.DataEditor.Recipes;
        foreach (var recipe in recipes)
        {
            GUI.Label(rect, recipe.Item.Name);
            var btnRect = rect;
            btnRect.x += btnRect.width;
            if (GUI.Button(btnRect, "CRAFT"))
            {
                if (HaveEnoughIngredients(recipe.Ingredients))
                {
                    TakeIngredients(recipe.Ingredients);
                    AddItem(recipe.Item);
                } else
                    Debug.LogError("Not Enough ingredients");
            }

            rect.y += rect.height * 1.2f;
        }
    }

    private bool HaveEnoughIngredients(Ingredient[] ingredients)
    {
        foreach (var ingredient in ingredients)
        {
            if (_itemsStorage[ingredient.Item] < ingredient.Count)
                return false;
        }

        return true;
    }
    
    private void TakeIngredients(Ingredient[] ingredients)
    {
        foreach (var ingredient in ingredients)
            _itemsStorage[ingredient.Item] -= ingredient.Count;
    }

    private void AddItem(Item item)
    {
        _itemsStorage[item] = _itemsStorage[item] + 1;
    }

    private void PrintAllData()
    {
        PrintItems();
        PrintRecipes();
    }

    private void PrintItems()
    {
        var items = UnnyNet.DataEditor.Items;
        Debug.LogWarning("Items Count = " + items.Count);
        foreach (var item in items)
            Debug.Log("ITEM: " + item.Name + " : " + item.Description);
    }
    
    private void PrintRecipes()
    {
        var recipes = UnnyNet.DataEditor.Recipes;
        Debug.LogWarning("Recipes Count = " + recipes.Count);
        foreach (var recipe in recipes)
            Debug.Log("RECIPE to create item " + recipe.Item.Name + " requires " + recipe.Ingredients.Length + " other items");
    }
}
