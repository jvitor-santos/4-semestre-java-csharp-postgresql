package org.me.excomponentes;

import javax.swing.*;
import java.awt.FlowLayout;

public class ExComponentes extends JFrame{
    private JLabel rotulo;
    private JTextField texto;
    private JButton botao;
    
    public  ExComponentes ( ) {
        super ("Teste de Janela");
        setLayout(new FlowLayout());
        rotulo = new JLabel ("Nome: ");
        rotulo.setToolTipText("Este é o rótulo 1");
        add(rotulo);
        texto = new JTextField(15);
        add(texto);botao = new JButton("Botao");
        add(botao);
    }
}
