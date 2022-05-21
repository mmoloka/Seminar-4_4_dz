/*Напишите программу,которая задает массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[] col)
{
    Console.Write("[");
    for (int i = 0; i < col.Length; i++)
    {
        if(i == col.Length - 1) Console.Write(col[i]);
        else Console.Write(col[i] + ", ");
    }
        
    Console.Write("]");
}
int[] array = new int[8];
Console.WriteLine("Введите поочередно 8 элементов массива:");
FillArray(array);
PrintArray(array);
