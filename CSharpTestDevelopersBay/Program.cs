using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTestDevelopersBay
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //    }
    //}

    using System;

    public enum Side { None, Left, Right }

    public class Link
    {
        public Link Left { get; private set; }
        public Link Right { get; private set; }

        public void Append(Link rightPart)
        {
            if (this.Right != null)
                throw new InvalidOperationException("Link is already connected.");

            this.Right = rightPart;
            rightPart.Left = this;
        }
    }

    public class Chain
    {
        public static Side WhichSideIsLonger(Link link)
        {
            if(link.Left == null && link.Right == null)
            {
                return Side.None;
            }

            if (NumberAtRight(link) > NumberAtLeft(link))
            {
                return Side.Right;
            }

            return Side.Left;
        }

        public static int NumberAtRight(Link link)
        {
            if (link == null || link.Right == null)
            {
                return 0;
            }

            return 1 + NumberAtRight(link.Right);
        }

        public static int NumberAtLeft(Link link)
        {
            if (link == null || link.Left == null)
            {
                return 0;
            }

            return 1 + NumberAtLeft(link.Left);
        }

        //public static void Main(string[] args)
        //{
        //    Link left = new Link();
        //    Link middle = new Link();
        //    Link right = new Link();
        //    left.Append(middle);
        //    middle.Append(right);
        //    Console.WriteLine(Chain.WhichSideIsLonger(left));
        //}
    }
}
