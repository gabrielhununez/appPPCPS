namespace Backend.Models
{
    internal class Personal
    {
        private int _IdPersonal { get; set; }
        private int _IdGrado { get; set; }
        private string _Nombre { get; set; }
        private string? _SegundoNombre { get; set; }
        private string _Apellido { get; set; }
        private string _TipoDeDoc { get; set; }
        private int _NroDoc { get; set; }
    }
}