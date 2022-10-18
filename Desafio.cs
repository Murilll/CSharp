using System;

/*Input a = new Input();
Input b = new Input();
Input c = new Input();
AndGate and = new AndGate();
OrGate or = new OrGate();
NoteGate not = new NoteGate();*/

Door InputA = new DoorAnd();
Door InputB = new DoorAnd();
Door InputC = new DoorAnd();




public abstract class Door
{
    public int Door1 { get; set; }
    public int Door2 { get; set; }
}
public class DoorAnd : Door
{
    public DoorAnd()
    {
        this.Door1 = 1;
        this.Door2 = 1;
        if (this.Door1 == 1 && this.Door2 == 1)
        {
            Console.WriteLine("Verdadeiro");
            return;
        }
        else
        {   
            Console.WriteLine("Desligado");
            return;
        }
    }
}

public class DoorOr : Door
{
    public DoorOr()
    {
        this.Door1 = 1;
        this.Door2 = 0;
        if (this.Door1 == 1 && this.Door2 == 0 || this.Door1 == 0 && this.Door2 == 1 || this.Door1 == 1 && this.Door2 == 1)
        {
            Console.WriteLine("Verdadeiro");
            return;
        }
        else
        {
            Console.WriteLine("Desligado");
            return;
        }
    }
}

public class DoorNot : Door
{
    public DoorNot()
    {
        this.Door1 = 0;
        this.Door2 = 0;
        if (this.Door1 == 1 && this.Door2 == 1)
        {
            Console.WriteLine("Verdadeiro");
            return;
        }
        else
        {
            Console.WriteLine("Desligado");
            return;
        }
    }
}