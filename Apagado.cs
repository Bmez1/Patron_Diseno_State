namespace Patron_Diseño_State
{
    public class Apagado : Estado
    {
        public override void ControlarEstado(Switch sw)
        {
            sw.DefinirEstado(new StandBy());
        }

        public override string Descubrir()
        {
            return "Swith apagado";
        }
    }
}