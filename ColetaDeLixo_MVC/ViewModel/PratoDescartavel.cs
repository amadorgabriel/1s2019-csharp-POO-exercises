using System;
using ColetaDeLixo_MVC.Interface;
using static ColetaDeLixo_MVC.Utils.Enum;
namespace ColetaDeLixo_MVC.ViewModel
{
    public class PratoDescartavel : IPlastico
    {
        public bool Plastico()
        {
            CorTerminal("Deposite na lixeira Vermelha", CoresNoTerminalEnum.VERMELHO);
            return true;
        }
    }
}