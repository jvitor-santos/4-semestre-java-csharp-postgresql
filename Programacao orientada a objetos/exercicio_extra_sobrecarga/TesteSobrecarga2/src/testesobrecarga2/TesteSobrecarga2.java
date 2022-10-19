package testesobrecarga2;

import org.me.ExSobrecarga2.ExSobrecarga2;

public class TesteSobrecarga2 {
    public static void main(String[] args) {
        ExSobrecarga2 s1 = new ExSobrecarga2();
        ExSobrecarga2 s2 = new ExSobrecarga2();
        
        s1.valor(10,20,30);
        s1.valor(10);
        s1.valor(10,20);
        
        s2.valor(40,50,60);
        s2.valor(20);
        s2.valor(2,3);
        
        System.out.println("Primeiro vez:");
        s1.imprimeValor();
        System.out.println("Segunda vez:");
        s2.imprimeValor();
    }
    
}
