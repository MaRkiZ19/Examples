Console.Write("Add your user name: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Yo, this is Masha!");
}
else 
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
