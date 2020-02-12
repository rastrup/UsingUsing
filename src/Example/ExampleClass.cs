using System.IO;
using System.Threading.Tasks;

namespace Example
{
    public class ExampleClass
    {
        public void DoStuff()
        {
            using (var stream = File.OpenWrite("filename"))
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.Write("content");
                }
            }
        }

        public void DoStuffNew()
        {
            using var stream = File.OpenWrite("filename");
            using var writer = new StreamWriter(stream);
            writer.Write("content");
        }

        public async Task DoStuffAsync()
        {
            await using (var stream = File.OpenWrite("filename"))
            {
                await using (var writer = new StreamWriter(stream))
                {
                    await writer.WriteAsync("content");
                }
            }
        }

        public async Task DoStuffNewAsync()
        {
            await using var stream = File.OpenWrite("filename");
            await using var writer = new StreamWriter(stream);
            await writer.WriteAsync("content");
        }
    }
}
