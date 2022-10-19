package aplicacaopratica;

import org.me.praticainteface.*;

public class AplicacaoPratica {
    public static void main(String[] args) {
        int i;
        
        Pagamento p[] = new Pagamento[4];
        p[0] = new Fatura(11,2,"Perfume",20);
        p[1] = new Fatura(22,4,"Pinga",40);
        p[2] = new FuncionarioMensalista("Julgadox","Cod",40028922,1200);
        p[3] = new FuncionarioMensalista("Toloske","Lol",3279186,2400);
        for (i=0; i<4; i++){
            System.out.printf("\n\n%s",p[i]);
            System.out.printf("\nValor a pagar: R$ %s",p[i].getValor_pagamento());
        }
    }  
}