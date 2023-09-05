//1
/
string input = Console.ReadLine();
bool isValid = IsPasswordValid(input);
Console.WriteLine(isValid);

bool IsPasswordValid(string password)
{
    bool isLonger = password.Length > 8;
    return isLonger;

    //return password.Length



//1.1
Console.WriteLine("email: ");
string email = Console.ReadLine();
Console.WriteLine(IsEmailValid(email));

static bool IsEmailValid(string email)
{
    return email.Contains("@") && email.Contains(".");
}



//1.2

Console.WriteLine("convert to euros");
float userInput = Convert.ToSingle(Console.ReadLine());

float sum = ConvertToEuros(userInput);
Console.WriteLine($" {sum} Eur.");

float ConvertToEuros(float dollars)
{
    return dollars * 0.85f;
}



//2

Console.WriteLine("vardas, pavarde: ");
string firstname = Console.ReadLine();
string lastName = Console.ReadLine();

string initials = GetInitials(firstname, lastName);
Console.WriteLine(initials);

string GetInitials(string name, string surname)
{
    return name.Substring(0, 1) + "." + surname.Substring(0, 1) + ".";
}


//2.1

Console.WriteLine("iveskite cilindro spinduli ir auksti: ");
double radius = Convert.ToDouble(Console.ReadLine());
double height = Convert.ToDouble(Console.ReadLine());
double together = CalculateCylinderVolume(radius, height);
Console.WriteLine("turis: " + together);

double CalculateCylinderVolume(double spind, double aukstis)
{
    return 3.14 * (Math.Pow(spind, 2)) * aukstis;
}


//2.2

Console.WriteLine("iveskite skaiciu: ");
int userInput = Convert.ToInt32(Console.ReadLine());
bool ret = IsNumberEven(userInput);
Console.WriteLine(ret);

bool IsNumberEven(int number)
{
    return number % 2 == 0;
}


//2.3

Console.WriteLine("iveskite ilgi ir ploti: ");
double length = Convert.ToDouble(Console.ReadLine());
double width = Convert.ToDouble(Console.ReadLine());
double result = CalculateRectangleArea(length, width);
Console.WriteLine(result);

double CalculateRectangleArea(double plot, double ilg)
{
    return plot * ilg;
}
