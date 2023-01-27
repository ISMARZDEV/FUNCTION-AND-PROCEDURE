using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
            static void Main(string[] args)


            {
            String pSelect =  "";

            bool mostrarMenu = true;

                while (mostrarMenu == true) 
                {
                    
                    Menu();
                    //INDICAR OPCION A SELECCIONAR
                    Console.Write("Favor de indicar ¿Cuál subprograma desea correr (1-6): ");
                    pSelect = Console.ReadLine();
                    Console.Clear();
                    Seleccionar(pSelect);
                }
            }
            
            static void Menu()
            {
                Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║  IDS - Ismael Porfirio Martínez Encarnación | ID: 1077546  ║");
                Console.WriteLine("║ 1. Área del cuadrado                                       ║");
                Console.WriteLine("║ 2. Área del rectángulo                                     ║");
                Console.WriteLine("║ 3. Área del triángulo                                      ║");
                Console.WriteLine("║ 4. Área del círculo                                        ║");
                Console.WriteLine("║ 5. Área del cono                                           ║");
                Console.WriteLine("║ 6. La Hipotenusa utilizando el teorema de Pitágoras        ║");
                Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
            }

            static void Seleccionar(String pSeleccion)
            {

                switch (pSeleccion)
                {
                    case "1":
                        Int32 pL1 = 0, pL2 = 0, pC = 0;
                        AreaCuadrado(pL1,pL2,pC);
                        Console.Write("Pulse una tecla para volver al menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Int32 pBC = 0, pAC = 0, pR = 0;
                        AreaRectangulo(pBC, pAC, pR);
                        Console.Write("Pulse una tecla para volver al menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Double pBT = 0, pAT = 0, pT = 0;
                        AreaTriangulo(pBT, pAT, pT);
                        Console.Write("Pulse una tecla para volver al menu...");
                        Console.ReadKey();
                        Console.Clear();
                    break;

                    case "4":
                        Double pRadCi = 0, pRCi = 0;
                        AreaCirculo(pRadCi, pRCi);
                        Console.Write("Pulse una tecla para volver al menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "5":

                        Double pRadCo = 0, pG = 0,pRCo = 0;
                        AreaCono(pRadCo, pG, pRCo);
                        Console.Write("Pulse una tecla para volver al menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "6":
                        Double pAD = 0, pOP = 0, pH = 0;
                        Hipotenusa(pAD, pOP, pH);
                        Console.Write("Pulse una tecla para volver al menu...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

            static void AreaCuadrado(Int32 pLado1, Int32 pLado2, Int32 pCuadrado)
            {
                Console.WriteLine("╔══════════════════════╗");
                Console.WriteLine("║ 1. Área del cuadrado ║");
                Console.WriteLine("╚══════════════════════╝");

                Console.Write("Digite el Lado #1: ");
                pLado1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite el Lado #2: ");
                pLado2 = Convert.ToInt32(Console.ReadLine());

                pCuadrado = (pLado1 * pLado2);

                Console.WriteLine("El área del cuadrado es {0} x {1} = {2}cm²", pLado1, pLado2, pCuadrado);
            }

            static void AreaRectangulo(Int32 pBase, Int32 pAltura, Int32 pRectangulo)
            {
                Console.WriteLine("╔═══════════════════════╗");
                Console.WriteLine("║ 2. Área de rectangulo ║");
                Console.WriteLine("╚═══════════════════════╝");

                Console.Write("Digite la Base: ");
                pBase = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite la Altura: ");
                pAltura = Convert.ToInt32(Console.ReadLine());

                pRectangulo = (pBase * pAltura);

                Console.WriteLine("El área del Rectangulo es {0} x {1} = {2}cm²", pBase, pAltura, pRectangulo);
            }
            
            static void AreaTriangulo(Double pBase, Double pAltura, Double pTriangulo)
            {
                Console.WriteLine("╔══════════════════════╗");
                Console.WriteLine("║ 3. Área de triangulo ║");
                Console.WriteLine("╚══════════════════════╝");

                Console.Write("Digite la Base: ");
                pBase = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite la Altura: ");
                pAltura = Convert.ToDouble(Console.ReadLine());

                pTriangulo = (pBase * pAltura) / 2;

                Console.WriteLine("El área del Triangulo es {0} x {1} / 2 = {2:N2}cm", pBase, pAltura, pTriangulo);
            }

            static void AreaCirculo(Double pRadio, Double pCirculo)
            {
                Console.WriteLine("╔════════════════════╗");
                Console.WriteLine("║ 4. Área de círculo ║");
                Console.WriteLine("╚════════════════════╝");

                Console.Write("Digite el Radio: ");
                pRadio = Convert.ToDouble(Console.ReadLine());

                pCirculo = (Math.PI) * (Math.Pow(pRadio, 2));

                Console.WriteLine("El área del Circulo es ({0:N2} x {1}²) = {2:N2}cm²", Math.PI, pRadio, pCirculo);
            }

            static void AreaCono(Double pRadio, Double pGeneratriz, Double pCono)
            {
                Console.WriteLine("╔═════════════════╗");
                Console.WriteLine("║ 5. Área de cono ║");
                Console.WriteLine("╚═════════════════╝");

                Console.Write("Digite el Radio: ");
                pRadio = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite la Generatriz: ");
                pGeneratriz = Convert.ToDouble(Console.ReadLine());

                pCono = Math.PI * pRadio * pGeneratriz;

                Console.WriteLine("El área del cono es: {0:N2}cm²", pCono);
                }

            static void Hipotenusa(Double pCatetoOP, Double pCatetoAD, Double pHipotenusa)
            {
                Console.WriteLine("╔═════════════════════════════════════════════════════╗");
                Console.WriteLine("║ 6. La Hipotenusa utilizando el teorema de Pitágoras ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════╝");

                Console.Write("Digite el Cateto Adyacente: ");
                pCatetoAD = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite el Cateto Opuesto: ");
                pCatetoOP = Convert.ToDouble(Console.ReadLine());

                pHipotenusa = Math.Sqrt((Math.Pow(pCatetoAD, 2)) + (Math.Pow(pCatetoOP, 2)));

                Console.WriteLine("La hipotenusa es {0:N2}cm", pHipotenusa);
            }
    }
    
}
