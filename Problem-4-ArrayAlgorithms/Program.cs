using System;

namespace Problem_4_ArrayAlgorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrayA = new int[10];
			int[] arrayB = new int[arrayA.Length];
			int[] resulting = new int[arrayA.Length * 2];

			Random r = new Random();
			for(int i = 0; i < arrayA.Length; i++)
			{
				arrayA[i] = r.Next(1, 11);
				arrayB[i] = r.Next(1, 11);
			}

			SortArray(arrayA);
			SortArray(arrayB);

			int aCounter = 0;
			int bCounter = 0;
			int cCounter = 0;

			while(cCounter < arrayA.Length * 2)
			{
				if(aCounter < arrayA.Length)
				{
					if(bCounter < arrayB.Length)
					{
						if (arrayA[aCounter] < arrayB[bCounter])
						{
							resulting[cCounter] = arrayA[aCounter];
							aCounter++;
						}
						else
						{
							resulting[cCounter] = arrayB[bCounter];
							bCounter++;
						}
					}
					else
					{
						resulting[cCounter] = arrayA[aCounter];
						aCounter++;
					}
				}
				else
				{
					resulting[cCounter] = arrayB[bCounter];
					bCounter++;
				}

				cCounter++;
			}

			Console.WriteLine($"Array A: {string.Join(" ", arrayA)}");
			Console.WriteLine($"Array B: {string.Join(" ", arrayB)}");
			Console.WriteLine($"Resulting: {string.Join(" ", resulting)}");
		}

		static void SortArray(int[] array)
		{
			for(int i = 0; i < array.Length; i++)
			{
				int minIndex = i;
				for(int j = i; j < array.Length; j++)
				{
					if(array[minIndex] > array[j])
					{
						minIndex = j;
					}
				}

				int temp = array[minIndex];
				array[minIndex] = array[i];
				array[i] = temp;
			}
		}
	}
}
