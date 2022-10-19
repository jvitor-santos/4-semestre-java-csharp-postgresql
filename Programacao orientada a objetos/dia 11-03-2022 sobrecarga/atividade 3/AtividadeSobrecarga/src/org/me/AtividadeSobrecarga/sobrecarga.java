package org.me.AtividadeSobrecarga;
public class sobrecarga {
    public int resultado;
    public double result;
    public String junta;
    
    public void adiciona(int v0, int v1){
        resultado = v0 + v1;
        System.out.println("O resultado é: " + resultado);
    }
    
    public void adiciona(int v2, int v3, int v4){
        resultado = v2 + v3 + v4;
        System.out.println("O resultado é: " + resultado);
    }
    
    public void adiciona(double v5, double v6){
        result = v5+v6;
        System.out.println("O resultado é: " + result);
    }
    
    public void adiciona(String v7, String v8){
        junta = v7 + v8;
        System.out.println("O resultado é: " + junta);
    }
}
