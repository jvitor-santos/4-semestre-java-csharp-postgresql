package testefuncionarios;
import org.me.exemploconstrutor.Funcionario;

public class TesteFuncionarios {
    public static void main(String[] args) {
        Funcionario f1 = new Funcionario ("Maria", 20, 1000.00);
        Funcionario f2 = new Funcionario ("Pedro", 25, 1000.00);
        
        System.out.println("Funcionario 1");
        System.out.println("Nome: " + f1.getNome());
        System.out.println("Idade: " + f1.getIdade());
        System.out.println("Salario " + f1.getSalario());
        
        System.out.println("Funcionario 2");
        System.out.println("Nome: " + f2.getNome());
        System.out.println("Idade: " + f2.getIdade());
        System.out.println("Salario: " + f2.getSalario());
    }
}
