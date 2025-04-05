namespace Backend.Models
{
    public class Personal
    {
        public int _idPersonal { get; set; }
        public int _idGrado { get; set; }
        public string _nombre { get; set; }
        public string? _segundoNombre { get; set; }
        public string _apellido { get; set; }
        public string _tipoDoc { get; set; }
        public int _nroDoc { get; set; }
    }
}