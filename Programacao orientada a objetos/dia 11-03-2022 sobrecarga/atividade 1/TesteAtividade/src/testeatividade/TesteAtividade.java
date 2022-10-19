package testeatividade;
import java.util.Scanner;
import org.me.atividade1.valor;

public class TesteAtividade {
    public static void main(String[] args) {
        valor novo = new valor();
        Scanner leia = new Scanner (System.in);
        int v;
        
        System.out.println("Digite um numero para fatorar: ");
        v=leia.nextInt();
        novo.setNumero(v);

        System.out.printf("O fatorial é: " + novo.fatorial(v));
    }
    
}
