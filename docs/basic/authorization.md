# Authorization

The list of method for authentication will be updated and for some platform we'll try to automate this process.

#### Email

```csharp fct_label="Unity"
UnnyNet.Auth.WithEmail(<email>, <password>, doneCallback);
```

#### Name and Password

```csharp fct_label="Unity"
UnnyNet.Auth.WithName(<username>, <password>, doneCallback);
```

#### As Guest using Device ID

```csharp fct_label="Unity"
UnnyNet.Auth.AsGuest(doneCallback);
```
