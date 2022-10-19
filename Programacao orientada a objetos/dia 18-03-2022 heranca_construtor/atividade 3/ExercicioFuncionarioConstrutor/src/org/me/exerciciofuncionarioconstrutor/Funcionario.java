package org.me.exerciciofuncionarioconstrutor;
public class Funcionario {
    private int matricula, rg;
    private String nome;
    
    public Funcionario(int matricula, int rg, String nome){
        this.matricula = matricula;
        this.rg = rg;
        this.nome = nome;
    }

    public int getMatricula() {
        return matricula;
    }

    public void setMatricula(int matricula) {
        this.matricula = matricula;
    }

    public int getRg() {
        return rg;
    }

    public void setRg(int rg) {
        this.rg = rg;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }
    
}
