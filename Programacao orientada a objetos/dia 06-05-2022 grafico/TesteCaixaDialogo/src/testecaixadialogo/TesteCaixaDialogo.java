package testecaixadialogo;
import javax.swing.JOptionPane;
public class TesteCaixaDialogo {
    public static void main(String[] args) {
        JOptionPane.showMessageDialog(null,"Sem icone",
        "Mensagem sem icone",JOptionPane.PLAIN_MESSAGE);
        
        JOptionPane.showMessageDialog(null,"Icone informação",
        "Mensagem icone informação",JOptionPane.INFORMATION_MESSAGE);
        
        JOptionPane.showMessageDialog(null,"Icone pergunta",
        "Mensagem icone pergunta",JOptionPane.QUESTION_MESSAGE);
        
        JOptionPane.showMessageDialog(null,"Icone aviso",
        " Mensagem icone aviso",JOptionPane.WARNING_MESSAGE);
        
        JOptionPane.showMessageDialog(null,"Icone erro",
        " Mensagem icone erro",JOptionPane.ERROR_MESSAGE);
    }
    
}
