package org.me.exherancaconstrutor;
public class Instrutor extends Funcionario{
    private String disciplina;
    private int n_alunos;
    
    public Instrutor(String nome, String email, double salario, String disciplina, int n_alunos){
        super(nome, email, salario);
        this.disciplina = disciplina;
        this.n_alunos = n_alunos;
    }
    
    public String getDisciplina(){
        return disciplina;
    }
    
    public int getN_alunos(){
        return n_alunos;
    }
    
}
