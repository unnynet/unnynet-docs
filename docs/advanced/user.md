# User

General methods to receive the data, but in most cases you need to write your own callback, because the Response class is always different.

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

### User's public info

```csharp fct_label="Unity"
UnnyNet.User.GetPlayerPublicInfo(ResponceReceived);
```

```csharp fct_label="JavaScript"
UnnyNet.User.getPlayerPublicInfo(responseReceived);
```

### Change user's display name

```csharp fct_label="Unity"
UnnyNet.User.SetDisplayName("display_name");
```

```csharp fct_label="JavaScript"
UnnyNet.User.setDisplayName("display_name");
``` 


### Change user's avatar

```csharp fct_label="Unity"
UnnyNet.User.SetAvatar(<avatar_id>);
```

```csharp fct_label="JavaScript"
UnnyNet.User.setAvatar(<avatar_id>);
```

In order to change user's avatar you need to get avatar_id. You can request the list of default avatars or if you have uploaded avatars for the game, you can request them as well.

 
### Get Default Avatars

```csharp fct_label="Unity"
UnnyNet.User.GetDefaultAvatars(ResponceReceived);
```

```csharp fct_label="JavaScript"
UnnyNet.User.getDefaultAvatars(ResponceReceived);
```

### Get Game Avatars

```csharp fct_label="Unity"
UnnyNet.User.GetGameAvatars(ResponceReceived);
```

```csharp fct_label="JavaScript"
UnnyNet.User.getGameAvatars(ResponceReceived);
```

Both GetDefaultAvatars and GetGameAvatars have the same response type: GetAvatarsResponseData.
In the GetAvatarsResponseData.Data there are just 2 properties: the string RemoteUrl and the array AvatarsInfo.
* **RemoteUrl** is the remote folder, where all avatars are located. 
* **AvatarsInfo** is the array of avatars, where each element has **Name** and **Id**. The **Id** is required in SetAvatar method. **Name** is used to get the full address of the avatar in case you are planing to display them in your game: **avatar_url = RemoteUrl + Name**
