# Localization

We are going to let you import/export and work with all of your localization right in the Data Editor. This feature is under development right now, but we have a temporary substitution, which you can use and later migrate without any problems. 

When you create a new parameter, instead of selecting type **String**, make it **Localized String**. Everytime, when you try to access this parameter in the code, it'll instantly give you already localized value.

Let's say you have a pair "Key": "LocalizedValue":

1. You create a new parameter with type of Localized String.
2. In the document you put the value **Key**.
3. When you access your parameter from the code, you will be getting **LocalizedValue** instead of **Key**.

You are probably using some other solution to store all the keys and values for localization. So in order to make everything work, you need to add those likes of code:

```
Balancy.Localization.Manager.onLocalizationRequested = key =>
{
    return <Value associated with current key for the selected localization>
};
```

Once we ready to store all keys and values in our system, you'll just need to remove that code and everything will be working automatically.

### UI

If you are using a lot of UnityEngine.UI.Text with static text, you'll find very helpful our Component: **LocalizationText.cs**.
Just add it to your GameObject and set parameter **Localization Key** value as your **Key**. It'll automatically put Localized value as Text when you launch the game.

We've the same Component for Text Mesh Pro. You can download it from [here](/code/LocalizationTextMeshPro.cs)
