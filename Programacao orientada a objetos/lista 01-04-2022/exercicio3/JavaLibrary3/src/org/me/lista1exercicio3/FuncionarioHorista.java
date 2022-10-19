package org.me.lista1exercicio3;
public class FuncionarioHorista extends Funcionario{
    private double salario_hora,horas_trabalhadas;
    
    public FuncionarioHorista(String nome, String sobrenome, int cpf, double salario_hora, double horas_trabalhadas) {
        super(nome, sobrenome, cpf);
        this.salario_hora=salario_hora;
        this.horas_trabalhadas=horas_trabalhadas;
    }


    public double getSalario_hora() {
        return salario_hora;
    }

    public void setSalario_hora(double salario_hora) {
        this.salario_hora = (salario_hora < 0)? 0: salario_hora;
    }

    public double getHoras_trabalhadas() {
        return horas_trabalhadas;
    }

    public void setHoras_trabalhadas(double horas_trabalhadas) {
        this.horas_trabalhadas = (horas_trabalhadas > 0 && horas_trabalhadas <= 168) ? horas_trabalhadas : 0;
    }
    
    @Override
    public double calcula_salario() {
        setSalario_hora(salario_hora);
        setHoras_trabalhadas(horas_trabalhadas);
        double salario_final;
        if (horas_trabalhadas <=40){
            salario_final=salario_hora*horas_trabalhadas;
        }
        else{
            salario_final=( 40 * getSalario_hora()) + (getHoras_trabalhadas() - 40) * (getSalario_hora()* 1.5);
        }
        return salario_final;
    }
    @Override
    public String toString(){
        return String.format("%sNumero de horas: %.2f\nValor Hora: %.2f\n",super.toString(), horas_trabalhadas, salario_hora);
    }
}