# Платежи

1.  Откройте раздел **Platforms** и добавьте всю информацию о платформах, на которых доступна игра. Это необходимо для механизма подтверждения покупок.
2.  Откройте раздел **Products** и заполните всю информацию о продуктах, которые присутствуют в вашей игре. В большинстве случаев вам просто нужна основная таблица. Но, у товаров отличаются ProductId или Nameдля разных платформ, вы можете в разделе **override** переопределить данные продуктов для необходимых платформ.
3.  Получить список продуктов:

        Balancy.Payments.GetProducts(productsResponse =>
        {
            Debug.Log("Products Received " + productsResponse.Success);
            if (productsResponse.Success)
                Debug.Log("Products Count: " + productsResponse.Products.Length);
        });
    
4.  Сделать покупку:

        Balancy.Payments.PurchaseProduct(<product_id>, doneCallback =>
        {
            Debug.Log("Purchase was made " + doneCallback.Success);
        });
