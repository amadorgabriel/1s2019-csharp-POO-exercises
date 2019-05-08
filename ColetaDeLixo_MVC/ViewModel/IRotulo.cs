using System;
using ColetaDeLixo_MVC.Interface;
using static ColetaDeLixo_MVC.Utils.Enum;

namespace ColetaDeLixo_MVC.ViewModel
{
    public class IRotulo : IPapel
    {
        public bool Papel()
        {   
            CorTerminal("Deposite na lixeira Azul",  CoresNoTerminalEnum.AZUL );
            return true;
        }
    }
}