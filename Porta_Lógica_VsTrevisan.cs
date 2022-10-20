/*using System;

Entrada a = new Entrada();
Entrada b = new Entrada();
Entrada c = new Entrada();

EPorta e = new EPorta();
EPorta e2 = new EPorta();

a.Connect(e);
b.Connect(e);
e.Connect(e2);
c.Connect(e2);

Console.WriteLine(e2.Saida);

a.isOn = true;

Console.WriteLine(e2.Saida);

b.isOn = true;

Console.WriteLine(e2.Saida);

c.isOn = true;

Console.WriteLine(e2.Saida);


public abstract class Component
{
    public abstract bool Saida { get; }
    public abstract void Update();

    protected Component Next {get; private set;}

    public void Connect (Component component)
    {
        this.Next = component;
        this.Next.ConnectInput(this);
    }

    public virtual void ConnectInput(Component component) { }
}


public class Entrada : Component
{
    private bool ison = false;
    public bool isOn
    {
        get
        {
            return ison;
        }

        set
        {
            this.ison = value;
            Update();
        }
    }

    public override bool Saida
    {
        get
        {
            return ison;
        }
    }

    public override void Update()
    {
        this.Next.Update();
    }
}

public class EPorta : Component
{
    private Component inputA = null;
    private Component inputB = null;
    private bool value = false;

    public override bool Saida
    {
        get
        {
            return value;
        }
    }

    public override void Update()
    {
        Console.WriteLine("E uptade");
        bool newValue = (inputA?.Saida ?? false) && (inputB?.Saida ?? false);
        if (newValue == value)
            return;
        
        value = newValue;
        this.Next?.Update();
    }

    public override void ConnectInput(Component component)
    {
        if (inputA == null)
            inputA = component;
        else if (inputB == null)
            inputB = component;
    }
}*/