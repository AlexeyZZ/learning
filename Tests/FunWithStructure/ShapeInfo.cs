using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructure
{
    class ShapeInfo
    {
        public string InfoString;
        public ShapeInfo (string info){ InfoString = info; }
    }
    struct Rectangle
    {
        //felds
        public int rectTop,rectBottom,rectLeft,rectRight;
        public ShapeInfo rectInfo;
        //ctor
        public Rectangle(string Info,int left,int right,int top,int bottom)
        {
            rectBottom = bottom;
            rectLeft = left;
            rectRight = right;
            rectTop = top;
            //ref type variable uses as field in structure
            rectInfo = new ShapeInfo(Info);
        }
        public void Display()
        {
            Console.WriteLine("Rectangle coodrinates: {0},{1},{2},{3},{4}",rectTop,rectBottom,rectLeft,rectRight,rectInfo.InfoString);
        }
    }
}
