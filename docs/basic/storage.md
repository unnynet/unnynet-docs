# Storage

Allows you to Save and Load any data on UnnyNet servers. Make sure to authorize the player (at least as a guest) before using the Storage, because all records are connected to specific players.


## General Information

#### Collections and Keys
Each player can have a set of Collections, and each collection can have a set of Keys. When you save to the Storage you need to specify both a Collection and a key. However, to Load the data there are two options:

1. Load a specific key from a specific collection
2. Load the whole collection.

You can think of a Collection as a Book, when a Key is a chapter of that book. You can have as many books as you want with many different chapters in each one. It's up to you what you want to write in each chapter. 

Both a Collection and a Key can be any string value. Just make sure you are loading from the same Collection/Key pair, which you used to save your data.

###### For example 
You might have a collection 'Player' with many keys: 'Inventory', 'Spells', 'Stats', etc.. When one of the data changes, you just need to update only a small portion, which will be stored in one key. But when you start a game you can load the whole profile with all the keys

#### Versions
Another worth mentioning topic is **versions**. UnnyNet handle them automatically, but it would be better for you to understand how it works. 
Each record in database has a version number, which increases every time you change the data. It's used to prevent using an out-dated data. 

###### For example 
You launch a game on the **Device1**, play for some time and the last version of your progress will be **5**. Then you switch to the **Device2**, which loads progress with version **5**, saves several changes, making the last version of the progress **10**. Finally you reopen the game on the **Device1**, where the client thinks he has a version **5**. The next time it tries to save the update, it'll get error of a wrong version. 

There are two ways to solve such issue:

1. Ignore version (we have such parameter in the Save method). I would not recommend this option, in most cases this is wrong.
2. If you get such error, reload your game progress to get the actual game data and version, apply it to your game and keep playing.

#### Data types

We support 2 options:

1. Simple **string**
2. Any Class. 

We are using Newtonsoft converter to Serialize and Deserialize objects, here is example of the class we can use to Save/Load in the Storage :

```csharp fct_label="Unity"
private class SaveExample
{
    public int IntValue;
    public string StringValue;

    [JsonIgnore]
    public int IgnoredValue;
    
    [JsonIgnore]
    public int AlsoIgnoredValue { get { return IntValue; } }
}   
```

In the example above **IntValue** and **StringValue** will be saved and loaded, when other 2 field won't. So if you don't want any property or attribute to be synchronized, just mark it with [JsonIgnore].

### Save

Example to save a string:

```csharp fct_label="Unity"
UnnyNet.Storage.Save("MyCollection1", "StringKey", "Hello World!", saveResponse =>
{
    Debug.Log("String was saved result: " + saveResponse.Success);
});
```

Example to save an object:

```csharp fct_label="Unity"
var saveExample = new SaveExample
{
    IntValue = 5,
    StringValue = "Hello World",
    IgnoredValue = 3
};

UnnyNet.Storage.Save("MyCollection2", "ObjectKey", saveExample, saveResponse =>
{
    Debug.Log("Object was saved result: " + saveResponse.Success);
});
```

### Load

Example to load a saved string:

```csharp fct_label="Unity"
UnnyNet.Storage.Load<string>("MyCollection1", "StringKey", loadResponse =>
{
    Debug.Log("String was loaded result: " + loadResponse.Success);
    if (loadResponse.Success)
        Debug.Log("Value = " + loadResponse.Data.Value);
});
```

Example to load a saved object:

```csharp fct_label="Unity"
UnnyNet.Storage.Load<SaveExample>("MyCollection2", "ObjectKey", loadResponse =>
{
    Debug.Log("Object was loaded result: " + loadResponse.Success);
    if (loadResponse.Success)
    {
        SaveExample saveExample = loadResponse.Data.Value;
        Debug.Log("String Value = " + saveExample.StringValue);
    }
});
```

### Limits

1. You can Save/Load the same combination of Collection & Key not more than once per 20 seconds.
2. The maximum size of a saved value is 100Kb.

It's subject to change in the future.
