string[] text(string[] array)
    {           
        string[] result = new string[array.Length];
        int count = 0;
            
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i].Length <= 3)
            {
                result[count] = array[i];
                count++;
            }
        }
        Array.Resize(ref result, count);
            
        return result;
    }
        
    void PrintArray(string[] array)
    {
        Console.WriteLine("[" + string.Join(", ", array) + "]");
        Console.WriteLine();
    }
    
    string[] array1 = {"hello", "2", "world", ":-)"};
    string[] array2 = {"1234", "1567", "-2", "computer science"};
    string[] array3 = {"Russia", "Denmark", "Kazan"};

        PrintArray(text(array1));
        PrintArray(text(array2));
        PrintArray(text(array3));
