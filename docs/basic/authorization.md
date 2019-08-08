# Authorization

Currently UnnyNet has 3 ways to authorize players:

1)  **Email** - this is a default method, which players can use from the main screen. 

2)  **Guest Mode** is turned on by default, players authorize using their deviceId. Players can do that manually from UnnyNet screen or developers can do that on their behalf, so players won't see our welcome window.

```csharp fct_label="Unity"
UnnyNet.UnnyNet.AuthorizeAsGuest("display_name");
```

```java fct_label="Java"
unnynet.authorizeAsGuest("display_name", null);
```

3)  **Custom Id**. This option should be used if you have an external or custom user identity service which you want to use.

```csharp fct_label="Unity"
UnnyNet.UnnyNet.AuthorizeWithCustomId("custom_id", "display_name");
```

```java fct_label="Java"
unnynet.authorizeWithCustomId("custom_id", "display_name", null);
```

`custom_id` should be no longer than 23 symbols.

4)  **Game Auth** with credentials if your game has any auth system, you can use those credentials to authorize your players in UnnyNet.

```csharp fct_label="Unity"
UnnyNet.UnnyNet.AuthorizeWithCredentials("username", "password", "display_name");
```

```java fct_label="Java"
unnynet.authorizeWithCredentials("username", "password", "display_name", null);
```

`password` must be at least 8 symbols length.
    
In case a player logs out he might want to login in back with the game credentials. We've created a flow for such situation, but it's up to developers to take care about the rest:

1. Turn on Login with Credentials in UnnyNet Settings.
2. Add the following callback.

```csharp fct_label="Unity"
UnnyNet.UnnyNetBase.m_OnGameLoginRequest = () => {
   UnnyNet.UnnyNet.AuthorizeWithCredentials("username", "password", "display_name");
};
```

```java fct_label="Java"
unnynet.setOnGameLoginRequestListener(() -> 
    unnynet.authorizeWithCredentials("username", "password", "display_name", null)
);
```

UnnyNet calls this method whenever player tries to authorize with game credentials.

### Log Out

In case your game supports several account and players can switch between them, you can force players to log out from UnnyNet as soon as they log out from your game.

```csharp fct_label="Unity"
UnnyNet.UnnyNet.ForceLogout();
```

```java fct_label="Java"
unnynet.forceLogout()
```
  
## Callbacks
    
UnnyNet invokes methods on different player's actions or to reply to a game request. If you need any of the information, you can subscribe to our callbacks.

### User has Logged In

```csharp fct_label="Unity"
UnnyNet.UnnyNetBase.m_OnPlayerAuthorized = (prms) => {
    string unnyId;
    prms.TryGetValue("unny_id", out unnyId);
    string playerName;
    prms.TryGetValue("name", out playerName);
    Debug.LogFormat("Player autorized: id = {0}; name = {1};", unnyId, playerName);
}
```

```java fct_label="Java"
unnynet.setOnPlayerAuthorizedListener((unnyId, name) -> 
    showMessage(String.format("Player Authorized: %s - %s", name, unnyId))
);
```

This event triggers once a user logs in to UnnyNet. Parameters:

* `unny_id` - UnnyNet player Id. It'll never change, so you can use it to identify a user and synchronize his game progress for example.
* `name` - User's Display Name.

### User has Logged Out

```csharp fct_label="Unity"
UnnyNet.UnnyNetBase.m_OnPlayerLoggedOut = () => {
    Debug.Log("On Player Logged Out");
};
```

This event triggers once a user logs out from UnnyNet.

### User has changed his name

```csharp fct_label="Unity"
UnnyNet.UnnyNetBase.m_OnPlayerNameChanged = (newName) => {
    Debug.Log("Player changed name to " + newName);
}
```

```java fct_label="Java"
unnynet.setOnPlayerNameChangedListener(newName -> showMessage(String.format("Player Name Changed: %s", newName)))
```
