package exerciociocalculadora;
import javax.swing.JOptionPane;
public class ExerciocioCalculadora {
    public static void main(String[] args) {
        int resp;
        do {
            calcula();
            resp = JOptionPane.showConfirmDialog(null, "Deseja finalizar a execucao?",
            "Saida",
            JOptionPane.YES_NO_OPTION, JOptionPane.QUESTION_MESSAGE);
        } 
        while (resp==1);    // 1 -Não
        System.exit(0);     // 0 -Sim
    }
    public static void calcula(){
        double N1, N2, R,r1,r2,r3,r4,r5,r6,r7,r8;
        N1 = Integer.parseInt(JOptionPane.showInputDialog(null, "Primeiro número",
        "Digite o primeiro numero",
        JOptionPane.QUESTION_MESSAGE));
        N2=Integer.parseInt(JOptionPane.showInputDialog(null, "Segundo número ",
        "Digite o segundo numero",JOptionPane.QUESTION_MESSAGE));
        R = N1 + N2;
        r1 = N1 - N2;
        r2 = N1 / N2;
        r3 = N1 * N2;
        r4 = N1 * N1;
        r5 = N2 * N2;
        r6 = N1 * N1 * N1;
        r7 = N2 * N2 * N2;
        r8 = (N1) * (N2/100);
        JOptionPane.showMessageDialog(null,"Resultado da soma= " + R);
        JOptionPane.showMessageDialog(null,"Resultado da subtração= " + r1);
        JOptionPane.showMessageDialog(null,"Resultado da divisão= " + r2);
        JOptionPane.showMessageDialog(null,"Resultado da multiplicação= " + r3);
        JOptionPane.showMessageDialog(null,"Resultado do N1²= " + r4);
        JOptionPane.showMessageDialog(null,"Resultado da N2²= " + r5);
        JOptionPane.showMessageDialog(null,"Resultado da N1³= " + r6);
        JOptionPane.showMessageDialog(null,"Resultado da n2³= " + r7);
        JOptionPane.showMessageDialog(null,"Resultado da porcentagem= " + r8);
        }
    }
