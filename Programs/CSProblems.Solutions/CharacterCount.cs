using System.Text;

namespace CSProblems.Solutions
{
    public static class CharacterCount
    {
        public static void Run()
        {
            var input = System.Console.ReadLine();

            var result = new StringBuilder();
            var array = input.ToArray();
            Array.Sort(array);
            var current = array[0];
            var count = 1;
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] == current)
                {
                    count++;
                }
                else
                {
                    result.Append(current);
                    result.Append(count);
                    current = array[i];
                    count = 1;
                }
            }
            result.Append(current);
            result.Append(count);
            Console.WriteLine(result);
        }
    }
}