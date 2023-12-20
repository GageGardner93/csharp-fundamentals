using Myfirstapplication;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// The below staement calls a local function
//single line comment
HouseExample();

 void HouseExample() 
    /*
     Multi-line comment
    The below statement is a local fumction. Local functions
    are inside of the memembers and are private by default. this means
    they are specific to that member and can only be called 
    inside that member.
     */
{
House myHouse = new House();
myHouse.DoorOpenClose();
}


   