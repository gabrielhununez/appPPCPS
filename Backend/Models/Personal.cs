namespace Backend.Models
{
    public class Personal
    {
        public int _IdPersonal { get; set; }
        public int _IdGrado { get; set; }
        public string _Nombre { get; set; }
        public string? _SegundoNombre { get; set; }
        public string _Apellido { get; set; }
        public string _TipoDoc { get; set; }
        public int _NroDoc { get; set; }
    }
}