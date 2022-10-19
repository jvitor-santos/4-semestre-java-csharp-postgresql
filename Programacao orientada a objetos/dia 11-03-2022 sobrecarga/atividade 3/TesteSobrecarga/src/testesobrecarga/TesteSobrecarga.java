package testesobrecarga;
import org.me.AtividadeSobrecarga.sobrecarga;

public class TesteSobrecarga {

    public static void main(String[] args) {
        sobrecarga s1 = new sobrecarga();
        sobrecarga s2 = new sobrecarga();
        
        s1.adiciona(10,20);
        s1.adiciona(10,20,30);
        s1.adiciona(10.5,20.5);
        s1.adiciona("Julgadox","Cod");
        
        s2.adiciona(30,40);
        s2.adiciona(40,50,60);
        s2.adiciona(20.5,30.5);
        s2.adiciona("Toloske","Lol");
    }
    
}
