# SampleCodeMultiWPFAppsShareMemory
I wrote this block of code to put in a WPF App, then to run multiple instances of the app from the command prompt to see if each instance shared any memory with the other.  They don't.

To use this. Create a new WPF C# app in Visual Studio.
Paste all of this code in to App.xaml.cs, and change the namespace to match the namespace of your app.
Then open at least 2 command prompts and navigate to the bin\debug folder where you have compiled this project and
run the app with two different parms, such as "wpfapp3 test" and in the other command window "wpfapp3 try".
Then go watch the changes as they occur in log.txt.
