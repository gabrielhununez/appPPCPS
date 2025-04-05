using Backend.Models;

namespace Backend.Models
{
    public class Grado
    {
        public int _idGrado  { get; set; }
        public string _abreviatura { get; set; }
        public string? _gradoCompleto { get; set; }

        public Grado()
        {

        }
    }
}