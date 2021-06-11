# Авторизация

Список методов аутентификации будет обновляться по мере добавления.

#### По почте

```csharp fct_label="Unity"
UnnyNet.Auth.WithEmail(<email>, <password>, authResponse =>
{
    Debug.Log("Authorized " + authResponse.Success);
    if (authResponse.Success)
        Debug.Log("User id: " + authResponse.UserId);
});
```

#### По имени и паролю

```csharp fct_label="Unity"
UnnyNet.Auth.WithName(<username>, <password>, authResponse =>
{
    Debug.Log("Authorized " + authResponse.Success);
    if (authResponse.Success)
        Debug.Log("User id: " + authResponse.UserId);
});
```

#### Как гость, используя Device ID

```csharp fct_label="Unity"
UnnyNet.Auth.AsGuest(authResponse =>
{
    Debug.Log("Authorized " + authResponse.Success);
    if (authResponse.Success)
        Debug.Log("User id: " + authResponse.UserId);
});
```
