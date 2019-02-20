# Calculator

Technical specifications:
The target platforms are UWP, Android and iOS. Xamarin.Forms and .NET Standard were used. The app was tested in Visual Studio Professional 2017 and in Visual Studio for Mac.

The application supports addition, subtraction, multiplication and division. The application is primarily driven by the UI.
Keyboard support not yet implemented.

All non-platform specific code are in the .NET Standard project. NUnit is the testing framework used.

MVVM pattern used for the presentation layer.

Reusable styles are stored away in a Resource Dictionary.



TODO: 
Precision of result display, 
Keyboard support, 
display the first number, operator and second number in very small font just above the result display,
look into changing string to StringBuilder in the CalculatorViewModel
Incorporate CE functionality (done)
Change "/" to "÷" (done)
