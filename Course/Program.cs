using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course
{
    class Program
    {
        //static double Pi = 3.14;

        static void Main(string[] args)
        {

            //Calculadora calc = new Calculadora();
            //sbyte x = 100;
            //Console.WriteLine(x);

            //byte x = 127;
            //x++;
            //Console.WriteLine(x);

            //int x = 1000;
            //long y = 2147483648L;
            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //bool completo = false;
            //Console.WriteLine(completo);

            //char genero = 'F';
            //char letra = '\u0041';
            //Console.WriteLine(letra);
            //Console.WriteLine(genero);

            //float n = 4.5f;
            //double b = 4.5;
            //Console.WriteLine(n);
            //Console.WriteLine(b);

            //string nome = "Maria";
            //Console.WriteLine(nome);

            //object obj1 = "Murilo";
            //object obj2 = 20;
            //Console.WriteLine(obj1);
            //Console.WriteLine(obj2);

            //int h = int.MinValue;
            //int l = int.MaxValue;
            //sbyte oi = sbyte.MinValue;
            //decimal ooi = decimal.MaxValue;
            //Console.WriteLine(ooi);
            //Console.WriteLine(oi);
            //Console.WriteLine(l);
            //Console.WriteLine(h);

            //Console.WriteLine("Bom dia!");
            //Console.WriteLine("Boa tarde!");

            //Console.Write("Bom dia!");
            //Console.Write("Boa tarde!");

            //char genero = 'F';
            //int idade = 27;
            //double saldo = 10.35624;
            //string nome = "Murilo";

            //Console.WriteLine(genero);
            //Console.WriteLine(idade);
            //Console.WriteLine(saldo.ToString("F3"));
            //Console.WriteLine(saldo.ToString("F2"));
            //Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);

            ////placeholder, interpolação e concatenação.
            //int idade = 27;
            //double saldo = 10.35624845;
            //string nome = "Murilo";

            //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);
            //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F5} reais.");
            //Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais. ");

            //string produto1 = "Computador";
            //string produto2 = "Mesa de Escritorio";

            //byte idade = 27;
            //int codigo = 0126;
            //char genero = 'M';

            //double preco1 = 6000.20;
            //double preco2 = 960.00;
            //double medida = 53.3256478;

            ////Console.WriteLine("Produtos: {0}, cujo preço é $ {1} reais, e {3}, cujo preço é $ {4} reais.", produto1, preco1.ToString("F2"), produto2, preco2);
            //Console.WriteLine("Produtos: {0}, cujo preço é $ {1} reais.", produto1, preco1.ToString("F2"));
            //Console.WriteLine("Produtos: {0}, cujo preço é $ {1} reais.", produto2, preco2);

            //Console.WriteLine($"Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            //Console.WriteLine("Medida com sete casas decimais: {0}", medida);
            //Console.WriteLine("Medida arredondada com três casas decimais: {0}", medida.ToString("F3"));
            //Console.WriteLine("Medida com separador decimal: {0}", medida.ToString("F7", CultureInfo.InvariantCulture));

            ////Operadores Aritméticos
            //int n1 = 3 + 4 * 2;
            //int n2 = (5 + 5) * 5;
            //int n3 = 17 % 3;
            //double n4 = 10 / 8;
            //double n5 = (double)10 / 8;
            //double n6 = 10.0 / 8.0;

            //double a = 1.0, b = -3.0, c = -4.0;
            //double delta = b * b - 4.0 * a * c;
            //double delta1 = Math.Pow(b, 2.0) - 4.0 * a * c;
            //double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            //double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.WriteLine(n3);
            //Console.WriteLine(n4);
            //Console.WriteLine(n5);
            //Console.WriteLine(n6);
            //Console.WriteLine(a);
            //Console.WriteLine(delta);
            //Console.WriteLine(delta1);
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);

            ////Operadores de Atribuição
            //int a = 10;
            //Console.WriteLine(a);
            //a += 2;
            //Console.WriteLine(a);

            //a *= 3;
            //Console.WriteLine(a);

            //a /= 10;
            //Console.WriteLine(a);

            //string s = "ABC";
            //Console.WriteLine(s);

            //s += "DEFG";
            //Console.WriteLine(s);

            //int a = 10;
            //int b = a++;
            //int c = ++a;
            //a++;
            //Console.WriteLine(a);

            //a--;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            ////Conversão implícita e casting
            //    float x = 4.5f;
            //    double y = x;
            //    Console.WriteLine(x);
            //    Console.WriteLine(y);

            //    double a;
            //    float b;
            //    a = 5.1;
            //    b = (float)a;
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);

            //    double c;
            //    int d;

            //    c = 5.1;
            //    d = (int)c;
            //    Console.WriteLine(c);
            //    Console.WriteLine(d);

            //    int f = 5;
            //    int g = 2;

            //    double resultado = (double)f / g;
            //    Console.WriteLine(resultado);

            ////Entrada de dados
            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            ////string s = Console.ReadLine();
            ////string[] vet = s.Split(' ');
            //string[] vet = Console.ReadLine().Split(' ');
            //string a = vet[0];
            //string b = vet[1];
            //string c = vet[2];

            //Console.WriteLine("Você digitou: " + frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(x + " " + y + " " + z);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string[] vet = Console.ReadLine().Split(' ');
            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura);

            //string comNome = Console.ReadLine();
            //int quarto = int.Parse(Console.ReadLine());
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //string[] vet = Console.ReadLine().Split(' ');
            //string ultNome = vet[0];
            //int idade = int.Parse(vet[1]);
            //double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com seu nome completo: ");
            //Console.WriteLine(comNome);
            //Console.WriteLine("Quantos quartos tem sua casa?");
            //Console.WriteLine(quarto);
            //Console.WriteLine("Entre com o preço de um produto: ");
            //Console.WriteLine(preco.ToString("F2"), CultureInfo.InvariantCulture);
            //Console.WriteLine(ultNome);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura);

            //// Operadores Comparativos
            //int a = 10;
            //bool c1 = a < 10;
            //bool c2 = a < 20;
            //bool c3 = a > 10;
            //bool c4 = a > 5;

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //Console.WriteLine("-------------------------------------------");

            //bool c5 = a <= 10;
            //bool c6 = a >= 10;
            //bool c7 = a == 10;
            //bool c8 = a != 10;

            //Console.WriteLine(c5);
            //Console.WriteLine(c6);
            //Console.WriteLine(c7);
            //Console.WriteLine(c8);

            ////Operadores Lógicos
            //bool c1 = 4 != 5; // true
            //bool c2 = 2 > 5 && 4 != 5; // false
            //bool c3 = 2 > 5 || 4 != 5; // true
            //bool c4 = !(2 > 3) && 4 != 5;

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //Console.WriteLine("-----------------");

            //bool c5 = 10 < 5;
            //bool c6 = c1 || c2 && c3;

            //Console.WriteLine(c6);

            //// Estrura condicional (if/else)
            //int x = 10;
            //Console.WriteLine("Bom dia!");
            //if (x < 5)
            //{
            //    Console.WriteLine("Boa tarde!");
            //}

            //Console.WriteLine("Boa noite!");

            //Console.WriteLine("Entre com um número inteiro: ");
            //int x = int.Parse(Console.ReadLine());

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine("Par!");
            //}
            //else
            //{
            //    Console.WriteLine("Impar!");
            //}

            //Console.WriteLine("Qual a hora atual?");
            //int hora = int.Parse(Console.ReadLine());

            //if (hora < 12)
            //{
            //    Console.WriteLine("Bom dia!");
            //}
            //if (hora > 12 && hora < 18)
            //{
            //    Console.WriteLine("Boa tarde!");
            //}
            //if (hora >= 18)
            //{
            //    Console.WriteLine("Boa noite!");
            //}

            //Console.WriteLine("Qual a hora atual?");
            //int hora = int.Parse(Console.ReadLine());

            //if (hora < 12)
            //{
            //    Console.WriteLine("Bom dia!");
            //}
            //else if (hora < 18)
            //{
            //    Console.WriteLine("Boa tarde!");
            //}
            //else
            //{
            //    Console.WriteLine("Boa noite!");
            //}

            //// Escopo e inicialização
            //double preco = double.Parse(Console.ReadLine());
            //double desconto = 0.0;

            //if (preco > 100.0) {
            //    desconto = preco * 0.1;
            //}

            //Console.WriteLine(desconto);

            //// Funções(sintaxe)
            // Representa um processamento que possui um significado
            //    Math.Sqrt(double)
            //    Console.WriteLine

            // Principais vantagens: modularização, delegação e reaproveitamento

            // Dados de entrada e saída
            //   Funções podem receber dados de entrada(parâmetros ou argumentos)
            //   Funções podem ou não retornar saídas

            // Em orientação a objetos, funções em classes recebem o nome de "métodos"

            //Console.WriteLine("Digite três números");
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());

            //if (n1 > n2 && n1 > n3)
            //{
            //    Console.WriteLine("Maior = " + n1);
            //}
            //else if (n2 > n3)
            //{
            //    Console.WriteLine("Maior = " + n2);
            //}
            //else
            //{
            //    Console.WriteLine("Maior = " + n3);
            //}

            //Console.WriteLine("Digite três números: ");
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());

            //double resultado = Maior(n1, n2, n3);

            //Console.WriteLine("Maior = " + resultado);

            //Console.Write("Digite um número: ");
            //double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //while (x >= 0.0)
            //{
            //    double raiz = Math.Sqrt(x);
            //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            //    Console.Write("Digite outro número: ");
            //    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}
            //Console.WriteLine("Número negativo!");

            ////Usando o comando FOR
            //Console.Write("Quantos números inteiros você vai digitar?");
            //int n = int.Parse(Console.ReadLine());
            //int soma = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write("Valor #{0}: ", i);
            //    int valor = int.Parse(Console.ReadLine());
            //    soma += valor;
            //}
            //Console.WriteLine("Soma = " + soma);

            //// Resolvendo um problema sem orientação a objeto
            //double xA, xB, xC, yA, yB, yC;

            //Console.WriteLine("Entre com as medidas do triângulo X:");
            //xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triângulo Y:");

            //yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (xA + xB + xC) / 2.0;

            //double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //p = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            //Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior área: X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área: y");
            //}

            //// Criando uma classe com três atributos para representar melhor um Triângulo
            ///Classes. Objetos e Atributos
            ///classe: é a definição do tipo
            ///objetos: são instâncias da classe

            //Triangulo x, y;

            //x = new Triangulo();
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do triângulo X:");
            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do triângulo Y:");

            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double areaX = x.Area();
            //double areaY = y.Area();

            //Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if (areaX > areaY)
            //{
            //    Console.WriteLine("Maior área: X");
            //}
            //else
            //{
            //    Console.WriteLine("Maior área: Y");
            //}

            //Pessoa p1 = new Pessoa();
            //Pessoa p2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa: ");
            //Console.Write("Nome: ");
            //p1.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa: ");
            //Console.Write("Nome: ");
            //p2.Nome = Console.ReadLine();
            //Console.Write("Idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());

            //if (p1.Idade > p2.Idade)
            //{
            //    Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            //}
            //else
            //{
            //    Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            //}

            //Produto p = new Produto();

            //Console.WriteLine("Entre com os dados do Produto: ");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine());
            //Console.Write("Quantidade em Estoque: ");
            //p.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Dados do Produto: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado em estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);

            //Console.WriteLine();
            //Console.Write("Digite a quantidade de produtos à ser removida do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);

            //Console.Write("Entre com o valor do raio: ");
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //1°
            //double circ = Circunferencia(raio);
            //double volume = Volume(raio);

            //2°
            //double circ = calc.Circunferencia(raio);
            //double volume = calc.Volume(raio);

            //3°
            //double circ = Calculadora.Circunferencia(raio);
            //double volume = Calculadora.Volume(raio);

            //Console.WriteLine("Circunferênia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Voulme: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            ////Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));


            //Construtores, palavra this, sobrecarga e encapsulamento
            //Contrutor
            //Console.WriteLine("Entre com os dados do Produto: ");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine());
            ////Console.Write("Quantidade em Estoque: ");
            ////int quantidade = int.Parse(Console.ReadLine());

            //Produto p = new Produto(nome, preco/*, quantidade*/);
            //Produto p2 = new Produto();
            //Produto p3 = new Produto
            //{
            //    Nome = "TV",
            //    Preco = 500.00,
            //    Quantidade = 10
            //};

            //Console.WriteLine();
            //Console.WriteLine("Dados do Produto: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado em estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);

            //Console.WriteLine();
            //Console.Write("Digite a quantidade de produtos à ser removida do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);

            //ENCAPSULAMENTO
            //Produto p = new Produto("tv", 500.00, 10);
            //p.Nome = "T";
            //p.Preco = 400.00;

            //Console.WriteLine(p.Nome);
            //Console.WriteLine(p.Preco);

            //Point p;
            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine(p);
            //p = new Point();
            //Console.WriteLine(p);


            ////NULLABLE
            //double? x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if (x.HasValue)
            //{
            //Console.WriteLine(x.Value);
            //}
            //else
            //{
            //    Console.WriteLine("X é nullo");
            //}

            //if (y.HasValue)
            //{
            //Console.WriteLine(y.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Y é nullo");
            //}

            //double a = x ?? 5;
            //double b = y ?? 5;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            ////Vetores
            //int n = int.Parse(Console.ReadLine());

            //double[] vect = new double[n];

            //for (int i = 0; i < n; i++)
            //{
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //double sum = 0.0;

            //for (int i = 0; i < n; i++)
            //{
            //    sum += vect[i];
            //}

            //double avg = sum / n;
            //Console.WriteLine("AVERAGE HEIGHT: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            //int n = int.Parse(Console.ReadLine());

            //VetProduto[] vect = new VetProduto[n];

            //for (int i = 0; i < n; i++)
            //{
            //    string name = Console.ReadLine();
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vect[i] = new VetProduto { Name = name, Price = price };
            //}

            //double sum = 0.0;
            //for (int i = 0; i < n; i++)
            //{
            //    sum += vect[i].Price;
            //}

            //double avg = sum / n;
            //Console.WriteLine("AVEGARE PRICE: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            //int s1 = Calculator.Sum(2, 6);
            //int s2 = Calculator.Sum(9, 5, 4);
            //int s3 = Calculator.Sum(new int[] { 5, 9, 15 });
            //int s4 = Calculator.sum(5, 30, 55);

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);

            ////Modificadores de parâmetros REF e OUT
            //int a = 10;
            //Calculator.Triple(ref a);

            //Console.WriteLine(a);

            //int b = 11;
            //int triple;
            //Calculator.Triple1(b, out triple);
            //Console.WriteLine(triple);

            //BOXING e UNBOXING
            //int x = 20;

            //Object obj = x;

            //int y = (int) obj;


            //Laços FOR EACH
            //string[] vect = new string[] { "Maria", "Alex", "Bob" };

            //for (int i = 0; i < vect.Length; i++)
            //{
            //    Console.WriteLine(vect[i]);
            //}
            //Console.WriteLine("------------------------------------");

            //foreach (string item in vect)
            //{
            //    Console.WriteLine(item);
            //}


            ////Listas
            //List<string> list = new List<string>();
            ////List<string> list2 = new List<string> { "Jose", "Ana", "Joao" };

            ////list.Add(new Produto());
            //list.Add("Maria");
            //list.Add("Alex");
            //list.Add("Bob");
            //list.Add("Ana");
            //list.Insert(2, "Murilo");

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("List count: " + list.Count);

            ////string s1 = list.Find(Test);
            ////Console.WriteLine("First 'A': " + s1);

            //string s1 = list.Find(x => x[0] == 'A');
            //Console.WriteLine("First 'A': " + s1);

            //string s2 = list.FindLast(x => x[0] == 'A');
            //Console.WriteLine("Last 'A': " + s2);

            //int pos = list.FindIndex(x => x[0] == 'A');
            //Console.WriteLine("First position 'A': " + pos);

            //int pos1 = list.FindLastIndex(x => x[0] == 'A');
            //Console.WriteLine("Last position 'A': " + pos1);

            //List<string> list1 = list.FindAll(x => x.Length == 5);
            //Console.WriteLine("----------------------------");
            //foreach (var item in list1)
            //{
            //    Console.WriteLine(item);
            //}

            //list.Remove("Alex");
            //Console.WriteLine("--------------------");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list.RemoveAll(x => x[0] == 'M');
            //Console.WriteLine("-----------------------------");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list.RemoveAt(2);
            //Console.WriteLine("-----------------------------");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //list.RemoveRange(2, 2);
            //Console.WriteLine("-----------------------------");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //MATRIZ
            //double[,] mat = new double[2, 3];
            //Console.WriteLine(mat.Length);

            //Console.WriteLine(mat.Rank);

            //Console.WriteLine(mat.GetLength(0));

            //Console.WriteLine(mat.GetLength(1));

            //int n = int.Parse(Console.ReadLine());

            //int[,] mat = new int[n, n];

            //for (int i = 0; i < n; i++)
            //{
            //    string[] values = Console.ReadLine().Split(' ');

            //    for (int j = 0; j < n; j++)
            //    {
            //        mat[i, j] = int.Parse(values[j]);
            //    }
            //}

            //Console.WriteLine("Main diagonal");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(mat[i, i] + " ");
            //}
            //Console.WriteLine();

            //int count = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (mat[i, j] < 0)
            //        {
            //            count++;
            //        }
            //    }
            //}
            //Console.WriteLine("Negative number: " + count);

            ////Conjuntos

            //HashSet<int> A = new HashSet<int>();
            //HashSet<int> B = new HashSet<int>();

            //A.Add(3);
            //A.Add(5);
            //A.Add(8);
            //A.Add(9);

            //B.Add(3);
            //B.Add(4);
            //B.Add(5);

            //B.Remove(4);

            //A.ExceptWith(B); //remove tudo que estiver diferente de b

            //A.UnionWith(B); // adiciona os numeros que não tem na estrutura de A

            //foreach (int x in A)
            //{
            //    Console.WriteLine(x);
            //}

            //foreach (var y in B)
            //{
            //    Console.WriteLine(y);
            //}

            //Console.WriteLine("Digite um valor inteiro: ");
            //int N = int.Parse(Console.ReadLine());

            //if (B.Contains(N))
            //{
            //    Console.WriteLine(N + "Percente ao grupo B.");
            //}
            //else
            //{
            //    Console.WriteLine(N + "Não pertence ao grupo B.");
            //}

            ////Interferência de tipos: palavra var

            //var x = 10;
            //var y = 20.0;
            //var z = "Maria";

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            ////Sintaxe alternativa: switch - case

            //int x = int.Parse(Console.ReadLine());
            //string day;

            //if (x == 1)
            //{
            //    day = "Sunday";
            //}
            //else if (x == 2)
            //{
            //    day = "Monday";
            //}

            //switch (x)
            //{
            //    case 1:
            //        day = "Sunday";
            //        break;
            //    case 2:
            //        day = "Monday";
            //        break;
            //    case 3:
            //        day = "Tuesday";
            //        break;
            //    case 4:
            //        day = "Wednesday";
            //        break;
            //    case 5:
            //        day = "Thursday";
            //        break;
            //    case 6:
            //        day = "Friday";
            //        break;
            //    case 7:
            //        day = "Saturday";
            //        break;
            //    default:
            //        day = "Invalid Value";
            //        break;
            //}

            //Console.WriteLine("Day: " + day);

            ////Expressão condicional ternária

            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double desconto;
            //if (preco < 20.0)
            //{
            //    desconto = preco * 0.1;
            //}
            //else
            //{
            //    desconto = preco * 0.05;
            //}

            //double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            //Console.WriteLine(desconto);

            ////DateTime - representando data e hora(representa um instante)
            //DateTime d1 = DateTime.Now;

            //Console.WriteLine(d1);
            //Console.WriteLine(d1.Ticks);

            //DateTime d1 = new DateTime(2020, 02, 26);
            //DateTime d2 = new DateTime(2020, 02, 26, 10, 00, 00);
            //DateTime d3 = new DateTime(2020, 02, 26, 10, 00, 00, 500);

            //DateTime d4 = DateTime.Now;
            //DateTime d5 = DateTime.Today;
            //DateTime d6 = DateTime.UtcNow;

            //DateTime d7 = DateTime.Parse("2020-02-26");
            //DateTime d8 = DateTime.Parse("2020-02-26 10:05:23");
            //DateTime d9 = DateTime.Parse("26/02/2020");
            //DateTime d10 = DateTime.Parse("26/02/2020 10:06:00");

            //DateTime d11 = DateTime.ParseExact("2020-02-26", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            //DateTime d12 = DateTime.ParseExact("26/02/2020 10:09:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);

            //Console.WriteLine(d4);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);

            //Console.WriteLine(d7);
            //Console.WriteLine(d8);
            //Console.WriteLine(d9);
            //Console.WriteLine(d10);

            //Console.WriteLine(d11);
            //Console.WriteLine(d12);

            ////TimeSpan( representa uma duração)
            //TimeSpan t1 = new TimeSpan();
            //TimeSpan t2 = new TimeSpan(0, 1, 30);
            //TimeSpan t3 = new TimeSpan(900000000L);
            //TimeSpan t4 = new TimeSpan(2, 11, 21);
            //TimeSpan t5 = new TimeSpan(1, 2, 11, 21);
            //TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);

            //TimeSpan t7 = TimeSpan.FromDays(1.5);
            //TimeSpan t8 = TimeSpan.FromHours(1.5);
            //TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            //TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            //TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            //TimeSpan t12 = TimeSpan.FromTicks(900000000L);


            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t2.Ticks);
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);
            //Console.WriteLine(t5);
            //Console.WriteLine(t6);

            //Console.WriteLine(t7);
            //Console.WriteLine(t8);
            //Console.WriteLine(t9);
            //Console.WriteLine(t10);
            //Console.WriteLine(t11);
            //Console.WriteLine(t12);

            ////Propriedades e operações com DateTime
            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //DateTime d4 = new DateTime(2000, 10, 15);

            //DateTime d5 = new DateTime(2000, 10, 18);

            //TimeSpan t = d5.Subtract(d4);

            //DateTime d1 = d.AddHours(2);
            //DateTime d2 = d.AddMinutes(3);
            //DateTime d3 = d.AddDays(7);


            //Console.WriteLine(d);
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(t);

            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);



            //Console.WriteLine(d.ToLongDateString());
            //Console.WriteLine(d.ToLongTimeString());
            //Console.WriteLine(d.ToShortDateString());
            //Console.WriteLine(d.ToShortTimeString());
            //Console.WriteLine(d.ToString());
            //Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            //Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));


            ////Propriedade e operações com TimeSpan
            //TimeSpan t1 = TimeSpan.MaxValue;
            //TimeSpan t2 = TimeSpan.MinValue;
            //TimeSpan t3 = TimeSpan.Zero;

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);

            //TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

            //Console.WriteLine(t4);
            //Console.WriteLine("Days: " + t4.Days);

            //TimeSpan t5 = new TimeSpan(1, 30, 10);
            //TimeSpan t6 = new TimeSpan(0, 10, 5);

            //TimeSpan sum = t5.Add(t6);
            //TimeSpan dif = t5.Subtract(t6);
            //TimeSpan mult = t6.Multiply(2.0);
            //TimeSpan div = t6.Divide(2.0);

            //Console.WriteLine(sum);
            //Console.WriteLine(dif);
            //Console.WriteLine(mult);
            //Console.WriteLine(div);

            ////DateTimeKind e padrão ISO 8601
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to local: " + d1.ToUniversalTime());
            Console.WriteLine("d1 to utc: " + d1.ToLocalTime());
            Console.WriteLine();

            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 Kind: " + d2.Kind);
            Console.WriteLine("d2 to local: " + d2.ToUniversalTime());
            Console.WriteLine("d2 to utc: " + d2.ToLocalTime());
            Console.WriteLine();

            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 Kind: " + d3.Kind);
            Console.WriteLine("d3 to local: " + d3.ToUniversalTime());
            Console.WriteLine("d3 to utc: " + d3.ToLocalTime());
            Console.WriteLine();

            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("d4: " + d4);
            Console.WriteLine("d4 Kind: " + d4.Kind);
            Console.WriteLine("d4 to local: " + d4.ToUniversalTime());
            Console.WriteLine("d4 to utc: " + d4.ToLocalTime());
            Console.WriteLine();
            Console.WriteLine("d5: " + d5);
            Console.WriteLine("d5 Kind: " + d5.Kind);
            Console.WriteLine("d5 to local: " + d5.ToUniversalTime());
            Console.WriteLine("d5 to utc: " + d5.ToLocalTime());
            Console.WriteLine();
            Console.WriteLine(d5.ToString("yyyy-MM-ddTHH:mm:ssZ")); // cuidado!
            Console.WriteLine(d5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

        }
        //static bool Test(string s)
        //{
        //    return s[0] == 'A';
        //}

        //static double Circunferencia(double r)
        //{
        //    return 2.0 * Pi * r;
        //}

        //static double Volume(double r)
        //{
        //    return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        //}

    }
    //static int Maior(int a, int b, int c)
    //{
    //    int m;

    //    if (a > b && a > c)
    //    {
    //        m = a;
    //    }
    //    else if (b > c)
    //    {
    //        m = b;
    //    }
    //    else
    //    {
    //        m = c;
    //    }
    //    return m;
    //}
}

