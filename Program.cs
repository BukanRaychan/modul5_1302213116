using System;
using System.Collections.Generic;

namespace modu5_1302213116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan<int> obj = new Penjumlahan<int>();

            obj.JumlahTigaAngka(13,2,21);

            SimpleDataBase<int, DateTime> simpleDataBase= new SimpleDataBase<int, DateTime>();

            simpleDataBase.addNewData(13, DateTime.UtcNow.Date);
            simpleDataBase.addNewData(02, DateTime.UtcNow.Date);
            simpleDataBase.addNewData(21, DateTime.UtcNow.Date);

            simpleDataBase.PrintAllData();
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

    class SimpleDataBase<T, Date>
    {
        private List<T> storedData;
        private List<Date> inputDates;

        public SimpleDataBase()
        {
            storedData= new List<T>();
            inputDates= new List<Date>();
        }

        public void addNewData(T input, Date now)
        {            
            this.storedData.Add(input);
            this.inputDates.Add(now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++){
                Console.WriteLine($"Data {i+1} berisi: {storedData[i].ToString()}, yang disimpan pada waktu {inputDates[i]}");
            }
        }
    }   
}