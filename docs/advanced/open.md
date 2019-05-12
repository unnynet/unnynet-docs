# Open UnnyNet Window

As UnnyNet has tons of features inside, you need a flexible way of displaying the information. You can have different buttons to open Friends, Leaderboards, Chat, Guild, etc... Thus you need different methods to open the window you want.

### Default
Opens Default page or the page, which a player visited the last: 

    UnnyNet.UnnyNetBase.OpenUnnyNet();

### Leaderboards  
Opens Leaderboards Window:

    UnnyNet.UnnyNet.OpenLeaderboards();

### Achievements
Open Achievements Window:

    UnnyNet.UnnyNet.OpenAchievements();

### Friends
Open Friends Window:

    UnnyNet.UnnyNet.OpenFriends();

### Chat
Open a specific channel. For example "general":

    UnnyNet.UnnyNet.OpenChannel("general");

### Guilds
Open Guilds window, where player can search, create or join guilds:

    UnnyNet.UnnyNet.OpenGuilds();

### My Guild
Open my Guild window. The Guilds window is opened if the player isn't in a guild:

    UnnyNet.UnnyNet.OpenMyGuild();