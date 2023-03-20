namespace modu5_1302213116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan<int> obj = new Penjumlahan<int>();

            obj.JumlahTigaAngka(13,2,21);
        }
    }

    class Penjumlahan<T>
    {
        public void JumlahTigaAngka(T input1,T input2,T input3)
        {
            dynamic input1_d = input1;
            dynamic input2_d = input2;
            dynamic input3_d = input3;
            Console.WriteLine(input1_d + input2_d + input3_d);
        }
    }

   
}