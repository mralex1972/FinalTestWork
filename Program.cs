Console.WriteLine("Введите текст");
Console.WriteLine("Для завершения ввода намите Enter");
string[] words = new string[0];
string[] shortArray = new string[0];
string word = "" + Console.ReadLine();
int i = 0;
int j = 0;
while(word != "")
{
    Array.Resize(ref words, words.Length + 1);
    words[i] = word;
    if(word.Length <= 3)
    {
        Array.Resize(ref shortArray, shortArray.Length + 1);
        shortArray[j] = word;
        j++;
    }
    i++;
    word = "" + Console.ReadLine();
}
for (int k = 0; k < shortArray.Length; k++)
{
    Console.WriteLine(shortArray[k]);
}