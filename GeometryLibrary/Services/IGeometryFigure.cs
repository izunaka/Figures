using GeometryLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Services
{
    /// <summary>
    /// Интерфейс, который реализуют все геометрические фигуры в проекте.
    /// Для создания новой фигуры необходимо добавить её тип в перечисление FigureTypes,
    /// создать класс, реализующий этот интерфейс и добавить новый "case" для этой фигуры
    /// в FigureContext.
    /// </summary>
    public interface IGeometryFigure
    {
        /// <summary>
        /// Получение площади фигуры.
        /// Может выбрасывать FigureException.
        /// </summary>
        double Square { get; }
        /// <summary>
        /// Полученить или задать стороны фигуры.
        /// </summary>
        List<double> Params { get; set; }
    }
}
