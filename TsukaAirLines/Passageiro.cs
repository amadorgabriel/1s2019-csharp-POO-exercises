using System;

namespace TsukaAirLines
{
    public class Passageiro
    {
        string nome; //Era o que estava escrito na bin Classes em umas 15 linhas
        int numeroPassagem; // Irá receber e moostrar?
        DateTime data;

        public void setNome(string nome ) { //O que houover nos parametros poderão ser usados no processo
            this.nome = nome;
        }

        public string getNome(){
            return this.nome;
        }

        
    }
}