package org.me.atividadeclasseabstrata2;
public class Utilitarios extends Veiculo{
    private String tipo_cabine;
    
    public Utilitarios(String marca, String modelo, int ano, int potencia, double capacidade_carga, String tipo_cabine){
        super(marca, modelo, ano, potencia, capacidade_carga);
        this.tipo_cabine=tipo_cabine;
    }
    
    @Override
    public void imprime(){
        System.out.println("Veiculo");
        System.out.println("marca: "+marca);
        System.out.println("Modelo: "+modelo);
        System.out.println("Ano: "+ano);
        System.out.println("Potência: "+potencia+" cavalos");
        System.out.println("Capacidade da carga: "+capacidade_carga+" toneladas");
        System.out.println("Tipo de cabine: "+tipo_cabine);
    }
    
}
