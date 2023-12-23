Console.WriteLine("Please enter your birthyear to enter: ");
var userinput = Console.ReadLine();
if (int.TryParse(userinput, out var year))
{
    var birthdate = new DateTime(year, 1, 1);
    var currentyear = DateTime.Now.Year;
    var age = currentyear - birthdate.Year;
    if (age < 20)
        Console.WriteLine("Sorry, you are too young to enter");


    else
        Console.WriteLine("Wellcome in and Enjoy!");
}
