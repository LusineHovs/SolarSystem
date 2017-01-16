# SolarSystem
Introduction of Solar System planets using Indexers (C# 6.0) 

In the documents you can find **StarSystem** abstract class with the following fields.

```C#
protected string systemName { get; set; }
protected int planetsNumber { get; set; }
protected string[] planetsName { get; set; }
```
And you can find **SolarSystem** concrete class which derived from **StarSystem**.
By using **Indexers** I set indexes to planets' name.

```C#
public string this[int index]
{
   get
       {
         if (index < 0 && index > planetsNumber)
            throw new IndexOutOfRangeException();
         return planetsName[index];
       }
   set
       {
          planetsName[index] = value;
       }
       }
 ```
 In **Testing** folder is executable program, outputs of execution are following
 
 # Outputs
 
- The 1st planet of SolarSystem is Mercury
The 2st planet of SolarSystem is Venus
The 3st planet of SolarSystem is Earth
The 4st planet of SolarSystem is Mars
The 5st planet of SolarSystem is Jupiter
The 6st planet of SolarSystem is Saturn
The 7st planet of SolarSystem is Uranus
The 8st planet of SolarSystem is Neptune
The 9st planet of SolarSystem is Pluto

        
