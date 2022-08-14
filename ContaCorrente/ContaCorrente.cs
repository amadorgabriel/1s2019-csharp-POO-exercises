namespace Ex1
{
    public class ContaCorrente
    {
        public string titular; // O publica permite voçe acessar pelo program os atributos.
        public int agencia;
        public int numeroConta;
        public double saldo{get; set;}


        public void Depositar(double valor){
            saldo = valor + saldo;
        }
        public bool Sacar(double valor){
            if (valor > saldo)
            {
                return false;
            }else{
                saldo = saldo - valor;
                return true;
            }
        }

        public double ExibirSaldo(){
            return saldo;
        }

        public bool Tranferir(double valor, ContaCorrente contaDestino){
            if (valor > saldo)
            {
                return false;
            }else
            {
                saldo -= valor;
                contaDestino.saldo += valor;
                return true;
            }
        }





    }
}