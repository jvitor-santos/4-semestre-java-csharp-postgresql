package org.me.atividadeclasseabstrata2;
public class Passageiros extends Veiculo{
    private int quantidade;
    
    public Passageiros(String marca, String modelo, int ano, int potencia, double capacidade_carga, int quantidade){
        super(marca, modelo, ano, potencia, capacidade_carga);
        this.quantidade=quantidade;
    }
    
    @Override
    public void imprime(){
        System.out.println("Passageiros");
        System.out.println("marca: "+marca);
        System.out.println("Modelo: "+modelo);
        System.out.println("Ano: "+ano);
        System.out.println("Potência: "+potencia+" cavalos");
        System.out.println("Capacidade da carga: "+capacidade_carga+" toneladas");
        System.out.println("A quantidade de passageiros é de: "+quantidade);
    }
    
}
