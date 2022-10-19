package testecaixadialogo2;
import javax.swing.JOptionPane;
public class TesteCaixaDialogo2 {
    public static void main(String[] args) {
        int resp;
        do {
            calcula();
            resp = JOptionPane.showConfirmDialog(null, "Deseja finalizar a execucao?",
            "Saida",
            JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);
        } while (resp==1);    // 1 -Não
        System.exit(0);     // 0 -Sim
    }
    
    public static void calcula(){
        int N1, N2, R;
        N1 = Integer.parseInt(JOptionPane.showInputDialog(null, "Primeiro número",
        "Digite o primeiro numero",
        JOptionPane.QUESTION_MESSAGE));
        N2=Integer.parseInt(JOptionPane.showInputDialog(null, "Segundo número ",
        "Digite o segundo numero",
        JOptionPane.QUESTION_MESSAGE));
        R = N1 + N2;
        JOptionPane.showMessageDialog(null,"Resultado da soma= " + R);
    }
    
}
