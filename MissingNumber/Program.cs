
Console.Write("Number of array elements:");

int count = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[count];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{i + 1}.entry the number:");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(numbers);
foreach (int i in numbers)
    Console.Write(" " + i);

int totalNum = 0;
int totalOdd;
int number;
int missingNumber;
for (int i = 0; i < numbers.Length; i++)
{
    totalNum += numbers[i];
}
number = ((numbers[count - 1] + 1) / 2);
totalOdd = (number * number);
missingNumber = Math.Abs(totalNum - (totalOdd));
Console.WriteLine($"  Missing Number : {missingNumber}");



