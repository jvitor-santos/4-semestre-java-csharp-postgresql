package org.me.lista1exercicio2;
public class Gerente extends Empregado{
    private double bonus;
    
    public Gerente(int codigo, String nome, double salario_base, double bonus){
        super(codigo, nome, salario_base);
        this.bonus=bonus;
    }

    public double getBonus() {
        return bonus;
    }

    public void setBonus(double bonus) {
        this.bonus = bonus;
    }
    
    @Override
    public double calculo(){
        return getSalario_base()+ getBonus();
    }
    
}
