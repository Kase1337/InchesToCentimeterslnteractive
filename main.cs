using System;

class Program {
  public static void Main (string[] args) {
    
    //declare the required variables
    double Measurement_in_inches  = 2.54;
    int Input_value;

    // Prompt the user to enter a measurement in inches
    Console.Write("Enter a measurement in inches: ");
    
    // Read and convert the entered value to string
     Input_value = Convert.ToInt32(Console.ReadLine());
    
    // convert inches to centimeters aka multiply the entered value by 2.54.
    double centimeters = Input_value  * Measurement_in_inches;

    // output the result of the conversion to the console.
   Console.WriteLine((Input_value ) + " inches is "+ (centimeters)+ " centimeters");
   

   
    }
}