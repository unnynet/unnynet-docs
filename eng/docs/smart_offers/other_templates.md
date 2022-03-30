# Other Templates

In the Smart Offers package there are some additional templates, which we need to cover in this section

### Item

An Item Document represents one entity within your game. It can be a sword, shield, wood, stone - anything from your game.

### Store Item

This is what we actually sell in our offers.

![Screenshot](../img/smart_offers/table_store_item.jpg)

Name              | Description
------------------|------
**Sprite**        | The image associated with this Store Item. Read more about [Data Objects](/data_editor/advanced/data_objects)
**Name**          | The name of the Store Item
**Price**         | The price of the current Store Item. It can contain soft or hard currencies.
**Reward**        | The list of **Items** with the amount you purchase.  


### Smart Config 

A singleton which store additional settings.

Name              | Description
------------------|------
**Offer Products** | Offers can have different prices and discounts, Balancy automatically finds the best product which can be associated with a specific Offer and Discount pair. Balancy search for the product from this very list.


#### [Next: Overview](/smart_offers/overview)
