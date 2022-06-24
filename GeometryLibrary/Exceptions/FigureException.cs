using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Exceptions
{
    public class FigureException : Exception
    {
        public FigureException() { }

        public FigureException(string message) : base(message) { }

        public FigureException(string message, Exception inner) : base(message, inner) { }
    }
}
