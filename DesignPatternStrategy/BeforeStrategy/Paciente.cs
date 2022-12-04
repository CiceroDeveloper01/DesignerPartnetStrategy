namespace DesignPatternStrategy.BeforeStrategy
{
    public class Paciente
    {
        public string Nome { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public float CalcularImc()
        {
            return Peso / (Altura * Altura);
        }
        public void PrescreverDieta(string DescricaoDieta)
        {
            Console.WriteLine($"{DescricaoDieta} para o Paciente: {Nome} realizada com sucesso.");
            Console.ReadLine();
        }
        public void PrescreverTreinamento(string DescricaoTreinamento)
        {
            Console.WriteLine($"{DescricaoTreinamento} para o Paciente: {Nome} realizada com sucesso.");
            Console.ReadLine();
        }
        public void EncaminharParaCirurgiaBariatrica()
        {
            Console.WriteLine($"Paciente: {Nome} encaminhado com sucesso para cirurgia báriatrica.");
            Console.ReadLine();
        }
    }
}
