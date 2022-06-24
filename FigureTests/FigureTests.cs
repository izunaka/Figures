using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryLibrary.Services;
using GeometryLibrary.Enums;
using GeometryLibrary.Exceptions;
using System;
using System.Collections.Generic;
using GeometryLibrary.Figures;

namespace FigureTests
{
    [TestClass]
    public class FigureTests
    {
        [TestMethod]
        public void Test1()
        {
            IGeometryFigure figure = FigureContext.CreateFigure(FigureTypes.Circle, null);
            Action action = () => { double a = figure.Square; };
            Assert.ThrowsException<FigureException>(action);
        }

        [TestMethod]
        public void Test2()
        {
            IGeometryFigure figure = FigureContext.CreateFigure(FigureTypes.Circle, new List<double>());
            Action action = () => { double a = figure.Square; };
            Assert.ThrowsException<FigureException>(action);
        }

        [TestMethod]
        public void Test3()
        {
            IGeometryFigure figure = FigureContext.CreateFigure(FigureTypes.Circle, new List<double> { 5, 2 });
            Action action = () => { double a = figure.Square; };
            Assert.ThrowsException<FigureException>(action);
        }

        [TestMethod]
        public void Test4()
        {
            IGeometryFigure figure = FigureContext.CreateFigure(FigureTypes.Triangle, new List<double>() { 3, 4 });
            Action action = () => { double a = figure.Square; };
            Assert.ThrowsException<FigureException>(action);
        }

        [TestMethod]
        public void Test5()
        {
            IGeometryFigure figure = FigureContext.CreateFigure(FigureTypes.Triangle, new List<double> { 5, 2, 4, 6 });
            Action action = () => { double a = figure.Square; };
            Assert.ThrowsException<FigureException>(action);
        }

        [TestMethod]
        public void Test6()
        {
            double r = 5;
            IGeometryFigure figure = FigureContext.CreateFigure(FigureTypes.Circle, new List<double> { r });
            double s = figure.Square;
            Assert.AreEqual(Math.PI * Math.Pow(r, 2), s);
        }

        [TestMethod]
        public void Test7()
        {
            List<double> figureParams = new List<double>() { 5, 3, 4 };
            IGeometryFigure figure = FigureContext.CreateFigure(FigureTypes.Triangle, figureParams);
            double s = figure.Square;
            bool isRight = (figure as Triangle).IsRightTriangle;
            Assert.AreEqual(s, (double)6);
            Assert.AreEqual(isRight, true);
        }

        [TestMethod]
        public void Test8()
        {
            List<double> figureParams = new List<double>() { 5, 5, 6 };
            IGeometryFigure figure = FigureContext.CreateFigure(FigureTypes.Triangle, figureParams);
            double s = figure.Square;
            bool isRight = (figure as Triangle).IsRightTriangle;
            Assert.AreEqual(s, (double)12);
            Assert.AreEqual(isRight, false);
        }
    }
}
