//string[] names = {"Mathew Desjardins", "Sally Fields", "Joe Smith", "Susan Rice", "Mike Long"};

System.Console.Write("How many students do you want to enter? ");
int numStudents = Convert.ToInt32(Console.ReadLine());

if(numStudents > 20)
{
    numStudents = 20;
}

string[] names = new string[numStudents];


for(int i = 0; i < numStudents; i++)
{
    //the first student to be 1st
    if(i == 0)
    {
        Console.Write($"Please enter the {i + 1}st students full name: ");
        
    }
    //the second students to be 2nd
    else if(i == 1)
    {
        Console.Write($"Please enter the {i + 1}nd students full name: ");
    }
    //the third studetn to be 3rd
    else if(i == 2)
    {
        Console.Write($"Please enter the {i + 1}rd students full name: ");
    }
    //the fourth and more to be nth
    else
    {
        Console.Write($"Please enter the {i + 1}th students full name: ");
    }

    names[i] = Console.ReadLine();
}

string[] userNames = MakeUserNameList(names);
int[] studentId = MakeStudentIds(names.Length);
int[] studentLockers = MakeStudentLockers(names.Length);

int userChoice;

do{
    DisplayAllStudents(names);
    System.Console.Write("Which student would you like to see more information on? (-1 to exit)");
    userChoice = Convert.ToInt32(Console.ReadLine());
   
   if(userChoice != -1)
    {
        DisplaySpecificStudentInformation(names, userNames, studentId, studentLockers, userChoice);
    }

}while(userChoice != -1);


static void DisplayAllStudents(string[] names)
{
    for(int i = 0; i < names.Length; i++)
    {
        System.Console.WriteLine($"{i + 1}. {names[i]}");
    }
}

static void DisplayStudentInformation(string[] names, string[] userNames, int[] studentId, int[] studentLockers)
{
    for(int i = 0; i < names.Length; i++)
    {
        System.Console.WriteLine(names[i]);
        System.Console.WriteLine(userNames[i]);
        System.Console.WriteLine(studentId[i]);
        System.Console.WriteLine(studentLockers[i]);
    }
}

static void DisplaySpecificStudentInformation(string[] names, string[] userNames, int[] studentId, int[] studentLockers, int location)
{
  
        System.Console.WriteLine(names[location - 1]);
        System.Console.WriteLine(userNames[location - 1]);
        System.Console.WriteLine(studentId[location - 1]);
        System.Console.WriteLine(studentLockers[location - 1]);
    
}


static int[] MakeStudentIds(int number)
{
    Random rng = new Random();
    int[] studentIds = new int[number];

    for(int i = 0; i < number; i++)
    {
        studentIds[i] = rng.Next(10000, 1000000);    
    }

    return studentIds;
}

static int[] MakeStudentLockers(int number)
{
    Random rng = new Random();
    int[] studentLockers = new int[number];

    for(int i = 0; i < number; i++)
    {
        studentLockers[i] = rng.Next(1, 501);    
    }

    return studentLockers;
}

static string[] MakeUserNameList(string[] names)
{
    string[] userNames = new string[names.Length];

    for(int i = 0; i < names.Length; i++)
    {
        string[] splitUpName = names[i].Split(' ');
        userNames[i] = MakeUserName(splitUpName[0], splitUpName[1]);
        //splitUpName[0] = Mathew /// 0 FirstName
        //splitUpName[1] = Desjardins /// 1 LastNAme?
    }

    return userNames;
}


static string MakeUserName(string firstName, string lastName)
{
    string userName = firstName.ToLower().Trim()[0].ToString();
    userName += lastName.ToLower().Trim();

    return userName;
}