namespace Tp1_Algoritmos_y_programacion_2025.Entidades
{
    public class Usuario
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int Edad {  get; private set; }
        public bool DeudaPaga { get; private set; } = false;
        public Usuario(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Usuario(int edad, string nombre) 
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public bool PagoLaCuenta() => DeudaPaga;
    }
}
