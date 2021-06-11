# Unity3D Integration

For your convenience we've recorded the [video of the integration](https://youtu.be/91JYYb1KVIY)

1.  Download the latest version of the plugin from the [Asset Store](https://assetstore.unity.com/packages/slug/128920).
2.  Import the Balancy plugin.
3.  Prepare Game ID and Public Key to use in the code:

    ![Screenshot](../img/game_id.jpg)

4.  Call initialize method at start:
        
```csharp fct_label="Unity"
Balancy.Main.Init(new Balancy.AppConfig {
    ApiGameId = YOUR_GAME_ID,
    PublicKey = YOUR_PUBLIC_KEY,
    Environment = Balancy.Constants.Environment.Development,
    OnReadyCallback = responseData => { Debug.Log("Balancy Initialized: " + responseData.Success); }
});
```

### Further reading

Balancy consists of several modules for your convenience.

1. [**Auth**](/basic/authorization) - authorizations
2. [**Data Editor**](/data_editor/basic) - a place to work with Data Editor
3. [**Storage**](/basic/storage) - save/load in-game data with the server
4. [**Payments**](/basic/payments) - purchase In-App and get information about them
5. **Localization** - (coming soon) a place to work with localizations
