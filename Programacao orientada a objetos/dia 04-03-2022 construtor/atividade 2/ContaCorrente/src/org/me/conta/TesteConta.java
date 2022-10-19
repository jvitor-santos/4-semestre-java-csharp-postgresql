package org.me.conta;
public class TesteConta {
    private String nome, email;
    private int cpf, telefone;
    private double saldo;
    
    public TesteConta (String nome,String email, int cpf, int telefone, double saldo, double credito, double debito){
        this.nome = nome;
        this.email = email;
        this.cpf = cpf;
        this.telefone = telefone;
        this.saldo = saldo;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public int getCpf() {
        return cpf;
    }

    public void setCpf(int cpf) {
        this.cpf = cpf;
    }

    public int getTelefone() {
        return telefone;
    }

    public void setTelefone(int telefone) {
        this.telefone = telefone;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }
    
    public void setCredito(double valor){
        saldo = saldo + valor;
    }
    
    public void setDebito(double debito){
        saldo = saldo - debito;
    }
    
    public double getSaldo(){
        return saldo;
    }
}
