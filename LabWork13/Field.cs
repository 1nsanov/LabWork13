namespace LabWork13
{
    public class Field: LandPlot
    {
        private string NameCrop { get; set; }
        private int ProductivityField { get; set; }

        public Field(string nameCrop, int productivityField, int length, int width) : base(length, width)
        {
            NameCrop = nameCrop;
            ProductivityField = productivityField;
        }

        public override double Square()
        {
            return Length * Width / ProductivityField;
        }

        public override string ToString()
        {
            return $"Длина: {Length}м | Ширина: {Width}м | Культура: {NameCrop} | Урожайность: {Square()} ц.";
        }
    }
}
