namespace BasicOOPSRevise.Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;


        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public override double CalculateArea()
        {
            return width * height;
        }
    }
}
