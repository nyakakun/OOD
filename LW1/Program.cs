namespace LW1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static List<IShape> ReadShapes(string path)
        {
            StreamReader input = new(path);
            List<IShape> result = new();
            string? line = null;

            while ((line = input.ReadLine()) != null)
            {

            }

            input.Close();
            return result;
        }
    }
}