package testesobrecarga;
import org.me.exemplosobrecarga.sobrecarga;
public class TesteSobrecarga {
    public static void main(String[] args) {
        sobrecarga teste = new sobrecarga ();
        
        teste.exibeMensagem();
        teste.exibeMensagem("Aula");
        teste.exibeMensagem(100);
    }
    
}
