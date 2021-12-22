using System;

namespace lab1
{
	class Program
	{
		/// <summary>
		/// Удлиненние сообщения пробелами
		/// </summary>
		/// <param name="isch">Исходное сообщение</param>
		/// <param name="key">Ключ</param>
		/// <returns></returns>
		public static String leng(string isch, int key)
		{
			int l1 = isch.Length;
			for (int i = 0; i < (l1 % key); i++)
			{
				isch = isch + ' ';
			}
			return isch;
		}

		/// <summary>
		/// Удлиненние сообщения пробелами
		/// </summary>
		/// <param name="otvet1">Зашифрованное сообщение</param>
		/// <param name="k">Ключ</param>
		/// <returns></returns>
		public static String pere(string otvet1, int k)
		{
			string otvet2 = leng(otvet1, k);
			int l3 = otvet2.Length;
			char[] perebor = new char[l3];

			int h = l3 / k;

			for (int i = 0; i < k; i++)
			{
				for (int j = 0; j < h; j++)
				{
					perebor[j * k + i] = otvet2[i * h + j];
				}
			}

			string otvet3 = new string(perebor);
			return otvet3;
		}


static void Main(string[] args)
		{
			Console.WriteLine("Иcходное соощение: ");
			String isch = "мама мыла раму";
			Console.WriteLine(isch);
			int key = 4;

			int l1 = isch.Length;

			isch = leng(isch, key);

			//шифровка
			int l2 = isch.Length;
			char[] shifr = new char[l2];

			int h = l2/ key;

			for (int i = 0; i < key; i++)
			{
				for (int j = 0; j < h; j++)
				{
					shifr[i * h + j] = isch[j * key + i];
				}
			}

			string otvet1 = new string(shifr);
			Console.WriteLine("\nЗашифрованное сообщение: ");
			Console.WriteLine(otvet1);

			// расшифровка
			// дальше для использования отдельно расшифорвки,
			// необходимы переменные  string otvet1, key
			Console.WriteLine("\nПроверка расшифорвки: ");
			Console.WriteLine(pere(otvet1, key));


			//перебор
			// дальше для использования отдельно перебора,
			//необходимы переменные string otvet1

			Console.WriteLine("\nВарианты перебора: ");
			for (int k = 2; k< l2 - 1; k++)
			{
				string otvet3 = pere(otvet1, k);
				Console.WriteLine(otvet3);
			}


			Console.ReadKey();

		}	
	}
}
