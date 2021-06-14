using System;
using System.Diagnostics;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Rectangle
            // 너비나 높이가 1보다 클 때
            char[,] canvas = Canvas.Draw(10, 8, EShape.Rectangle);
            printCanvas(canvas);

            Debug.Assert(!Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesTriangle));

            //너비가 0일 때
            canvas = Canvas.Draw(0, 8, EShape.Rectangle);

            Debug.Assert(!Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesTriangle));

            //높이가 0일 때
            canvas = Canvas.Draw(10, 0, EShape.Rectangle);

            Debug.Assert(!Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesTriangle));

            //너비가 1일 때
            canvas = Canvas.Draw(1, 8, EShape.Rectangle);
            printCanvas(canvas);

            Debug.Assert(!Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesTriangle));

            //높이가 1일 때
            canvas = Canvas.Draw(10, 1, EShape.Rectangle);
            printCanvas(canvas);

            Debug.Assert(!Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesTriangle));

            //너비와 높이가 1일 때
            canvas = Canvas.Draw(1, 1, EShape.Rectangle);
            printCanvas(canvas);

            Debug.Assert(Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.IsoscelesTriangle));
            #endregion


            #region IsoscelesRightTriangle
            //너비와 높이가 같을 때
            canvas = Canvas.Draw(8, 8, EShape.IsoscelesRightTriangle);
            printCanvas(canvas);

            Debug.Assert(!Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesTriangle));

            //너비와 높이가 다를 때
            canvas = Canvas.Draw(6, 8, EShape.IsoscelesRightTriangle);

            Debug.Assert(!Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesTriangle));

            //너비와 높이가 1일 때
            canvas = Canvas.Draw(1, 1, EShape.IsoscelesRightTriangle);
            printCanvas(canvas);

            Debug.Assert(Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.IsoscelesTriangle));
            #endregion


            #region IsoscelesTriangle
            // 너비와 높이 * 2 - 1이 같을 때
            canvas = Canvas.Draw(9, 5, EShape.IsoscelesTriangle);
            printCanvas(canvas);

            Debug.Assert(!Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.IsoscelesTriangle));

            //너비와 높이 * 2 - 1이 다를 때
            canvas = Canvas.Draw(9, 10, EShape.IsoscelesTriangle);

            Debug.Assert(!Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesTriangle));

            //너비와 높이가 1일 때
            canvas = Canvas.Draw(1, 1, EShape.IsoscelesTriangle);
            printCanvas(canvas);

            Debug.Assert(Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.IsoscelesTriangle));
            #endregion


            #region Circle
            //원의 너비와 높이가 같고 홀수일 때
            canvas = Canvas.Draw(21, 21, EShape.Circle);
            printCanvas(canvas);

            Debug.Assert(Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesTriangle));

            //너비와 높이가 다를 때
            canvas = Canvas.Draw(21, 20, EShape.Circle);

            Debug.Assert(!Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesTriangle));

            //너비와 높이가 같고 짝수일 때
            canvas = Canvas.Draw(20, 20, EShape.Circle);

            Debug.Assert(!Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(!Canvas.IsShape(canvas, EShape.IsoscelesTriangle));

            //너비와 높이가 1일 때
            canvas = Canvas.Draw(1, 1, EShape.Circle);
            printCanvas(canvas);

            Debug.Assert(Canvas.IsShape(canvas, EShape.Circle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.Rectangle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.IsoscelesRightTriangle));
            Debug.Assert(Canvas.IsShape(canvas, EShape.IsoscelesTriangle));
            #endregion
    }

        // canvas를 콘솔 창에 출력해주는 도우미 함수
        private static void printCanvas(char[,] canvas)
        {
            for (int i = 0; i < canvas.GetLength(0); i++)
            {
                for (int j = 0; j < canvas.GetLength(1); j++)
                {
                    Console.Write(canvas[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}