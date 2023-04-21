namespace OOP_Lab7._1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\n Task1: ");
            string file = @"D:\OOP\file_shapes.txt";
            string text = "";

            List<Shape> firstList = new List<Shape>();
            Console.WriteLine("\n Enter the name, radius or side of 6 shapes: ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("\n Enter shape name: ");
                string shapeName = Console.ReadLine().ToLower();

                if (shapeName == "circle")
                {
                    Console.Write("\n Enter circle radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    firstList.Add(new Circle(shapeName, radius));
                }
                else if (shapeName == "square")
                {
                    Console.Write("\n Enter square side: ");
                    double side = double.Parse(Console.ReadLine());
                    firstList.Add(new Square(shapeName, side));
                }
                else
                {
                    Console.WriteLine("\n You can write only circles or squares!");
                    i--;
                }
            }

            IEnumerable<Shape> shapesTenOneHundred = firstList.Where(i => (i.Area() >= 10) && (i.Area() <= 100));

            using (StreamWriter writer = new StreamWriter(file, false, System.Text.Encoding.Default))
            {
                foreach (Shape shape in shapesTenOneHundred)
                {
                    writer.WriteLine(shape.Area());
                }
            }

            IEnumerable<Shape> shapesContainsA = firstList.Where(shape => shape.Name.Contains("a"));

            using (StreamWriter writer = new StreamWriter(file, false, System.Text.Encoding.Default))
            {
                foreach (Shape shape in shapesContainsA)
                {
                    writer.WriteLine(shape.Name);
                }
            }

            // Видаляємо фігури з периметром менше 5 та виводимо список на консоль 
            firstList.RemoveAll(shape => shape.Perimeter() < 5);
            Console.WriteLine("\n List of shapes without ones, \n which perimeter is 5: \n");
            foreach (Shape shape in firstList)
            {
                Console.WriteLine($"Shape: {shape.Name}: Perimeter - {shape.Perimeter()}");
            }
        }
    }
}
