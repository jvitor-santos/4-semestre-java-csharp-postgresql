package testeherancaconstrutor;

import org.me.exherancaconstrutor.Instrutor;

public class TesteHerancaConstrutor {
    public static void main(String[] args) {
        Instrutor i1 = new Instrutor("Mario", "mario@gmail.com", 2000.00, "Inglês", 20);
        
        System.out.println("Nome: " + i1.getNome());
        System.out.println("E-mail: " + i1.getEmail());
        System.out.println("Salario: " + i1.getSalario());
        System.out.println("Disciplina: " + i1.getDisciplina());
        System.out.println("Numero de alunos: " + i1.getN_alunos());
    }
    
}
