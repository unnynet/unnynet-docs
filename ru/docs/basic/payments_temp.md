# Payments

Balancy offers a one line purchase system for all the platforms. The list of available platforms is available in your Admin Panel and it'll be updated.

#### Add purchases information to Balancy platform:

//TODO
 
#### Prepare Unity

Please follow unity instructions to activate payments. You just need to implement everything before the section **Making a Purchase Script** - we have already did the rest for you.
https://learn.unity.com/tutorial/unity-iap#5c7f8528edbc2a002053b46e

#### Make Purchase

```csharp fct_label="Unity"
Balancy.Payments.PurchaseProduct(<balancy_purchase_id>, doneCallback);
```

#### Get list of available Purchases

```csharp fct_label="Unity"
Balancy.Payments.GetProducts(doneCallback);
```

This can be used if you want to display the list of available purchases with the prices. But we would recommend to create your own StoreItems system with [Data Editor](/data_editor/basic). It'll be more flexible. 

#### Get list of already purchased products:

```csharp fct_label="Unity"
Balancy.Payments.GetPurchases(Balancy.Constants.PurchaseStatusFilter.Claimed, doneCallback);
```

#### Restore Purchases

Sometimes something can go wrong, for example a player had purchased a product, but the game crashed and he didn't get the item. We have prepared a method which might help in such situations.

```csharp fct_label="Unity"
Balancy.Payments.RestorePurchases(doneCallback);
```

We recommend to call it every time a player opens your Store Window.
