using Core.Entities;
using System.Reflection.Metadata.Ecma335;

public class ConsoleApp
{
    public static void Main()
    {
        Kata.validate("fwe");
    }
}

public class Kata
{
    public static int[] MoveZeroes(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int j = i + 1;
            if (arr[i] == 0)
            {
                for (; j < arr.Length; j++)
                {
                    if (arr[j] != 0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        break;
                    }
                }
            }
        }
        
        return arr;

    }
    public static List<int> TreeByLevels(Node node)
    {
        List<int> list = new List<int>();
        if (node != null)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var res = queue.Dequeue();
                list.Add(res.Value);
                if (res.Left != null)
                {
                    queue.Enqueue(res.Left);
                }
                if (res.Right != null)
                {
                    queue.Enqueue(res.Right);
                }
            }
        }
        
        return list;
    }
    public static string boolToWord(bool word)
    {
        return word ? "Yes" : "No";
    }
    public static int find_it(int[] seq)
    {
        int single = 0;
        foreach(int i in seq)
        {
            single ^=i;
        }
        return single;
    }
    public static bool validate(string domain)
    {
        if (domain.Length > 253) return false;

        string[] levels = domain.Split(".");
        int levelCount = levels.Length;
        if (levelCount > 127 || levelCount < 2) return false;

            
        return false;
    }

}

public class Node
{
    public Node Left;
    public Node Right;
    public int Value;

    public Node(Node l, Node r, int v)
    {
        Left = l;
        Right = r;
        Value = v;
    }
}
