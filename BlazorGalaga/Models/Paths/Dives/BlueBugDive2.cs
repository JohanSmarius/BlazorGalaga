﻿using System;
using System.Collections.Generic;
using System.Drawing;
using BlazorGalaga.Interfaces;
using BlazorGalaga.Models;
using BlazorGalaga.Static;

namespace BlazorGalaga.Models.Paths
{
    public class BlueBugDive2 : IDive
    {
        public List<BezierCurve> GetPaths(IAnimatable animatable, Ship ship)
        {
            List<BezierCurve> paths = new List<BezierCurve>();

            var cx = Constants.CanvasSize.Width / 2;

            var rotatecounterclockwise = new BezierCurve()
            {
                StartPoint = animatable.Location,
                EndPoint = new PointF(animatable.Location.X - 100, animatable.Location.Y),
                ControlPoint1 = new PointF(animatable.Location.X, animatable.Location.Y - 100),
                ControlPoint2 = new PointF(animatable.Location.X - 100, animatable.Location.Y - 100)
            };
            var dive = new BezierCurve()
            {
                StartPoint = new PointF(animatable.Location.X - 101, animatable.Location.Y+1),
                EndPoint = new PointF(cx, Constants.CanvasSize.Height - 50),
                ControlPoint1 = new PointF(animatable.Location.X - 100, Constants.CanvasSize.Height / 2),
                ControlPoint2 = new PointF(Constants.CanvasSize.Width, Constants.CanvasSize.Height / 2),
            };
            var swoopclockwise = new BezierCurve()
            {
                StartPoint = new PointF(cx-1, Constants.CanvasSize.Height - 49),
                EndPoint = new PointF(cx - 250, Constants.CanvasSize.Height - 200),
                ControlPoint1 = new PointF(cx - 50, Constants.CanvasSize.Height + 25),
                ControlPoint2 = new PointF(cx - 250, Constants.CanvasSize.Height - 20)
            };
            var gohome = new BezierCurve()
            {
                StartPoint = new PointF(cx - 249, Constants.CanvasSize.Height - 199),
                EndPoint = new PointF(cx - 150, 375),
                ControlPoint1 = new PointF(cx - 250, Constants.CanvasSize.Height - 300),
                ControlPoint2 = new PointF(0, Constants.CanvasSize.Height / 2)
            };

            paths.Add(rotatecounterclockwise);
            paths.Add(dive);
            paths.Add(swoopclockwise);
            paths.Add(gohome);

            return paths;
        }
    }
}
