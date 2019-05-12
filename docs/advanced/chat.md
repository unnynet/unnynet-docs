# Real-time Chat

Realtime chat makes it easy to power a live community. Users can chat with each other 1-on-1 and in chat channels you create. Messages can contain images, emojis, links, and other content. Our channels can scale to millions of users all in simultaneous communication. This is perfect for live participation apps or games with live events or tournaments.

![Screenshot](../img/chat_1.jpg)

1.  Open game settings
2.  Select Channels section
3.  Add/remove or edit channels in this section

Channels can be edited even after the game is released.


### Game Messages
Game messages can be used to share special moments of a player with the community. For example if a players completes a hard achievement or summons a rare monster, why not to tell about that to everybody? Game messages can do that automatically on behalf on a player. Messages can be sent only to the game channels.

    UnnyNet.UnnyNet.SendMessageToChannel("achievements", "Made a successful evolution to 3★");

Sends "Made a successful evolution to 3★" message to the "achievements" channel on behalf on the player.
