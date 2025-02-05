/* Implement the FindMax method, which given a two-dimensional array of integers, returns the maximal value from this array.

If any of the array's dimensions is zero, it means the array is empty, and the method should return -1.

For example:

for an empty array of size [0,3] the result should be -1

for an array like this, the result should be 12

    int[,] numbers = new int[,] {
    { 3, 5 },
    { -1, 12 },
    { 4, 0 }
};
 
 */

int[,] numbers = new int[,] {
    { 3, 5 },
    { -1, 12 },
    { 4, 0 }
};

Console.WriteLine(FindMax(numbers));


static int FindMax(int[,] numbers)
{
    var height = numbers.GetLength(0);
    var width = numbers.GetLength(1);

    if (height == 0 || width == 0) return -1;

    int result = numbers[0, 0];

    for (int i = 0; i < height; i++)
    {
        //Console.WriteLine($"First Dimension: {i}");
        for (int j = 0; j < width; j++)
        {
            //Console.WriteLine($"Second Dimension: {j}");
            //Console.WriteLine($"Position: {i},{j} | Element: {letters[i, j]}");

            if (numbers[i, j] > result)
            {
                result = numbers[i, j];
            };

        }

    }
    return result;
}

Console.ReadKey();