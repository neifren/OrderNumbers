// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



class Solution
{
    public int GetMenor(int[] A)
    { 
        Array.Sort(A);
        return A[0];
    }

    public int GetMayor(int[] A)
    {
        Array.Sort(A);
        return A[A.Length - 1];
    }


    public int solution(int[] arr)
    {

        Array.Sort(arr);
        int smallest = 1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == smallest)
            {
                smallest++;
            }
        }

        return smallest;
    }


}
public class Example
{
    public static void Main()
    {
        //int[] arr = { 8, 15, 5, -1, 2 };


        Solution s1 = new Solution();

        int[] array = { 1, 3, 6, 4, 1, 2 };
        int[] array2 = { 1, 2, 3};
        int[] array3 = { -1, -3};

        Console.WriteLine("El numero menor es: " + s1.GetMenor(array));
        Console.WriteLine("El numero MAYOR es: " + s1.GetMayor (array));

        Console.WriteLine("Ordenado Ejm1: " + s1.solution(array));

        Console.WriteLine("Ordenado Ejm2: " + s1.solution(array2));

        Console.WriteLine("Ordenado Ejm3: " + s1.solution(array3));

    }
}

 