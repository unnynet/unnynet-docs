# JavaScript Integration

1) Install UnnyNet using [npm](https://www.npmjs.com/package/unnynet) or just include the latest library: 
https://assetstore.unity.com/packages/slug/128920

2) Find your Game Id and Public Key in your game settings:

![Screenshot](../img/game_id_1_.jpg)

Read and accept Terms of Service first:
![Screenshot](../img/game_id_2_.jpg)

Copy Game ID and Public Key: 
![Screenshot](../img/game_id_3_.jpg)

3)  Call initialize method at start:

```
UnnyNet.UnnyNet.initialize({
    game_id: <your_game_id>,
    public_key: <your_public_key>,
    default_channel: <channel_id>,
    open_animation: UnnyNet.ViewOpenDirection.LEFT_TO_RIGHT
});
```

The full list of parameters:

*   game_id (mandatory) - the ID of your game in UnnyNet
*   public_key (mandatory) - the Public Key of your game in UnnyNet
*   default_channel (optional) - the default channel to open
*   open_animation (optional) - animation used to show the window
    *   UnnyNet.ViewOpenDirection.LEFT_TO_RIGHT
    *   UnnyNet.ViewOpenDirection.RIGHT_TO_LEFT
    *   UnnyNet.ViewOpenDirection.TOP_TO_BOTTOM
    *   UnnyNet.ViewOpenDirection.BOTTOM_TO_TOP

4)  Call the next method to show UnnyNet window:

```
UnnyNet.UnnyNet.openUnnyNet();
```

###Congratulations!

Your game is a part of UnnyNet now and your players are happy!
