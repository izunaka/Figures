using GeometryLibrary.Enums;
using GeometryLibrary.Exceptions;
using GeometryLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Services
{
    public static class FigureContext
    {
        /// <summary>
        /// Получить геметрическую фигуру по её типу.
        /// Может выбрасывать FigureException.
        /// </summary>
        /// <param name="type">Тип фигуры</param>
        /// <param name="figureParams">Стороны фигуры</param>
        /// <returns>Необходимая фигура</returns>
        public static IGeometryFigure CreateFigure(FigureTypes type, List<double> figureParams)
        {
            switch (type)
            {
                case FigureTypes.Circle:
                    return new Circle() { Params = figureParams };
                case FigureTypes.Triangle:
                    return new Triangle() { Params = figureParams };
                default:
                    throw new FigureException("Для данной фигуры ещё нет реализации");
            }
        }
    }
}
