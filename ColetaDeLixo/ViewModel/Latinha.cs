using System;
using ColetaDeLixo_MVC.Interface;
using static ColetaDeLixo_MVC.Utils.Enum;
namespace ColetaDeLixo_MVC.ViewModel
{
    public class Latinha : IMetal
    {
        public bool Metal()
        {
            CorTerminal("Deposite na lixeira Amarelo", CoresNoTerminalEnum.AMARELO);
            return true;
        }
    }
}