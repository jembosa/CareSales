namespace CareSales
{
    public class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Cars()
        {
        }
        public Cars(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }




        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Price:${Price}";
        }
    }
}
