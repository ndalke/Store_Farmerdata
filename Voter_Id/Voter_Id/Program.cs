/// <summary>
///Create a class Voter(voterId, name, age) with parameterized constructor.
//The parameterized constructor should throw a checked exception if age is less
//than 18. The message of exception is “invalid age for voter ”
/// </summary>

//class voter
class Voter
{
    int voterId;
    string name;
    int age;
    //perametrised constructor
    public Voter(int voterId,string name,int age)
    {
        this.voterId = voterId;
        this.name = name;
        this.age = age;
        //try and catch
        try
        {
            if (age >= 18)
            {
                Console.WriteLine("You are eligible for votting");
            }
            else
            {
                //throw exception
                throw new Exception("You are not eligible");
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
class Program
{
    public static void Main()
    {
        Voter v = new Voter(123,"Neha",12);

    }
}