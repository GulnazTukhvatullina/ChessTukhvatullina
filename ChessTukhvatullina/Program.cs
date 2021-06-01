using System;

namespace ChessCore
{
    class Program
    {
        static void Main()
        {
            Rook r = new Rook(1, 1, "W");
            Console.WriteLine(r.Move(2, 1));

            Queen q = new Queen(1, 1, "W");
            Console.WriteLine(q.Move(2, 7));

            King k = new King(1, 1, "W");
            Console.WriteLine(k.Move(5, 2));

            Knight kn = new Knight(1, 1, "W");
            Console.WriteLine(kn.Move(3, 2));

            Bishop b = new Bishop(1, 1, "W");
            Console.WriteLine(b.Move(5, 7));
        }
    }

    class Figure
    {
        protected int x;
        protected int y;
        protected string color;

        public Figure(int posX, int posY, string col)
        {
            x = posX;
            y = posY;
            color = col;
        }

        public virtual bool Move(int x1, int y1)
        {
            return false;
        }
    }

    class King : Figure
    {
        public King(int posX, int posY, string col) : base(posX, posY, col)
        {

        }

        public override bool Move(int posX, int posY)
        {
            if ((Math.Abs(x - posX) <= 1) && (Math.Abs(y - posY) <= 1))
            {
                this.x = posX;
                this.y = posY;
                return true;
            }
            return false;
        }
    }

    class Queen : Figure
    {
        public Queen(int posX, int posY, string col) : base(posX, posY, col)
        {

        }

        public override bool Move(int posX, int posY)
        {
            if ((Math.Abs(x - posX) == Math.Abs(y - posY)) ||
                ((x == posX) || (y == posY)))
            {
                this.x = posX;
                this.y = posY;
                return true;
            }
            return false;
        }
    }

    class Rook : Figure
    {
        public Rook(int posX, int posY, string col) : base(posX, posY, col)
        {

        }

        public override bool Move(int posX, int posY)
        {
            if ((x == posX) || (y == posY))
            {
                this.x = posX;
                this.y = posY;
                return true;
            }
            return false;
        }
    }

    class Bishop : Figure
    {
        public Bishop(int posX, int posY, string col) : base(posX, posY, col)
        {

        }

        public override bool Move(int posX, int posY)
        {
            if (Math.Abs(x - posX) == Math.Abs(y - posY))
            {
                this.x = posX;
                this.y = posY;
                return true;
            }
            return false;
        }
    }

    class Knight : Figure
    {
        public Knight(int posX, int posY, string col) : base(posX, posY, col)
        {

        }

        public override bool Move(int posX, int posY)
        {
            if ((Math.Max(Math.Abs(x - posX), Math.Abs(y - posY)) == 2) &&
                (Math.Min(Math.Abs(x - posX), Math.Abs(y - posY)) == 1))
            {
                this.x = posX;
                this.y = posY;
                return true;
            }
            return false;
        }
    }
}

