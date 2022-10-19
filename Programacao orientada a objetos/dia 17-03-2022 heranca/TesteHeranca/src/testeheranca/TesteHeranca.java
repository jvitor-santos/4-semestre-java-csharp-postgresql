package testeheranca;

import org.me.exemploheranca.Programador;
import org.me.exemploheranca.Vendedor;
public class TesteHeranca {

    public static void main(String[] args) {
        Programador p1 = new Programador ();
        Vendedor v1 = new Vendedor ();
        p1.setMatricula(1233434);
        p1.setNome("Julgadox");
        p1.setData_nasc("12/03/1998");
        p1.setLinguagem("Java");
        p1.setNivel("Sênior");
        
        v1.setMatricula(54545);
        v1.setNome("Toloske");
        v1.setCidades("Itapê");
        
        System.out.println("Nome " + p1.getNome());
        System.out.println("Linguam " + p1.getLinguagem());
        
        System.out.println("Nome " + v1.getNome());
        System.out.println("Cidade " + v1.getCidades());
    }
    
}
