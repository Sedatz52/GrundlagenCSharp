// Aufgabe 1
string a = "Hallo";
string b = "H";
b += "allo";
Console.WriteLine(b);

a = "Hallo";
b = "H";
b += "allo";
Console.WriteLine(b.Length);

a = "Hallo";
b = "H";
b += "allo";
Console.WriteLine(a == b);


a = "Hallo";
b = "H";
b += "allo";
Console.WriteLine((object)a == b);

// Aufgabe 2

double x = 2.0;
double y = x * x + 1 + x / 4;
Console.WriteLine(y);

x = 2.0;
y = x * (x + 1 + x / 4);
Console.WriteLine(y);

bool b2 = true && false || 5 > 6;
Console.WriteLine(b2);

int z = 50;
bool numeric = z > 47 && z < 58;
Console.WriteLine(numeric);
