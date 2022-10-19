package org.me.exerciciometodo;
public class Cliente {
    
    private String nome, email;
    private int numconta;
    private double saldo = 100.00;
    
    public void exibeSaldo (double valdeposito){
        System.out.printf("Saldo atualizado: %.2f \n",(saldo + valdeposito));
    }
    
    public void setNome(String nome){
        this.nome = nome;
    }
    public String getNome(){
        return nome;
    }
}
