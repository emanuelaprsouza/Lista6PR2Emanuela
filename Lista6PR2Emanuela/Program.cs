using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista6PR2Emanuela
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n;

            Console.WriteLine(" ==========MENU============ ");
            Console.WriteLine(" 1- EXERCÍCIO 1 ");
            Console.WriteLine(" 2- EXERCÍCIO 2 ");
            Console.WriteLine(" 3- EXERCÍCIO 3 ");
            Console.WriteLine(" 4- EXERCÍCIO 4 ");
            Console.WriteLine(" 5- EXERCÍCIO 5 ");
            Console.WriteLine(" 6- EXERCÍCIO 6 ");
            Console.WriteLine(" 7- EXERCÍCIO 7 ");
            Console.WriteLine(" ========================= ");

            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    float quantp, valorp, valort = 0, quant = 0;
                    int i;

                    for (i = 1; ; i++)
                    {
                        Console.WriteLine("Digite a quantidade de itens: ");
                        quantp = float.Parse(Console.ReadLine());
                        if (quantp == 0)
                        {
                            break;
                        }

                        Console.WriteLine("Digite o preço da unidade: ");
                        valorp = float.Parse(Console.ReadLine());

                        valort += quantp * valorp;
                        quant += quantp;

                        Console.WriteLine("A quantidade de itens é: " + quant);
                        Console.WriteLine("O total é: " + valort);

                    }

                    break;

                case 2:
                    string nome, nomemenor =" ", nomemaior =" ";
                    int numitens, parada = 2;
                    float preco, menorvalor, maiorvalor;

                    menorvalor = float.MaxValue;
                    maiorvalor = float.MinValue;

                    for ( ; parada != 1; )//laço infinito
                    {
                        Console.WriteLine("Informe o nome do produto: ");
                        nome = Console.ReadLine();

                        Console.WriteLine("Infome a quantidade: ");
                        numitens = int.Parse(Console.ReadLine());

                        Console.WriteLine("Entre com preço unitario: ");
                        preco = float.Parse(Console.ReadLine());

                        float total = numitens * preco;

                        if (total > maiorvalor)
                        {
                            maiorvalor = total;
                            nomemaior = nome;
                        }
                        
                        if (total < menorvalor)
                        {
                            menorvalor = total;
                            nomemenor = nome;
                        }

                        Console.WriteLine("Digite 1 para SAIR ou 2 para CONTINUAR");
                        parada = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("maior quantia investida {0} no produto {1} " ,+ maiorvalor,nomemaior);
                    Console.WriteLine("menor quantia investida {0} no produto {1} " ,+ menorvalor,nomemenor);

                    break;

                case 3: Double nota, peso,notat;

                    Console.WriteLine(" quantas notas terão neste bimestre:  ");
                    nota = Double.Parse(Console.ReadLine());
                    notat = 0;
                    for (i = 0; i < nota; i++)
                    {
                        Console.WriteLine(" qual o peso das notas: (ex: 3) ");
                        peso = Double.Parse(Console.ReadLine());
                        notat = notat + peso;
                    }

                    notat = notat * 10;

                    if(notat > 100)
                        {
                        Console.WriteLine("As notas são superior a 100 ");
                        break;
                    }
                    if(notat == 100)
                        {
                        Console.WriteLine("As notas são iguais a 100 ");
                        break;
                    }
                    if(notat < 100)
                        {
                        Console.WriteLine("As notas são inferior a 100 ");
                        break;
                    }

                    break;

                case 4:
                    string estado;

                    Console.WriteLine(" ==========MENU============ ");
                    Console.WriteLine("AC");
                    Console.WriteLine("AL");
                    Console.WriteLine("AP");
                    Console.WriteLine("AM");
                    Console.WriteLine("BA");
                    Console.WriteLine("CE");
                    Console.WriteLine("DF");
                    Console.WriteLine("ES");
                    Console.WriteLine("GO");
                    Console.WriteLine("MA");
                    Console.WriteLine("MT");
                    Console.WriteLine("MS");
                    Console.WriteLine("MG");
                    Console.WriteLine("PA");
                    Console.WriteLine("PB");
                    Console.WriteLine("PR");
                    Console.WriteLine("PE");
                    Console.WriteLine("PI");
                    Console.WriteLine("RJ");
                    Console.WriteLine("RN");
                    Console.WriteLine("RS");
                    Console.WriteLine("RO");
                    Console.WriteLine("RR");
                    Console.WriteLine("SC");
                    Console.WriteLine("SP");
                    Console.WriteLine("SE");
                    Console.WriteLine("TO");
                    Console.WriteLine(" ========================= ");

                  Console.WriteLine("escolha a sigla de um estado ");
                    estado = Console.ReadLine();

                    switch (estado)
                    {
                        case "AC":
                            Console.WriteLine("Acre");
                            break;

                        case "AL":
                            Console.WriteLine("Alagoas");
                            break;

                        case "AP":
                            Console.WriteLine("Amapá");
                            break;

                        case "AM":
                            Console.WriteLine("Amazonas");
                            break;

                        case "BA":
                            Console.WriteLine("Bahia");
                            break;

                        case "CE":
                            Console.WriteLine("Ceará");
                            break;

                        case "DF":
                            Console.WriteLine("Distrito Federal");
                            break;

                        case "ES":
                            Console.WriteLine(" Espírito Santo");
                            break;

                        case "GO":
                            Console.WriteLine(" Goiás");
                            break;

                        case "MA":
                            Console.WriteLine(" Maranhão ");
                            break;

                        case "MT":
                            Console.WriteLine(" Mato Grosso");
                            break;

                        case "MS":
                            Console.WriteLine("Mato Grosso do Sul  ");
                            break;

                        case "MG":
                            Console.WriteLine(" Minas Gerais");
                            break;

                        case "PA":
                            Console.WriteLine(" Pará");
                            break;

                        case "PB":
                            Console.WriteLine(" Paraíba");
                            break;

                        case "PR":
                            Console.WriteLine(" Paraná");
                            break;

                        case "PE":
                            Console.WriteLine(" Pernambuco");
                            break;

                        case "PI":
                            Console.WriteLine("Piauí");
                            break;

                        case "RJ":
                            Console.WriteLine(" Rio de Janeiro");
                            break;

                        case "RN":
                            Console.WriteLine(" Rio Grande do Norte");
                            break;

                        case "RS":
                            Console.WriteLine(" Rio Grande do Sul");
                            break;

                        case "RO":
                            Console.WriteLine(" Rondônia ");
                            break;

                        case "RR":
                            Console.WriteLine(" Roraima");
                            break;

                        case "SC":
                            Console.WriteLine(" Santa Catarina ");
                            break;

                        case "SP":
                            Console.WriteLine(" São Paulo ");
                            break;

                        case "SE":
                            Console.WriteLine(" Sergipe");
                            break;

                        case "TO":
                            Console.WriteLine(" Tocantins ");
                            break;

                        default: Console.WriteLine(" Opção Inválida! ");
                            break;
                    }
                    break;

                case 5:
            }

            Console.ReadKey();

        }
    }
}
