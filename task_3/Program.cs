string first = Console.ReadLine();
string second = Console.ReadLine();
int f = int.Parse(first);
int s = int.Parse(second);

if(f>s){
    Console.WriteLine("Число " + f + " больше чем " + s);
}else{
    Console.WriteLine("Число " + s + " больше чем " + f);
}