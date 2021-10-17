using System;

namespace FashionDevs_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double n1;
            double n2;
            double n3;
            double n4;
            double salariominimo = 1100;
            double novamedia;
            double resultado;
            bool validacao = true;
            Program program = new Program();

            Console.WriteLine("C&A Fashion Devs");
            Console.WriteLine("Olá, seja bem vindo!");


            do
            {
                Console.WriteLine("Selecione a opção desejada");
                Console.WriteLine("(1) Cálculo de IMC");
                Console.WriteLine("(2) Conversão de salários mínimos");
                Console.WriteLine("(3) Cálculo de volume de esfera");
                Console.WriteLine("(4) Média de notas escolares");
                Console.WriteLine("(5) Animais de estimação");
                Console.WriteLine("(6) SAIR");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Informe o seu peso: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe sua altura: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Imc(n1, n2);
                        Console.WriteLine("Seu IMC é {0}", Math.Round(resultado, 2));

                        if (resultado < 20)
                        {
                            Console.WriteLine("Abaixo do peso");

                        } else if (resultado >= 20 && resultado < 25) {
                            Console.WriteLine("Peso Ideal");

                        } else if (resultado >= 25) {
                            Console.WriteLine("Acima do peso");
                        }

                        break;

                    case 2:

                        Console.WriteLine("Informe seu salário atual: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("O salário mínimo atual é de R$ {0}", salariominimo);

                        resultado = program.Salario(n1, salariominimo);
                        Console.WriteLine("Seu salário atual equivale a {0} salários mínimos", Math.Round(resultado, 2));

                        break;

                    case 3:

                        Console.WriteLine("Informe o raio: ");
                        n1 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Volume(n1);
                        Console.WriteLine("O volume da esfera é de: {0} m³", Math.Round(resultado, 2));

                        break;

                    case 4:

                        Console.WriteLine("Informe sua nota de JavaScript:");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe sua nota de HTML:");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe sua nota de CSS:");
                        n3 = Convert.ToDouble(Console.ReadLine());

                        resultado = program.Media(n1, n2, n3);

                        if (resultado >= 7)
                        {
                            Console.WriteLine("Parabéns, Você foi Aprovado! Sua média foi: {0}", Math.Round(resultado, 2));

                        } else {
                            Console.WriteLine("Você não atingiu a média, por favor, informe sua nota de exame:");
                            n4 = Convert.ToDouble(Console.ReadLine());
                            novamedia = Convert.ToDouble((program.Media(n1, n2, n3) + n4) / 2);

                            if (novamedia >= 5)
                            {
                                Console.WriteLine("Você foi aprovado pela nota de exame, sua média foi: {0}", Math.Round(novamedia, 2));

                            } else {
                                Console.WriteLine("Você foi reprovado, sua média foi: {0}", Math.Round(novamedia, 2));

                            }
                        }

                        break;

                    case 5:

                        
                        AnimaisEstimacao animal1 = new AnimaisEstimacao();
                        AnimaisEstimacao animal2 = new AnimaisEstimacao();
                        AnimaisEstimacao animal3 = new AnimaisEstimacao();
                        AnimaisEstimacao animal4 = new AnimaisEstimacao();
                        AnimaisEstimacao animal5 = new AnimaisEstimacao();
                        int ttCachorro = 0, ttGato = 0, ttPeixe = 0;

                        Console.WriteLine("Animais de estimação");

                        Console.WriteLine("Informe o nome do 1° animal");
                        animal1.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o tipo do 1° animal (Ex.: Cachorro, Gato, Peixe):");
                        animal1.Tipo = Console.ReadLine();

                            if (animal1.Tipo == "cachorro") ttCachorro++;
                            if (animal1.Tipo == "gato") ttGato++;
                            if (animal1.Tipo == "peixe") ttPeixe++;

                        Console.WriteLine("Informe o nome do 2° animal");
                        animal2.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o tipo do 2° animal (Ex.: Cachorro, Gato, Peixe):");
                        animal2.Tipo = Console.ReadLine();

                            if (animal2.Tipo == "cachorro") ttCachorro++;
                            if (animal2.Tipo == "gato") ttGato++;
                            if (animal2.Tipo == "peixe") ttPeixe++;

                        Console.WriteLine("Informe o nome do 3° animal");
                        animal3.Nome = Console.ReadLine();
                        Console.WriteLine("Informe o tipo do 3° animal (Ex.: Cachorro, Gato, Peixe):");
                        animal3.Tipo = Console.ReadLine();

                            if (animal3.Tipo == "cachorro") ttCachorro++;
                            if (animal3.Tipo == "gato") ttGato++;
                            if (animal3.Tipo == "peixe") ttPeixe++;

                       Console.WriteLine("Informe o nome do 4° animal");
                       animal4.Nome = Console.ReadLine();
                       Console.WriteLine("Informe o tipo do 4° animal (Ex.: Cachorro, Gato, Peixe):");
                       animal4.Tipo = Console.ReadLine();

                            if (animal4.Tipo == "cachorro") ttCachorro++;
                            if (animal4.Tipo == "gato") ttGato++;
                            if (animal4.Tipo == "peixe") ttPeixe++;

                       Console.WriteLine("Informe o nome do 5° animal");
                       animal5.Nome = Console.ReadLine();
                       Console.WriteLine("Informe o tipo do 5° animal (Ex.: Cachorro, Gato, Peixe):");
                       animal5.Tipo = Console.ReadLine();

                            if (animal5.Tipo == "cachorro") ttCachorro++;
                            if (animal5.Tipo == "gato") ttGato++;
                            if (animal5.Tipo == "peixe") ttPeixe++;

                      Console.WriteLine("Você possui: Cachorros: {0} , Gatos: {1} , Peixes: {2} ", ttCachorro, ttGato, ttPeixe);
                        

                        break;
                }


                Console.Write("Aperte ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

            } while (validacao);
        }

        public double Imc(double n1, double n2)
        {
            return (n1 / Math.Pow(n2, 2));
        }

        public double Salario(double n1, double salariominimo)
        {

            return n1 / salariominimo;
        }

        public double Volume(double n1)
        {
            return 4 * Math.PI * Math.Pow(n1, 3) / 3;
        }

        public double Media(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3;
        }


    }
}