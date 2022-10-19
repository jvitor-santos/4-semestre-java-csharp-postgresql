package testecomponentes;

import javax.swing.JFrame;
import org.me.excomponentes.ExComponentes;

public class TesteComponentes {
    public static void main(String[] args) {
        
        ExComponentes  exemplo  = new ExComponentes ( );
        exemplo.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        exemplo.setSize(260,180);
        exemplo.setVisible(true);  
    }
    
}
