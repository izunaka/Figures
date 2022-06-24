using GeometryLibrary.Exceptions;
using GeometryLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Figures
{
    public class Circle : IGeometryFigure
    {
        private const int necessaryParams = 1;

        public Circle() { }

        public Circle(List<double> figureParams)
        {
            Params = figureParams;
        }

        private void Validate()
        {
            if (Params == null)
            {
                throw new FigureException("Не указаны стороны фигуры");
            }
            if (Params.Count != Circle.necessaryParams)
            {
                throw new FigureException("Указано неверное количество сторон");
            }
        }

        public List<double> Params { get; set; }

        public double Square
        {
            get
            {
                this.Validate();
                return Math.PI * Math.Pow(Params[0], 2);
            }
        }
    }
}
