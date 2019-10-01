# Close UnnyNet Window

Depending on a game, you might need to close UnnyNet window to display your in-game information. For example, if someone challenges you to the duel or invites you to play together.

```csharp fct_label="Unity"
UnnyNet.UnnyNetBase.CloseUnnyNet();
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.closeUnnyNet();
```

```java fct_label="Java"
unnynet.close();
```

### UnnyNet was closed event

Whenever UnnyNet window got closed (from the code or by the user action), the event triggers:

```csharp fct_label="Unity"
UnnyNet.UnnyNetBase.m_OnUnnyNetClosed = () => {
    Debug.Log("On UnnyNet was closed");
};
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.onUnnyNetClosed = () => {
    console.info("onUnnyNetClosed");
};
```
