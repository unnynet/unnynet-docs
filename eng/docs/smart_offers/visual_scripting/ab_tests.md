# A/B Tests

A/B testing is a way for developers to run a controlled experiment between two or more versions of something in their game to determine which is more effective. Your audience is segmented into two or more groups, the control group (current performance – no changes) and your test group.

A/B testing is a great way to find the best pricing, game difficulty or test any of your hypothesis.

There are currently 3 ways to work with A/B testing:

1.  [Conditions](/smart_offers/extra/conditions)
2.  Use the **AB Test** Node in Visual Scripting
3.  Make your own logic


### Section for programmers

After the initialization of the SmartObjects, you can get all current A/B tests and their values for the user. 

```csharp fct_label="Unity"
ExternalEvents.SmartObjects.SmartObjectsInitializedEvent += () =>
{
    //In this callback all A/B Tests were already loaded and assigned
    var allTests = AbTestsManager.GetAllTests();
    Debug.LogWarning("All Tests " + allTests.Count);
    foreach (var test in allTests)
        Debug.Log("Name = " + test.AbTest.Name + " ; Variant = " +test.Variant.Name + " ; isFinished = " + test.Finished);
};
```

#### [Next: Smart Offers](/smart_offers/smart_offers)
