# Conditions

Conditional Logic can be applied to any document. Currently we use it to run [GameEvents](/smart_offers/game_events). Any condition starts with one of 2 logical operators **And** / **Or**. Then you can add any other types of conditions. Condition can be as complex and nested as you want.

*   **Dates Range**, **Day Of The Week** and **Time Of The Day** are conditions based on a specific times.
*   **ABTest Condition** checks if the user was assigned to a specific ABTest and Variant.
*   **Active Event** triggers only if the specified **GameEvent** is active right now.
*   **Segment Condition** checks if the user belongs to a specific Segment.

We'll be adding new Conditions. Please let us know if you need some.

### Section for programmers

**GameEvent** documents take care about the conditional logic, however if you want to add conditions to your documents, here is what steps you need to do:

*   Let's say you have a Document called **MyDocument** with a conditional parameter **Condition**.
*   Use interface for your class **IConditionsListener** which will be responsible for the logic. Usually it's some sort of a Manager. 
*   Call the following method **ConditionsManager.Subscribe(MyDocument.Condition, MyDocument, this, <Current_Active_State>);**
*   The default condition value (True or False) is the forth parameter in the method above. Whenever the condition state changes one of the following methods from teh interface **IConditionsListener** is called on your Manager:

    *   public void ConditionPassed(object data);
    *   public void ConditionFailed(object data);
   
*   The **data** parameter in the methods above is the second parameter you send to the **ConditionsManager.Subscribe** - it's **MyDocument** in our example.

```csharp fct_label="Unity"
public class Manager : IConditionsListener
{
    private void Start()
    {
        foreach (var ev in DataManager.GameEvents)
            ConditionsManager.Subscribe(ev.Condition, ev, this, IsGameEventActive(ev));
    }
    
    public void ConditionPassed(object data)
    {
        if (data is GameEvent gameEvent)
            StartEvent(gameEvent);
    }
    
    public void ConditionFailed(object data)
    {
        if (data is GameEvent gameEvent)
            StopEvent(gameEvent);
    }
    
    ....
    ....
    ....
}
``` 

#### [Back: Overview](/smart_offers/overview)
