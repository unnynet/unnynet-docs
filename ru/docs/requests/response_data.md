# Requests, Response Data and Errors

Все UnnyNet методы являются асинхронными с аргументом в виде колбека, который вызывается после завершения. Тип аргумента колбека наследуется от **ResponseData**.


```csharp fct_label="Unity"
public class ResponseData {
    public bool Success;
    public Error Error;
    public object Data;
}

public class Error {
    public int Code;
    public string Message;
}
```

```csharp fct_label="JavaScript"
ResponseExample = {
    success: true,
    error: {
        code: 1,
        message: 'unknown error'
    },
    data: //some data depending on the request
}
```

Вам необходимо проверить значение **Success**, чтобы убедиться, что запрос завершился без ошибок. В противном случае вам нужно прочитать **Error**, чтобы понять, что пошло не так. Вот список возможных ошибок:

```
public enum Errors {
    NotInitialized = -1,
    Unknown = 1,
    
    NoAccessToken = 1000,
    StorageRequestsMadeTooOften = 1001,
    NoSuchProduct = 1002,
    StorageError = 1003,
    
    UnityPurchasing_PurchasingUnavailable = 1010,
    UnityPurchasing_NoProductsAvailable = 1011,
    UnityPurchasing_AppNotKnown = 1012,
    UnityPurchasing_ProductIsNotAvailable = 1013,
    UnityPurchasing_PurchaseFailed = 1014,
    
    Nutaku_Error = 1100,
};
```

Если никаких ошибок не было, при необходимости вы можете прочитать **responseData.Data**. 
