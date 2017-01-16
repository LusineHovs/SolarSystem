# SolarSystem
Introduction of Solar System planets using Indexers (C# 6.0) 

In the documents you can find **StarSystem** abstract class with the following fields.

```C#
protected string systemName { get; set; }
protected int planetsNumber { get; set; }
protected string[] planetsName { get; set; }
```
And you can find **SolarSystem** concrete class which is the implementation of **StarSystem**.
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
 
 **Outputs**
 
  <img src="https://cloud.githubusercontent.com/assets/24455176/21983514/2132d82c-dc0b-11e6-9af1-128ea710fccc.jpg" width="150px"  /> 




        
