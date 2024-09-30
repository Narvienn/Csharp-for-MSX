// All functions and objects/instances of classes need to be contained in a class - '{}' defines the class scope
//Instances of class are created using the _new_ keyword:

class Addition
{
    public int Add(int x, int y)
    {
        return x + y;
    }

}

var simpleMaths = new Addition();

//Passing function/method arguments + calling a function on a class object:

//One way:
var sum_1 = simpleMaths.Add(1,2);

//Another way:
var sum_2 = simpleMaths.Add(x:1, y:2);