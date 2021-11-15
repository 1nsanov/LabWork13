namespace LabWork13
{
    public class LandPlot
    {
        protected int Length { get; set; }
        protected int Width { get; set; }

        public LandPlot(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public virtual double Square()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return $"Длина: {Length}м | Ширина: {Width}м | Площадь: {Square()} м^2";
        }
    }
}
