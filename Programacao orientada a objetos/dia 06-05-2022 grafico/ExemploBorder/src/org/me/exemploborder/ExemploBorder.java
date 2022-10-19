package org.me.exemploborder;
import java.awt.BorderLayout;
import javax.swing.*;
public class ExemploBorder extends JFrame{
    private JButton sim, nao, cancelar, salvar, confirmar;
    public ExemploBorder ( ) {
        super ("Exemplo BorderLayout");
        sim = new JButton("Sim");
        nao = new JButton("Nao");
        cancelar = new JButton("Cancelar");
        salvar = new JButton("Salvar");
        confirmar = new JButton("Confirmar");
        getContentPane().setLayout( new BorderLayout() );
        add( salvar, BorderLayout.CENTER );
        add( sim, BorderLayout.EAST );
        add( nao, BorderLayout.WEST );
        add( cancelar, BorderLayout.NORTH );
        add( confirmar, BorderLayout.SOUTH );
    }
}
