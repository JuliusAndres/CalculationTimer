using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        int n = 800000;
        Stopwatch timer = new Stopwatch();

        //Timing between int addition and multiplication
        int[,] intnumbers;
        intnumbers = GenRandomNumInt(n);
        timer.Start();
        AddNumbersInt(intnumbers, n);
        timer.Stop();
        Console.WriteLine("int addition");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        float addTicks = timer.ElapsedTicks;
        timer.Restart();

        timer.Start();
        MultiplyNumbersInt(intnumbers, n);
        timer.Stop();
        Console.WriteLine("int multiplication");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks");
        long MultTicks = timer.ElapsedTicks;
        Console.WriteLine("int addition and multiplication Ratio = " + addTicks/MultTicks + "\n");
        timer.Restart();

        //Timing between float and double addition
        double[,] doublenumbers;
        doublenumbers = GenRandomNumDouble(n);

        float[,] floatnumbers;
        floatnumbers = new float[n,3];
        int i = 0;
        for(i=0; i<n; i++)
        {
            floatnumbers[i,0] = (float)doublenumbers[i,0];
            floatnumbers[i,1] = (float)doublenumbers[i,1];
        }

        timer.Start();
        AddNumbersDouble(doublenumbers, n);
        timer.Stop();
        Console.WriteLine("Double Addition");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        float AddDoubTicks = timer.ElapsedTicks;
        timer.Restart();

        timer.Start();
        AddNumbersFloat(floatnumbers, n);
        timer.Stop();
        Console.WriteLine("Float Addition");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks");
        long AddFloatTicks = timer.ElapsedTicks;
        Console.WriteLine("double and float addition Ratio = " + AddDoubTicks/AddFloatTicks + "\n");
        timer.Restart();

        //Timing between square multiplication and square power
        double[,] squarenumbers;
        squarenumbers = GenRandomNumSquare(n);
        
        timer.Start();
        MultiplyNumbers(squarenumbers, n);
        timer.Stop();
        Console.WriteLine("Squared Multiplication");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        float MultSquareTicks = timer.ElapsedTicks;
        timer.Restart();

        timer.Start();
        PowerNumbers(squarenumbers, n);
        timer.Stop();
        Console.WriteLine("Squared Power");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms " + timer.ElapsedTicks + " ticks\n");
        long PowSquareTicks = timer.ElapsedTicks;
        Console.WriteLine("Muliplication and Power Ratio = " + MultSquareTicks/PowSquareTicks + "\n");
        timer.Restart();

        //Timing between Sin, Cos, and quintic Taylor Series
        double anglenumber;
        double AngleGenerated;
        Random rnd = new Random();
        AngleGenerated = rnd.Next(0,157);
        anglenumber = AngleGenerated/100;

        timer.Start();
        SinNumbers(anglenumber);
        timer.Stop();
        Console.WriteLine("Sin Operation");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedTicks + " ticks\n");
        timer.Restart();

        timer.Start();
        CosNumbers(anglenumber);
        timer.Stop();
        Console.WriteLine("Cos Operation");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedTicks + " ticks\n");
        timer.Restart();

        timer.Start();
        TaylorSeriesNum(anglenumber);
        timer.Stop();
        Console.WriteLine("Taylor Series Operation");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedTicks + " ticks\n");
        timer.Restart();
    }

//functions for int compares
static int[,] GenRandomNumInt(int count)
    {
        Random rand = new Random();
        int[,] num = new int[count,3];
        for(int i=0; i<count; ++i)
        {
            num[i,0] = 100*(int)rand.NextDouble();
            num[i,1] = 100*(int)rand.NextDouble();
        }

        return num;
    }
static void AddNumbersInt(int[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,2] = nums[i,0] + nums[i,1];
        }
    }
static void MultiplyNumbersInt(int[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,2] = nums[i,0] * nums[i,1];
        }
    }

//functions for float and double addition
static double[,] GenRandomNumDouble(int count)
    {
        Random rand = new Random();
        double[,] num = new double[count,3];
        for(int i=0; i<count; ++i)
        {
            num[i,0] = 100*rand.NextDouble();
            num[i,1] = 100*rand.NextDouble();
        }
        return num;
    }
static void AddNumbersDouble(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,2] = nums[i,0] + nums[i,1];
        }
    }
static void AddNumbersFloat(float[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,2] = nums[i,0] + nums[i,1];
        }
    }

//functions for power compares
static double[,] GenRandomNumSquare(int count)
    {
        Random rand = new Random();
        double[,] num = new double[count,3];
        for(int i=0; i<count; ++i)
        {
            num[i,0] = 100*rand.NextDouble();
        }

        return num;
    }

static void MultiplyNumbers(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,1] = nums[i,0] * nums[i,0];
        }
    }
static void PowerNumbers(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i)
        {
            nums[i,1] = Math.Pow(nums[i,0], 2);
        }
    }
//functions for Sin, Cos, and Exp operations
static double SinNumbers(double nums)
    {
        Math.Sin(nums);
        return nums;
    }
static double CosNumbers(double nums)
    {
        Math.Cos(nums);
        return nums;
    }
static double TaylorSeriesNum(double nums)
    {
        double anglenum;
        anglenum = nums - (1/6)*(Math.Pow(nums, 3)) + (1/120)*(Math.Pow(nums, 5));
        return anglenum;
    }
}
