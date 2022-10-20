using System;

SomaComplex = new SomaComplex();

public class SomaComplex
{
    public int Number {get;set;}
    public int I {get;set;}
    public int Number2 {get;set;}
    public int I2 {get;set;}
    public int result {get;set;}
}

public class Soma : SomaComplex
{
    public Soma(){
    this.result = this.Number + this.Number2;
    Console.WriteLine(" ${this.Number} + ${this.Number2} + ${this.Number2} + = ")
}
}
