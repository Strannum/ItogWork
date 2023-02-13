void ShowArr(string [] arr, string mes = "Ваш массив") 
  {
    Console.Write("{0}: [{1}]\n", mes, String.Join(", ", arr));
  } 
    
  int NumInt (string mes= "Ведите целое число: ", string error = "Вы ввели некорректное значение!")   
  {
    Console.Write(mes);
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))  
      {
        Console.WriteLine(error);
        Console.Write(mes);
      }
    return num;
  }  
    
string [] ArrayStr(int m=5)
  {
    string [] array = new string [m];
    for (int i=0; i<array.Length; i++)
      {
        Console.Write("Введите значение строки {0} элемента массива: ", i);
        array[i]= Console.ReadLine();
      }
    return array;
  }

string [] ArrayStr3(string [] arr)
  {
    int k=0;
      for (int i=0; i<arr.Length; i++)
      {
        string str;
        if (arr[i].Length<=3)
          {
            str= arr[k];
            arr[k]= arr[i];
            arr[i]=str;
            k++;
          }
      }
    string [] array = new string [k];
    for (int i=0; i<k; i++)
      {
            array[i]=arr[i];

      }
    return array;
  }

Console.Clear();    
int n= NumInt("Введите размер массива: ");
string [] Str= ArrayStr(n); 
ShowArr (Str, "Изначальный массив");
Str =  ArrayStr3(Str);
ShowArr (Str, "Итоговый массив");
