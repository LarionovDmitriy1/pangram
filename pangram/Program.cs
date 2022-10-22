
using System.Linq;
int counteng = 0;
int countruss = 0;
char[] russ = new char[] { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'а', 'я', 'у', 'ю', 'о', 'е', 'ё', 'э', 'и', 'ы', 'ь', 'ъ' };
char[] eng = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
Console.WriteLine("Введите Панграмму");
string pangram = Console.ReadLine();
char[] result = pangram.ToCharArray();

foreach (char c in eng)
{
    bool s = pangram.Contains(c);
    if(s == true)
    {
      counteng ++;
    }
}
foreach (char b in russ)
{
    bool g = pangram.Contains(b);
    if (g == true)
    {
        countruss++;
    }
}
if (counteng == 26 || countruss==33)
{
    Console.WriteLine("Текст - панграмма");
}
else
{
    Console.WriteLine("Текст - не панграмма");
}
