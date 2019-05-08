using System;
using ColetaDeLixo_MVC.Interface;
using static ColetaDeLixo_MVC.Utils.Enum;

namespace ColetaDeLixo_MVC.ViewModel
{
    public class GarrafaDeVidro : IVidro
    {
        public bool Vidro()
        {
            CorTerminal("Deposite na lixeira Verde", CoresNoTerminalEnum.VERDE);
            return true;
        }
    }
}