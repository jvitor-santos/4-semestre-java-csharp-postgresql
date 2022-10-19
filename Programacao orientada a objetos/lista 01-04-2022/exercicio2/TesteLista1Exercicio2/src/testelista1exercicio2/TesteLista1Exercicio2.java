package testelista1exercicio2;
import org.me.lista1exercicio2.*;


public class TesteLista1Exercicio2 {
    public static void main(String[] args) {
        Engenheiro e1 = new Engenheiro(50,"Toloske",1000.00,"TI",105131);
        Gerente g1 = new Gerente(100,"Julgadox",2000.00,1500.00);
        
        
        System.out.println("Engenheiro");
        System.out.println("Codigo: "+ e1.getCodigo());
        System.out.println("Nome: "+ e1.getNome());
        System.out.println("Salario: "+e1.getSalario_base());
        System.out.println("Departamento: "+e1.getDepartamento());
        System.out.println("CREA: "+ e1.getCrea());
        System.out.printf("Reajuste: "+ e1.calculo());
        
        System.out.println("Gerente");
        System.out.println("Codigo: "+ g1.getCodigo());
        System.out.println("Nome: "+ g1.getNome());
        System.out.println("Salario: "+ g1.getSalario_base());
        System.out.println("Bonus: "+ g1.calculo());
        
        
    }
    
}
