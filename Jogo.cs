/*using System;

Edjalma edjalmafeliz = new Edjalma();
Edjalma edjalmaagressivo = new Edjalma();
Sword sword = new Sword();
edjalmaagressivo.Weapon = sword;
edjalmaagressivo.Attack(edjalmafeliz);

Console.WriteLine(edjalmafeliz.Life);
public abstract class Entity
{
    public string Name { get; protected set; }
    public int Life { get; protected set; }
    public int Damage { get; protected set; }
    public Weapon Weapon { get; set; }


    public abstract void Attack (Entity target);
    public abstract void ReciveDamage(int damage);
}

public abstract class Weapon
{
    public string Name { get; protected set; }
    public int Damage { get; protected set; }
}
public class Edjalma : Entity
{
    public int Shield { get; private set; }
    public Edjalma()
    {
        this.Name = "Edjalma";
        this.Life = 200;
        this.Damage = 10;
        this.Shield = 20;
    }
    public override void Attack(Entity target) // Override: Ele é abstrato, apartir do momento que você da um override, ele deixa de ser abstrato
    {
        int damage = this.Damage / 2
            + this.Weapon.Damage * 2;
        target.ReciveDamage(damage);
    }
    public override void ReciveDamage(int damage)
    {
        if (this.Shield > 0)
        {
            if (this.Shield > damage)
            {
                this.Shield = 0;
                return;
            }
            else
            {
                damage -= this.Shield;
                this.Shield = 0;
            }
        }
        if (damage < 5)
            return;
        this.Life -= damage;
    }
    
}

public class Sword : Weapon
{
    public Sword()
    {
        this.Name = "Espada";
        this.Damage = 5;
    }
}
public class Travis : Entity
{
    public Travis()
    {
        this.Name = "Travis";
        this.Life = 80;
        this.Damage = 20;
    }
    public override void Attack(Entity target) // Override: Ele é abstrato, apartir do momento que você da um override, ele deixa de ser abstrato
    {
        int damage = 2 * (Weapon?.Damage ?? 0)
            + 2 * this.Damage;
        target.ReciveDamage(damage);
    }
    public override void ReciveDamage(int damage)
    {
        this.Life -= 2 * damage;
    }
}*/