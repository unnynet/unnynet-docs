# Unity3D Integration

For your convenience we've recorded the [video of the integration](https://www.youtube.com/watch?v=T0QxR8t0x7I&list=PLHHFKd2iPYt4SJ3o7RdcgxhuGzhjbin4I)

1.  Download the latest version of the plugin from the [Asset Store](https://assetstore.unity.com/packages/slug/128920).
2.  Alternatively you can use our direct link to the [package](https://dictionaries-unnynet.fra1.cdn.digitaloceanspaces.com/config/Packages/balancy_latest.unitypackage).
3.  Import the Balancy plugin.
4.  Prepare Game ID and Public Key to use in the code:

    ![Screenshot](../img/game_id.jpg)

5.  Call initialize method at start:
        
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

1. [**Data Editor**](/data_editor/basic) - a place to work with Game Balance Data
2. [**Auth**](/basic/authorization) - authorizations
3. [**Payments**](/basic/payments) - purchase In-App and get information about them
4. **Localization** - (coming soon) a place to work with localizations
