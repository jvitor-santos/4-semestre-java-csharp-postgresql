package org.me.ExercicioSobrecarga;
public class sobrecarga {
    public int resultado;
    public void calcula(int v0){
        resultado = v0/2;
    }
    
    public void calcula(int v1, int v2, int v3, int v4){
        resultado= v1 + v2 + v3 + v4;
    }
    
    public void calcula(int v5, int v6){
        resultado = v5 - v6;
    }
    
    public void calcula(int v7, int v8, int v9){
        resultado = v7 * v8 * v9;
    }
    
    public void exibeCalculo(){
        System.out.println("O resultado de: " + resultado);
    }
}
