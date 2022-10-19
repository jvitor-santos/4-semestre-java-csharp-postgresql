package testeexerciciofuncionarioconstrutor;
import org.me.exerciciofuncionarioconstrutor.Analista;
import org.me.exerciciofuncionarioconstrutor.Gerente;

public class TesteExercicioFuncionarioConstrutor {
    public static void main(String[] args) {
        Gerente g1 = new Gerente(001,494186,"Julgadox","Distribuição",20);
        Analista a1 = new Analista(002,85876,"Toloske","Java");
        
        System.out.println("A matricula do gerente é: "+ g1.getMatricula());
        System.out.println("O rg é: "+ g1.getRg());
        System.out.println("O nome é: "+ g1.getNome());
        System.out.println("O departamento é: "+g1.getDepartamento());
        System.out.println("O numero de pessoas é: "+g1.getN_pessoas());
        
        System.out.println("A matricula do Analista é: "+ a1.getMatricula());
        System.out.println("O rg é: "+ a1.getRg());
        System.out.println("O nome é: "+ a1.getNome());
        System.out.println("O projeto dele é: "+ a1.getProjeto());
    }
    
}
