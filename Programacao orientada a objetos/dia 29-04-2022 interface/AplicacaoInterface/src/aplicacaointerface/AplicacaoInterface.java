package aplicacaointerface;

import org.me.produto.*;

public class AplicacaoInterface {
    public static void main(String[] args) {
        Notebook n1 = new Notebook(31,"Samsung hero144", 3000,"16GB","500GB");
        Mousepad m1 = new Mousepad(51,"Mousepad Husky", 200, "Preto", "90x30");
        
        System.out.println("Notebook:");
        System.out.printf("%s",n1);
        System.out.printf("Valor de venda: %.2f",n1.getValor_venda());
        
        System.out.println("\nMousepad:");
        System.out.println(m1);
        System.out.printf("Valor de venda: %.2f",m1.getValor_venda());
    }
    
}
