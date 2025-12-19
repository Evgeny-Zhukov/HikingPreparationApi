using System.Collections.Generic;
using System.Text;

public class ConsoleApp
{
    public static void Main()
    {
        Encoder.Decode("123");
    }
}

public class Encoder
{
    public static string Encode(string p_what)
    {

        return p_what;
    }
    public static string Decode(string p_what)
    {
        Console.WriteLine(Encoder.Encode("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
        Console.WriteLine(Encoder.Encode("bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb"));
        Console.WriteLine(Encoder.Encode("!@#$%^&*()_+-"));

        StringBuilder a = new StringBuilder();
        StringBuilder b = new StringBuilder();
        StringBuilder c = new StringBuilder();
        foreach (char w in "abcdefghijklmnopqrstuvwxyz")
        {
            a.Append(Encoder.Encode("" + w)[0]);
            b.Append(Encoder.Encode("_" + w)[1]);
            c.Append(Encoder.Encode("__" + w)[2]);
        }

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        return p_what;
    }
    /*
     General Patron is faced with a problem , his intelligence has intercepted some secret messages from the enemy but they are all encrypted. 
     Those messages are crucial to getting the jump on the enemy and winning the war. Luckily intelligence also captured an encoding device as well. 
     However even the smartest programmers weren't able to crack it though. So the general is asking you , his most odd but brilliant programmer.

        You can call the encoder like this.
        
        Console.WriteLine(Encoder.Encode("Hello World!"));
        
        Our cryptoanalysts kept poking at it and found some interesting patterns.
        
        Console.WriteLine(Encoder.Encode ("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"));
        Console.WriteLine(Encoder.Encode ("bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb"));
        Console.WriteLine(Encoder.Encode ("!@#$%^&*()_+-"));
        
        StringBuilder a = new StringBuilder();
        StringBuilder b = new StringBuilder();
        StringBuilder c = new StringBuilder();
        foreach (char w in "abcdefghijklmnopqrstuvwxyz") {
            a.Append(Encoder.Encode (  "" + w)[0]);
            b.Append(Encoder.Encode ( "_" + w)[1]);
            c.Append(Encoder.Encode ("__" + w)[2]);
        }
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        
        We think if you keep on this trail you should be able to crack the code! You are expected to fill in the
        
        public static string Decode(string p_what)
        
        function. Good luck ! General Patron is counting on you!

     */
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
    public static string BooleanToString(bool b)
    {
        return b.ToString();
    }
    public static string Order(string words)
    {
        if (words.Length == 0) return words;

        var splitWords = words.Split(' ');
        string[] newWords = new string[splitWords.Length];
        for (int i = 0; i < splitWords.Length; i++)
        {
            string word = splitWords[i];
            foreach (var item in word)
            {
                if (char.IsDigit(item))
                {
                    int number = int.Parse(item.ToString());
                    newWords[number - 1] = word;

                    break;
                }
            }
        }
            
        return string.Join(" ", newWords);
    }
    public static string[] dirReduc(String[] arr)
    {
        Stack<String> stack = new Stack<String>();
        if (stack.Count < 0)
        {
            stack.Push(arr[0]);
        }
        for (int i = 1; i < arr.Length; i++)
        {

        }

        return arr;
    }

    public static bool IsTriangle(int a, int b, int c)
    {
        if((a < 0) && (b < 0) && (c < 0))
            return false;
        if((a + b > c) && (a + c > b) && (b + c > a))
            return true;
        return false;
    }
    public static double Doubles(int maxk, int maxn)
    {
        double u = 0;
        for (int k = 1; k <= maxk; k++)
        {
            for (int n = 1; n <= maxn; n++)
            {
                u += 1 / (k * Math.Pow((n + 1), 2*k));
            }
        }
        return u;
    }
    public static string Extract(int[] args)
    {
        List<string> values = new List<string>();

        int i = 0;
        while (i < args.Length)
        {
            int start = i;

            while (i < (args.Length - 1) && args[i + 1] - args[i] == 1)
            {
                i++;
            }

            int lenght = i - start + 1;
            if (lenght == 1)
            {
                values.Add(args[start].ToString());
            }
            else if (lenght == 2)
            {
                values.Add(args[start].ToString());
                values.Add(args[start + 1].ToString());
            }
            else
            {
                values.Add($"{args[start]}-{args[i]}");
            }
                i++;
        }
          
        return string.Join(",", values);  //TODO
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
