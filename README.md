# Topic: Modularity
## Exercise3 : ref, out parameters

### Summary:
The 25-pair color code, is used to identify wires in telecommunications cables. Different codes are used for wire leads on devices such as transformers or in building wiring. For more details refer to [This Wiki](https://en.wikipedia.org/wiki/25-pair_color_code). 
There are 25 pairs of colors. 
 - Each pair number can be mapped to a pair of colors - a major color and a minor color
 - Each pair of colors can be mapped to the pair number it corresponds to

### Exercise Details:
During a desing and code review session, it was pointed out that throwing of exception is an expensive operation. 
Hystorically, Exception  ensures that code is forced to handle the situation whereas return codes can be ignored by the caller function. 
However the guidelines for when to use what is a long discussion topic and hence both these methods need to be used in the right context.
So the suggestion was to not remove throwing exception, but to follow a good design practice of providing a 'Try' equivalent of the operations.
This is similar to having different flavours of parsing a string to int as [in this blog post] (https://www.c-sharpcorner.com/article/uses-of-int-parse-convert-toint-and-int-tryparse/)

### Source code details:
 The implementation of this feature provides the above mentioned mapping between the pair number and the color pair. 

 ##### File Details:
| FileName | Description |
| ------ | ------ |
| ColorCoder.cs | Contains the implementation of the color coder |
| ColorPair.cs | Contains the ColorPair class implementation |
| ColorReader.cs | Contains the ColorReader helper class implementation |
| StringFormatter.cs | Contains the StringFormater helper class implementation |
| Program.cs | Entry point of the program, main method to test the functionality |

 ##### Class and Method Details:
| Entity | Name | Description |
| ------ | ------ | ------ |
| Class | Program | Provides the main method to test the functionality |
| Class | ColorCoder.cs | Provides the ColorPair coder feature functionality |
| Class | ColorReader.cs | Provides the functionality to initialize the color codes |
| Class | StringFormatter.cs | Provides helper functions for formatting the coded colors into display format |
| Class | ColorPair | Data type for encapsulating the major and minor color |
| Method | GetColorFromPairNumber | Given pair number return the 2 colors mapping to the number |
| Method | GetPairNumberFromColor | Given the colors, return the pair number corresponding to them |
| Method | ToString | Returns all the colours in displayable format |

### Reference
If interested, please go through the below links on try catch
- [Design guideline on throwing Exception ] (https://docs.microsoft.com/en-us/archive/blogs/kcwalina/design-guidelines-update-exception-throwing) 
- [Cost of throwing exception] https://docs.microsoft.com/en-us/archive/blogs/ricom/the-true-cost-of-net-exceptions-solution
- [Try-catch cost comparison] (https://buildplease.com/pages/slow-exceptions/#:~:text=Costs%20of%20Throwing%20Exceptions&text=The%20first%20cost%20comes%20from,from%20actually%20throwing%20the%20exception)



