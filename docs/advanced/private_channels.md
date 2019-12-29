# Private Channels

Private chats can be used for a temporary group of players united with one goal. It can be a team chat for the current match in MOBA or a chat room for a board game player playing at the same desk.

### Join private channel
```csharp fct_label="Unity"
UnnyNet.UnnyNet.JoinPrivateChannel("channel_id", "display name");
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.joinPrivateChannel("channel_id", "display name");
```

```java fct_label="Java"
unnynet.joinPrivateChannel("channel_id", "display name");
```

This methods adds current player to the private channel. If the channel doesn't exists, it'll be created. 

* **channel_id** helps you to make sure you unite only the players you need to be in one group.
* **display name** is the name of the channel players see in UnnyNet windows.

### Leave private channels
There is one method to leave all private channels: 

```csharp fct_label="Unity"
UnnyNet.UnnyNet.LeaveAllPrivateChannels();
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.leaveAllPrivateChannels();
```

```java fct_label="Java"
unnynet.leaveAllPrivateChannels();
```

### Main feature of private channels

Private channels can be used to display everything in your UI. You can use the same [methods to send and receive messages](/advanced/chat) as for other chat channels, and the only difference is that you'll be able to read the message text from the client. It's stored under the key **message**.

### Limitations

Private channels have some limits though, which is a subject to change

* Max message size is limited to 100 symbols
* Max players in one channel is limited by 20
* Each player can present only in one private channel at a time. If you try to join another private channel, it'll remove you from the previous channel.


You can find an example of usage of Private Channels in our Unity Scene: **UnnyNet_PrivateChannel**. 
