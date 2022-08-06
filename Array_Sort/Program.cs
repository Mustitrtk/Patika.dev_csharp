

internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[]{0,3,11,6,4};
        sort(arr);
        foreach(int item in arr){
            Console.Write(item+" ");
        }
    }
    public static void sort(int[] arr)
    {
        int temp = 1; ;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
}