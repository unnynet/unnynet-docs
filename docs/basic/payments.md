# Payments

1.  Open **Platforms** section and add all the information about the Platforms, where the game is available. It's required to validate the purchases.
2.  Open **Products** section and fill all the information about the Products your game has. In most cases you just need the main table, however if you have different ProductId, Name or Price for different platforms, you might want to use **override** section for each of the platforms.
3.  Get List Of Products:

```csharp fct_label="Unity"
UnnyNet.Payments.GetProducts(productsResponse =>
{
    Debug.Log("Products Received " + productsResponse.Success);
    if (productsResponse.Success)
        Debug.Log("Products Count: " + productsResponse.Products.Length);
});
``` 

4.  Get List Of Products:

```csharp fct_label="Unity"
UnnyNet.Payments.PurchaseProduct(<product_id>, doneCallback =>
{
    Debug.Log("Purchase was made " + doneCallback.Success);
});
``` 
