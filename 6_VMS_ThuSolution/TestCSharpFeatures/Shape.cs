using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharpFeatures
{
   public  abstract class Shape
    {
        public abstract void Draw();

    }


    public class Line : Shape
    {

        public override void Draw()
        {
          //logic for drawing line
        }
    }


    public class Recntangle : Shape
    {

        public override void Draw()
        {
            //logic for drawing Rectangle
        }

    }
}
