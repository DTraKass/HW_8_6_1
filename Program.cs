 using System.IO;

 class Program
    {
        static string path = @"C:\Users\demon\Desktop\TemporaryFolder";

        public static void Main(string[] args)
        {
            Directory.CreateDirectory(path);
            string[] files = Directory.GetFiles(path);

            for(int i = 0; i < files.Length; i++)
            {
                if (File.GetLastWriteTime(path).Second < TimeSpan.FromSeconds(2).Seconds)
                {
                    File.Delete(path + files[i]);
                    Console.WriteLine($"Файл: {files[i]} удален");
                }
            }
        }
    }