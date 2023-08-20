   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept.Abstract
{
    abstract public class Shape
    {
        
        public abstract string Draw(string name);
        public abstract void Area();
        
    }
        
    public class Rectangle : Shape
    {
    private int l;
    private int b;
    private double AreaofRectangle;
    public Rectangle(int l,int b)
    {
        this.l = l;
        this.b = b;
    }
    public override string Draw(string name)
    {
        return name;
    }
    public override void Area()
    {
        AreaofRectangle = l * b;
    }
    public string Print()
    {
        return $"Area of Rectnagle is={AreaofRectangle}";
    }
}
}
