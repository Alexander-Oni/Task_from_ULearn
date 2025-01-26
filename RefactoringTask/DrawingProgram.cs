using System;
using Avalonia.Media;
using RefactorMe.Common;

namespace RefactorMe
{
    class Draftsman
    {
        static float X, Y;
        static IGraphics graphics;

        public static void Initialization(IGraphics newGraphics)
        {
            graphics = newGraphics;
            graphics.Clear(Colors.Black);
        }

        public static void SetPosition(float x0, float y0)
        {
            X = x0;
            Y = y0;
        }

        public static void makeIt(Pen pen, double length, double angle)
        {
            //Делает шаг длиной length в направлении angle и рисует пройденную траекторию
            var x1 = (float)(X + length * Math.Cos(angle));
            var y1 = (float)(Y + length * Math.Sin(angle));
            graphics.DrawLine(pen, X, Y, x1, y1);
            X = x1;
            Y = y1;
        }

        public static void Change(double lenght, double angle)
        {
            X = (float)(X + lenght * Math.Cos(angle)); 
            Y = (float)(Y + lenght * Math.Sin(angle));
        }
    }
    
    public class ImpossibleSquare
    {
        public static void Draw(int width, int height, double rotationAngle, IGraphics graphics)
        {
            // ugolPovorota пока не используется, но будет использоваться в будущем
            Draftsman.Initialization(graphics);

            var sz = Math.Min(width, height);

            var diagonal_length = Math.Sqrt(2) * (sz * 0.375f + sz * 0.04f) / 2;
            var x0 = (float)(diagonal_length * Math.Cos(Math.PI / 4 + Math.PI)) + width / 2f;
            var y0 = (float)(diagonal_length * Math.Sin(Math.PI / 4 + Math.PI)) + height / 2f;

            Draftsman.SetPosition(x0, y0);
            //Рисуем 1-ую сторону
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.375f, 0);
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.04f * Math.Sqrt(2), Math.PI / 4);
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.375f, Math.PI);
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.375f - sz * 0.04f, Math.PI / 2);

            Draftsman.Change(sz * 0.04f, -Math.PI);
            Draftsman.Change(sz * 0.04f * Math.Sqrt(2), 3 * Math.PI / 4);

            //Рисуем 2-ую сторону
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.375f, -Math.PI / 2);
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.04f * Math.Sqrt(2), -Math.PI / 2 + Math.PI / 4);
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.375f, -Math.PI / 2 + Math.PI);
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.375f - sz * 0.04f, -Math.PI / 2 + Math.PI / 2);

            Draftsman.Change(sz * 0.04f, -Math.PI / 2 - Math.PI);
            Draftsman.Change(sz * 0.04f * Math.Sqrt(2), -Math.PI / 2 + 3 * Math.PI / 4);

            //Рисуем 3-ю сторону
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.375f, Math.PI);
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.04f * Math.Sqrt(2), Math.PI + Math.PI / 4);
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.375f, Math.PI + Math.PI);
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.375f - sz * 0.04f, Math.PI + Math.PI / 2);

            Draftsman.Change(sz * 0.04f, Math.PI - Math.PI);
            Draftsman.Change(sz * 0.04f * Math.Sqrt(2), Math.PI + 3 * Math.PI / 4);

            //Рисуем 4-ую сторону
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.375f, Math.PI / 2);
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.04f * Math.Sqrt(2), Math.PI / 2 + Math.PI / 4);
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.375f, Math.PI / 2 + Math.PI);
            Draftsman.makeIt(new Pen(Brushes.Yellow), sz * 0.375f - sz * 0.04f, Math.PI / 2 + Math.PI / 2);

            Draftsman.Change(sz * 0.04f, Math.PI / 2 - Math.PI);
            Draftsman.Change(sz * 0.04f * Math.Sqrt(2), Math.PI / 2 + 3 * Math.PI / 4);
        }
    }
}