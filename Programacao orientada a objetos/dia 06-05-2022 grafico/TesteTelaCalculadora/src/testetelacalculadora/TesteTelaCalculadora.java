package testetelacalculadora;

import javax.swing.JFrame;
import org.me.telacalculadora.TelaCalculadora;

public class TesteTelaCalculadora {
    public static void main(String[] args) {
        TelaCalculadora  Flow = new  TelaCalculadora ( );
        Flow.setSize( 200, 200 );
        Flow.setLocation( 300, 200 );
        Flow.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Flow.setVisible( true );
    }
}