package org.me.lista1exercicio2;
public abstract class Empregado {
    private int codigo;
    private String nome;
    private double salario_base;
    
    public Empregado(int codigo, String nome, double salario_base){
        this.codigo=codigo;
        this.nome=nome;
        this.salario_base=salario_base;
    }

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public double getSalario_base() {
        return salario_base;
    }

    public void setSalario_base(double salario_base) {
        this.salario_base = salario_base;
    }
    
    public abstract double calculo();
    
}
