namespace Patron_Diseño_State
{
    public class Encendido : Estado
    {
        public override void ControlarEstado(Switch sw)
        {
            sw.DefinirEstado(new Apagado());
        }

        public override string Descubrir()
        {
            return "Switch encendido";
        }
    }
}