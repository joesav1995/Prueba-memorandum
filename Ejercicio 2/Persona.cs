namespace Ejercicio_2
{
    public class Persona
    {
        public Persona()
        {
        }
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string nombre { get; set; }
        public int edad { get; set; }
        
    }
}
