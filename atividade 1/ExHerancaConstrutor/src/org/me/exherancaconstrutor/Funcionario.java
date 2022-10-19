package org.me.exherancaconstrutor;
public class Funcionario {
    private String nome, email;
    private double salario;
    
    public Funcionario(String nome, String email, double salario){
        this.nome = nome;
        this.email = email;
        this.salario = salario;
    }
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public String getNome(){
        return nome;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public void setSalario(double salario) {
        this.salario = salario;
    }
    
    public double getSalario(){
        return salario;
    }
}
