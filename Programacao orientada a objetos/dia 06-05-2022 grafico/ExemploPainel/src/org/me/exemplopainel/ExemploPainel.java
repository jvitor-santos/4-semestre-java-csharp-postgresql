package org.me.exemplopainel;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import javax.swing.*;

public class ExemploPainel extends JPanel{
    private JLabel lbSenha;
    private JPasswordField txtSenha;
    private JButton  ok,  cancel;
    public ExemploPainel ( ) {
        lbSenha = new JLabel("Senha");
        txtSenha = new JPasswordField ("",16);
        ok = new JButton("Ok");
        cancel = new JButton("Cancelar");
    }
    
    public void init ( ) {
        setLayout( new GridLayout(2,1) );
        FlowLayout centro = new FlowLayout( FlowLayout.CENTER );
        JPanel auxSenha = new JPanel( centro );
        auxSenha.add( lbSenha );
        auxSenha.add( txtSenha );
        JPanel auxBotoes = new JPanel( centro );
        auxBotoes.add( ok );
        auxBotoes.add( cancel );
        add( auxSenha );
        add( auxBotoes );
}
}
