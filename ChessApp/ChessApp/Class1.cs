using System;

public class Example
{
   public static void Mafxvxcvin()
   {
      // Save colors so they can be restored when use finishes input.
      ConsoleColor dftForeColor = Console.ForegroundColor;
      ConsoleColor dftBackColor = Console.BackgroundColor;
      bool continueFlag = true;
      Console.Clear();

      do { 

        
         Console.WriteLine();
         Console.Write("Enter a message to display: ");
         String textToDisplay = Console.ReadLine();
         Console.WriteLine();

         Console.ForegroundColor = ConsoleColor.White;
         Console.BackgroundColor = ConsoleColor.Gray;
         Console.WriteLine(textToDisplay);

         Console.ForegroundColor = ConsoleColor.DarkGray;
         Console.BackgroundColor = ConsoleColor.Black;
         Console.Clear();
      } while (continueFlag);
   }

   private static Char GetKeyPress(String msg, Char[] validChars) 
   {
      ConsoleKeyInfo keyPressed;
      bool valid = false;

      Console.WriteLine();
      do {
         Console.Write(msg);
         keyPressed = Console.ReadKey();
         Console.WriteLine();
         if (Array.Exists(validChars, ch => ch.Equals(Char.ToUpper(keyPressed.KeyChar))))           
            valid = true;

      } while (! valid);
      return keyPressed.KeyChar; 
   }
}