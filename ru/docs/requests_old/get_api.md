# GET API

There are a lot of information about a player stored in UnnyNet, which you might need for your game.

Please make sure to read about [ResponseData and Errors](/requests/response_data) before moving forward.

For the testing purpose we'll declare one function, which we'll be using in all the requests:

```csharp fct_label="Unity"
void ResponceReceived(UnnyNet.ResponseData data) {
    if (data.Success)
        Debug.Log("data received = " + data.Data);
    else
        Debug.LogError("Error occured: " + data.Error.Code);
}
```

```csharp fct_label="JavaScript"
function responseReceived(data) {
    if (data.success)
        console.info("Success! data: ", data.data);            
    else
        console.info("Failed! error: ", data.error);
}
```

### Player's leaderboard info

Put your leaderboard_id to get leaderboard info:

```csharp fct_label="Unity"
UnnyNet.Social.GetLeaderboardScores("leaderboard_id", ResponceReceived);
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.getLeaderboardScores("leaderboard_id", responceReceived);
```

### Get Achievements Scores
You can request the total Achievements scores

```csharp fct_label="Unity"
UnnyNet.Social.GetAchievementsInfo(ResponceReceived);
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.getAchievementsInfo(responceReceived);
```


### Get Guild Info

You can request guild information of a player. First parameter indicates if you need full information (basic info + list of members) or just basic information about the guild.

```csharp fct_label="Unity"
UnnyNet.Social.GetGuildInfo(true, ResponceReceived);
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.getGuildInfo(true, responceReceived);
```

Example of the response:  **{"create_time":"2019-06-20T18:05:14Z","creator_id":"2f8d6006-3b77-41ff-88da-cb30fa2e40bd","description":"Test","display_name":"Lime","players_count":2,"open":false,"info":{"exp":0,"level":1},"members":[]}** 
