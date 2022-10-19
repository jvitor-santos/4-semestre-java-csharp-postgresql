package testeveiculos;
import org.me.atividadeclasseabstrata2.Passageiros;
import org.me.atividadeclasseabstrata2.Utilitarios;
import org.me.atividadeclasseabstrata2.Veiculo;

public class TesteVeiculos {
    public static void main(String[] args) {
        int i;
        
        Veiculo v1[] = new Veiculo[4];
        v1[0] = new Utilitarios("Mercedes","1315",1984,136,13,"Simples");
        v1[1] = new Utilitarios("Scania","R440",2013,440,78,"Simples");
        v1[2] = new Passageiros("Mercedes","1315",1984,136,13,2);
        v1[3] = new Passageiros("Scania","R440",2013,440,78,2);
        for (i=0;i<4;i++){
            v1[i].imprime();
        }
    }
    
}
