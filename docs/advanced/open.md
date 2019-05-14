# Open UnnyNet Window

As UnnyNet has tons of features inside, you need a flexible way of displaying the information. You can have different buttons to open Friends, Leaderboards, Chat, Guild, etc... Thus you need different methods to open the window you want.

### Default
Opens Default page or the page, which a player visited the last: 

```csharp fct_label="Unity"
UnnyNet.UnnyNetBase.OpenUnnyNet();
```

```js fct_label="Java"
unnynet.show();
```

### Leaderboards  
Opens Leaderboards Window:

```csharp fct_label="Unity"
UnnyNet.UnnyNet.OpenLeaderboards();
```

```js fct_label="Java"
unnynet.openLeaderboards();
```

### Achievements
Open Achievements Window:

```csharp fct_label="Unity"
UnnyNet.UnnyNet.OpenAchievements();
```

```js fct_label="Java"
unnynet.openAchievements();
```

### Friends
Open Friends Window:

```csharp fct_label="Unity"
UnnyNet.UnnyNet.OpenFriends();
```

```js fct_label="Java"
unnynet.openFriends();
```

### Chat
Open a specific channel. For example "general":

```csharp fct_label="Unity"
UnnyNet.UnnyNet.OpenChannel("general");
```

```js fct_label="Java"
unnynet.openChannel("general");
```  

### Guilds
Open Guilds window, where player can search, create or join guilds:

```csharp fct_label="Unity"
UnnyNet.UnnyNet.OpenGuilds();
```

```js fct_label="Java"
unnynet.openGuilds();
```

### My Guild
Open my Guild window. The Guilds window is opened if the player isn't in a guild:

```csharp fct_label="Unity"
UnnyNet.UnnyNet.OpenMyGuild();
```

```js fct_label="Java"
unnynet.openMyGuild();
```
