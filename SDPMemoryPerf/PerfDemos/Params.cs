using System.Text;

namespace PerfDemos
{
    class Params
    {
        private StringBuilder _logger = new StringBuilder();

        public void Log(string message, params object[] args)
        {
            _logger.AppendFormat(message, args);
        }

        public Params()
        {
            Log("Hello", System.Array.Empty<object>());
        }
    }
}
