# Guilds API

When you [setup](/advanced/guilds/guilds_setup) the guilds in UnnyNet and [test](/advanced/guilds/guilds_test) everything, we can move forward to learn about API and events, which you can use in your game.

### Guild creation

If your game has any conditions for guild creation, you can use the next callback:

```csharp fct_label="Unity"
UnnyNet.UnnyNetBase.m_OnNewGuildRequest = (prms) =>{
    string guildName;
    prms.TryGetValue("name", out guildName);
    string description;
    prms.TryGetValue("description", out description);
    string guildType;
    prms.TryGetValue("type", out guildType);
    Debug.Log("Guilds are allowed, so we return null. If you want to prevent guild from the creation - just return any string error");
    return null;
};
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.onNewGuildRequest = (prms) =>{
    console.info("onNewGuildRequest", prms);
    return null;
};
```

```java fct_label="Java"
unnynet.setOnNewGuildRequestListener((name, description, guildType) -> {
    showMessage(String.format("NewGuild Request: %s - %s, %s, Guilds are allowed, so we return null. If you want to prevent guild from the creation - just return any string error", name, description, guildType));
    return null;
});
```

For example: it costs 25,000 Gold to create a guild. You can check if a player has this amount of Gold and return 'null' if everything is ok. In case the player doesn't have enough money, you can return the error "You need 25,000 Gold to create a guild".

Once a guild is created, the game is notified with the next event:

```csharp fct_label="Unity"
UnnyNet.UnnyNetBase.m_OnNewGuild = (prms) =>{
    string guildName;
    prms.TryGetValue("name", out guildName);
    string description;
    prms.TryGetValue("description", out description);
    string guildId;
    prms.TryGetValue("guild_id", out guildId);
    Debug.LogFormat("New Guild was created: id = {0}; name = {1}; description= {2}", guildId, guildName, description);
};
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.onNewGuild = (prms) =>{
    console.info("onNewGuild", prms);
};
```

```java fct_label="Java"
unnynet.setOnNewGuildListener((name, description, guildId) -> showErrorMessage(String.format("OnNewGuild: %s - %s, %s", name, description, guildId)));
```


### Guild Ranks

If your game supports ranks for players in guilds, you can subscribe for the event to be notified once the player's rank changes:

```csharp fct_label="Unity"
UnnyNet.UnnyNetBase.m_OnRankChanged = (prms) =>{
    string previousRankIndex;
    prms.TryGetValue("prev_index", out previousRankIndex);
    string previousRankName;
    prms.TryGetValue("prev_rank", out previousRankName);
    string currentRankIndex;
    prms.TryGetValue("curr_index", out currentRankIndex);
    string currentRankName;
    prms.TryGetValue("curr_rank", out currentRankName);
    Debug.LogFormat("Player's rank changed from {0} ({1}) to {2} ({3})", previousRankName, previousRankIndex, currentRankName, currentRankIndex);
};
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.onRankChanged = (prms) =>{
    console.info("onRankChanged", prms);
};
```

```java fct_label="Java"
unnynet.setOnRankChangedListener((index, rank, prevIndex, prevRank) -> 
    showMessage(String.format("Rank Changed: %s - %s => %s - %s", prevIndex, prevRank, index, rank))
);
```


### Guild Experience

As a game developer, you need to decide when exactly players give experience to his Guild: after completing a quest, winning a PvP match, making a donation,... Use the next method to add experience:

```csharp fct_label="Unity"
UnnyNet.UnnyNet.AddGuildExperience(500);
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.addGuildExperience(500);
```

```java fct_label="Java"
unnynet.addGuildExperience(500);
```
