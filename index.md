A core mod that makes it easier to access PlayerData, use reflection and use on/il hooks.   
# Explanation of features:
## **PlayerDataAccess** 
A class that allows you to access PlayerData as properties while also using best practices (i.e. going through PlayerData.Get/Set functions).
```cs
//the normal way to set health
PlayerData.instance.SetInt(nameof(PlayerData.health), PlayerData.instance.GetInt(nameof(PlayerData.health) - 1));

//with HKMirror
PlayerDataAccess.health -= 1
```  

To use, add a `using HKMirror;` and get/set fields the same way you would do with `PlayerData.instance.` but instead use `PlayerDataAccess.`
## **HKMirror.Reflection** 
HKMirror does all the reflection for you, allowing you to call any private field/method in almost any class effortlessly.  

To use, add a `using HKMirror.Reflection;` and call the extension method `.Reflect()` on any instance of the class you want to have publicised access to.  
```cs
//easy way to access enemy type which is normally private
gameObject.GetComponent<HealthManager>().Reflect().enemyType = 6;

//set is gameplay scene to true which is normally private
GameManager.instance.cameraCtrl.Reflect().isGameplayScene = true;
```
For convenience, common classes like HeroController and GameManager can be accessed as `HeroContollerR.DoAttack()` with a `using HKMirror.Reflection.SingletonClasses;` 
## **HKMirror.Hooks.OnHooks** 
The On Hooks contain all on hooks that are available in the `On` namespace plus hooks for methods that aren't there such as API generated methods and property getter/setters.  

To use, add a `using HKMirror.Hooks.OnHooks` and find the class you want, in this example GameManager. The class in HKMirror will be called OnGameManager and there are 3 subclasses in it, BeforeOrig, AfterOrig, WithOrig. 
* BeforeOrig are events which are invoked before orig(self) is called in an onhook. You can access the parameters through accessing the fields of the passed in `args`.
```cs
OnGameManager.BeforeOrig.IncreaseGameTimer += args => //args has 2 fields, GameManager self and float timer (just like normal on hooks)
  {
     Log(args.timer); //this log statement will be run before orig(self) is called.
  }
``` 
* AfterOrig are events which are invoked after orig(self) is called in an onhook. You can access the parameters through accessing the fields of the passed in `args`.
```cs
OnGameManager.AfterOrig.IncreaseGameTimer += args => 
  {
     Log(args.timer); //this log statement will be run after orig(self) is called.
  }
``` 
* On the other hand, WithOrig work like, and are structured like normal On Hooks
```cs
OnGameManager.WithOrig.IncreaseGameTimer += (orig, self, timer) => 
  {
    Log(args.timer) //this log statement will be run before orig(self) is called.
    orig(self); //run the original function
    Log(args.timer); //this log statement will be run after orig(self) is called.
  }
``` 

## **HKMirror.Hooks.ILHooks** 
The IL hooks contain all correct IL Hooks (i.e gives the GetStateMachineTarget version of IEnumerators ILs that run after every yeild return as opposed to regular IL Hooks) and includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.  

To use, add a `using HKMirror.Hooks.ILHooks` and find the class you want, in this example HeroContoller. The class in HKMirror will be called ILHeroController in which there are the il hooks you can hook onto.
```cs
ILGameManager.IncreaseGameTimer += (il) => 
  {
    //the IL hook code
  }
```

## Explanation of namespaces:
* HKMirror
  * PlayerDataAccess
  * HKMirror.Reflection
    * HKMirror.Reflection.SingletonClasses - Contains publicised access to common singleton classes
      * HeroController, GameManager, UIManager, SceneData, InputHandler, GameCameras
    * HKMirror.Reflection.StaticClasses - Contains publicised access to static classes
      * e.g. BossSequenceController, Language, etc. 
    * HKMirror.Reflection.InstanceClasses - Contains publicised access to instance classes
      * e.g. HealthManager, DamageHero, etc.
  * HKMirror.Hooks
    * HKMirror.Hooks.OnHooks - Contains the on hook events to hook onto
    * HKMirror.Hooks.ILHooks - Contains the il hook events to hook onto
