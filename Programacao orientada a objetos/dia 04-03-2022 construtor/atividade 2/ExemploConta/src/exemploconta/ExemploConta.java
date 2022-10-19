package exemploconta;
import java.util.Scanner;
import org.me.conta.TesteConta;
public class ExemploConta {
    public static void main(String[] args) {
        TesteConta c1 = new TesteConta("Maria", "maria@gmail.com", 105131, 190, 0, 0, 0);
        TesteConta c2 = new TesteConta("Pedro", "pedro@gmail.com", 400289, 181, 0, 0 ,0);
        double v1,v2;
        Scanner leia = new Scanner (System.in);
        
        System.out.printf("Saldo inicial da conta 1: %.2f \n", c1.getSaldo());
        System.out.println("Infome a quantidade a creditar na 1º conta: ");
        v1 = leia.nextDouble();
        c1.setCredito(v1);
        System.out.println("Infome a quantidade a debitar na 1º conta: ");
        v2 = leia.nextDouble();
        c1.setDebito(v2);
        
        System.out.println("conta 1");
        System.out.println("Nome: " + c1.getNome());
        System.out.println("Email: " + c1.getEmail());
        System.out.println("Telefone: " + c1.getTelefone());
        System.out.printf("Saldo final conta 1: \n" + c1.getSaldo());
        
        System.out.printf("Saldo inicial da conta 2: %.2f \n", c2.getSaldo());
        System.out.println("Infome a quantidade a creditar na 2º conta: ");
        v1 = leia.nextDouble();
        c2.setCredito(v1);
        System.out.println("Infome a quantidade a debitar na 2º conta: ");
        v2 = leia.nextDouble();
        c2.setDebito(v2);
        
        System.out.println("conta 2");
        System.out.println("Nome: " + c1.getNome());
        System.out.println("Email: " + c1.getEmail());
        System.out.println("Telefone: " + c1.getTelefone());
        System.out.printf("Saldo final conta 2: %.2f \n" + c1.getSaldo());
        
    }
    
}
