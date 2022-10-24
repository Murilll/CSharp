/*using System;

public abstract class Player
{
    public int Moeda { get; set; }
    public abstract bool Decide();
    public abstract void Recebe(int resultado);
}

public class Iludido : Player
{
    public override bool Decide()
    {
        return true;
    }
    public override void Recebe(int resultado)
    {
        
    }
}

public class Medroso : Player
{
    public override bool Decide()
    {
        if (Moeda == 1)
        return false;
        else
        return true;
    }
    public override void Recebe(int resultado)
    {

    }
}

public class Rancoroso : Player
{
    public bool Jogar;
    public override bool Decide()
    {
        if (Jogar == true)
        return true;
        else
        return false;
    }
    public override void Recebe(int resultado)
    {
        if (resultado == 0)
        Jogar = false;
    }
}

public class Traidor : Player
{
    public override bool Decide()
    {
        return false;
    }
    public override void Recebe(int resultado)
    {
        
    }
}

public class Pensante : Player
{
    public bool Jogar;
    public override bool Decide()
    {
        if (Jogar == true)
        return true;
        else
        return false;
    }
    public override void Recebe(int resultado)
    {
        if (resultado == 1)
        Jogar = false;
    }
}

public class World
{
    public Player[] Jogadores (get;set;) = new Player [1000];
    {
    for (int i = 0; i < 10; i++)
    if (p1.Decide == true && p2.Decide == true)
    p1.moeda += 1;
    p2.moeda += 1;

    else if (p1.Decide == true && p2.Decide == false)
    p1.moeda = p1.moeda + 4;
    p2.moeda = p2.moeda - 4;

    else if (p1.Decide == false && p2.Decide == true)
    p2.moeda = p2.moeda - 4;
    p1.moeda = p1.moeda + 4;

    else
    p1.moeda += 0;
    p2.moeda += 0;
    }

}*/