using System;
using System.Collections.Generic;

namespace Assignment2
{
    public static class Canvas 
    {
        public static char[,] Draw(uint width, uint height, EShape shape)
        {
            char[,] result = new char[height + 4, width + 4];
            char[,] blank = new char[0, 0];

            if (width == 0 || height == 0)
            {
                result = blank;
            }

            else if (shape == EShape.Rectangle)
            {
                for (int i = 0; i < result.GetLength(0); ++i)
                {
                    for (int j = 0; j < result.GetLength(1); ++j)
                    {
                        if (i == 0 || i == result.GetLength(0) - 1)
                        {
                            result[i, j] = '-';
                        }

                        else if (j == 0 || j == result.GetLength(1) - 1)
                        {
                            result[i, j] = '|';
                        }

                        else if (i == 1 || i == result.GetLength(0) - 2)
                        {
                            result[i, j] = ' ';
                        }

                        else if (j == 1 || j == result.GetLength(1) - 2)
                        {
                            result[i, j] = ' ';
                        }

                        else
                        {
                            result[i, j] = '*';
                        }
                    }
                }
            }

            else if (shape == EShape.IsoscelesRightTriangle && width == height)
            {
                for (int i = 0; i < result.GetLength(0); ++i)
                {
                    for (int j = 0; j < result.GetLength(1); ++j)
                    {
                        if (i == 0 || i == result.GetLength(0) - 1)
                        {
                            result[i, j] = '-';
                        }

                        else if (j == 0 || j == result.GetLength(1) - 1)
                        {
                            result[i, j] = '|';
                        }

                        else if (i == 1 || i == result.GetLength(0) - 2)
                        {
                            result[i, j] = ' ';
                        }

                        else if (j == 1 || j == result.GetLength(1) - 2)
                        {
                            result[i, j] = ' ';
                        }

                        else if (j >= 2 && i >= j)
                        {
                            result[i, j] = '*';
                        }

                        else
                        {
                            result[i, j] = ' ';
                        }
                    }
                }
            }

            else if (shape == EShape.IsoscelesTriangle && width == height * 2 - 1)
            {
                int z = 1;

                for (int i = 0; i < result.GetLength(0); ++i)
                {
                    if (i >= 3)
                    {
                        ++z;
                    }

                    for (int j = 0; j < result.GetLength(1); ++j)
                    {
                        if (i == 0 || i == result.GetLength(0) - 1)
                        {
                            result[i, j] = '-';
                        }

                        else if (j == 0 || j == result.GetLength(1) - 1)
                        {
                            result[i, j] = '|';
                        }

                        else if (i == 1 || i == result.GetLength(0) - 2)
                        {
                            result[i, j] = ' ';
                        }

                        else if (j == 1 || j == result.GetLength(1) - 2)
                        {
                            result[i, j] = ' ';
                        }

                        else if (i >= 2 && (j < result.GetLength(1) / 2 + z) && (j > result.GetLength(1) / 2 - z))
                        {
                            result[i, j] = '*';
                        }

                        else
                        {
                            result[i, j] = ' ';
                        }
                    }
                }
            }

            else if (shape == EShape.Circle && width == height && width % 2 != 0)
            {
                int radius = (int)(width + 4) / 2;

                for (int i = 0; i < result.GetLength(0); ++i)
                {
                    for (int j = 0; j < result.GetLength(1); ++j)
                    {
                        if (i == 0 || i == result.GetLength(0) - 1)
                        {
                            result[i, j] = '-';
                        }

                        else if (j == 0 || j == result.GetLength(1) - 1)
                        {
                            result[i, j] = '|';
                        }

                        else if (Math.Pow(i - radius, 2) + Math.Pow(j - radius, 2) <= Math.Pow(radius - 2, 2))
                        {
                            result[i, j] = '*';
                        }

                        else
                        {
                            result[i, j] = ' ';
                        }
                    }
                }
            }

            else
            {
                result = blank;
            }


            return result;
        }

        //        public static bool IsShape(char[,] canvas, EShape shape)
        //        {

        //            bool bResult = true;

        //            char[,] rectangleArray = Draw((uint)canvas.GetLength(1) - 4, (uint)canvas.GetLength(0) - 4, EShape.Rectangle);
        //            char[,] isoscelesTriangleArray = Draw((uint)canvas.GetLength(1) - 4, (uint)canvas.GetLength(0) - 4, EShape.IsoscelesTriangle);
        //            char[,] isoscelesRightTriangleArray = Draw((uint)canvas.GetLength(1) - 4, (uint)canvas.GetLength(0) - 4, EShape.IsoscelesRightTriangle);
        //            char[,] circleArray = Draw((uint)canvas.GetLength(1) - 4, (uint)canvas.GetLength(0) - 4, EShape.Circle);
        //            //char[,] newArray = Draw((uint)canvas.GetLength(1) - 4, (uint)canvas.GetLength(0) - 4, shape);

        //            //if (canvas.GetLength(0) - 4 > 0 && canvas.GetLength(1) - 4 > 0 && newArray.GetLength(0) != 0 && newArray.GetLength(1) != 0)
        //            //{

        //            //    for (int i = 0; i < canvas.GetLength(0); ++i)
        //            //    {
        //            //        for (int j = 0; j < canvas.GetLength(1); ++j)
        //            //        {
        //            //            if (canvas[i, j] == newArray[i, j])
        //            //            {
        //            //                bResult = true;
        //            //            }

        //            //            else
        //            //            {
        //            //                bResult = false;
        //            //                break;
        //            //            }
        //            //        }
        //            //    }

        //            //}

        //            if (canvas.GetLength(0) == 0 || canvas.GetLength(1) == 0 || canvas.GetLength(0) - 4 <= 0 || canvas.GetLength(1) - 4 <= 0)
        //            {
        //                return false;
        //            }

        //            else if (canvas.GetLength(0) == rectangleArray.GetLength(0) || canvas.GetLength(0) == isoscelesRightTriangleArray.GetLength(0) || canvas.GetLength(0) == isoscelesTriangleArray.GetLength(0) || canvas.GetLength(0) == circleArray.GetLength(0))
        //            {

        //                if (shape == EShape.Rectangle)
        //                {
        //                    for (int i = 0; i < canvas.GetLength(0); ++i)
        //                    {
        //                        for (int j = 0; j < canvas.GetLength(1); ++j)
        //                        {
        //                            if (canvas[i, j] != rectangleArray[i, j])
        //                            {
        //                                bResult = false;
        //                            }
        //                        }
        //                    }
        //                }

        //                else if (shape == EShape.IsoscelesRightTriangle)
        //                {
        //                    for (int i = 0; i < canvas.GetLength(0); ++i)
        //                    {
        //                        for (int j = 0; j < canvas.GetLength(1); ++j)
        //                        {
        //                            if (canvas[i, j] != isoscelesRightTriangleArray[i, j])
        //                            {
        //                                bResult = false;
        //                            }
        //                        }
        //                    }
        //                }

        //                else if (shape == EShape.IsoscelesTriangle)
        //                {
        //                    for (int i = 0; i < canvas.GetLength(0); ++i)
        //                    {
        //                        for (int j = 0; j < canvas.GetLength(1); ++j)
        //                        {
        //                            if (canvas[i, j] != isoscelesTriangleArray[i, j])
        //                            {
        //                                bResult = false;
        //                            }
        //                        }
        //                    }
        //                }

        //                else if (shape == EShape.Circle)
        //                {
        //                    for (int i = 0; i < canvas.GetLength(0); ++i)
        //                    {
        //                        for (int j = 0; j < canvas.GetLength(1); ++j)
        //                        {
        //                            if (canvas[i, j] != circleArray[i, j])
        //                            {
        //                                bResult = false;
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //            return bResult;
        //        }
        public static bool IsShape(char[,] canvas, EShape shape)
        {
            bool bResult = false;

            if (canvas.GetLength(0) - 4 == 1 && canvas.GetLength(1) - 4 == 1)
            {
                bResult = true;
            }

            else if (canvas.GetLength(0) - 4 != 0 && canvas.GetLength(1) - 4 != 0 && canvas.GetLength(0) != 0 && canvas.GetLength(1) != 0)
            {
                //else if (canvas.GetLength(0) == canvas.GetLength(1) && canvas.GetLength(1) % 2 != 0 && shape == EShape.Circle)
                //{
                //    bResult = true;
                //}

                if ((canvas.GetLength(0) != canvas.GetLength(1) || canvas.GetLength(1) % 2 == 0) && shape == EShape.Circle)
                {
                    bResult = false;
                }

                //else if (canvas.GetLength(1) - 4 == (canvas.GetLength(0) - 4) * 2 - 1 && shape == EShape.IsoscelesTriangle)
                //{
                //    bResult = true;
                //}

                else if (canvas.GetLength(1) - 4 != (canvas.GetLength(0) - 4) * 2 - 1 && shape == EShape.IsoscelesTriangle)
                {
                    bResult = false;
                }

                else if ((canvas.GetLength(0) != canvas.GetLength(1) || canvas[2, 2] != '*' || canvas[2, canvas.GetLength(1) - 3] != ' ') && shape == EShape.IsoscelesRightTriangle)
                {
                    bResult = false;
                }

                //else if (canvas.GetLength(0) == canvas.GetLength(1) && canvas[2, 2] == '*' && canvas[2, canvas.GetLength(1) - 3] == ' ' && shape == EShape.IsoscelesRightTriangle)
                //{
                //    bResult = true;
                //}

                else if ((canvas[2, 2] != '*' || canvas[2, canvas.GetLength(1) - 3] != '*') && shape == EShape.Rectangle)
                {
                    bResult = false;
                }

                //else if (canvas[2, 2] == '*' && canvas[2, canvas.GetLength(1) - 3] == '*' && shape == EShape.Rectangle)
                //{
                //    bResult = true;
                //}

                else
                {
                    bResult = true;
                }
            }

            return bResult;
        }
    }
}


//if (canvas.GetLength(0) - 4 != 0 && canvas.GetLength(1) - 4 != 0 && canvas.GetLength(0) != 0 && canvas.GetLength(1) != 0)
//{

//    if (canvas.GetLength(0) - 4 == 1 && canvas.GetLength(1) - 4 == 1)
//    {
//        if (shape == EShape.Circle && CircleEqual(canvas))
//        {
//            bResult = true;
//        }

//        else if (shape == EShape.IsoscelesRightTriangle && RightTriangleEqual(canvas))
//        {
//            bResult = true;
//        }

//        else if (shape == EShape.Rectangle && RectangleEqual(canvas))
//        {
//            bResult = true;
//        }

//        else
//        {
//            bResult = false;
//        }
//    }

//    //else if (canvas.GetLength(0) == canvas.GetLength(1) && canvas.GetLength(1) % 2 != 0 && shape == EShape.Circle)
//    //{
//    //    bResult = true;
//    //}

//    else if ((canvas.GetLength(0) != canvas.GetLength(1) || canvas.GetLength(1) % 2 == 0) && shape == EShape.Circle)
//    {
//        bResult = false;
//    }

//    //else if (canvas.GetLength(1) - 4 == (canvas.GetLength(0) - 4) * 2 - 1 && shape == EShape.IsoscelesTriangle)
//    //{
//    //    bResult = true;
//    //}

//    else if (canvas.GetLength(1) - 4 != (canvas.GetLength(0) - 4) * 2 - 1 && shape == EShape.IsoscelesTriangle)
//    {
//        bResult = false;
//    }

//    else if ((canvas.GetLength(0) != canvas.GetLength(1) || canvas[2, 2] != '*' || canvas[2, canvas.GetLength(1) - 3] != ' ') && shape == EShape.IsoscelesRightTriangle)
//    {
//        bResult = false;
//    }

//    //else if (canvas.GetLength(0) == canvas.GetLength(1) && canvas[2, 2] == '*' && canvas[2, canvas.GetLength(1) - 3] == ' ' && shape == EShape.IsoscelesRightTriangle)
//    //{
//    //    bResult = true;
//    //}

//    else if ((canvas[2, 2] != '*' || canvas[2, canvas.GetLength(1) - 3] != '*') && shape == EShape.Rectangle)
//    {
//        bResult = false;
//    }

//    //else if (canvas[2, 2] == '*' && canvas[2, canvas.GetLength(1) - 3] == '*' && shape == EShape.Rectangle)
//    //{
//    //    bResult = true;
//    //}

//    else
//    {
//        bResult = true;
//    }
//}




//if (canvas.GetLength(0) - 4 == 1 && canvas.GetLength(1) - 4 == 1)
//{
//    if (canvas[2, 2] == '*' && canvas[2, canvas.GetLength(1) - 3] == '*' && shape == EShape.Rectangle)
//    {
//        bResult = true;
//    }

//    else if (canvas.GetLength(1) - 4 == (canvas.GetLength(0) - 4) * 2 - 1 && shape == EShape.IsoscelesTriangle)
//    {
//        bResult = true;
//    }

//    else if (canvas.GetLength(0) == canvas.GetLength(1) && canvas.GetLength(1) % 2 != 0 && shape == EShape.Circle)
//    {
//        bResult = true;
//    }

//    else if (canvas[2, 2] == '*' && shape == EShape.IsoscelesRightTriangle)
//    {
//        bResult = true;
//    }
//}
