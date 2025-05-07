namespace GastosApp2.Entidades
{
    internal class Ingreso
    {

        public decimal Importe { get; set; }
        public string Description { get; set; }
        public Ingreso(string desc, decimal importe)
        {
            this.Description = desc;
            this.Importe = importe;
        }
        public void AddValueInGastoProperty(decimal importe)
        {
            this.Importe = (importe * 0.99m);
        }
    }
}
