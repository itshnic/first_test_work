string Input(string text)
{
	Console.Write($"{text} -> ");
	return Console.ReadLine();
}

void Print(string text, string[] Arr)
{
	Console.Write($"{text} -> [ ");
	for (int i = 0; Arr.Length > i; i++)
	{
		if (i != 0)
			Console.Write(", ");
		Console.Write($"\"{Arr[i]}\"");
	}
	Console.Write(" ]");
	Console.WriteLine();
}

string[] CreateArr()
{
	string requestLength = Input("Введите длину массива");
	int length;
	if (int.TryParse(requestLength, out length) && length > 0)
	{
		string[] Arr = new string[length];
		for (int i = 0; i < length; i++)
		{
			Arr[i] = Input($"Введите элемент массива №{i + 1}");
		}
		Print("Исходный массив", Arr);
		return Arr;
	}
	else
	{
		Console.Write("Неправильно указана длина массива!!!");
		string[] Arr = new string[0];
		return Arr;
	}
}
void CheckedArr(string[] Arr)
{
	if (Arr.Length > 0)
	{
		string requestLengthString = Input("Сортируем все элементы с количеством символов не более");
		int lengthString;
		if (int.TryParse(requestLengthString, out lengthString) && lengthString > 0)
		{
			string[] ArrNew = new string[Arr.Length];
			for (int i = 0; i < Arr.Length; i++)
			{
				if (lengthString >= Arr[i].Length)
					ArrNew[i] = Arr[i];
			}
			ArrNew = ArrNew.Where(val => val != null).ToArray();
			Console.Write($"Массив с длинной символов не белее {lengthString}");
			Print("", ArrNew);
		}
		else Console.Write("Неправильно указана длина строки!!!");
	}
}
string[] Array = CreateArr();
CheckedArr(Array);