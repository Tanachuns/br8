namespace CalculationService;

public class Tree
{

    public string BuildTree(int height)
    {
        string tree = $@"";
        string trunk = "  *\n";
        string baseTree = " ***";

        for (int i = 1; i < height; i++)
        {
            for (int j = 0; j < height - i; j++)
            {
                tree += " ";
            }
            for (int k = 0; k < i + (i - 1); k++)
            {
                tree += "*";
            }
            tree += "\n";
            if (i < height - 2)
            {
                trunk = " " + trunk;
                baseTree = " " + baseTree;
            }
        }
        tree = tree + trunk + baseTree;
        return tree;
    }
    public void Print(int height)
    {
        string tree = this.BuildTree(height);
        Console.WriteLine(tree);
    }
}