package org.me.exerciciofuncionarioconstrutor;
public class Analista extends Funcionario{
    private String projeto;
    
    public Analista(int matricula, int rg, String nome, String projeto){
        super(matricula, rg, nome);
        this.projeto = projeto;
    }
    
    public void setProjeto(String projeto){
        this.projeto = projeto;
    }
    
    public String getProjeto(){
        return projeto;
    }
}
