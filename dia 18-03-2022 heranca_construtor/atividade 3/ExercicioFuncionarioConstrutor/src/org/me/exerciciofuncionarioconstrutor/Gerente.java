package org.me.exerciciofuncionarioconstrutor;
public class Gerente extends Funcionario{
    private String departamento;
    private int n_pessoas;
    
    public Gerente(int matricula, int rg, String nome, String departamento, int n_pessoas){
        super(matricula, rg, nome);
        this.departamento = departamento;
        this.n_pessoas = n_pessoas;
    }

    public String getDepartamento() {
        return departamento;
    }

    public void setDepartamento(String departamento) {
        this.departamento = departamento;
    }

    public int getN_pessoas() {
        return n_pessoas;
    }

    public void setN_pessoas(int n_pessoas) {
        this.n_pessoas = n_pessoas;
    }
    
    
}
