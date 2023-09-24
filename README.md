# CalculationTimer
This program calculates and compares the time it takes to compute; 
* Addition between two floats and addition between two doubles
* Addition and multiplication between two integer values
* The square of a double through direct multiplication, using the built in power function Math.Pow, and compares both of these to the square root function
* The sine of an angle using the built in function Math.Sin, using Taylor series approximation for the angle, and compares both of these to the cosine function

For the comparison between addition for floats or doubles, the integer addition and multiplication comparison, and the square comparison functions,
the program generates arrays of 800,000 pairs of random numbers to be used by those functions and a built-in stopwatch times how long each process takes to run through all 800,000 pairs.
The functions use the same arrays of numbers so there isn't a change in what numbers are used when comparing the timing between functions, 
for example the addition between two floats and two doubles uses the same generated list of random pairs of numbers except the one for float addition is converted to float values instead of double values.
However, for the functions that use generated angles for their processes I only generated one random angle to use in all the compared functions.

Using the program the results show that;
* Float addition takes much less time than double addition
* Addition and Multiplication between integer values takes roughly the same amount of time
* Using the power function takes longer than squaring by multiplication, but taking the square root of a number takes less time than both
* Using the Taylor series approximation takes less time than using the sine function, but using the cosine function takes less time than both
