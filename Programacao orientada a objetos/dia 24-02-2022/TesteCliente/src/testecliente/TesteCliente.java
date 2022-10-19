package testecliente;
import java.util.Scanner;
import org.me.exerciciometodo.Cliente;
public class TesteCliente {
    public static void main(String[] args) {
        Cliente cl = new Cliente();
        Scanner entrada = new Scanner (System.in);
        double deposito;
        System.out.println("informe o valor do depósito");
        deposito = entrada.nextDouble();
        
        c1.exibeSaldo(deposito);
        c1.setNome("Chaves");
        System.out.println("nome do cliente" + c1.getNome());
    }
    
}
