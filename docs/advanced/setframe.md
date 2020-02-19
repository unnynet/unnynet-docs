# Set Frame of UnnyNet Window

You can change the frame of UnnyNet window. 
Here is an example of how you can set UnnyNet to cover only the right half of the screen:

```csharp fct_label="Unity"
UnnyNet.MainController.SetFrame(new Rect(Screen.width/2, 0, Screen.width/2, Screen.height));
```

```csharp fct_label="JavaScript"
UnnyNet.UnnyNet.setFrame({
        top: 0,
        right: 0,
        left: '',
        bottom: 0,
        width: '50%',
        height: '100%'
    });
```
