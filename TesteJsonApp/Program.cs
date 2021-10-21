using System;
using System.Text.Json;


namespace TesteJsonApp
{
    public class Person
    {
        public object Nome { get; set; }
        public string Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
    }

    public class Nome
    {
        public string Primeiro { get; set; }
        public string Segundo { get; set; }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            string jsonString =
                                @"{
                                  ""Date"": ""2019-08-01T00:00:00-07:00"",
                                  ""TemperatureCelsius"": 25,
                                  ""Summary"": ""Hot"",  
                                  ""Nome"": {""Primeiro"": ""Leona"", ""Segundo"": ""Lenis""}
                                }
                                ";

            //Pego todos os registro Objeto Json
            Person instance = JsonSerializer.Deserialize<Person>(jsonString);

            //Separo o Objeto Nome para pegar registro separado
            var Nome1 = instance.Nome;
            string jsonString1 = JsonSerializer.Serialize(Nome1);
            Nome teste = JsonSerializer.Deserialize<Nome>(jsonString1);

            //Mostro os dados do Objeto Json
            var Date1 = instance.Date;
            var Temp = instance.TemperatureCelsius;
            var Sum = instance.Summary;
            Console.WriteLine(Date1);
            Console.WriteLine(Temp);
            Console.WriteLine(Sum);

            //Mostro os dados do Objeto Nome que esta dentro do Objeto Principal
            var nome3 = teste.Primeiro;
            var nome4 = teste.Segundo;
            Console.WriteLine(Nome1);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
        }
    }
}
