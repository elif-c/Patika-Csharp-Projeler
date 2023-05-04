int x = 3;
int y = 3;
y = y + 2;

Console.WriteLine("*** Islemli Atama ***");
y += 2;
y /= 1;
x *= 2;

Console.WriteLine("*** Mantiksal Operatorler ***");
// || --> veya
// && --> ve 
// ! --> degil

bool isSuccess = true;
bool isCompleted = false;

if(isSuccess && isCompleted)
{
    Console.WriteLine("Perfect!");
}

if(isSuccess || isCompleted)
{
    Console.WriteLine("Okay.");
}

if(isSuccess && !isCompleted)
{
    Console.WriteLine("Perfect-eh!");
}

Console.WriteLine("*** Iliskisel Operatorler ***");
// <, >, <=, >=, ==, !=
int a = 3;
int b = 4;
bool sonuc = a < b;
Console.WriteLine(sonuc);
sonuc = a > b;
Console.WriteLine(sonuc);
sonuc = a >= b;
Console.WriteLine(sonuc);
sonuc = a <= b;
Console.WriteLine(sonuc);
sonuc = a==b;
Console.WriteLine(sonuc);
sonuc = a != b;
Console.WriteLine(sonuc);

Console.WriteLine("*** Aritmetik Operatorler ***");
// /, *, +, -

int sayi1 = 10;
int sayi2 = 5;
int sonuc1 = sayi1 / sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1 * sayi2;
Console.WriteLine(sonuc1);
sonuc1 = sayi1 + sayi2;
Console.WriteLine(sonuc1);
sayi1++;
Console.WriteLine(sayi1);
sayi2--;
Console.WriteLine(sayi2);

Console.WriteLine("*** Mod alma ***");
int sonuc2 = 20 % 3;
Console.WriteLine(sonuc2);