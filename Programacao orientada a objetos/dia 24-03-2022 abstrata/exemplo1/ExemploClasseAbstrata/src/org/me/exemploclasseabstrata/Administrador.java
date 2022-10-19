package org.me.exemploclasseabstrata;
public class Administrador extends Funcionario{
    protected int n_pessoas;
    
    public Administrador(String nome, String email, int n_pessoas){
        super(nome, email);
        this.n_pessoas = n_pessoas;
    }
    
    @Override
    public void imprime(){
        System.out.println("Administrador");
        System.out.println("Nome: "+ nome);
        System.out.println("Email: " + email);
        System.out.println("Numero de pessoas: " + n_pessoas);
    }  
}
