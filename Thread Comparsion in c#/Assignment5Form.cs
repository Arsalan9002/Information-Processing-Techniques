using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Assignment5Form : Form,Interface
    {
        public Assignment5Form()
        { 
           InitializeComponent();
        }


        String myMatrix;
        TimeSpan[] multiplicationArray = new TimeSpan[5];
        Stopwatch stopWatch = new Stopwatch();

        private void matrixMultiplyButton_Click(object sender, EventArgs e)
        {
            timeTxtBox.Clear();
            //get matrix matrixSize choice
            myMatrix = matrixSizeCombo.SelectedItem.ToString();

            if (myMatrix =="100 by 100")
            {
                string datatype = typeCombo.SelectedItem.ToString();
                if (datatype == "Decimal")
                {
                    string technique = threadChoiceCombo.SelectedItem.ToString();
                    if (technique == "Use Single Thread")
                    {
                        ((Interface) this).Decimal_With_Single_Thread(100);

                    }
                    if (technique == "Use 10 Threads")
                    {
                        ((Interface) this).Decimal_With_Ten_Thread(100);

                    }
                    if (technique == "Use TPL")
                    {
                        ((Interface) this).Decimal_With_TPL(100);
                    }
                }

                else if (datatype == "Integer")
                {
                    string technique = threadChoiceCombo.SelectedItem.ToString();
                    if (technique == "Use 10 Thread")
                    {
                        ((Interface) this).Integer_With_single_Thread(100);

                    }
                    if (technique == "Use 10 Threads")
                    {
                        ((Interface) this).Integer_With_Ten_Thread(100);

                    }
                    if (technique == "Use TPL")
                    {
                        ((Interface) this).Integer_With_TPL(100);
                    }
                }
                else if (datatype == "Double")
                {
                    string technique = threadChoiceCombo.SelectedItem.ToString();
                    if (technique == "Use 10 Thread")
                    {
                        ((Interface) this).Double_With_Single_Thread(100);

                    }
                    if (technique == "Use 10 Threads")
                    {
                        ((Interface) this).Double_With_Ten_Thread(100);

                    }
                    if (technique == "Use TPL")
                    {
                        ((Interface) this).Double_With_TPL(100);
                    }
                }
                else
                {
                    //do nothing
                }
            }
            else if (myMatrix == "500 by 500")
            {
                string datatype = typeCombo.SelectedItem.ToString();
                if (datatype == "Decimal")
                {
                    string technique = threadChoiceCombo.SelectedItem.ToString();
                    if (technique == "Use Single Thread")
                    {
                        ((Interface) this).Decimal_With_Single_Thread(500);

                    }
                    if (technique == "Use 10 Threads")
                    {
                        ((Interface) this).Decimal_With_Ten_Thread(500);

                    }
                    if (technique == "Use TPL")
                    {
                        ((Interface) this).Decimal_With_TPL(500);
                    }
                }

                else if (datatype == "Integer")
                {
                    string technique = threadChoiceCombo.SelectedItem.ToString();
                    if (technique == "Use 10 Thread")
                    {
                        ((Interface) this).Integer_With_single_Thread(500);

                    }
                    if (technique == "Use 10 Threads")
                    {
                        ((Interface) this).Integer_With_Ten_Thread(500);

                    }
                    if (technique == "Use TPL")
                    {
                        ((Interface) this).Integer_With_TPL(500);
                    }
                }
                else if (datatype == "Double")
                {
                    string technique = threadChoiceCombo.SelectedItem.ToString();
                    if (technique == "Use 10 Thread")
                    {
                        ((Interface) this).Double_With_Single_Thread(500);

                    }
                    if (technique == "Use 10 Threads")
                    {
                        ((Interface) this).Double_With_Ten_Thread(500);

                    }
                    if (technique == "Use TPL")
                    {
                        ((Interface) this).Double_With_TPL(500);
                    }
                }
                else
                {
                    //do nothing
                }
            }
            else if (myMatrix == "1000 by 1000")
            {
                string datatype = typeCombo.SelectedItem.ToString();
                if (datatype == "Decimal")
                {
                    string technique = threadChoiceCombo.SelectedItem.ToString();
                    if (technique == "Use Single Thread")
                    {
                        ((Interface) this).Decimal_With_Single_Thread(1000);

                    }
                    if (technique == "Use 10 Threads")
                    {
                        ((Interface) this).Decimal_With_Ten_Thread(1000);

                    }
                    if (technique == "Use TPL")
                    {
                        ((Interface) this).Decimal_With_TPL(1000);
                    }
                }

                else if (datatype == "Integer")
                {
                    string technique = threadChoiceCombo.SelectedItem.ToString();
                    if (technique == "Use 10 Thread")
                    {
                        ((Interface) this).Integer_With_single_Thread(1000);

                    }
                    if (technique == "Use 10 Threads")
                    {
                        ((Interface) this).Integer_With_Ten_Thread(1000);

                    }
                    if (technique == "Use TPL")
                    {
                        ((Interface) this).Integer_With_TPL(1000);
                    }
                }
                else if (datatype == "Double")
                {
                    string technique = threadChoiceCombo.SelectedItem.ToString();
                    if (technique == "Use 10 Thread")
                    {
                        ((Interface) this).Double_With_Single_Thread(1000);

                    }
                    if (technique == "Use 10 Threads")
                    {
                        ((Interface) this).Double_With_Ten_Thread(1000);

                    }
                    if (technique == "Use TPL")
                    {
                        ((Interface) this).Double_With_TPL(1000);
                    }
                }
                else
                {
                    //do nothing
                }
            }
            else
            {
                //do nothing
            }

            

        }

        // single thread with decimal with matrixSize 100 by 100 , 500 by 500 and 1000 by 1000 matrix
        void Interface.Decimal_With_Single_Thread(int matrixSize)
        {
            threadBox.Items.Clear();    
            timeBox.Items.Clear();      
            for (int matrix_Iterator = 0; matrix_Iterator < 5; matrix_Iterator++)
            {
                stopWatch.Start();
                //matrix array declaration
                decimal[,] first_matrix = new decimal[matrixSize, matrixSize];
                decimal[,] second_matrix = new decimal[matrixSize, matrixSize];
                decimal[,] result_matrix = new decimal[matrixSize, matrixSize];
                Random random = new Random();

                //generating numbers
                for (int outer_Iterator = 0; outer_Iterator < matrixSize; outer_Iterator++)
                {
                    for (int inner_Iterator = 0; inner_Iterator < matrixSize; inner_Iterator++)
                    {
                        first_matrix[outer_Iterator, inner_Iterator] = (decimal)(random.NextDouble() * (0.10 * 999.99) + 0.10);
                        second_matrix[outer_Iterator, inner_Iterator] = (decimal)(random.NextDouble() * (0.10 * 999.99) + 0.10);

                    }
                }


                for (int outer_Iterable = 0; outer_Iterable < matrixSize; outer_Iterable++)
                {
                    for (int inner_Iterable = 0; inner_Iterable < matrixSize; inner_Iterable++)
                    {
                        result_matrix[outer_Iterable, inner_Iterable] = 0;
                        for (int k = 0; k < matrixSize; k++)
                        {
                            result_matrix[outer_Iterable, inner_Iterable] += first_matrix[outer_Iterable, k] * second_matrix[k, inner_Iterable];
                        }

                    }
                    threadBox.Items.Add("Value in Matrix Cell,  " + (outer_Iterable + 1).ToString());
                }
                stopWatch.Stop();




                multiplicationArray[matrix_Iterator] = stopWatch.Elapsed;
                string elapseTimeSpan = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    multiplicationArray[matrix_Iterator].Hours, multiplicationArray[matrix_Iterator].Minutes, multiplicationArray[matrix_Iterator].Seconds,
                    multiplicationArray[matrix_Iterator].Milliseconds / 10);
                timeBox.Items.Add("RunTime " + elapseTimeSpan);
            }
            TimeSpan Decimal_Average_Time = new TimeSpan();
            for (int i = 0; i < 5; i++)
                Decimal_Average_Time = multiplicationArray[i] + Decimal_Average_Time;

            string formattedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    Decimal_Average_Time.Hours, Decimal_Average_Time.Minutes, Decimal_Average_Time.Seconds,
                    Decimal_Average_Time.Milliseconds / 10);

            timeTxtBox.Text = formattedTime2.ToString();
            stopWatch.Reset();
        }
        //10 threads with decimal with matrixSize 100 by 100 , 500 by 500 and 1000 by 1000 matrix
        void Interface.Decimal_With_Ten_Thread(int matrixSize)
        {
            threadBox.Items.Clear();
            timeBox.Items.Clear();
            for (int mainIterator = 0; mainIterator < 5; mainIterator++)
            {
                stopWatch.Start();
                decimal[,] first_matrix = new decimal[matrixSize, matrixSize];
                decimal[,] second_matrix = new decimal[matrixSize, matrixSize];
                decimal[,] result_matrix = new decimal[matrixSize, matrixSize];
                Random random = new Random();
                for (int outer_Iterator = 0; outer_Iterator < matrixSize; outer_Iterator++)
                {
                    for (int inner_Iterator = 0; inner_Iterator < matrixSize; inner_Iterator++)
                    {
                        first_matrix[outer_Iterator, inner_Iterator] = (decimal)(random.NextDouble() * (0.10 * 999.99) + 0.10);
                        second_matrix[outer_Iterator, inner_Iterator] = (decimal)(random.NextDouble() * (0.10 * 999.99) + 0.10);

                    }
                }


                Thread[] t = new Thread[10];
                int start = -(matrixSize / 10), end = 0;
                for (int outer_Iterable = 0; outer_Iterable < 10; outer_Iterable++)
                {
                    start = start + (matrixSize / 10);
                    end = end + (matrixSize / 10);
                    t[outer_Iterable] = new Thread(() => For_Decimal(start, end, ref first_matrix, ref second_matrix, ref result_matrix));
                    t[outer_Iterable].Start();


                }

                for (int inner_Iterable = 0; inner_Iterable < 10; inner_Iterable++)
                {
                    t[inner_Iterable].Join();
                    threadBox.Items.Add("thread=> " + (inner_Iterable + 1).ToString() + "completed");
                }
                stopWatch.Stop();
                multiplicationArray[mainIterator] = stopWatch.Elapsed;
                string elapseTimeSpan = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    multiplicationArray[mainIterator].Hours, multiplicationArray[mainIterator].Minutes, multiplicationArray[mainIterator].Seconds,
                    multiplicationArray[mainIterator].Milliseconds / 10);
                timeBox.Items.Add("RunTime " + elapseTimeSpan);
            }
            TimeSpan Decimal_Average_Time = new TimeSpan();
            for (int i = 0; i < 5; i++)
                Decimal_Average_Time = multiplicationArray[i] + Decimal_Average_Time;

            string formattedTime2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    Decimal_Average_Time.Hours, Decimal_Average_Time.Minutes, Decimal_Average_Time.Seconds,
                    Decimal_Average_Time.Milliseconds / 10);

            timeTxtBox.Text = formattedTime2.ToString();
            stopWatch.Reset();
        }

        //TPL with decimal with matrixSize 100 by 100 , 500 by 500 and 1000 by 1000 matrix
        void Interface.Decimal_With_TPL(int matrixSize)
        {
            threadBox.Items.Clear();
            timeBox.Items.Clear();
            for (int mainIterator = 0; mainIterator < 5; mainIterator++)
            {
                stopWatch.Start();
                double[,] first_matrix = new double[matrixSize, matrixSize];
                double[,] second_matrix = new double[matrixSize, matrixSize];
                double[,] result_matrix = new double[matrixSize, matrixSize];
                Random random = new Random();
                for (int outer_Iterator = 0; outer_Iterator < matrixSize; outer_Iterator++)
                {
                    for (int inner_Iterator = 0; inner_Iterator < matrixSize; inner_Iterator++)
                    {
                        first_matrix[outer_Iterator, inner_Iterator] = (random.NextDouble() * (0.10 * 999.99) + 0.10);
                        second_matrix[outer_Iterator, inner_Iterator] = (random.NextDouble() * (0.10 * 999.99) + 0.10);

                    }
                }
                int outer_Iterable = -1;
                Parallel.For(0, matrixSize, i =>
                {
                    outer_Iterable++;
                    for (int inner_Iterable = 0; inner_Iterable < matrixSize; inner_Iterable++)
                    {
                        result_matrix[outer_Iterable, inner_Iterable] = 0;
                        for (int k = 0; k < matrixSize; k++)
                        {
                            result_matrix[outer_Iterable, inner_Iterable] += first_matrix[outer_Iterable, k] * second_matrix[k, inner_Iterable];
                        }

                    }


                }
                );
                for (int l = 0; l < 10; l++)
                    threadBox.Items.Add("thread=> " + l + "completed");
                stopWatch.Stop();
                multiplicationArray[mainIterator] = stopWatch.Elapsed;
                string elapseTimeSpan = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    multiplicationArray[mainIterator].Hours, multiplicationArray[mainIterator].Minutes, multiplicationArray[mainIterator].Seconds,
                    multiplicationArray[mainIterator].Milliseconds / 10);
                timeBox.Items.Add("RunTime " + elapseTimeSpan);
            }
            TimeSpan Double_Average_Time = new TimeSpan();
            for (int i = 0; i < 5; i++)
                Double_Average_Time = multiplicationArray[i] + Double_Average_Time;

            string FormatTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    Double_Average_Time.Hours, Double_Average_Time.Minutes, Double_Average_Time.Seconds,
                    Double_Average_Time.Milliseconds / 10);

            timeTxtBox.Text = FormatTime.ToString();
            stopWatch.Reset();
        }

        void For_Decimal(int start, int end, ref decimal[,] first_matrix, ref decimal[,] second_matrix, ref decimal[,] result_matrix)
        {
            for (int outer_Iterable = start; outer_Iterable < end; outer_Iterable++)
            {
                for (int inner_Iterable = start; inner_Iterable < end; inner_Iterable++)
                {
                    result_matrix[outer_Iterable, inner_Iterable] = 0;
                    for (int k = 0; k < 100; k++)
                    {
                        result_matrix[outer_Iterable, inner_Iterable] += first_matrix[outer_Iterable, k] * second_matrix[k, inner_Iterable];
                    }

                }

            }
        }


        //single thread with double using 100 by 100 , 500 by 500 and 1000 by 1000 matrix

        void Interface.Double_With_Single_Thread(int matrixSize)
        {
            threadBox.Items.Clear();
            timeBox.Items.Clear();
            for (int mainIterator = 0; mainIterator < 5; mainIterator++)
            {
                stopWatch.Start();
                double[,] first_matrix = new double[matrixSize, matrixSize];
                double[,] second_matrix = new double[matrixSize, matrixSize];
                double[,] result_matrix = new double[matrixSize, matrixSize];
                Random random = new Random();
                for (int outer_Iterator = 0; outer_Iterator < matrixSize; outer_Iterator++)
                {
                    for (int inner_Iterator = 0; inner_Iterator < matrixSize; inner_Iterator++)
                    {
                        first_matrix[outer_Iterator, inner_Iterator] = (random.NextDouble() * (0.10 * 999.99) + 0.10);
                        second_matrix[outer_Iterator, inner_Iterator] = (random.NextDouble() * (0.10 * 999.99) + 0.10);

                    }
                }


                for (int outer_Iterable = 0; outer_Iterable < matrixSize; outer_Iterable++)
                {
                    for (int inner_Iterable = 0; inner_Iterable < matrixSize; inner_Iterable++)
                    {
                        result_matrix[outer_Iterable, inner_Iterable] = 0;
                        for (int k = 0; k < matrixSize; k++)
                        {
                            result_matrix[outer_Iterable, inner_Iterable] += first_matrix[outer_Iterable, k] * second_matrix[k, inner_Iterable];
                        }

                    }
                    threadBox.Items.Add("Value in matrix Cell " + (outer_Iterable + 1).ToString());
                }
                stopWatch.Stop();
                multiplicationArray[mainIterator] = stopWatch.Elapsed;
                string elapseTimeSpan = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    multiplicationArray[mainIterator].Hours, multiplicationArray[mainIterator].Minutes, multiplicationArray[mainIterator].Seconds,
                    multiplicationArray[mainIterator].Milliseconds / 10);
                timeBox.Items.Add("RunTime " + elapseTimeSpan);
            }
            TimeSpan Double_Average_Time = new TimeSpan();
            for (int i = 0; i < 5; i++)
                Double_Average_Time = multiplicationArray[i] + Double_Average_Time;

            string FormatTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    Double_Average_Time.Hours, Double_Average_Time.Minutes, Double_Average_Time.Seconds,
                    Double_Average_Time.Milliseconds / 10);

            timeTxtBox.Text = FormatTime.ToString();
            stopWatch.Reset();
        }

        //10 threads with double using 100 by 100 , 500 by 500 and 1000 by 1000 matrix
        void Interface.Double_With_Ten_Thread(int matrixSize)
        {
            threadBox.Items.Clear();
            timeBox.Items.Clear();
            for (int mainIterator = 0; mainIterator < 5; mainIterator++)
            {
                stopWatch.Start();
                double[,] first_matrix = new double[matrixSize, matrixSize];
                double[,] second_matrix = new double[matrixSize, matrixSize];
                double[,] result_matrix = new double[matrixSize, matrixSize];
                Random random = new Random();
                for (int outer_Iterator = 0; outer_Iterator < matrixSize; outer_Iterator++)
                {
                    for (int inner_Iterator = 0; inner_Iterator < matrixSize; inner_Iterator++)
                    {
                        first_matrix[outer_Iterator, inner_Iterator] = (random.NextDouble() * (0.10 * 999.99) + 0.10);
                        second_matrix[outer_Iterator, inner_Iterator] = (random.NextDouble() * (0.10 * 999.99) + 0.10);

                    }
                }


                Thread[] t = new Thread[10];
                int start = -(matrixSize / 10), end = 0;
                for (int outer_Iterable = 0; outer_Iterable < 10; outer_Iterable++)
                {
                    start = start + (matrixSize / 10);
                    end = end + (matrixSize / 10);
                    t[outer_Iterable] = new Thread(() => For_Double(start, end, ref first_matrix, ref second_matrix, ref result_matrix));
                    t[outer_Iterable].Start();


                }

                for (int inner_Iterable = 0; inner_Iterable < 10; inner_Iterable++)
                {
                    t[inner_Iterable].Join();
                    threadBox.Items.Add("thread=> " + (inner_Iterable + 1).ToString() + "completed");
                }
                stopWatch.Stop();
                multiplicationArray[mainIterator] = stopWatch.Elapsed;
                string elapseTimeSpan = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    multiplicationArray[mainIterator].Hours, multiplicationArray[mainIterator].Minutes, multiplicationArray[mainIterator].Seconds,
                    multiplicationArray[mainIterator].Milliseconds / 10);
                timeBox.Items.Add("RunTime " + elapseTimeSpan);
            }
            TimeSpan Double_Average_Time = new TimeSpan();
            for (int i = 0; i < 5; i++)
                Double_Average_Time = multiplicationArray[i] + Double_Average_Time;

            string FormatTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    Double_Average_Time.Hours, Double_Average_Time.Minutes, Double_Average_Time.Seconds,
                    Double_Average_Time.Milliseconds / 10);

            timeTxtBox.Text = FormatTime.ToString();
            stopWatch.Reset();
        }

        //TPL threads with double using 100 by 100 , 500 by 500 and 1000 by 1000 matrix

        void Interface.Double_With_TPL(int matrixSize)
        {
            threadBox.Items.Clear();
            timeBox.Items.Clear();
            for (int mainIterator = 0; mainIterator < 5; mainIterator++)
            {
                stopWatch.Start();
                double[,] first_matrix = new double[matrixSize, matrixSize];
                double[,] second_matrix = new double[matrixSize, matrixSize];
                double[,] result_matrix = new double[matrixSize, matrixSize];
                Random random = new Random();
                for (int outer_Iterator = 0; outer_Iterator < matrixSize; outer_Iterator++)
                {
                    for (int inner_Iterator = 0; inner_Iterator < matrixSize; inner_Iterator++)
                    {
                        first_matrix[outer_Iterator, inner_Iterator] = (random.NextDouble() * (0.10 * 999.99) + 0.10);
                        second_matrix[outer_Iterator, inner_Iterator] = (random.NextDouble() * (0.10 * 999.99) + 0.10);

                    }
                }
                int outer_Iterable = -1;
                Parallel.For(0, matrixSize, i =>
                {
                    outer_Iterable++;
                    for (int inner_Iterable = 0; inner_Iterable < matrixSize; inner_Iterable++)
                    {
                        result_matrix[outer_Iterable, inner_Iterable] = 0;
                        for (int k = 0; k < matrixSize; k++)
                        {
                            result_matrix[outer_Iterable, inner_Iterable] += first_matrix[outer_Iterable, k] * second_matrix[k, inner_Iterable];
                        }

                    }
                }
               );
                for (int l = 0; l < 10; l++)
                    threadBox.Items.Add("thread=> " + l + "completed");
                stopWatch.Stop();
                multiplicationArray[mainIterator] = stopWatch.Elapsed;
                string elapseTimeSpan = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    multiplicationArray[mainIterator].Hours, multiplicationArray[mainIterator].Minutes, multiplicationArray[mainIterator].Seconds,
                    multiplicationArray[mainIterator].Milliseconds / 10);
                timeBox.Items.Add("RunTime " + elapseTimeSpan);
            }
            TimeSpan Double_Average_Time = new TimeSpan();
            for (int i = 0; i < 5; i++)
                Double_Average_Time = multiplicationArray[i] + Double_Average_Time;

            string FormatTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    Double_Average_Time.Hours, Double_Average_Time.Minutes, Double_Average_Time.Seconds,
                    Double_Average_Time.Milliseconds / 10);

            timeTxtBox.Text = FormatTime.ToString();
            stopWatch.Reset();
        }


        void For_Double(int start, int end, ref double[,] first_matrix, ref double[,] second_matrix, ref double[,] result_matrix)
        {
            for (int outer_Iterable = start; outer_Iterable < end; outer_Iterable++)
            {
                for (int inner_Iterable = start; inner_Iterable < end; inner_Iterable++)
                {
                    result_matrix[outer_Iterable, inner_Iterable] = 0;
                    for (int k = 0; k < 100; k++)
                    {
                        result_matrix[outer_Iterable, inner_Iterable] += first_matrix[outer_Iterable, k] * second_matrix[k, inner_Iterable];
                    }

                }

            }
        }


        //single thread with integer using 100 by 100 , 500 by 500 and 1000 by 1000 matrix
        void Interface.Integer_With_single_Thread(int matrixSize)
        {
            threadBox.Items.Clear();
            timeBox.Items.Clear();
            for (int mainIterator = 0; mainIterator < 5; mainIterator++)
            {
                stopWatch.Start();
                int[,] first_matrix = new int[matrixSize, matrixSize];
                int[,] second_matrix = new int[matrixSize, matrixSize];
                int[,] result_matrix = new int[matrixSize, matrixSize];
                Random random = new Random();
                for (int outer_Iterator = 0; outer_Iterator < matrixSize; outer_Iterator++)
                {
                    for (int inner_Iterator = 0; inner_Iterator < matrixSize; inner_Iterator++)
                    {
                        first_matrix[outer_Iterator, inner_Iterator] = random.Next(0, 10);
                        second_matrix[outer_Iterator, inner_Iterator] = random.Next(0, 10);

                    }
                }


                for (int outer_Iterable = 0; outer_Iterable < matrixSize; outer_Iterable++)
                {
                    for (int inner_Iterable = 0; inner_Iterable < matrixSize; inner_Iterable++)
                    {
                        result_matrix[outer_Iterable, inner_Iterable] = 0;
                        for (int k = 0; k < matrixSize; k++)
                        {
                            result_matrix[outer_Iterable, inner_Iterable] += first_matrix[outer_Iterable, k] * second_matrix[k, inner_Iterable];
                        }

                    }
                    threadBox.Items.Add("Value in matrix Cell " + (outer_Iterable + 1).ToString());
                }
                stopWatch.Stop();
                multiplicationArray[mainIterator] = stopWatch.Elapsed;
                string elapseTimeSpan = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    multiplicationArray[mainIterator].Hours, multiplicationArray[mainIterator].Minutes, multiplicationArray[mainIterator].Seconds,
                    multiplicationArray[mainIterator].Milliseconds / 10);
                timeBox.Items.Add("RunTime " + elapseTimeSpan);
            }
            TimeSpan Integer_Average_Time = new TimeSpan();
            for (int i = 0; i < 5; i++)
                Integer_Average_Time = multiplicationArray[i] + Integer_Average_Time;

            string formattedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    Integer_Average_Time.Hours, Integer_Average_Time.Minutes, Integer_Average_Time.Seconds,
                    Integer_Average_Time.Milliseconds / 10);

            timeTxtBox.Text = formattedTime1.ToString();
            stopWatch.Reset();
        }

        //10 thread with integer using 100 by 100 , 500 by 500 and 1000 by 1000 matrix

        void Interface.Integer_With_Ten_Thread(int matrixSize)
        {
            threadBox.Items.Clear();
            timeBox.Items.Clear();
            for (int mainIterator = 0; mainIterator < 5; mainIterator++)
            {
                stopWatch.Start();
                int[,] first_matrix = new int[matrixSize, matrixSize];
                int[,] second_matrix = new int[matrixSize, matrixSize];
                int[,] result_matrix = new int[matrixSize, matrixSize];
                Random random = new Random();
                for (int outer_Iterator = 0; outer_Iterator < matrixSize; outer_Iterator++)
                {
                    for (int inner_Iterator = 0; inner_Iterator < matrixSize; inner_Iterator++)
                    {
                        first_matrix[outer_Iterator, inner_Iterator] = random.Next(0, 10);
                        second_matrix[outer_Iterator, inner_Iterator] = random.Next(0, 10);

                    }
                }

                Thread[] t = new Thread[10];
                int start = -(matrixSize / 10), end = 0;
                for (int outer_Iterable = 0; outer_Iterable < 10; outer_Iterable++)
                {
                    start = start + (matrixSize / 10);
                    end = end + (matrixSize / 10);
                    t[outer_Iterable] = new Thread(() => For_Integer(start, end, ref first_matrix, ref second_matrix, ref result_matrix));
                    t[outer_Iterable].Start();


                }

                for (int inner_Iterable = 0; inner_Iterable < 10; inner_Iterable++)
                {
                    t[inner_Iterable].Join();
                    threadBox.Items.Add("thread=> " + (inner_Iterable + 1).ToString() + "completed");
                }
                stopWatch.Stop();

                multiplicationArray[mainIterator] = stopWatch.Elapsed;
                string elapseTimeSpan = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    multiplicationArray[mainIterator].Hours, multiplicationArray[mainIterator].Minutes, multiplicationArray[mainIterator].Seconds,
                    multiplicationArray[mainIterator].Milliseconds / 10);
                timeBox.Items.Add("RunTime " + elapseTimeSpan);
            }
            TimeSpan Integer_Average_Time = new TimeSpan();
            for (int i = 0; i < 5; i++)
                Integer_Average_Time = multiplicationArray[i] + Integer_Average_Time;

            string formattedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    Integer_Average_Time.Hours, Integer_Average_Time.Minutes, Integer_Average_Time.Seconds,
                    Integer_Average_Time.Milliseconds / 10);

            timeTxtBox.Text = formattedTime1.ToString();
            stopWatch.Reset();
        }

        void For_Integer(int start, int end, ref int[,] first_matrix, ref int[,] second_matrix, ref int[,] result_matrix)
        {
            for (int outer_Iterable = start; outer_Iterable < end; outer_Iterable++)
            {
                for (int inner_Iterable = start; inner_Iterable < end; inner_Iterable++)
                {
                    result_matrix[outer_Iterable, inner_Iterable] = 0;
                    for (int k = 0; k < 100; k++)
                    {
                        result_matrix[outer_Iterable, inner_Iterable] += first_matrix[outer_Iterable, k] * second_matrix[k, inner_Iterable];
                    }

                }

            }
        }

        void Interface.Integer_With_TPL(int matrixSize)
        {

            threadBox.Items.Clear();
            timeBox.Items.Clear();
            for (int mainIterator = 0; mainIterator < 5; mainIterator++)
            {
                stopWatch.Start();
                int[,] first_matrix = new int[matrixSize, matrixSize];
                int[,] second_matrix = new int[matrixSize, matrixSize];
                int[,] result_matrix = new int[matrixSize, matrixSize];
                Random random = new Random();
                for (int outer_Iterator = 0; outer_Iterator < matrixSize; outer_Iterator++)
                {
                    for (int inner_Iterator = 0; inner_Iterator < matrixSize; inner_Iterator++)
                    {
                        first_matrix[outer_Iterator, inner_Iterator] = random.Next(0, 10);
                        second_matrix[outer_Iterator, inner_Iterator] = random.Next(0, 10);

                    }
                }
                int outer_Iterable = -1;
                Parallel.For(0, matrixSize, i =>
                {
                    outer_Iterable++;
                    for (int inner_Iterable = 0; inner_Iterable < matrixSize; inner_Iterable++)
                    {
                        result_matrix[outer_Iterable, inner_Iterable] = 0;
                        for (int k = 0; k < matrixSize; k++)
                        {
                            result_matrix[outer_Iterable, inner_Iterable] += first_matrix[outer_Iterable, k] * second_matrix[k, inner_Iterable];
                        }

                    }


                }
                );
                for (int l = 0; l < 10; l++)
                    threadBox.Items.Add("thread=> " + l + "completed" +
                                        "");
                stopWatch.Stop();
                multiplicationArray[mainIterator] = stopWatch.Elapsed;
                string elapseTimeSpan = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    multiplicationArray[mainIterator].Hours, multiplicationArray[mainIterator].Minutes, multiplicationArray[mainIterator].Seconds,
                    multiplicationArray[mainIterator].Milliseconds / 10);
                timeBox.Items.Add("RunTime " + elapseTimeSpan);
            }
            TimeSpan Integer_Average_Time = new TimeSpan();
            for (int i = 0; i < 5; i++)
                Integer_Average_Time = multiplicationArray[i] + Integer_Average_Time;

            string formattedTime1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    Integer_Average_Time.Hours, Integer_Average_Time.Minutes, Integer_Average_Time.Seconds,
                    Integer_Average_Time.Milliseconds / 10);

            timeTxtBox.Text = formattedTime1.ToString();
            stopWatch.Reset();
        }

    }
}
