/*using System;

Input a = new Input();
Input b = new Input();
Input c = new Input();
AndGate and = new AndGate();
OrGate or = new OrGate();
NoteGate not = new NoteGate();

a.Connect(and);
b.Connect(and);
c.Connect(or);
and.Connect(or);
or.Connect(not);

b.IsOn = true;
c.IsOn = true;

Console.WriteLine(not.Output);
public abstract class Component
{
    public abstract bool Output { get; }
    public abstract void Update();
    protected Component Next { get; private set; }
    public void Connect (Component component)
    {
        this.Next = component;
        this.Next.ConnectInput
        (component);
    }
    public virtual void ConnectInput(Component component) { }
}
public class Input : Component 
{
    public bool ison = false; 
    public bool IsOn
    {
        get
        {
            return ison;
        }
        set
        {
            this.ison = value;
            this.Update();
        }
    }

    public override bool Output
    {
        get
        {
            return ison;
        }
    }

    public override void Update()
    {
        this.Next?.Update();
    }
}
public class AndGate : Component
{
    private Component inputA = null;
    private Component inputB = null;
    public override bool Output => throw new NotImplementedException();
    public override void Update()
    {
        throw new NotImplementedException();
    }

    public override void Update()
    {
        throw new
    }
    public override void Update()
    {
        throw new
        NotImplementedException();
    }

    protected override void ConnectInput(Component component)
    {
        if (inputA == null)
        {
            this.inputA = component;
        }
    }
}
public class HalfSum : IntegratedCircuit
{
    private Component carryOut = null;
    private Component ResultOut = null;
    public HalfSum()
    {
        XorGate xor = new XorGate();
        AndGAte and = new AndGate();

        carryOut =  and;
        ResultOut = xor;
    }
}
*/