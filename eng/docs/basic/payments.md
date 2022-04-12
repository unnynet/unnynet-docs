# Payments

1.  Open **Platforms** section and add all the information about the Platforms, where the game is available. It's required to validate the purchases.
2.  Open **Products** section and fill all the information about the Products your game has. In most cases you just need the main table, however if you have different ProductId, Name or Price for different platforms, you might want to use **override** section for each of the platforms.
3.  Get List Of Products:

        Balancy.Payments.GetProducts(productsResponse =>
        {
            Debug.Log("Products Received " + productsResponse.Success);
            if (productsResponse.Success)
                Debug.Log("Products Count: " + productsResponse.Products.Length);
        });

4. Make purchase:

        Balancy.Payments.PurchaseProduct(<product_id>, doneCallback =>
        {
            Debug.Log("Purchase was made " + doneCallback.Success);
        });
        
5. If you are using our [Smart Offers](/smart_offers/basic), use the next method to purchase an [Offer](/smart_offers/smart_offers) and a [Store Item](/smart_offers/extra/other_templates)
        
        Balancy.SmartObjects.Manager.PurchaseOffer(offerInfo, purchaseResponse =>
        {
            Debug.Log("Purchase status " + purchaseResponse.Success + " for " + purchaseResponse.ProductId);
        });
        
        Balancy.SmartObjects.Manager.PurchaseStoreItem(storeItem, purchaseResponse =>
        {
            Debug.Log("Purchase status " + purchaseResponse.Success + " for " + purchaseResponse.ProductId);
        });
        
7. If you are using your own Payment/Validation system, you just need to confirm the purchase with Balancy. This information will only be used for future [Segmentation](/smart_offers/visual_scripting/segmentation) and will be saved in the profile history if the purchase if valid.

        var paymentInfo = new PaymentInfo
        {
            Receipt = unityProduct.receipt,
            Price = (float)unityProduct.metadata.localizedPrice,
            Currency = unityProduct.metadata.isoCurrencyCode,
            ItemId = unityProduct.definition.id
        };
        
        Balancy.SmartObjects.Manager.OfferWasPurchased(offerInfo, paymentInfo, purchaseResponse =>
        {
            Debug.Log("Purchase status " + purchaseResponse.Success + " for " + purchaseResponse.ProductId);
        });
        <-- OR -->
        Balancy.SmartObjects.Manager.ItemWasPurchased(storeItem, paymentInfo, purchaseResponse =>
        {
            Debug.Log("Purchase status " + purchaseResponse.Success + " for " + purchaseResponse.ProductId);
        });

8.  To get the list of all the payments the user made, call the following method (make sure to do that after **ExternalEvents.SmartObjects.SmartObjectsInitializedEvent** is invoked)

        UnnyProfileManager.GetPaymentsInfo();

