//and(&&) or(||) logical operations

string username, password;
Console.WriteLine("Enter your username:");
username = Console.ReadLine();

Console.WriteLine("Enter your password");
password = Console.ReadLine();

//if(username == "admin" && password == "Yavuz1910")
//{
//    Console.WriteLine("Welcome");
    
//}
//else
//{
//    Console.WriteLine("Invalid username or password");
//}

if(username != "admin" || password != "admin1910")
    {
    Console.WriteLine("Invalid username or password");
}
else
{
    Console.WriteLine("Welcome");
}