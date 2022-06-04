using System;
using System.IO;

namespace Liblary
{
    public class Writer
    {
        public void WriteMessage(string message, string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) throw new PathIntCorrectException("You'r idiot", message);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(message);
            }
        }


    }

    public class PathIntCorrectException : Exception
    {
        public string MessageThatDidntWrite { get; set; }

        public PathIntCorrectException(string message, string messageThatDidnt) : base(message)
        {
            MessageThatDidntWrite = messageThatDidnt;
        }
    }
}
