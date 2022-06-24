using GeometryLibrary.Enums;
using GeometryLibrary.Exceptions;
using GeometryLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Figures
{
    public class Triangle : IGeometryFigure
    {
        private const int necessaryParams = 3;

        public Triangle() { }

        public Triangle(List<double> figureParams)
        {
            Params = figureParams;
        }
        
        private void Validate()
        {
            if (Params == null)
            {
                throw new FigureException("Не указаны стороны фигуры");
            }
            if (Params.Count != Triangle.necessaryParams)
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
                double p = (Params[0] + Params[1] + Params[2]) / 2;
                return Math.Sqrt(p * (p - Params[0]) * (p - Params[1]) * (p - Params[2]));
            } 
        }

        public bool IsRightTriangle
        {
            get
            {
                this.Validate();
                return Math.Pow(Params[0], 2) == Math.Pow(Params[1], 2) + Math.Pow(Params[2], 2) ||
                    Math.Pow(Params[1], 2) == Math.Pow(Params[0], 2) + Math.Pow(Params[2], 2) ||
                    Math.Pow(Params[2], 2) == Math.Pow(Params[1], 2) + Math.Pow(Params[0], 2);
            }
        }
    }
}
