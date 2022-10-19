package testeproduto;
import java.util.Scanner;
import org.me.produto.produto;
public class TesteProduto {
    public static void main(String[] args) {
        produto p1 = new produto();
        Scanner entrada = new Scanner (System.in);
        String nome_p1;
        double quantidade_p1, preco_p1;
        System.out.println("Informe o nome do produto: ");
        nome_p1 = entrada.nextLine();
        p1.setDescricao(nome_p1);
        
        System.out.println("Informe a quantidade de produto: ");
        quantidade_p1 = entrada.nextDouble();
        p1.setQuantidade(quantidade_p1);
        
        System.out.println("Informe o preço do produto");
        preco_p1 = entrada.nextDouble();
        p1.setPreco(preco_p1);
        
        System.out.println("Descrição "+ p1.getDescricao());
        System.out.println("Quantidade "+ p1.getQuantidade());
        System.out.printf("preço %.2f \n", p1.getPreco());
        System.out.printf("desconto %.2f \n", p1.calculaDesconto());
    }
    
}
