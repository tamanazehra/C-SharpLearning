string permission = "Admin|Manager";
int level = 20;

if(permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin User.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin User");
    }  
}
else if(permission.Contains("Manager"))
{
    if(level >= 20)
    {
        Console.WriteLine("Contact an Admin for access");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges");
    }
}
else 
{
    Console.WriteLine("You do not have sufficient privileges");
}