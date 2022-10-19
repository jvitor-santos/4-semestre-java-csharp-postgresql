package testeclasseabstrata;
import org.me.exemploclasseabstrata.Administrador;
import org.me.exemploclasseabstrata.Medico;

public class TesteClasseAbstrata {
    public static void main(String[] args) {
        Medico m1 = new Medico ("Paulo","paulo@gmail",1223455);
        Administrador a1 = new Administrador ("Vitor","vitor@gmail.com",20);
        m1.imprime();
        a1.imprime();

    }
    
}
