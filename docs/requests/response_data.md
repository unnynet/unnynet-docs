# Requests, Response Data and Errors

When you request any information from UnnyNet or submit leaderboard scores you can provide a callback method. All methods are asynchronous, so it might take some time(usually milliseconds) for callback to be invoked. In the callback you are receiving ResponseData:
 
```csharp fct_label="Unity"
public class Error {
    public int Code;
    public string Message;
}

public class ResponseData {
    public bool Success;
    public string Data;
    public Error Error;
}
```

```csharp fct_label="JavaScript"
ResponseExample = {
    success: true,
    error: {
        code: 1,
        message: 'unknown error'
    },
    data: {
        //some data
    }
}
```

You need to check if Success is true to be sure that the request was successful and the Data is valid. Otherwise you need to read Error.Code to understand what went wrong. Here is the list of error, which might occur:

```csharp fct_label="Unity"
public enum Errors {
    NotInitialized = -1,
    Unknown = 1,
    NotAuthorized = 2,
    NoMessage = 3,
    NoChannel = 4,
    UnnynetNotReady = 5,
    NoGameId = 6,
    NoSuchLeaderboard = 7,
    NoLeaderboardsForTheGame = 8,
    NoAchievementsForTheGame = 9,
    NoGuildsForTheGame = 10,
    NotInGuild = 11,
    NoSuchAchievement = 12,
    WrongAchievementType = 13
};
```  

```csharp fct_label="JavaScript"
export const Errors = {
    NotInitialized: -1,
    Unknown: 1,
    NotAuthorized: 2,
    NoMessage: 3,
    NoChannel: 4,
    UnnynetNotReady: 5,
    NoGameId: 6,
    NoSuchLeaderboard: 7,
    NoLeaderboardsForTheGame: 8,
    NoAchievementsForTheGame: 9,
    NoGuildsForTheGame: 10,
    NotInGuild: 11,
    NoSuchAchievement: 12,
    WrongAchievementType: 13
};
```

Once a request succeeded you can view the response in the Data field.

```csharp fct_label="Unity"
//The data is the json string, which you can parse into your own classes:
Dictionary<string, object> json = UnnyNetMiniJSON.Json.Deserialize(data.Data) as Dictionary<string, object>; 
```

```csharp fct_label="JavaScript"
//The data is an object ready to use:
const json = data.data; 
```
