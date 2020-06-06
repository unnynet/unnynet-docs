# Release Notes

Most of the features of UnnyNet will become available despite the version of plugin, however some features require additional integration, so it's important to have the latest version of UnnyNet installed.

### v4.0 - June 30, 2020
* Content Management System

### v3.2 - April 13, 2020
* GetDefaultAvatars to receive the list of default avatars
* GetGameAvatars to receive available avatars
* SetAvatar to change player's avatar
* SetDisplayName to change player's name


### v3.1 - March 24, 2020
* xCode min version was decreased to 10.1;
* Customization of the close icon in UnnyNet windows;
* View list of banned players and other roles.


### v3.0 - February 20, 2020
Global Refactoring

**No JSONs**

Instead of receiving Json data as a response in request or event callback, we have created unique classes, which had already parsed all the JSON data into the convenient fields and properties.

All methods were also split into different modules:

**MainController**

* UnnyNetBase.InitializeUnnyNet -> MainController.Init
* UnnyNetBase.OpenUnnyNet -> MainController.Open
* UnnyNetBase.CloseUnnyNet -> MainController.Close
* UnnyNet.OpenLeaderboards -> MainController.OpenLeaderboards
* UnnyNet.OpenAchievements -> MainController.OpenAchievements
* UnnyNet.OpenFriends -> MainController.OpenFriends
* UnnyNet.OpenChannel -> MainController.OpenChannel
* UnnyNet.OpenGuilds -> MainController.OpenGuilds
* UnnyNet.OpenMyGuild -> MainController.OpenMyGuild
* UnnyNetBase.SetFrame -> MainController.SetFrame
* UnnyNetBase.GetPlayerPublicInfo -> MainController.GetPlayerPublicInfo


**Auth**

* UnnyNet.AuthorizeAsGuest -> Auth.AuthorizeAsGuest
* UnnyNet.AuthorizeWithCustomId -> Auth.AuthorizeWithCustomId
* UnnyNet.AuthorizeWithCredentials -> Auth.AuthorizeWithCredentials
* UnnyNet.ForceLogout -> Auth.ForceLogout


**Social**

* UnnyNet.ReportLeaderboards -> Social.ReportLeaderboardScore
* UnnyNet.ReportAchievements -> Social.ReportAchievementProgress
* UnnyNet.GetLeaderboardScores -> Social.GetLeaderboardScores
* UnnyNet.GetAchievementsInfo -> Social.GetAchievementsInfo
* UnnyNet.GetGuildInfo -> Social.GetGuildInfo


**Chat**

* UnnyNet.SendMessageToChannel -> Chat.SendMessageToChannel
* UnnyNet.JoinPrivateChannel -> Chat.JoinPrivateChannel
* UnnyNet.LeaveAllPrivateChannels -> Chat.LeaveAllPrivateChannels


**Events**

* UnnyNetBase.m_OnUnnyNetClosed -> Events.OnUnnyNetClosed
* UnnyNetBase.m_OnAchievementCompleted -> Events.OnAchievementCompleted
* UnnyNetBase.m_OnNewMessageReceived -> Events.OnNewMessageReceived
* UnnyNetBase.m_OnPopupOpened -> Events.OnPopupOpened
* UnnyNetBase.m_OnGameLoginRequest -> Events.OnGameLoginRequest
* UnnyNetBase.m_OnPlayerAuthorized -> Events.OnPlayerAuthorized
* UnnyNetBase.m_OnPlayerLoggedOut -> Events.OnPlayerLoggedOut
* UnnyNetBase.m_OnPlayerNameChanged -> Events.OnPlayerNameChanged
* UnnyNetBase.m_OnPlayerAvatarChanged -> Events.OnPlayerAvatarChanged 


### v2.12 - January 17, 2020
* New feature: [Multiple Level Achievements](/advanced/achievements)
* Improvements in Theme Management
* Upload your own icons for UnnyNet UI features 
* Many small fixes

### v2.11 - December 31, 2019
* New feature: [Private Channels](/advanced/private_channels)
* New parameters for the achievement [complete event](/advanced/achievements)
* New callback when player changes his [avatar](/basic/authorization)

### v2.10 - November 19, 2019
* Fixed problem with SafeArea on Android devices 
* You can upload your own avatars, which players can use 
* onPopupOpened now also returns channel_id and channel_name if it called from the general channel
 
### v2.9 - October 28, 2019
* Unpublished achievements are not displayed for user and can't be reported from the game
* You can now remove our Exit Button to use your own logic
* Leaderboards and Achievements can now be reported in offline and once UnnyNet connects to the server, it'll automatically synch them
* You can't report scores for the same leaderboard more often than once per 10 seconds
* You can send to leaderboards any custom string (including emoji), which will be displayed in our UI

### v2.8 (Backend only) - October 11, 2019
* Reset leaderboards in the game settings window
* Remove any specific record from a leaderboard
* Popups are now working in leaderboards
* New parameter "placement" in the [popup callback](/advanced/chat_popup)
* New SetFrame [method](/advanced/setframe)
* Request leaderboard scores now returns [the top-20](/requests/get_api)

### v2.7 - September 20, 2019
* New methods:
 - GetPlayerPublicInfo for display_name and avatar_url
 - GetLeaderboardScores
* Custom method to popup window

### v2.6 - September 12, 2019
* UIWebView warning on iOS fixed
* GetAchievementsInfo - the method to get total scores for achievements
* Fixed notches for iOS and Android

### v2.5 - August 27, 2019
* Fixed problem with screen size on some Android devices

### v2.4 - August 09, 2019
* OnPlayerLoggedOut event was added
* Optimization for chat channels

### v2.3 - August 01, 2019
* New method CloseUnnyNet window
* Messages format: make text bold, italic, start new lines or post links
* Now you can open player's profile from his invitation to friends

### v2.2 - June 22, 2019
* Our Business model was changed for new clients.
* Authorization as guests can be done from the code now
* Authorization with custom Id was added

### v2.1 - June 4, 2019
* Fixed problems in some Unity versions 
* Public key added

### v2.0 - May 20, 2019
* Unity 5.6+ support  
* Android min version was reduced to 4.4

### v1.12 - May 7, 2019
* New design
* New API Methods:
    1.  ForceLogOut - used when you game supports several accounts for players to switch
    2.  GetGuildInfo - returns information about player's guild 
* Nice animations to show UnnyNet window: 
    1.  Fade
    2.  Move from side

### v1.9 - February 13, 2019
* Partnership with PlayMaker. UnnyNet features are available in visual scripting now.
    
### v1.8 - February 7, 2019
* Guilds
    
### v1.7 - January 29, 2019
* Achievements
    
### v1.6 - January 21, 2019
* Performance improvements
* 'Close button' is now available from everywhere
* 'No Connection' window was added
* Developers can open different UnnyNet windows from the game: leaderboards, friends, specific channel
* Players now can view other players profile's and see who is online
    
### v1.5 - November 27, 2018
* Performance improvements
* Guest mode is now optional
* Example Scene was dramatically improved
* Bug fixes

### v1.4 - November 1, 2018
* Guest Login
* SSL added to all the websites
* Game Icon Change
* Channels Editor

### v1.3 - October 15, 2018
* Leaderboards
* Friends and Private Chat

### v1.2 - October 6, 2018
* Attach a picture to a chat
* Change Default Channel
    
### v1.0 - September 16, 2018
