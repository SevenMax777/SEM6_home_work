string str = "aBcD1ef!";

bool IsPalindrome(string str)
{
	char[] chars = str.ToCharArray();
	int start = 0, end = chars.Length - 1;
	while (start < end)
	{
   	if (chars[start] != chars[end])
   	{
   		return false;
   	}

   start++;
   end--;
	}

	return true;
}

bool isPalindrome = IsPalindrome(str);
if (isPalindrome)
{
	Console.WriteLine("Строка является палиндромом");
}
else
{
	Console.WriteLine("Строка не является палиндромом");
}

