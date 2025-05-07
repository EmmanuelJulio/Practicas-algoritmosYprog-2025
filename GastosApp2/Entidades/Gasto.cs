namespace GastosApp2.Entidades
{
    public class Gasto
    {
        public decimal Importe { get; private set; }
        public string Description { get; }
        public Gasto()
        {   
        }
        public Gasto(string desc, decimal importe)
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
