//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//  14212 -> нет
//  12821 -> да
//  23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
        int[] arr = new int[5];


            for (int i = arr.Length - 1; i >= 0;i--)
            {
                arr[i] = num % 10;
                num /= 10;
            }
            Console.Write("Init array: ");
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i]);
            }

            void palindrom () {
                for (int i = 0; i < 2; i++) {
                   if (arr[i] == arr[arr.Length-i]){
                    Console.WriteLine("Yes");
                   } else {
                   Console.WriteLine("No"); 
                }
            }
            }

            palindrom();

        

       // Boolean result (Array[]){
           // for (int i = 0; i < arr.Length/2; i++) {
               // if (arr[i] == arr[arr.Length-i]) {
               //    Boolean palindrom = true;
              //  } else {
               //     Boolean palindrom = false;
               // }
//} return palindrom;
     //   }
