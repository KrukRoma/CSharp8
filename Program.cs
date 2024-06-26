namespace CSharp7
{
    public abstract class GeometricFigure
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Triangle : GeometricFigure
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double GetPerimeter()
        {
            return a + b + c;
        }
    }

    public class Square : GeometricFigure
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            return side * side;
        }

        public override double GetPerimeter()
        {
            return 4 * side;
        }
    }

    public class Rhombus : GeometricFigure
    {
        private double side, diagonal1, diagonal2;

        public Rhombus(double side, double diagonal1, double diagonal2)
        {
            this.side = side;
            this.diagonal1 = diagonal1;
            this.diagonal2 = diagonal2;
        }

        public override double GetArea()
        {
            return (diagonal1 * diagonal2) / 2;
        }

        public override double GetPerimeter()
        {
            return 4 * side;
        }
    }

    public class Rectangle : GeometricFigure
    {
        private double width, height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }

        public override double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }

    public class Parallelogram : GeometricFigure
    {
        private double baseSide, height, side;

        public Parallelogram(double baseSide, double height, double side)
        {
            this.baseSide = baseSide;
            this.height = height;
            this.side = side;
        }

        public override double GetArea()
        {
            return baseSide * height;
        }

        public override double GetPerimeter()
        {
            return 2 * (baseSide + side);
        }
    }

    public class Trapezoid : GeometricFigure
    {
        private double baseSide1, baseSide2, height, side1, side2;

        public Trapezoid(double baseSide1, double baseSide2, double height, double side1, double side2)
        {
            this.baseSide1 = baseSide1;
            this.baseSide2 = baseSide2;
            this.height = height;
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double GetArea()
        {
            return (baseSide1 + baseSide2) * height / 2;
        }

        public override double GetPerimeter()
        {
            return baseSide1 + baseSide2 + side1 + side2;
        }
    }

    public class Circle : GeometricFigure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Ellipse : GeometricFigure
    {
        private double semiAxis1, semiAxis2;

        public Ellipse(double semiAxis1, double semiAxis2)
        {
            this.semiAxis1 = semiAxis1;
            this.semiAxis2 = semiAxis2;
        }

        public override double GetArea()
        {
            return Math.PI * semiAxis1 * semiAxis2;
        }

        public override double GetPerimeter()
        {
            double h = (semiAxis1 - semiAxis2) / (semiAxis1 + semiAxis2);
            double p = Math.PI * (semiAxis1 + semiAxis2);
            return p * (1 + h * h / 4 + h * h * h * h / 64);
        }
    }

    public class CompositeFigure : GeometricFigure
    {
        private List<GeometricFigure> figures = new List<GeometricFigure>();

        public void AddFigure(GeometricFigure figure)
        {
            figures.Add(figure);
        }

        public void RemoveFigure(GeometricFigure figure)
        {
            figures.Remove(figure);
        }

        public override double GetArea()
        {
            double area = 0;
            foreach (var figure in figures)
            {
                area += figure.GetArea();
            }
            return area;
        }

        public override double GetPerimeter()
        {
            double perimeter = 0;
            foreach (var figure in figures)
            {
                perimeter += figure.GetPerimeter();
            }
            return perimeter;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine("Triangle:");
            Console.WriteLine($"Area: {triangle.GetArea():F2}");
            Console.WriteLine($"Perimeter: {triangle.GetPerimeter():F2}");

            Square square = new Square(4);
            Console.WriteLine("\nSquare:");
            Console.WriteLine($"Area: {square.GetArea():F2}");
            Console.WriteLine($"Perimeter: {square.GetPerimeter():F2}");

            Rhombus rhombus = new Rhombus(5, 6, 8);
            Console.WriteLine("\nRhombus:");
            Console.WriteLine($"Area: {rhombus.GetArea():F2}");
            Console.WriteLine($"Perimeter: {rhombus.GetPerimeter():F2}");

            Rectangle rectangle = new Rectangle(3, 4);
            Console.WriteLine("\nRectangle:");
            Console.WriteLine($"Area: {rectangle.GetArea():F2}");
            Console.WriteLine($"Perimeter: {rectangle.GetPerimeter():F2}");

            Parallelogram parallelogram = new Parallelogram(3, 4, 5);
            Console.WriteLine("\nParallelogram:");
            Console.WriteLine($"Area: {parallelogram.GetArea():F2}");
            Console.WriteLine($"Perimeter: {parallelogram.GetPerimeter():F2}");

            Trapezoid trapezoid = new Trapezoid(3, 4, 5, 6, 7);
            Console.WriteLine("\nTrapezoid:");
            Console.WriteLine($"Area: {trapezoid.GetArea():F2}");
            Console.WriteLine($"Perimeter: {trapezoid.GetPerimeter():F2}");

            Circle circle = new Circle(5);
            Console.WriteLine("\nCircle:");
            Console.WriteLine($"Area: {circle.GetArea():F2}");
            Console.WriteLine($"Perimeter: {circle.GetPerimeter():F2}");

            Ellipse ellipse = new Ellipse(3, 4);
            Console.WriteLine("\nEllipse:");
            Console.WriteLine($"Area: {ellipse.GetArea():F2}");
            Console.WriteLine($"Perimeter: {ellipse.GetPerimeter():F2}");
        }
    }
}
