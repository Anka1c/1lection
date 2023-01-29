Console.WriteLine("Enter your name ");
String Name = Console.ReadLine();
if(Name.ToLower() == "anna")     //true       .ToLower() - считывает все буквы (большие, маленькие; anna, aNNa...)
{
  Console.WriteLine("Good Morning, my Queen Anna");
}
else                             //false
{
  Console.Write("Hi King ");
  Console.WriteLine(Name);
}