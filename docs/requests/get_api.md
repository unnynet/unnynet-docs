# GET API

There are a lot of information about a player, stored in UnnyNet, which you might need for your game.

Please make sure to read about [ResponseData and Errors](/response_data) before moving forward.

For the testing purpose we'll declare one function, which we'll be using in all the requests:

```csharp fct_label="Unity"
void ResponceReceived(UnnyNet.ResponseData data) {
    if (data.Success)
        Debug.Log("data received = " + data.Data);
    else
        Debug.LogError("Error occured: " + data.Error.Code);
}
```

## Player's public info

```csharp fct_label="Unity"
UnnyNet.UnnyNet.GetPlayerPublicInfo(ResponceReceived);
```

Example of the response:  **{"display_name":"Pavel Ignatov","avatar_url":"https://unnynet.azureedge.net/avatars/unnyhog/4.jpg"}**


## Player's leaderboard info

Put your leaderboard_id to get current player's leaderboard rank and score:

```csharp fct_label="Unity"
UnnyNet.UnnyNet.GetLeaderboardScores("leaderboard_id", ResponceReceived);
```

Example of the response:  **{"leaderboard_name":"Arena","leaderboard_id":"612832c3-d308-478d-a155-46cd70b48d72","rank":6,"score":1999}**


### Get Achievements Scores
You can request the total Achievements scores

```csharp fct_label="Unity"
UnnyNet.UnnyNet.GetAchievementsInfo(ResponceReceived);
```

Example of the response:  **{"scores":100}**


### Get Guild Info

You can request guild information of a player. First parameter indicates if you need full information (basic info + list of members) or just basic information about the guild.

```csharp fct_label="Unity"
UnnyNet.UnnyNet.GetGuildInfo(true, ResponceReceived);
```

Example of the response:  **{"create_time":"2019-06-20T18:05:14Z","creator_id":"2f8d6006-3b77-41ff-88da-cb30fa2e40bd","description":"Test","display_name":"Lime","players_count":2,"open":false,"info":{"exp":0,"level":1},"members":[]}** 
