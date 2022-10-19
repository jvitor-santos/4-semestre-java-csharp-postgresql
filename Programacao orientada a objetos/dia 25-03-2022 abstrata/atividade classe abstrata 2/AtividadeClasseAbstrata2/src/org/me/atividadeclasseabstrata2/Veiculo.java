package org.me.atividadeclasseabstrata2;
public abstract class Veiculo {
    protected String marca, modelo;
    protected int ano, potencia;
    protected double capacidade_carga;
    
    public Veiculo(String marca, String modelo, int ano, int potencia, double capacidade_carga){
        this.marca=marca;
        this.modelo=modelo;
        this.ano=ano;
        this.potencia=potencia;
        this.capacidade_carga=capacidade_carga;
    }
    
    public abstract void imprime();
    
}
