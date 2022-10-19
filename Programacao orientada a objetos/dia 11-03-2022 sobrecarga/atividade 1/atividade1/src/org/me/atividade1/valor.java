package org.me.atividade1;
public class valor {
    private int numero;

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }
    
    public int fatorial(int numero){
        int f=1;
        for (int i = 1; i <=numero;i++){
            f = f*i;
        }
        return f;
    }
 }
