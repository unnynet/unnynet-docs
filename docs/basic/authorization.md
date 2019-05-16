# Authorization

Currently UnnyNet has 3 ways to authorize players:

1.  **Email** - this is a default method, which players can use from the main screen.
2.  **Guest Mode** is turned on by default, but if you don't want guests to join your group, you can turn it off in the UnnyNet settings (Unity: UnnyNet->Settings)
3.  **Game Auth** with credentials if your game has any auth system, you can use those credentials to authorize your players in UnnyNet.

```csharp fct_label="Unity"
UnnyNet.UnnyNet.AuthorizeWithCredentials("username", "password", "display_name");
```

```java fct_label="Java"
unnynet.authorizeWithCredentials("username", "password", "display_name", null);
```
    
In case a player logs out he might want to login in back with the game credentials. We've created a flow for such situation, but it's up to developers to take care about the rest:

1.  Turn on Login with Credentials in UnnyNet Settings.
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
    string email;
    prms.TryGetValue("email", out email);
    string playerName;
    prms.TryGetValue("name", out playerName);
    Debug.LogFormat("Player autorized: id = {0}; name = {1}; email= {2}", unnyId, playerName, email);
}
```

```java fct_label="Java"
unnynet.setOnPlayerAuthorizedListener((unnyId, email, name) -> 
    showMessage(String.format("Player Authorized: %s - %s, %s", name, email, unnyId))
);
```

This event triggers once a user logs in to UnnyNet. Parameters:

* **unny_id** - UnnyNet player Id. It'll never change, so you can use it to identify a user and synchronize his game progress for example.
* **email** - Email, which player used to login. This value can be changed by a player or might not present at all.
* **name** - User's Name.

### User has changed his name

```csharp fct_label="Unity"
UnnyNet.UnnyNetBase.m_OnPlayerNameChanged = (newName) => {
    Debug.Log("Player changed name to " + newName);
}
```

```java fct_label="Java"
unnynet.setOnPlayerNameChangedListener(newName -> showMessage(String.format("Player Name Changed: %s", newName)))
```