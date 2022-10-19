package org.me.telacalculadora2;
import java.awt.*;
import javax.swing.*;
public class TelaCalculadora2 extends JFrame{
    private JButton zero,um,dois,tres,quatro,cinco,seis,sete,oito,nove,mais,menos,div,ponto,igual,mult;
    private JTextField Resultado,Resultado1,Resultado2,Resultado3;
    public TelaCalculadora2() {
        super("Exemplo GridLayout");
        Resultado = new JTextField (4);
        Resultado1 = new JTextField ("");
        Resultado2 = new JTextField ("");
        Resultado3 = new JTextField ("");
        zero = new JButton("0");
        um = new JButton("1");
        dois = new JButton("2");
        tres = new JButton("3");
        quatro = new JButton("4");
        cinco = new JButton("5");
        seis = new JButton("6");
        sete = new JButton("7");
        oito = new JButton("8");
        nove = new JButton("9");
        mais = new JButton("+");
        menos = new JButton("-");
        div = new JButton("/");
        ponto = new JButton(".");
        igual = new JButton("=");
        mult = new JButton("*");
        getContentPane().setLayout( new GridLayout(4,4));
        add(Resultado);
        add(sete );
        add(oito );
        add(nove );
        add(div );
        add(quatro );
        add(cinco );
        add(seis );
        add(mult );
        add( um );
        add( dois );
        add(tres );
        add(menos );
        add( zero );
        add(ponto );
        add(igual );
        add(mais );
    }
}
