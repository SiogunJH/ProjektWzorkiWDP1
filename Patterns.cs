namespace System
{
    class Patterns
    {
        public static void Prostokat(int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            for (int j = 1; j < m - 1; j++)
            {
                Star();
                for (int i = 1; i < n - 1; i++)
                    Space();

                StarLn();
            }

            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();
        }
        public static void LiteraX(int n)
        {
            if (n < 3) throw new ArgumentException("Zbyt mały rozmiar");
            for (int i = 0; i < n; i++)
            {
                for (int ii = 0; ii < n; ii++)
                {
                    if (i == ii) Star();
                    else if (n - i - 1 == ii) Star();
                    else Space();
                }
                NewLine();
            }
        }
        public static void LustrzanaLiteraZ(int n)
        {
            for (int i = 0; i < n; i++) Star();
            NewLine();
            for (int i = 1; i < n - 1; i++)
            {
                for (int ii = 0; ii < n; ii++)
                {
                    if (i == ii) Star();
                    else Space();
                }
                NewLine();
            }
            for (int i = 0; i < n; i++) Star();
        }
        public static void LiteraZ(int n)
        {
            for (int i = 0; i < n; i++) Star();
            NewLine();
            for (int i = 1; i < n - 1; i++)
            {
                for (int ii = 0; ii < n; ii++)
                {
                    if (n - i - 1 == ii) Star();
                    else Space();
                }
                NewLine();
            }
            for (int i = 0; i < n; i++) Star();
        }

        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();
    }
}