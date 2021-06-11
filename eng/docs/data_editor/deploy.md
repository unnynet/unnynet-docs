# Deploy

Whenever you change a Template or a Document in DE, it's saved on our servers, but not yet available for your end users. You can compare all the changes you make in DE with commits in GIT, with only difference that other DE users can see your commits. 

When you are ready to publish (like Push in git) your changes for the end users, you need open **Deploy** section in DE and click on **Deploy** button.
The process takes several seconds, and once it's completed, you can launch your game in Unity and get all the updated data.

Bear in mind that your are pushing only for the active Environment. If you want to push the changes to the Stage or Production environments, please use [Environment](/data_editor/advanced/environment) page for Data Migration.

## Versions

Before you deploy the new data, you can set a minimum version for your game and data:
![Screenshot](../../img/de_example/de_deploy.jpg)

If your game version (Unity->Player Settings->Version) is lower than any of 2 versions, the new data will not be downloaded.

### Min version to Launch Game
This version usually used to let your players know about a new game update available. It's up to the developer to implement all the logic, Balancy will only return an error in Init Method. This is how you can check if the game version is outdated (after you init Balancy): 

```csharp fct_label="Unity"
private bool IsVersionOutdated()
{
    var errors = Controller.GetErrors();
    foreach (var err in errors)
    {
        switch (err.Error.Code)
        {
            case Errors.GameVersion:
                return true;
        }
    }
    
    return false;
}
```

### Min version to Update Data
This version is usually used, when Templates in DE were dramatically changed, thus old clients won't be able to parse new structure correctly.

