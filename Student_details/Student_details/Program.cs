//Create a class Student with two members : rollno and percentage.
//Create default and parameterized constructors. Create method show() to
//display information.
//Create another class CollegeStudent inherits Student class. Add a new
//member semester to it.Create default and parameterized constructors.Also
//override show() method.
//Create another class SchoolStudent inherits Student class. Add a new
//member classname(eg 12th ,10th etc.) to it.Create default and parameterized
//construtors.Also override show() method.c
//Create a class(say XYZ) with main method that carries out the operation of
//the project :
//--has array to store objects of any class(Student or CollegeStudent,
//SchoolStudent)
//--create two CollegeStudent and three SchoolStudent record objects and
//store them inside the array
//-- display all record from the array
//-- search record on the basic of rollno and check given rollno is of
//SchoolStudent or of CollegeStudent.
//--count how many students are having A grade, if for A grade percentage >75






// Create a class Student with two members : rollno and percentage.
 
class Student
{
    int rollno;
    float percentage;
    //property
    public double ROllNo
    {
        get
        {
            return rollno;
        }

        set
        {
            rollno =(int)value;
        }
    }
    //property
    public double Percentage
    {
        get
        {
            return percentage;
        }

        set
        {
            percentage = (float)value;
        }
    }

    //Create default and parameterized constructors.
    public Student()
    {

    }
    public Student(int roll_no,float per_centage)
    {
        this.rollno = roll_no;
        this.percentage = per_centage;
    }
    //Create method show() to display information.
    public virtual void Show()
    {
        Console.WriteLine("Rollno="+ROllNo+" Percentage="+Percentage);
    }
}

//Create another class CollegeStudent inherits Student class

class CollegeStudent :Student
{
    int semester;

   // Create default and parameterized constructors

    public CollegeStudent()
    {

    }
    public CollegeStudent(int sem,int roll_number,float percentage)
    {
        ROllNo = roll_number;
        Percentage = percentage;
        this.semester = sem;
    }
    //override show() method.
    
    public override void Show()

    {
        base.Show();
        Console.WriteLine("Semester=" + semester);
    }
}

//create SchoolStudent class and inherit Student class
class SchoolStudent:Student
{
    int classname;
    //default constructor
    SchoolStudent()
    {

    }
    //perameterized constructors
    public SchoolStudent(int class_name,int roll_number, float percentage)
    {
        ROllNo = roll_number;
        Percentage = percentage;
        this.classname = class_name;
    }
    //override show method
    public override void Show()
    {
        base.Show();
        Console.WriteLine("Class name=" + classname);
    }
}
//class main
class Having_main
{
    //main function
    public static void Main()
    {
        //array declaration of collegeStudent and SchoolStudent class 

        CollegeStudent[] clg = new CollegeStudent[2];
        SchoolStudent[] scl = new SchoolStudent[3];

        //storing data in college student array
        Console.WriteLine("Enter Semester,rollnumber and percentage of College Student");

        for (int i = 0; i < clg.Length; i++)
        {
            int sem = int.Parse(Console.ReadLine());
            int rollno = int.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());
            clg[i] = new CollegeStudent(sem, rollno, percentage);
        }
        //display college data
        for (int i = 0; i < clg.Length; i++)
        {
            clg[i].Show();
        }

        //storing data in Student student array
        Console.WriteLine("Enter class,rollnumber and percentage of School Student");
        for (int i = 0; i < scl.Length; i++)
        {
            int class_name = int.Parse(Console.ReadLine());
            int rollno = int.Parse(Console.ReadLine());
            int percentage = int.Parse(Console.ReadLine());
            scl[i] = new SchoolStudent(class_name, rollno, percentage);
        }
        //display student data
        for (int i = 0; i < scl.Length; i++)
        {
            scl[i].Show();
        }
        //search data by rollno
        Console.WriteLine("Enter roll number for search...");
        int rollnumber = int.Parse(Console.ReadLine());
        //if rollno==school
        for (int i = 0; i < scl.Length; i++)
        {

            if (rollnumber == scl[i].ROllNo)
            {
                scl[i].Show();
                Console.WriteLine(rollnumber + " is a School Student");
            }
        }         
           //if roll==college      
        for(int i = 0; i < clg.Length; i++)
        {
            if (rollnumber == clg[i].ROllNo)
            {
                clg[i].Show();
                Console.WriteLine(rollnumber + " is a College Student");
            }

        }
        // count student above 75% for school
        int count = 0;
        for (int j = 0; j < scl.Length; j++)
        {
            if (scl[j].Percentage > 75)
            {
                count++;
            }

        }
        // count student above 75% for college
        for (int j = 0; j < clg.Length; j++)
        {
            if (clg[j].Percentage > 75)
            {
                count++;
            }

        }
        Console.WriteLine("No. of student above 75 percantage:" + count);

    }
}
