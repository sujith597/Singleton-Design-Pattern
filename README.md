# Singleton-Design-Pattern

We can achieve singleton design pattern by keeping constructor as private ( so that no one can inherit ) 
and keep instance as static so that at any time it will have only one instance.

keep a method which return that single instance, one should use that instance for this needs.

we may face problem with multi threading, so we created a object and used lock(object).
this will lock that further threads which are trying to access it when one thread is running over it.

In Lock method internally, start() and exit() method calls will be there. if one thread is in lock block, it will throw exception starting it is already in use until exit method calls.

A single thread can call n number of times start() and exit() but at same time it both count should be equal.



Check list

Define a private static attribute in the "single instance" class.
Define a public static accessor function in the class.
Do "lazy initialization" (creation on first use) in the accessor function.
Define all constructors to be protected or private.
Clients may only use the accessor function to manipulate the Singleton.

