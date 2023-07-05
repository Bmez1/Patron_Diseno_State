namespace Patron_Diseño_State
{
    public class Switch
    {
        private Estado _estado;

        public Switch()
        {
            _estado = new Encendido();
        }

        public void DefinirEstado(Estado estado)
        {
            _estado = estado;
        }

        /// <summary>
        /// Metodo que se encarga de hacer el cambio de estado del objeto estado
        /// </summary>
        public void Presionar()
        {
            _estado.ControlarEstado(this);
            Console.WriteLine(_estado.Descubrir());
        }
    }
}