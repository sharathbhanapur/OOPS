namespace Polymorphism
{
    public class RunTimePolyMorphism
    {
        public virtual string Print() => "parent class";
    }

    class Subclass1 : RunTimePolyMorphism
    {
        public new string Print() => "subclass1";
    }

    class Subclass2 : RunTimePolyMorphism
    {
        public new string Print() => "subclass2";
    }
  
}
