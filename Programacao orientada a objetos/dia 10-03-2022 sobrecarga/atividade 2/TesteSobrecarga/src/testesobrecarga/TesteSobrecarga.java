package testesobrecarga;
import org.me.ExercicioSobrecarga.sobrecarga;
public class TesteSobrecarga {
    public static void main(String[] args) {
        sobrecarga valor = new sobrecarga();
        
        valor.calcula(20);
        valor.exibeCalculo();
        
        valor.calcula(20,5);
        valor.exibeCalculo();
        
        valor.calcula(10, 20, 30);
        valor.exibeCalculo();
        
        valor.calcula(5, 6, 7, 8);
        valor.exibeCalculo();
    }
    
}
