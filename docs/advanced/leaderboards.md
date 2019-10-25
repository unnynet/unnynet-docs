# Leaderboards

Leaderboards are a great way to add a social and competitive element to any game. They're a fun way to drive competition among your players.

The server has no special requirement on what the score value should represent from your game. A leaderboard is created with a sort order on values. If you're using lap time or currency in records you'll want to order the results in ASC or DESC mode as preferred. At creation time you must also specify the operator which controls how scores are submitted to the leaderboard: "best" or "set".

For your convenience we've recorded the [small video tutorial](https://youtu.be/fvbJznVhaw0)

### How to add Leaderboards
1.  Open Game Settings window
    ![Screenshot](../img/game_settings.jpg)
2.  Select Leaderboards section
    ![Screenshot](../img/leaders.jpg)
3.  Click on "Create Leaderboard" Button
    
When a player completes a level or makes any other important action, use the next method to report his scores to UnnyNet:

```csharp fct_label="Unity"
UnnyNet.UnnyNet.ReportLeaderboards("leaderboard_id", 99);
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.reportLeaderboards("leaderboard_id", 99);
```

```java fct_label="Java"
unnynet.reportLeaderboards("leaderboard_id", 99);
```

You can find leaderboard_id on the leaderboards page in the game settings.
The same leaderboard can't be reported from the same user very often (no more than once per 10s). If you try to report the scores too often, the messages will be cached and delivered after the mentioned period.

### Leaderboards UI
UnnyNet displays Global Leaderboards and also Leaderboards only for Friends:
    ![Screenshot](../img/leaders_2.jpg)
    
### Leaderboards Custom Data
There is a third parameter in reportLeaderboards method (Custom Data - string). You can send there anything you want. It can be the race(Ork, Human, Elf,..) of the player or the weapon he used. This information will be displayed in the Leaderboards table.

### Leaderboards in Offline
It's obvious that UnnyNet requires internet connection in order to operate, however we've added a mecanism, which saves locally all undelivered Leaderboard reports. Once the internet is back, UnnyNet will automatically resend all the information it stored. 
