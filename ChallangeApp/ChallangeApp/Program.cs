
int age = 30;
string name = "Ewa";
string sex = "kobieta";
//
if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}

else if (sex != "kobieta" && name != "Ewa" && age != 30)
{
    Console.WriteLine("   ");
}