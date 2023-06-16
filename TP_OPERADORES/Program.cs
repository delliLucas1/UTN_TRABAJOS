namespace TP_OPERADORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Ejercicio 1
            ////Ejercicio A
            //var sumInt = HelperCalculator.Addition(3, 4);
            //var sumDecimal = HelperCalculator.Addition((decimal)3.53, (decimal)4.72);

            //Console.WriteLine("A:");
            //Console.WriteLine(sumInt.ToString() + " SumINT");
            //Console.WriteLine(sumDecimal.ToString() + " SumDecimal \n");

            ////Ejercicio B
            //var subtractionInt = HelperCalculator.Subtraction(10, 18);
            //var subtractionDecimal = HelperCalculator.Subtraction((decimal)8.53, (decimal)1.72);

            //Console.WriteLine("Ejercicio B:");
            //Console.WriteLine(subtractionInt.ToString() + " subtractionInt");
            //Console.WriteLine(subtractionDecimal.ToString() + " subtractionDecimal \n");

            ////Ejercicio C
            //var multiplyNum = HelperCalculator.Multiply((decimal)8, (decimal)1.72);

            //Console.WriteLine("Ejercicio C:");
            //Console.WriteLine(multiplyNum.ToString() + " multiplyNum \n");

            ////Ejercicio D
            //var divideNum = HelperCalculator.Divide(15, 6);
            //var divideNum2 = HelperCalculator.Divide((decimal)17, (decimal)6);

            //Console.WriteLine("Ejercicio D:");
            //Console.WriteLine(divideNum.ToString() + " divideNum ");
            //Console.WriteLine(divideNum2.ToString() + " divideNum2 \n");

            ////Ejercicio E
            //var moduleNum = HelperCalculator.Module((decimal)56, (decimal)6.56);

            //Console.WriteLine("Ejercicio E:");
            //Console.WriteLine(moduleNum.ToString() + " moduleNum \n");

            ////Ejercicio F
            //var elevateNum = HelperCalculator.Elevate(3, 3);

            //Console.WriteLine("Ejercicio F:");
            //Console.WriteLine(elevateNum.ToString() + " elevateNum \n");

            ////Ejercicio G
            //var promNum = HelperCalculator.Prom(3, 3, 4);

            //Console.WriteLine("Ejercicio G:");
            //Console.WriteLine(promNum.ToString() + " promNum \n");

            ////Ejercicio H
            //EjercicioH();

            ////Ejercicio I
            //EjercicioI();

            ////Ejercicio J
            //EjercicioJ();

            ////Ejercicio K
            //EjercicioK();

            //------------------------------------------------------

            ////Ejercicio 2
            //Promiedos();

            //Ejercicio 3
            //Conversor();

            //Ejercicio 5
            BillCalculator();

        }

        private static void Promiedos()
        {
            Console.WriteLine("Ejercicio 2:");

            Console.WriteLine("Ingrese el primer numero: ");
            string n1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero: ");
            string n2 = Console.ReadLine();
            Console.WriteLine("Ingrese el tercer numero: ");
            string n3 = Console.ReadLine();
            Console.WriteLine("Ingrese el cuarto numero: ");
            string n4 = Console.ReadLine();

            if (HelperCalculator.VerifyInput(n1) && HelperCalculator.VerifyInput(n2) && HelperCalculator.VerifyInput(n3) && HelperCalculator.VerifyInput(n4)) 
            {
                var promNum = HelperCalculator.Prom(Convert.ToDecimal(n1), Convert.ToDecimal(n2), Convert.ToDecimal(n3), Convert.ToDecimal(n4));
                Console.WriteLine("El promedio es: " + promNum.ToString() + " \n");
            }
            else
            {
                Console.WriteLine("Base o altura ingresados no son validos! \n");
            }
        }

        private static void EjercicioH()
        {
            Console.WriteLine("Ejercicio H:");
            Console.WriteLine("Ingrese la base: ");
            string _base = Console.ReadLine();
            Console.WriteLine("Ingrese la altura: ");
            string height = Console.ReadLine();

            if (HelperCalculator.VerifyInput(_base) && HelperCalculator.VerifyInput(height))
            {
                var area = HelperCalculator.Area(Convert.ToDecimal(_base), Convert.ToDecimal(height));
                Console.WriteLine(area.ToString() + " area del triangulo \n");
            }
            else
            {
                Console.WriteLine("Base o altura ingresados no son validos! \n");
            }
        }

        private static void EjercicioI()
        {
            Console.WriteLine("Ejercicio I:");
            Console.WriteLine("Ingrese el radio: ");
            string radio = Console.ReadLine();

            if (HelperCalculator.VerifyInput(radio))
            {
                var area = HelperCalculator.AreaRadio(Convert.ToDecimal(radio));
                Console.WriteLine(area.ToString() + " area del circulo \n");
            }
            else
            {
                Console.WriteLine("El radio ingresado no es valido! \n");
            }
        }

        private static void EjercicioJ()
        {
            Console.WriteLine("Ejercicio J:");
            Console.WriteLine("Ingrese la temperatura: ");
            string temperature = Console.ReadLine();

            if (HelperCalculator.VerifyInput(temperature))
            {
                var tempF = HelperCalculator.ConvertToFarenheit(Convert.ToDecimal(temperature));
                Console.WriteLine(tempF.ToString() + " F \n");
            }
            else
            {
                Console.WriteLine("la temperatura ingresada no es valida! \n");
            }
        }

        private static void EjercicioK()
        {
            string[] validOperators = new string[] { "+", "-", "/", "*" };

            Console.WriteLine("Calculadora:");
            Console.WriteLine("Ingrese el primer numero: ");
            string _num1 = Console.ReadLine();
            Console.WriteLine("Ingrese la operacion que quiere realizar (+, -, /, *): ");
            string operation = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero: ");
            string _num2 = Console.ReadLine();

            if (validOperators.Contains(operation.ToString())) {

                if (HelperCalculator.VerifyInput(_num1) && HelperCalculator.VerifyInput(_num2))
                {
                    if (operation == validOperators[0])
                    {   //SUMA
                        var result = HelperCalculator.Addition(Convert.ToDecimal(_num1), Convert.ToDecimal(_num2));
                        Console.WriteLine("Resultado: " + result.ToString() + "\n");
                    }
                    else if (operation == validOperators[1])
                    {   //RESTA
                        var result = HelperCalculator.Subtraction(Convert.ToDecimal(_num1), Convert.ToDecimal(_num2));
                        Console.WriteLine("Resultado: " + result.ToString() + "\n");
                    }
                    else if (operation == validOperators[2])
                    {   //DIVISION
                        var result = HelperCalculator.Divide(Convert.ToDecimal(_num1), Convert.ToDecimal(_num2));
                        Console.WriteLine("Resultado: " + result.ToString() + "\n");
                    }
                    else if (operation == validOperators[3])
                    {   //MULTIPLICACION
                        var result = HelperCalculator.Multiply(Convert.ToDecimal(_num1), Convert.ToDecimal(_num2));
                        Console.WriteLine("Resultado: " + result.ToString() + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("Datos ingresados no son validos! \n");
                }
            }
            else
            {
                Console.WriteLine("No es un operador valido! \n");
            }
        }

        private static void Conversor()
        {
            Console.WriteLine("Ejercicio 3:");
            Console.WriteLine("Ingrese los centimetros: ");
            string centimeters = Console.ReadLine();

            if (HelperCalculator.VerifyInput(centimeters))
            {
                var result = HelperCalculator.ConvertToInches(Convert.ToDecimal(centimeters));
                Console.WriteLine(result.ToString() + " in \n");
            }
            else
            {
                Console.WriteLine("Datos ingresados no son validos! \n");
            }

            Console.WriteLine("Ejercicio 4:");
            Console.WriteLine("Ingrese el valor en pesos: ");
            string val = Console.ReadLine();
            Console.WriteLine("Ingrese la cotizacion actual: ");
            string cotizacion = Console.ReadLine();

            if (HelperCalculator.VerifyInput(val) && HelperCalculator.VerifyInput(cotizacion))
            {
                var result = HelperCalculator.ConvertToDolar(Convert.ToDecimal(val), Convert.ToDecimal(cotizacion));
                Console.WriteLine(result.ToString() + " dolares \n");
            }
            else
            {
                Console.WriteLine("Datos ingresados no son validos! \n");
            }
        }

        private static void BillCalculator()
        {
            decimal hotDog = 2;
            decimal frenchFries = 1;
            decimal soda = 0.85m;

            Console.WriteLine("Ejercicio 5:");
            Console.WriteLine("Ingrese la cantidad de hot dogs: ");
            string qtHotDogs = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de french fries: ");
            string qtFF = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de sodas: ");
            string qtSoda = Console.ReadLine();


            if (HelperCalculator.VerifyInput(qtHotDogs) && HelperCalculator.VerifyInput(qtFF) && HelperCalculator.VerifyInput(qtSoda))
            {
                var result = (Convert.ToDecimal(qtHotDogs) * hotDog) + (Convert.ToDecimal(qtFF) * frenchFries) + (Convert.ToDecimal(qtSoda) * soda);
                result += (result * 10) / 100;  
                Console.WriteLine("La cuenta dio $ " + result.ToString() + "\n");
            }
            else
            {
                Console.WriteLine("Datos ingresados no son validos! \n");
            }
          
        }
    }
}