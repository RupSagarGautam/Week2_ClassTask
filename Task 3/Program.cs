// See https://aka.ms/new-console-template for more information
byte a = 16;
short b = 32;
int c = 42;
long d = 128;
float e = 2.712345f;
double f = 3.1456789;
decimal g = 1.2345678m;
char h = 'A';
bool i = false;

int j = 42;
string changedToString = j.ToString();

string k = "3.14";
double changedToDouble = Convert.ToDouble(k);

Console.WriteLine($"Byte: {a}\nShort: {b}\nInt: {c}\nLong: {d}\nFloat: {e}\nDouble: {f}\nDecimal:{g}\nChar: {h}\nBool:{i}");