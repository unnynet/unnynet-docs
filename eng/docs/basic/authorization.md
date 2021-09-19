# Authorization

The list of method for authentication will be updated and for some platform we'll try to automate this process.

#### Name and Password

```csharp fct_label="Unity"
Balancy.Auth.WithName(<username>, <password>, authResponse =>
{
    Debug.Log("Authorized " + authResponse.Success);
    if (authResponse.Success)
        Debug.Log("User id: " + authResponse.UserId);
});
```

#### As Guest using Device ID

```csharp fct_label="Unity"
Balancy.Auth.AsGuest(authResponse =>
{
    Debug.Log("Authorized " + authResponse.Success);
    if (authResponse.Success)
        Debug.Log("User id: " + authResponse.UserId);
});
```
