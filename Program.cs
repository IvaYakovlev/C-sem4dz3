

// ---
// **Задача 3:**Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
Console.Write("Массив элементов от 0 до 100: ");
int num = 8;
int[] array = GetBinArray(num);

Console.Write($"[{String.Join(", ", array)}]");



int[] GetBinArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(100);
    }
    
    return result;}


