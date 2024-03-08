char[,] array = new char[3, 3] {
	{ '1', '2', '3'},
	{ '4', '5', '6'},
	{ '7', '8', '9'}
};

string str = "";

for (int i = 0; i < array.GetLength(0); i++)
{
	for (int j = 0; j < array.GetLength(1); j++)
	{
		str += array[i, j];
	}
}

Console.WriteLine(str);