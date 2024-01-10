using SingletonPattern;

Singleton singletonInstance = Singleton.GetInstance();
singletonInstance.DisplayMessage();

//Example that this class cannot be instantiated directly
//Singleton singletonInstance1 = new Singleton();


Singleton anotherInstance = Singleton.GetInstance();

// The two instances are the same.
Console.WriteLine(singletonInstance == anotherInstance);

