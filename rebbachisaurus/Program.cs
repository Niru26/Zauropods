﻿Console.Clear();
Console.WriteLine("Homework 5 by Rudakov N.");
Console.WriteLine("Task 34");
// //Task 34
int getIntData () {
    return Convert.ToInt32(Console.ReadLine());
}

int [] generateRandomArray() {
    Console.Write("Enter array size: ");
    int size = getIntData();
    Console.Write("Enter array minimal value: ");
    int minValue = getIntData();
    Console.Write("Enter array maximum value: ");
    int maxValue = getIntData(); 
    int [] outputArray = new int [size];
    for(int i = 0; i < size; i++) {
        outputArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return outputArray;
}

void showArray(int [] array) {
        Console.WriteLine("Array elements: ");
        for(int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}

int countEven(int[] array) {
    int counter = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) counter++;
    }
    return counter;
}

void showTask34Answer() {
    int[] randomArray = generateRandomArray();
    showArray(randomArray);
    int result = countEven(randomArray);
    Console.WriteLine("");
    Console.WriteLine($"The even element quantity is: {result}");
}

showTask34Answer();
Console.WriteLine("End task 34");
Console.WriteLine("");
//Task 36
Console.WriteLine("Task 36");

 int sumOddValues(int[] array) {
    int sum = 0;
    Console.WriteLine("Value on even index positions:");
    for (int i = 1; i < array.Length; i += 2) {
            Console.Write($"{array[i]} ");
            sum += array[i];
        
    }
    return sum;
 }

void showTask36Answer() {
    int[] randomArray = generateRandomArray();
    showArray(randomArray);
    Console.WriteLine("");
    int result = sumOddValues(randomArray);
    Console.WriteLine("");
    Console.WriteLine($"The answer is: {result}");
}

showTask36Answer();
Console.WriteLine("End task 36");
Console.WriteLine("");
//Task 38
Console.WriteLine("Task 38");
//How to write universal show method, here I have to modify "show array" method from int to double?
void showDoubleArray(double[] array) {
        Console.WriteLine("Array elements: ");
        for(int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}

double[] generateDoubleArray() {
    Console.WriteLine("Enter array size:");
    int arraySize = getIntData();
    double[] array = new double[arraySize];

    for (int i = 0; i < arraySize; i++) {
        double randaomValue = new Random().Next(10, 100);
        double decimalPart = new Random().NextDouble();
        double roundedDecimalPart = Math.Round(decimalPart, 2);
        array[i] = randaomValue + roundedDecimalPart;
    }

    return array;
}

double findMaxValue(double[] array) {
    int maximum = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[maximum] < array[i]) {
            maximum = i;
        }
    }
    return array[maximum];
}

double findMinValue(double[] array) {
    int mininmum = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[mininmum] > array[i]) {
            mininmum = i;
        }
    }
    return array[mininmum];
}

double findDifference() {
    double[] array = generateDoubleArray();
    showDoubleArray(array);
    double minimum = findMinValue(array);
    double maximum = findMaxValue(array);
    Console.WriteLine(' ');
    Console.WriteLine($"Minimum is: {minimum}, maximum is: {maximum}");
    return Math.Round((maximum - minimum), 2);
}

Console.WriteLine($"Difference: {findDifference()}");
Console.WriteLine("End task 38");


// double[] sortArray(double[] array) {
//     for (int i = 0; i < array.Length - 1; i++) {
//     int minimumIndex = i;
//         for(int j = i + 1; j < array.Length; j++){
//            if(array[j] < array[minimumIndex]) {
//             minimumIndex = j;     
//         }
//         double temporary = array[i];
//         array[i] = array[minimumIndex];
//         array[minimumIndex] = temporary;
//         }
//     }
//     return array;
// }
// double[] sorted = sortArray(result);
// showDoubleArray(sorted);