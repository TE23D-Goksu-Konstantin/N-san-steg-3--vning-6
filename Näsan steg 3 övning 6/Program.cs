using System;
class program
{
    
static void Main(string[] args)
{
string tal;
int tal2;
bool det = false;


    while(det == false)
{
    Console.Clear();
    Console.WriteLine("Vänligen skriv in ett tal");
    tal = Console.ReadLine();
    int.TryParse(tal, out tal2);

    if(int.TryParse(tal, out tal2))
    {
        Console.Clear();
        Console.WriteLine("Du skrev " + GetNumberInput(tal2) + ", tryck på enter om du vill fortsätta");
        Console.ReadLine();
    }else
    {
        Console.Clear();
        continue;
    }
}


}
static int GetNumberInput(int blabla)
{
    return blabla;
}

}
