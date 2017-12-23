namespace Bridge
{
    public abstract class Exportacao
    {
        protected ExportacaoImpl _implementor;

        public ExportacaoImpl Implementor
        {
            set { _implementor = value; }
        }

        public virtual void Exportar()
        {
            _implementor.Exportar();
        }
    }
}