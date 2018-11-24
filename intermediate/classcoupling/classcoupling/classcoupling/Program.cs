namespace classcoupling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Coupling is a measure of how interconnected
            // classes and subsystems are.

            // classes should be loosley coupled!

            var text = new Text();
            text.Width = 100;
            text.Copy();
            text.Duplicate();
        }
    }
}
