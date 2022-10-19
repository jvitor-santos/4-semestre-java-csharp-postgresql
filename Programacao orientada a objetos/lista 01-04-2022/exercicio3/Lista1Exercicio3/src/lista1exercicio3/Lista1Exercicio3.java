package lista1exercicio3;

import org.me.lista1exercicio3.*;

public class Lista1Exercicio3 {

    
    public static void main(String[] args) {
     FuncionarioMensalista f1 = new FuncionarioMensalista("Julgadox","Cod",494,1000.00);
     FuncionarioHorista fh1 = new FuncionarioHorista("Toloske","Lol",157,20,20);
     FuncionarioComissao c1 = new FuncionarioComissao("Ofioravante","Cs",777,300,0.2);
     
     f1.calcula_salario();
     double salarioHorista = fh1.calcula_salario();
     double salarioComissao = c1.calcula_salario();
     
        System.out.println("Funcionario Mensalista");
        System.out.printf("%s",f1);
        
        System.out.println("\nFuncionario Horista");
        System.out.printf("%s",fh1);
        System.out.printf("Salario: R$%.2f\n\n", salarioHorista);
        
        System.out.println("\nFuncionario Comissao");
        System.out.printf("%s",c1);
        System.out.printf("Comissao: R$%.2f\n\n",salarioComissao);

    }
}
