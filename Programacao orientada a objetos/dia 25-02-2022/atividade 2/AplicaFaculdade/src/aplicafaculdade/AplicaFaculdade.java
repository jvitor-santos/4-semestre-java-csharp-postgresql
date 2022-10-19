package aplicafaculdade;
import java.util.Scanner;
import org.me.faculdade.faculdade;
public class AplicaFaculdade {
    public static void main(String[] args) {
        faculdade a1 = new faculdade();
        Scanner leia = new Scanner (System.in);
        String nome_a1, curso_a1;
        int ra_a1;
        double nota_a1, mensalidade_a1;
        
        System.out.println("Informe o nome do aluno: ");
        nome_a1 = leia.nextLine();
        System.out.println("Informe o curso: ");
        curso_a1 = leia.nextLine();
        System.out.println("Informe o RA do aluno: ");
        ra_a1 = leia.nextInt();
        System.out.println("Informe a nota do aluno:");
        nota_a1 = leia.nextDouble();
        System.out.println("Informe a mensalidade: ");
        mensalidade_a1 = leia.nextDouble();
        
        a1.setNome(nome_a1);
        a1.setCurso(curso_a1);
        a1.setRa(ra_a1);
        a1.setNota(nota_a1);
        a1.setMensalidade(mensalidade_a1);
        
        System.out.println("Nome: " + a1.getNome());
        System.out.println("Curso: " + a1.getCurso());
        System.out.println("RA: " + a1.getRa());
        System.out.println("Nota: " + a1.getNota());
        System.out.println("Mensalidade: " + a1.getMensalidade());
        System.out.println("Desconto: " + a1.calculaDesconto());
    }
}
