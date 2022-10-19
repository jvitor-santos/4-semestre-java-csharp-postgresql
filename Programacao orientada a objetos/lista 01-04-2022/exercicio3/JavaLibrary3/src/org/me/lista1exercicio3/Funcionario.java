package org.me.lista1exercicio3;
public abstract class Funcionario {
    private String nome, sobrenome;
    private int cpf;
    
    public Funcionario(String nome, String sobrenome, int cpf){
        this.nome=nome;
        this.sobrenome=sobrenome;
        this.cpf=cpf;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getSobrenome() {
        return sobrenome;
    }

    public void setSobrenome(String sobrenome) {
        this.sobrenome = sobrenome;
    }

    public int getCpf() {
        return cpf;
    }

    public void setCpf(int cpf) {
        this.cpf = cpf;
    }
    
    @Override
    public String toString(){
        return "\nNome: "+ getNome()+ "\nSobrenome: "+ getSobrenome() + "\nCPF: "+getCpf() +"\n";
    }
    public abstract double calcula_salario();
}