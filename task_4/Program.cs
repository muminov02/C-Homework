string first = Console.ReadLine();
string second = Console.ReadLine();
string third = Console.ReadLine();
int f = int.Parse(first);
int s = int.Parse(second);
int t = int.Parse(third);

if(f>s & f>t){
Console.WriteLine(f + " Максимальное число");
}
if(s>f & s>t){
Console.WriteLine(s + " Максимальное число");
}
if(t>f & t>s){
Console.WriteLine(t + " Максимальное число");
}