namespace ExercicioBancoApp
{
    public class Conta
    {
        private int _numeroConta;
        private string _titular;
        public double Saldo { get; private set; }

        public Conta(int numeroConta, string titular)
        {
            _numeroConta = numeroConta;
            _titular = titular;
        }

        public Conta(int numeroConta, string titular, double depositoInicial) : this(numeroConta, titular)
        {
            Deposito(depositoInicial);
        }

        public int NumeroConta
        {
            get { return _numeroConta; }
            set
            {
                if ( value > 1)
                {
                    _numeroConta = value;
                }
            }
        }

        public string Titular 
        {
            get { return _titular; }
            set
            {
                if (value != null && value.Length > 1)
                { _titular = value; }

            }
        }

        public void Deposito(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public void Saque(double valor)
        {
            if (valor > 0)
            {
                Saldo -= valor + 5;
            }
        }

        public override string ToString()
        {
            return "Conta " + _numeroConta + ", Titular: " + _titular + ", Saldo: $" + Saldo;
        }
    }
}
