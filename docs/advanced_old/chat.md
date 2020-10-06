# Real-time Chat

Realtime chat makes it easy to power a live community. Users can chat with each other 1-on-1 and in chat channels you create. Messages can contain images, emojis, links, and other content. Our channels can scale to millions of users all in simultaneous communication. This is perfect for live participation apps or games with live events or tournaments.

![Screenshot](../img/chat_1.jpg)

1.  Open game settings
2.  Select Channels section
3.  Add/remove or edit channels in this section

Channels can be edited even after the game is released.

### Game Messages
Game messages can be used to share special moments of a player with the community. For example if a players completes a hard achievement or summons a rare monster, why not to tell about that to everybody? Game messages can do that automatically on behalf on a player. Messages can be sent only to the game channels.
```csharp fct_label="Unity"
UnnyNet.Chat.SendMessageToChannel("channel_id", "Made a successful evolution to 3");
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.sendMessageToChannel("channel_id", "Made a successful evolution to 3");
```

```java fct_label="Java"
unnynet.sendMessageToChannel("channel_id", "Made a successful evolution to 3");
```

Sends "Made a successful evolution to 3" message to the channel with id "channel_id" on behalf on the player. You can find "channel_id" right above the name of the channel in the channels settings.

### New Message Received
You might want to show notification in the game once a player receives a message. Just 

```csharp fct_label="Unity"
UnnyNet.Events.OnNewMessageReceived = eventData => {
    Debug.LogFormat("New Message received from user {0} ({1}); Placement = {2}", eventData.SenderName, eventData.SenderId, eventData.Placement);
};
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.onNewMessageReceived = (prms) => {
    console.info("onNewMessageReceived", prms);
};
```

**channel_name** doesn't present for direct messages.  
**UnnyNet.ChannelType** is the enum with 3 values:

1.  **Global** - one of the general channels. Which one is specified in **channel_name**
2.  **Direct** - a private message from a friend
3.  **Guild** - a message from my guild mate 