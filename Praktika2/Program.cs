Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Завдання№1");
Console.WriteLine("Введіть рядок тексту:");
string text = Console.ReadLine();
Console.WriteLine("Введіть першу букву:");
char letter1 = Console.ReadLine()[0];
Console.WriteLine("Введіть другу букву:");
char letter2 = Console.ReadLine()[0];
int count1 = CountOccurrences(text, letter1);
int count2 = CountOccurrences(text, letter2);
if (count1 > count2)
{
    Console.WriteLine($"Буква '{letter1}' зустрічається частіше ({count1} разів).");
}
else if (count2 > count1)
{
    Console.WriteLine($"Буква '{letter2}' зустрічається частіше ({count2} разів).");
}
else
{
    Console.WriteLine($"Обидві букви '{letter1}' і '{letter2}' зустрічаються однакову кількість разів ({count1} разів).");
}
    static int CountOccurrences(string text, char letter)
{
    int count = 0;
    int index = -1;

    while ((index = text.IndexOf(letter, index + 1)) != -1)
    {
        count++;
    }

    return count;
}
Console.WriteLine("Завдання№2");
static string InsertTextBeforeSubstring(string mainString, string targetSubstring, string insertString)
{
    int index = 0;
    while ((index = mainString.IndexOf(targetSubstring, index)) != -1)
    {
        mainString = mainString.Insert(index, insertString);
        index += insertString.Length + targetSubstring.Length;
    }

    return mainString;
}
string S = "Hello S1 World S1";
string S1 = "S1";
string S2 = "Inserted Text ";
string result = InsertTextBeforeSubstring(S, S1, S2);
Console.WriteLine(result);
Console.WriteLine("Завдання№3");
static string CapitalizeFirstLetter(string word)
{
    if (string.IsNullOrEmpty(word))
    {
        return word;
    }

    char[] letters = word.ToCharArray();
    letters[0] = char.ToUpper(letters[0]);
    return new string(letters);
}
string sentence = "hi my dear friend";
Console.WriteLine(sentence);
string[] words = sentence.Split(' ');
for (int i = 0; i < words.Length; i++)
{
    words[i] = CapitalizeFirstLetter(words[i]);
}
string capitalizedSentence = string.Join(" ", words);
Console.WriteLine(capitalizedSentence);
Console.WriteLine("Завдання№4");
string sentence2 = "це речення для перестановки слів";
string[] words2 = sentence2.Split(' ');
for (int i = 0; i < words2.Length - 1; i += 2)
{
    string temp = words2[i];
    words2[i] = words2[i + 1];
    words2[i + 1] = temp;
}
string rearrangedSentence = string.Join(" ", words2);
Console.WriteLine(rearrangedSentence);
