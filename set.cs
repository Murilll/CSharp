using System;
/*public class Set
{
    protected virtual string toString()
    {
        return "{}";
    }
}

public class NaturalSet : set
{
    protected override string toString()
    {
        return "N";
    }
}*/

/*public abstract class Set
{
    public abstract bool IsIn(Set set);
    public abstract Set Union(Set set);
    {
        UnionSet unionSet = new UnionSet();
        unionSet.A = this;
        unionSet.B = set;
        return = 
    }
}

public class EmptySet : Set
{
    public override bool IsIn(Set set)
    {
        return false;
    }
    public override bool Equals(object obj)
    {
        return obj is EmptySet;
    }

    public override Set Union(Set set)
    {
        return set;
    }

}

public class PairSet : Set
{
    public Set A { get; set; }
    public Set B { get; set; }

    public override bool IsIn(Set set)
    {
        return A.Equals(set) || B.Equals(set);
    }

    public override bool Equals(object obj)
    {
        if (obj is PairSet pair)
        {
            return ((pair.A.Equals(this.A) && pair.B.Equals(this.B)) 
                || (pair.A.Equals(this.B) && pair.B.Equals(this.A))
                || (pair.A.Equals(this.B) && pair.B.Equals(this.A) || pair.A.Equals(this.B)));
            
        }
        return false;
    }
}*/
/*public class NaturalSet : Set
{
    public override bool IsIn(Set set)
    {
        if (set is EmptySet)
        {
            return true;
        }
        return false;
    }
}*/

/*EmptySet empty = new EmptySet();
EmptySet empty2 = new EmptySet();
EmptySet empty3 = new EmptySet();

PairSet pair = new PairSet();
pair.A = empty;
pair.B = empty2;

Console.WriteLine(pair.IsIn(empty3));*/
