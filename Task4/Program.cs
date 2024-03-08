string str = "Hello my world!";

string reversedStr = "";
string[] words = str.Split(' ');
for (int i = words.Length - 1; i >= 0; i--)
{
	reversedStr += words[i] + " ";
}

Console.WriteLine(reversedStr);