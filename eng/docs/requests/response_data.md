# Requests, Response Data and Errors

All Balancy methods are asynchronous with a callback as an argument, which is invoked once the method is complete. The parameter of the callback is inherited from **ResponseData**.    

 
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

You need to check if **Success** is true to be sure that the request was successful, and the Data is valid. Otherwise, you need to read **Error** to understand what went wrong. Here is the list of error, which might occur:

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

If everything is ok, you can read **responseData.Data** if needed.
