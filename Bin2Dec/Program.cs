using System;

namespace Bin2Dec
{
    class Program
    {
        static void Main(){
            string nValorDecimal;

            Console.Write("Digite o valor binário: ");
            nValorDecimal = Console.ReadLine().ToString();

            if (nValorDecimal.Length > 8){
                Console.WriteLine("Valor inválido!");
            }else
            {
                if (!f_verificaBinario(nValorDecimal.PadLeft(8, '0'))){
                    Console.WriteLine("Valor inválido!");
                }else{
                    F_calcula(nValorDecimal.PadLeft(8, '0'));
                }
            }
          }

        static void F_calcula(string cBinario){
            int nDecimal = 0;
            
            for (int i = 7;i > -1;i--){
                nDecimal = nDecimal + int.Parse(cBinario.Substring(i, 1)) * (int)Math.Pow(2, 7 - i);
                //Console.WriteLine(cBinario.Substring(i, 1));
            }
            Console.WriteLine("O valor decimal é {0}.", nDecimal);
        }

        static bool f_verificaBinario(string cBinario){
            for (int i = 0; i < 8; i++){
                if (!(cBinario.Substring(i, 1).Contains("1") | cBinario.Substring(i, 1).Contains("0"))){
                    return false;
                }
            }
            return true;
        }
    }
}
