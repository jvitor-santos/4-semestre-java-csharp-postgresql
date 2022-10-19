package org.me.atividadeclasseabstrata1;
public class Secretaria extends Funcionario{
    private String idioma, departamento;
    
    public Secretaria(String nome, double salario){
        super(nome, salario);
    }

    public String getIdioma() {
        return idioma;
    }

    public void setIdioma(String idioma) {
        this.idioma = idioma;
    }

    public String getDepartamento() {
        return departamento;
    }

    public void setDepartamento(String departamento) {
        this.departamento = departamento;
    }
    
    @Override
    public double reajuste(){
        salario+=salario*0.15;
        return salario;
    }
}
