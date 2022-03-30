# Smart Objects

**Smart Objects** is a new section, where you can create your user's profile.

![Screenshot](../../img/smart_offers/table_smart_objects.jpg)

This section works very similar to **Templates** section, so you should be very familiar.
You can create 2 types of Smart Objects: 

*   **ParentBaseData** - the root element for your player's profile. It can have parameters of type BaseData only.
*   **BaseData** - additional layer, which will be stored in one or many **ParentBaseData**. It can have parameters of single types only  (temporary): int, float, string, bool. 

When you specify a profile, you can start using it in Visual Scripting. For example you can store player's level, gold coins, attribution campaign, etc... in the profile and then use that data to segment players and decide which Offer you want to give to the player.

You need to load player's profile in order to make operations with it. Don't forget to [generate the code](/data_editor/code_generation) every time you make changes in the structure of Smart Objects.

```csharp fct_label="Unity"
Balancy.SmartStorage.LoadSmartObject<DefaultProfile>(null, responseData =>
{
    var profile = responseData.Data;
});
```

#### [Next: Smart Offers](/smart_offers/smart_offers)
