# Unity3D Integration

For your convenience we've recorded the [video of the integration](https://youtu.be/ql6h1WTBj5I)

1)  Download the latest version of the plugin from the [Asset Store](https://assetstore.unity.com/packages/slug/128920).
2)  Import the UnnyNet plugin.
3)  Prepare Game ID and Public Key to use in the code:
    ![Screenshot](../img/game_id_1_.jpg)

    Read and accept Terms of Service first:
    ![Screenshot](../img/game_id_2_.jpg)

    Copy and paste Game ID and Public Key: 
    ![Screenshot](../img/game_id_3_.jpg)

4)  Call initialize method at start:

```
UnnyNet.MainController.Init(new UnnyNet.Config {
    GameId = "8ff16d3c-ebcc-4582-a734-77ca6c14af29",
    PublicKey = "...",
    OnReadyCallback = responseData => { Debug.Log("UnnyNet Initialized: " + responseData.Success); },
    Environment = UnnyNet.Constants.Environment.Development,
    OpenAnimation = UnnyNet.UniWebViewTransitionEdge.Left,
    DefaultChannel = "general",
    OpenWithFade = true
});
```
        
5)  Call the next method to show UnnyNet window:

```
UnnyNet.MainController.Open();
```
        
6)  In the Player Settings set for Android Minimum API Level to at least 19, for iOS Target minimum iOS Version to at least 8.0.

Once you make an Android or iOS build - everything will work like magic. Unfortunately you can't test it in Unity yet, but we are working on it.

### Further reading

UnnyNet consists of several modules for your convenience.

1) **Auth** - authorizations
2) **Social** - leaderboards, achievements, guilds, etc...
3) **Chat** - everything related to the chat
4) **Events** - callbacks for different events
5) **MainController** - open/close windows and to request general information 
6) **Storage** - (coming soon) a place to save/load in-game data from the server

### Android additional settings

UnnyNet allows users to exchange photos and screenshots thus we need to request a permission to do that. 
It is a good practice to request such permission at runtime [Android Documentation](https://developer.android.com/training/permissions/requesting#explain). 
As an App can't request some permissions at start and some at runtime, we urge you to request the permission you need at runtime as well. 
You can use our class UnityAndroidPermissions (method RequestPermission) for this.

Please add the next permission to your Android Manifest:

```
<uses-permission android:name="android.permission.WRITE_EXTERNAL_STORAGE" />
```

###Congratulations!

Your game is a part of UnnyNet now and your players are happy!
