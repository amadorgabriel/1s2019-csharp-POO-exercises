using System;
using ColetaDeLixo_MVC.Interface;
using static ColetaDeLixo_MVC.Utils.Enum;
namespace ColetaDeLixo_MVC.ViewModel
{
    public class Maca : IOrganico
    {
        public bool Organico()
        {
            CorTerminal("Deposite na lixeira Preta", CoresNoTerminalEnum.PRETO);
            return true;
        }
    }
}