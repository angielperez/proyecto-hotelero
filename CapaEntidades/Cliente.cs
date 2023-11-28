
namespace CapaEntidades
{
    public class Cliente: Persona
    {
        public decimal IdCliente { get; set; }
        public Cliente()
        {
            this.Perfil = "cliente";
        }
    }
}
