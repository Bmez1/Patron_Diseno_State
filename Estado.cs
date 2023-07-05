namespace Patron_Diseño_State
{
    public abstract class Estado
    {

        /// <summary>
        /// Hace las veces de presionar el interruptor puesto que cambia el estado
        /// actual del switch a otro
        /// </summary>
        /// <param name="sw"></param>
        public abstract void ControlarEstado(Switch sw);

        /// <summary>
        /// Retorna el estado actual del switch o interruptor
        /// </summary>
        /// <returns></returns>
        public abstract string Descubrir();
    }
}