using System;

namespace Lab6
{
    public static class Lab6
    {
        public static int[,] Rotate90Degrees(int[,] data)
        {
            int[,] result = new int[data.GetLength(1), data.GetLength(0)];
            int k = data.GetLength(0) - 1;

            for (int i = 0; i < data.GetLength(0); ++i)
            {
                for (int j = 0; j < data.GetLength(1); ++j)
                {
                    result[j, k] = data[i, j];
                }
                --k;
            }

            return result;
        }

        public static int[,] TransformArray(int[,] data, EMode value)
        {
            int[,] result = new int[data.GetLength(0), data.GetLength(1)];

            if (value == EMode.HorizontalMirror)
            {
                int k = data.GetLength(1) - 1;

                for (int i = 0; i < data.GetLength(0); ++i)
                {
                    for (int j = 0; j < data.GetLength(1); ++j)
                    {
                        result[i, k] = data[i, j];
                        --k;
                    }
                    k = data.GetLength(1) - 1;
                }
            }
            else if (value == EMode.VerticalMirror)
            {
                int k = data.GetLength(0) - 1;

                for (int i = 0; i < data.GetLength(0); ++i)
                {
                    for (int j = 0; j < data.GetLength(1); ++j)
                    {
                        result[k, j] = data[i, j];
                    }
                    --k;
                }
            }
            else if (value == EMode.DiagonalShift)
            {
                int k = 1;
                for (int i = 0; i < data.GetLength(0); ++i)
                {
                    for (int j = 0; j < data.GetLength(1); ++j)
                    {
                        if (i == data.GetLength(0) - 1 && j != data.GetLength(1) - 1)
                        {
                            result[0, j + 1] = data[i, j];
                        }
                        else if (i == data.GetLength(0) - 1 && j == data.GetLength(1) - 1)
                        {
                            result[0, 0] = data[i, j];
                        }
                        else if (j == data.GetLength(1) - 1)
                        {
                            result[k, 0] = data[i, j];
                        }
                        else
                        {
                            result[k, j + 1] = data[i, j];
                        }
                    }
                    ++k;
                }
            }
            for (int i = 0; i < result.GetLength(0); ++i)
            {
                for (int j = 0; j < result.GetLength(1); ++j)
                {
                    data[i, j] = result[i, j];
                }
            }

            return data;
        }
    }
}
