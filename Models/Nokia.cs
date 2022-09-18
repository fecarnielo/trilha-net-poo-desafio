namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria)
        : base (numero, modelo, imei, memoria){}
         public override void Dados()
        {
            Console.WriteLine($"Número: {Numero}, Modelo: {Modelo}, IMEI: {Imei}, Memória: {Memoria} ");
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} instalado no Nokia com êxito!");
        }
    }
}