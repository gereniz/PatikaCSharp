using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan 
            //n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın

            
            Console.Write("Kaç adet pozitif sayı girmek istersiniz : ");
            int n = int.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            int x;
            for(int i = 0 ; i<n ; i++){
                while(true){
                    Console.Write((i+1) + ". sayıyı giriniz : " );
                    x = int.Parse(Console.ReadLine());
                    if(x<0){
                        Console.WriteLine("Pozitif bir sayı giriniz");
                    }else{
                        dizi[i] = x;
                        break;
                    }
                }
            }
            Console.WriteLine("Girilen sayılardan çift olan sayılar");
            foreach(var i in dizi){
                if(i %2 == 0){
                    Console.WriteLine(i);
                }
            }

            

            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan
            // n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            
            
            Console.Write("Bir M sayısı giriniz : ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Kaç adet pozitif sayı girmek istersiniz : ");
            int n1 = int.Parse(Console.ReadLine());
            int[] dizi1 = new int[n1];
            int y;
            for(int i = 0 ; i<n1 ; i++){
                while(true){
                    Console.Write((i+1) + ". sayıyı giriniz : " );
                    y = int.Parse(Console.ReadLine());
                    if(y<0){
                        Console.WriteLine("Pozitif bir sayı giriniz");
                    }else{
                        dizi1[i] = y;
                        break;
                    }
                }
            }
            Console.WriteLine("Girilen sayılardan M sayısına eşit ya da tam bölünen sayılar");
            foreach(var i in dizi1){
                if((i % m == 0) || (i == m)){
                    Console.WriteLine(i);
                }
            }

            
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet 
            //kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            
            Console.Write("Kaç adet kelime girmek istersiniz : ");
            int n2 = int.Parse(Console.ReadLine());
            string[] dizi2 = new string[n2];
            string word;
            for(int i = 0 ; i<n2 ; i++){
                
                Console.Write((i+1) + ". kelimeyi giriniz : " );
                word = Console.ReadLine();
                dizi2[i] = word;
            }
            Console.WriteLine("Girilen kelimeler sondan başa doğru");
            for(int i = n2-1 ; i >= 0 ; i--){
                Console.WriteLine(dizi2[i]);
            }

            

            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        
            Console.Write("Bir cümle giriniz : "); 
            string sentence = Console.ReadLine();
            int length = sentence.Length;
            int count = 0;

            foreach(var s in sentence){
                if( s == ' '){
                    count++;
                    length--;
                }
            }
            if(sentence[sentence.Length-1] == ' '){
                count--;
            }
            if(sentence[0] == ' '){
                count--;
            }
             
            Console.WriteLine("Girilen cümledeki kelime sayısı : " + (count+1));
            Console.WriteLine("Girilen cümledeki harf sayısı : " + (length));

        }
    }
}
