namespace Ficha1_Exer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura;
            double peso;


            Console.WriteLine("Introduza o seu peso (kg): ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduza a sua altura (metros): ");
            altura = Convert.ToDouble(Console.ReadLine());


            //Math.pow = potências (pow e ** em python)

            altura = Math.Pow(altura, 2);
            double IMC = (peso / altura);

            // F* delimita as casa decimais apresentada no output
            Console.WriteLine($"O seu IMC é : {IMC:F2}");
        }
    }
}
