package org.me.ExSobrecarga2;

public class ExSobrecarga2 {
    private int a,b,c,v1,v2,v3;
    
    public void valor(int v1, int v2, int v3){
        a=v1+v2+v3;
        b=0;
        c=0;
    }
    
    public void valor(int v1){
        b=v1;
        a=a+0;
        c=c+0;
    }
    
    public void valor(int v1, int v2){
        c=v1*v2;
        a=a+0;
        b=b+0;
    }
    
    public void imprimeValor(){
        System.out.println("O valor de a é: " +a);
        System.out.println("O valor de b é: " +b);
        System.out.println("O valor de c é: " +c);
    }
    
}
