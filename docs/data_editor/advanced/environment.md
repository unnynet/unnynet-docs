# Environment

We provide each game with 3 Environments: Development, Stage and Production. It's a standard and commonly user approach.

1. **Development** used during the development process. All new features, bug fixes are created here.
2. **Stage** can be skipped by Indie developers. It's used usually by big companies, which have their own QA department. This environment is used for testing all the features, which were created before. Separate environment for testing is helpful, because it doesn't require the development team to stop.
3. **Production** this is where all your live clients are playing.


### Workflow

1.  New features are being developed and balanced on the **Development** environment.
2.  Once you ready, open Environment section and migrate your **Development** data to the **Stage** environment.
3.  It'll erase all the changes you made in **Stage** environment and copy everything from the **Development**.
4.  Give the build, connected to the **Stage** environment to your QA.
5.  Once QA approves the build, transfer the data from **Stage** to **Production** and publish your game build (connected to the **Production**) in the stores.

### Changing of the environment

You should try to avoid changing the environment in DE. In the best case scenario you just need to work in the **Development** and then transfer the data to other environments. UnnyNet even doesn't support transferring the environment's data in the opposite direction.

However there are situation when you might need to change something in the **Production** environment. 

Let's say you have already published your game and your users are playing in the **Production** environment. Then you find some bug in the balance, which you want to fix asap. Your team has already prepared tons of changes in the **Development**, so you can't migrate everything to the **Production** without updating the build. So the solution here is to switch to the **Production** environment in DE, fix your balance and Deploy the changes. That's it! Just don't forget to make the same changes in the **Developement**.

### Data Migration

In the Environment section you can migrate you data
1. From **Development** to **Stage**
2. From **Stage** to **Production**

When you start a migration process, there are many things are happening. For example when you transfer the data from Dev to Stage, under the hood is happening:
1.  [Deploy](/data_editor/advanced/deploy) is called for **Development**.
2.  All the data is transferred from **Dev** to **Stage**, overriding all the changes made in **Stage** before.
3.  [Deploy](/data_editor/advanced/deploy) is called for **Stage**.

It means that if you want to send all the data from the **Dev** to **Prod**, you just need to transfer the data from **Dev** to **Stage** and then to **Prod**. You don't need to Deploy anything afterwards. That was already made during the migration.    

### How to connect to the proper 

We usually use [Define Symbols](https://docs.unity3d.com/Manual/PlatformDependentCompilation.html) to deal with different environments:

```csharp fct_label="Unity"
UnnyNet.Main.Init(new AppConfig
{
    ApiGameId = <API_GAME_ID>,
    PublicKey = <PUBLIC_KEY>,
    OnReadyCallback = response =>
    {
        if (!response.Success)
            Debug.LogError("Couldn't initialize UnnyNet");
    },
    Environment = GetEnvironment()
});
            
public static UnnyNet.Constants.Environment GetEnvironment()
{
#if SERVER_PROD
    return UnnyNet.Constants.Environment.Production;
#elif SERVER_STAGE
    return UnnyNet.Constants.Environment.Stage;
#else
    return UnnyNet.Constants.Environment.Development;
#endif
}
```

Then you just need to switch the define symbols between **SERVER_DEV**, **SERVER_STAGE** and **SERVER_PROD** before you launch your game in Unity or make a build to make it connect to different environment.
Of course you might want to be able to change the environment at runtime for the testing purposes. Just be careful and don't let your end users to be able to connect to an environment different from the **Production**. 
