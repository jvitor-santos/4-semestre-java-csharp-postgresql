package testeatividade1classeabstrata;
import org.me.atividadeclasseabstrata1.Secretaria;
import org.me.atividadeclasseabstrata1.Vendedor;

public class TesteAtividade1ClasseAbstrata {
    public static void main(String[] args) {
        Vendedor v1 = new Vendedor("vitor",1200);
        Secretaria s1 = new Secretaria("Maria",1500);
        String no,re,idi,dep;
        double sal,com;
        
        no="vitor";
        v1.setNome(no);
        sal=1200;
        v1.setSalario(sal);
        re="SMA";
        v1.setRegiao(re);
        com=200;
        v1.setComissao(com);
        
        System.out.println("Vendedor");
        System.out.println("Nome: " +v1.getNome());
        System.out.println("Salario: "+v1.getSalario());
        System.out.println("Região: "+v1.getRegiao());
        System.out.println("Comissão: "+v1.getComissao());
        System.out.println("Salario reajustado: "+v1.reajuste());
       
        no="Maria";
        s1.setNome(no);
        sal=1500;
        s1.setSalario(sal);
        idi="inglês";
        s1.setIdioma(idi);
        dep="Recepção";
        s1.setDepartamento(dep);
        
        System.out.println("Secretaria");
        System.out.println("Nome: "+s1.getNome());
        System.out.println("Salario: "+s1.getSalario());
        System.out.println("Idioma: "+s1.getIdioma());
        System.out.println("Departamento: "+s1.getDepartamento());
        System.out.println("Salario reajustado: "+s1.reajuste());
        
    }
}