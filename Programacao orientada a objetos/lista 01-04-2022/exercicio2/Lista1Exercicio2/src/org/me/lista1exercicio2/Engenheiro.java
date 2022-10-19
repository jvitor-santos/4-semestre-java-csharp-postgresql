package org.me.lista1exercicio2;
public class Engenheiro extends Empregado{
    private String departamento;
    private int crea;
    
    public Engenheiro(int codigo, String nome, double salario_base, String departamento, int crea){
        super(codigo, nome, salario_base);
        this.departamento=departamento;
        this.crea=crea;
    }

    public String getDepartamento() {
        return departamento;
    }

    public void setDepartamento(String departamento) {
        this.departamento = departamento;
    }

    public int getCrea() {
        return crea;
    }

    public void setCrea(int crea) {
        this.crea = crea;
    }
    
    
    @Override
    public double calculo(){
       return getSalario_base()*1.5;
    }
    
}
