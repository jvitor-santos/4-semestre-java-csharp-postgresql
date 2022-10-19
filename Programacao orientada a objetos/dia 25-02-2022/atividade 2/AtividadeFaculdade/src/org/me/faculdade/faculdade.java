package org.me.faculdade;
public class faculdade {
    private String nome,curso;
    private int ra;
    private double nota,mensalidade;
    
    public void setNome(String nome){
        this.nome = nome;
    }
    public String getNome(){
        return nome;
    }
    
    public void setCurso(String curso){
        this.curso = curso;
    }
    public String getCurso(){
        return curso;
    }
    
    public void setRa(int ra){
        this.ra = ra;
    }
    
    public int getRa(){
        return ra;
    }
    
    public void setNota(double nota){
        this.nota = nota;
    }
    public double getNota(){
        return nota;
    }
    
    public void setMensalidade(double mensalidade){
        this.mensalidade = mensalidade;
    }
    public double getMensalidade(){
        return mensalidade;
    }
    
    public double calculaDesconto(){
        if (nota >= 9)
            return mensalidade/2;
        else
            return mensalidade*0;
    }
}
