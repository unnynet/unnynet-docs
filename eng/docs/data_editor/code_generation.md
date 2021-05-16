# Code Generation

## Why do I need it?
It's a good question, because many developers like to rewrite such things in every project.

Here are some reasons for you to consider:

1. Why would you spend your precious time on such a monotone job? Such things should've been automated long time ago.
2. Human mistakes excluded. Very often a game designer or a programmer misspell a word and parsing doesn't work as expected. Such problem might take some time to be found.
3. Whenever a game designer changes a parameter or a Templates, all of that will be instantly reflected in the code after the generation. A programmer won't forget to apply those changes.
4. Code generation is tightly connected with other UnnyNet awesome features, like: [SmartObjects](link) and [Localization](link). Using them all together gives your team a huge boost. 
5. You can forget about JSONs and how to parse them. UnnyNet will do that for you, so you could work with convenient Classes only.
6. When document refers to another document, developers usually use some kind of ID to create those links. UnnyNet will do that for you, it automatically resolves all links and gives you direct access to the Documents you expect.

## How to generate code
1. In Unity select Tools->UnnyNet, input your GameId/PublicKey and start Code Generation.
2. It might take some time depending on your connection and the amount of Templates you have.
3. Generated classes will be placed in Assets/UnnyNet/AutoGeneratedCode.
4. Please **DO NOT** change anything in this folder, because your changes will be overwritten with the next generation.


## How does it work inside?
UnnyNet server generated JSON files based on your Documents and puts it to the CDN storage. UnnyNet plugin automatically checks for the updates of those JSON files and downloads only updated files. After that it parses the data from JSON to the generated classes and find all dependencies. The programmer doesn't have to download, parse or understand any of JSONs. There is also no need to find any links if any of the Documents refers to another one - the link will be automatically resolved by UnnyNet, so you would get a direct access to the Documents you expect.    


## How to get an access to the documents
1. Let's say you have a Template **ItemModel** and several Documents of this Template. Use **UnnyNet.DataEditor.ItemModels** to access the list of those Documents.
2. Let's say you have a Template **RecipeModel**, which has a Parameter Item of type **ItemModel**. Once you get an instance of that that RecipeModel as **recipeModel**, you can get an access to it's Item as **recipeModel.Item**. As simple as that!
3. If your Template **GameConfig** is a Singleton, you get access to it by writing **UnnyNet.DataEditor.GameConfig**


## How to work with the generated code

Every developer has his own style and it's really up to you how to work with the game data. Below we just list you couple of example, which we would use:

### 1. [Extension Method](https://en.wikipedia.org/wiki/Extension_method)

Let's say you have a generated code for items:

```csharp fct_label="Unity"
public class ItemModel : BaseModel
{
    public string Name;
    public string Description;
    public string IconName;
    public string AssetName;
    public int MaxStack;
}
```

If you want to add a check whether an Item can be stacked in inventory, you can write in a separate file:

```csharp fct_label="Unity"
public static class ItemModelExtension
{
    public static bool CanStack(this ItemModel item)
    {
        return item.MaxStack > 1;
    }
}
```

So later if you have an instance of **ItemModel** as **item**, you can just call the new method:

```csharp fct_label="Unity"
item.CanStack();
```

### 2. [Facade Pattern](https://en.wikipedia.org/wiki/Facade_pattern)

Let's say you have a generated code for inventory:

```csharp fct_label="Unity"
public class Inventory : BaseData
{
    public SmartList<ItemSlot> ItemSlots;
}
```

First you create a new class called InventoryController, which has property Inventory in it. Instead of working with Inventory directly, your game has an access only to the InventoryController.
So if you want to add a check if there are any empty slots, you can write:

```csharp fct_label="Unity"
public class InventoryController
{
    public Inventory Inventory;
    
    public bool HasEmptySlot() {
        foreach (var slot in Inventory.ItemSlots)
        {
            if (slot.IsEmpty())
                return true;
        }
        return false;
    }
}
```

This is just a simple example. This very logic can be easily rewritten using the first approach (Extension Method), which would be recommended for this situation.

### 3. [Partial Classes](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods)

###### This feature was deactivated temporary.

If you activate partial checkbox for your Template in the CMS, the generated class will be marked as partial. It means that you can add as many methods and properties for this class in a separate file as you want.


###### Recommendation:
The first approach is the best one. It definitely suits all simple Templates (which don't have any references as parameters).
For more complicated Templates you should use combinations of the first and the seconds approaches. 
The last approach of Partial classes might look attractive, but it's not recommended to use. Many developers don't like this feature for many reasons. The same can be implemented using the first or the seconds approaches.

Of course there a lot of other ways to implement such logic. If you personally like one, please share it with us, and we might add it to the documentation.

#### [Next: Example](/data_editor/example)