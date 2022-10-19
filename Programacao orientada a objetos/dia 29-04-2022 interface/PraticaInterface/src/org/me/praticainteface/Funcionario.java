package org.me.praticainteface;
public class Funcionario {
    private String nome, sobrenome;
    private int cpf;
    
    public Funcionario(String nome, String sobrenome, int cpf){
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.cpf = cpf;
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
        return String.format("%s %s\n"
                            +"%s %s\n"
                            +"%s %d",
                            "Nome: ",getNome(),
                            "Sobrenome: ",getSobrenome(),
                            "CPF: ", getCpf());
    }
}