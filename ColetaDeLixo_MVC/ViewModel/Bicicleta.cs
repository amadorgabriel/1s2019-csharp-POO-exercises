using System;
using ColetaDeLixo_MVC.Interface;
using static ColetaDeLixo_MVC.Utils.Enum;


namespace ColetaDeLixo_MVC.ViewModel
{
    public class Bicicleta : IIndefinido
    {
        public bool Indefinido()
        {
            CorTerminal("Deposite na lixeira CINZA", CoresNoTerminalEnum.CINZA);
            return true;
        }
    }
}