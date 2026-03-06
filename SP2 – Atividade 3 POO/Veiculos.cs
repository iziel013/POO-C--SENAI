using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Veiculos
{
    public class Veiculo : IPagamento
    {
        private string _placa,_modelo,_marca;
        private double TEntrada, TSaida, TempV, ValorTtl, HrAdcional;
        private int PHora;


        public string Marca { get => _marca; set => _marca = value; }
        public string Placa {get => _placa; set => _placa = value;}
        public string Modelo {get =>_modelo; set => _modelo = value;}
        public double TmpEntrada{get => TEntrada; set=> TEntrada = value;}
        public double TmpSaida{get => TSaida; set=>TSaida = value;}
        public double VlTotal{get => ValorTtl; set=> ValorTtl = value;}
        public double HoraAdd {get => HrAdcional; set=> HrAdcional = value;}
        public int PrimeiraHr {get => PHora; set => PHora = value;}

        public void tempVaga()
        {

        }

        public void Pagamento()
        {
            
            TempV = TSaida - TEntrada;

            if (TempV <= 1)
            {
                ValorTtl = PrimeiraHr;
            }
            else
            {
                ValorTtl = PrimeiraHr + (TempV - 1) * HrAdcional;
            }
        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"hora da entrada do carro {TmpEntrada:F2}");
            Console.WriteLine($"hora da saida do carro {TmpSaida:F2}");
            Console.WriteLine($"o preço do estacionamento pela primeira hora é{PrimeiraHr:F2} o valor total é{VlTotal:F2}");
            Console.WriteLine($"");
            Console.WriteLine($"");
            
        }

    }
        public class Moto : Veiculo
        {
            public Moto()
            {
                PrimeiraHr = 03.00;
                TmpEntrada = 13.30;
                TmpSaida = 17.00;
                Marca = "";
                Placa = "";
                Modelo = "";
                Pagamento();
                ExibirInfo();
                
                

            }

        }

        public class Carro : Veiculo 
        {
          public Carro()
          {
            PrimeiraHr = 12.00;
            TmpEntrada = 13.30;
            TmpSaida = 17.00;
            Marca = "";
            Placa = "";
            Modelo = "gfh767";
          }
        



         

        



    }


    



     
}
