namespace DesignPatterns.Factory_Method
{
    public abstract class Pedido
    {
        protected double Importe { get; set; }

        public Pedido(double Importe)
        {
            this.Importe = Importe;
        }

        public abstract bool IsValid();

        public abstract void Pay();
    }
}
