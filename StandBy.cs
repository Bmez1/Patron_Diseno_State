namespace Patron_Diseño_State
{
    public class StandBy : Estado
    {
        public override void ControlarEstado(Switch sw)
        {
            sw.DefinirEstado(new Encendido());
        }

        public override string Descubrir()
        {
            return "Switch en Stand by";
        }
    }
}
