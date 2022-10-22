A core mod that makes it easier to access PlayerData, use reflection and use on/il hooks.   
# Explanation of features:
## **PlayerDataAccess** 
  * A class that allows you to access PlayerData as properties while also using best practices (i.e. going through PlayerData.Get/Set functions). 
  * Can make your code from `PlayerData.instance.SetInt(nameof(PlayerData.health), PlayerData.instance.GetInt(nameof(PlayerData.health) - 1));` to `PlayerDataAccess.health -= 1`
  * How to use: add a `using HKMirror;` and get/set fields the same way you would do with `PlayerData.instance.` but instead use `PlayerDataAccess.`
## **HKMirror.Reflection** 
  * HKMirror does all the reflection for you, allowing you to call any private field/method in almost any class effortlessly.
  * How to use: add a `using HKMirror.Reflection;` and call the extension method `.Reflect()` on any instance of the class you want to have publicised access to. For example: `gameObject.GetComponent<HealthManager>().Reflect().enemyType = 6` (enemy type is normally a private field). For convenience, common classes like HeroController and GameManager can be accessed as `HeroContollerR.DoAttack()` with a `using HKMirror.Reflection.SingletonClasses;` 
## **HKMirror.Hooks** 
  * The On Hooks contain all on hooks that are available in the `On` namespace plus hooks for methods that aren't there such as API generated methods and property getter/setters.
    * How to use: add a `using HKMirror.Hooks.OnHooks` and find the class you want, in this example GameManager. The class in HKMirror will be called OnGameManager and there are 3 subclasses in it, BeforeOrig, AfterOrig, WithOrig. BeforeOrig are events which are invoked before orig(self) is called in an onhook. AfterOrig are events which are invoked after orig(self) is called in an onhook. In these, you can access the parameters through accessing the fields of the passed in `args` (e.g. `args.self`). An example would be `OnGameManager.BeforeOrig.IncreaseGameTimer += args => Log(args.timer);`. On the other hand, WithOrig work like, and are structured like normal On Hooks
  * The IL hooks contain all correct IL Hooks (i.e gives the GetStateMachineTarget version of IEnumerators ILs that run after every yeild return as opposed to regular IL Hooks) and includes ILHooks that aren't in the IL namespace such as API generated functions and property getters/setters.
    * How to use: add a `using HKMirror.Hooks.ILHooks` and find the class you want, in this example HeroContoller. The class in HKMirror will be called ILHeroController in which there are the il hooks you can hook onto.

## Available namespaces:
* HKMirror
  * PlayerDataAccess
  * HKMirror.Reflection
    * HKMirror.Reflection.SingletonClasses - Contains publicised access to common classes like HeroController and GameManager
    * HKMirror.Reflection.StaticClasses - Contains publicised access to static classes
    * HKMirror.Reflection.InstanceClasses - Contains publicised access to instance classes
  * HKMirror.Hooks
    * HKMirror.Hooks.OnHooks - Contains the on hook events to hook onto
    * HKMirror.Hooks.ILHooks - Contains the il hook events to hook onto
