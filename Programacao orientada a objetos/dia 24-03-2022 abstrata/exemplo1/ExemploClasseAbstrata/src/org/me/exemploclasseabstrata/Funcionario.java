package org.me.exemploclasseabstrata;
public abstract class Funcionario {
    protected String nome, email;
    
    public Funcionario(String nome, String email){
        this.nome = nome;
        this.email = email;
    }
    
    public abstract void imprime ();
    
}
