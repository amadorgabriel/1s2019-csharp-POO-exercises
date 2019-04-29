using System;

namespace Classes
{
    class Usuario //O main usuario só tem a responsibilidade de preencher aos solicitões 
    {
      string nome;
      string senha;
      string cpf;
      string email;

      // void = executa algo mas não retorna nada é apenas uma saida



    //setter = insere informação

    public void setSenha(string senha){ 
        this.senha = senha;
    }

    //getter = recebe a informação
    public string getSenha(){
        return this.senha;
    }







    }

}
