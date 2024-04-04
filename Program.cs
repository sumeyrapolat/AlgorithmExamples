using System;
class Program
{
    static void Main(string[] args)
    {

        /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
        Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
        Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */

        

        Console.WriteLine("Bir pozitif bir sayı girin: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0) {
            Console.WriteLine($"Lütfen {number} adet sayı girin: ");

            string numbers = Console.ReadLine();
            string[] NumberArray = numbers.Split(' ');

            foreach (var item in NumberArray)
            {
               if (int.TryParse(item, out int num))
                {
                    if (num % 2 == 0)
                    {
                        Console.Write(num + " ");
                    }
                }
            }
        }


        /*
          Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
         Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
          Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
         */

        

        Console.WriteLine("İki sayı girin: ");
        string numbers = Console.ReadLine();

        string[] numberArray = numbers.Split(' ');

            int number1 = Convert.ToInt32(numberArray[0]);
            int number2 = Convert.ToInt32(numberArray[1]);

            Console.WriteLine($"{number1} adet sayı giriniz: ");

            string inputNumbers = Console.ReadLine();
            string[] inputNumbersArray = inputNumbers.Split(' ');

            foreach (string num in inputNumbersArray)
            {
                if (int.TryParse(num , out int intNum))
                {
                    if ( intNum == number2 || intNum % number2 == 0)
                    {
                        Console.Write(num + " ");
                    }
                }
            } 

        

        /* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
         * Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini 
         * yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        */

        

        Console.WriteLine("Pozitif bir sayı girin: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{num} adet kelime giriniz: ");
        string words = Console.ReadLine();
        string[] wordArray = words.Split(' ');

        for (int i = 0; i < wordArray.Length / 2; i++)
        {
            string temp = wordArray[i];
            wordArray[i] = wordArray[wordArray.Length - 1 - i];
            wordArray[wordArray.Length - 1 - i] = temp;
        }

        foreach (string word in wordArray )
        {
            Console.Write(word + " ");
        }


        


        /* Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
         * Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
         * */

        Console.WriteLine("Bir cümle girin: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');
        int numberOfWords = words.Length;

        Console.WriteLine($"Number of Words : {numberOfWords}");

        string newSentence = sentence.Replace(" ","");
        int numberOfChar = sentence.Length;
        Console.WriteLine($"Number of Char: {numberOfChar}");

}

}