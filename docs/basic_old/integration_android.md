# Android Integration


1) Download the latest version of the library from the [github](https://github.com/unnynet/unnynet-android/releases). *Later we will publish it to JCenter or Maven Center*.  
2) Add library to a project.  
3) In the assets folder create file **unnynet.data.json** with the next content:  

```json
{
  "gameId":"your_game_id"
}
```
        
Here you can also setup addition settings:
        
```json
{
  "guests_allowed": true,
  "game_login": true,
  "default_channel": "general",
  "open_fade": true,
  "open_animation": 2,
  "close_fade": true,
  "close_animation": 2,
  "gameId":"your_game_id"
}
```
            
To get the required information, open your game's settings at UnnyNet website:
![Screenshot](../img/game_id_1_.jpg)

Read and accept Terms of Service first:
![Screenshot](../img/game_id_2_.jpg)

Copy and paste Game ID and Public Key: 
![Screenshot](../img/game_id_3_.jpg)

4) Init UnnyNet:  

```java
unnynet = new UnnyNetDefault(this);
```

5) Call the next method to show UnnyNet window:

```java
unnynet.show();
```


###Congratulations!

Your game is a part of UnnyNet now and your players are happy!
