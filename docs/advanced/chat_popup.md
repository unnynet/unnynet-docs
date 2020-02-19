# Chat Popup

When a player selects another player, a popup appear with a set of option:

*   View Profile
*   Add Friend
*   Mention
*   Set Role (For Creator only)
*   Ban (For Admins only)
*   Delete Message Role (For Admins only)

Some additional buttons might preset if the player is in the guild.

### Code example

As a game developer you can add additional buttons.
To achieve this you need to add a callback for OnPopupOpened event and return PopupButtons class:

```csharp fct_label="Unity"
UnnyNet.Events.OnPopupOpened = eventData => {
    UnnyNet.PopupButtons popup = new UnnyNet.PopupButtons();

    popup.AddButton("Test Button", () => {
        Debug.LogWarning("Test Button Clicked");
    }, UnnyNet.ButtonType.Info);

    popup.AddButton("Warn Button", () => {
        Debug.LogWarning("Warn Button Clicked");
    }, UnnyNet.ButtonType.Warning);

    return popup;
};
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.onPopupOpened = (prms) =>
{
    console.info("onPopupOpened", prms);
    
    const popup = new UnnyNet.PopupButtons();
    popup.addButton("Test 1", () => console.log("Test 1 Clicked"), UnnyNet.ButtonType.Success);
    popup.addButton("Test 2", () => console.log("Test 2 Clicked"), UnnyNet.ButtonType.Warning);
    return popup;
};
```

### Button parameters

You can add as many buttons as you want, just bear in mind the size of the screen. With AddButton method you can add a button a specify the following parameters:

*   Title on the button
*   Action, which triggers in case player selects this button
*   Optional parameter for the button style. You can view how they all look like in the Theme settings of your game.

### Incoming parameters

As you might've noticed there are additional parameters passed to the OnPopupOpened event:

*   DisplayName - the display name of the selected player
*   UnnyId - the unique id of the selected player
*   FriendState - your relationship with the player
*   Placement - where the popup was called from

If the player is in a guild, additional parameters are passed as well:

*   GuildId
*   GuildName
*   GuildMate - (true/false) indicates whether the player is in the same guild as current player  

