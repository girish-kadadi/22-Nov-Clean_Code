review1.cs
public bool IsShopOpen(string day)
{
    if (!string.IsNullOrEmpty(day))
    {
        day = day.ToLower();
        if (day == "friday")
        {
            return true;
        }
        else if (day == "saturday")
        {
            return true;
        }
        else if (day == "sunday")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }

}

public bool IsShopOpen(string day)
{
    if (!string.IsNullOrEmpty(day))
    {
        day = day.ToLower();
        if (day == "friday" || day == "saturday" || day == "sunday")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }

}
----------------------------
  review3.cs
  public long Fibonacci(int n)
{
    if (n < 50)
    {
        if (n != 0)
        {
            if (n != 1)
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            else
            {
                return 1;
            }
        }
        else
        {
            return 0;
        }
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}

public long Fibonacci(int n)
{
    if(n>50)
    {
      throw new System.Exception("Not supported");
    }
    if (n != 0 || n != 1)
    {
      return n;
    }
  return return Fibonacci(n - 1) + Fibonacci(n - 2);
}
--------------------
  review4.cs
  var l = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < l.Count(); i++)
{
    var li = l[i];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(li);
}

var CityNamesList = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < l.Count(); i++)
{
    var CityName = CityNamesList[i];
    DoStuff();
    DoSomeOtherStuff();
    Dispatch(CityName);
}
-------------------------

  review5.cs
  if (userRole == 8) // Check if Admin 
{
    
}

const int userRoleId = 8;
if (userRole == userRoleId) // Check if Admin 
{
    
}
--------------------------------
  review6.cs
  public class Car
{
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public string CarColor { get; set; }

    //...
}
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    //...
}
---------------------
  review7.cs
  var ymdstr = DateTime.UtcNow.ToString("MMMM dd, yyyy");
  var DateMonthYear = DateTime.UtcNow.ToString("MMMM dd, yyyy");
-------------
review9.cs
public void CreateMicrobrewery(string name = null)
{
    var breweryName = !string.IsNullOrEmpty(name) ? name : "Hipster Brew Co.";
    // ...
}
public void CreateMicrobrewery(string name = "Hipster Brew Co.")
{

}
