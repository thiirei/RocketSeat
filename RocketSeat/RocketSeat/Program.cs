
using System.Globalization;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using RocketSeat;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelloWorld;

public class Trabalho
{
    static void Main()
    {
        /*#1
          string nome;

          Console.WriteLine("Digite seu nome :");
          nome = Console.ReadLine();
          Console.WriteLine($"Ola,{nome}! Seja muito bem vindo!");
      }
  }

   //2#  
   string nome1, nome2;

      Console.whiteline("Digite seu nome e seu sobrenome:");

      string[] vet;
      vet = Console.ReadLine().Split(' ');
      nome1 = vet[0];
      nome2 = vet[1];

      Console.WriteLine(nome1 + nome2);


      //3#
      double numero1, numero2;

  Console.WriteLine("Digite dois numeros com casa decimal: ")

    string[] vet;

      vet = Console.ReadLine().Split(' ');
  numero1 = double.Parse(vet[0]);
  numero2 = double.Parse(vet[1]);

    resultado1 = numero1 + nuemro2;

      Console.WriteLine(resultado1);    

      resultado2 = numero1 - nuemro2;

      Console.WriteLine(reusltado2);

      resultado3 = numero1 * nuemro2;

      Console.WriteLine(resultado3)

      resultado4 = numero1 / nuemro2;

      Console.WriterLine(resultado4);

      resultado5 = (numero1 + numero2) /2

      Console.WriteLine(resutado5);
  */

        /*4#
        string palavra;
    int Resulado;

        Console.WriterLine("Digite algumas palavras:");
        palavra = Console.ReadLine();
        Resultado = palvra.Lenght;

        Console.WriteLine(Resultado);

        

        //5#
        using System.Text.RegularExpressions;



        Console.Write("Informe a placa  ");
        var caracteres = Console.ReadLine();

        bool count = caracteres.Length == 7;

        bool ok = Regex.IsMatch(caracteres, @"^[a-zA-Z]{3}") && Regex.IsMatch(caracteres, @"[0-9]{4}$") && count;
        if (!ok)
        {

            Console.WriteLine("Falso.");
        }
        else
        {
            Console.WriteLine("Verdadeiro");
        }


    }
}

    

    
    Console.WriteLine("Digite a data de hoje");
    
  dia = Console.ReadLine();

    DateTime data1 = new DateTime(dia);
string data1 = data1.ToString("d",new CultureInfo("pt-BR"));
    
    Conlose.WriterLine(data1);

    DateOnly data2 = new DateOnly(dia);
string data2 = data2.ToShortDateString();
    Console.WriterLine(data2);
    
    
    DateOnly data3 = new DateOnly(dia);
string data3 = data3.ToString("D", new CultureInfo("pt-BR"));
Console.WriterLine(data3);

    
    DateOnly data4 = new DateOnly(dia);
string data4 = date1.ToString("H:mm:ss", new CultureInfo.InvariantCulture));
                  
Console.WriterLine(data4);

    */