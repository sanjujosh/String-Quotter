# String-Quotter

String-Quotter is a handy stand-alone tool to add quotes to SQL queries. Simply paste the string and hit the button. Processed output is copied to clipboard, ready to paste. 
  - Add quotes and comma around strings
  - Support varchar and numbers
  - Automatically copy to clipboard, ready to paste. 
  - Output in one line or many lines. 
  - Stand-alone - no installation required. 

### Installation

Download the String-Quotter.exe from [\bin\Release](https://raw.githubusercontent.com/sanjujosh/String-Quotter/master/LifeIsMiserable/bin/Release/String-Quotter.exe) folder 

### What you get
![Image of String-Quotter](https://i.imgur.com/wpfE0OT.png)

Input Varchar:
```
one
two
three
```

Output:
```
(
 'one', 
 'two', 
 'three'
 )
```
Input Number:
```
1999
2999
3999
```

Output:
```
(
 1999, 
 2999, 
 3999
 )
```

### Development

I have created this atrocity using Visual Studio 2010. Import the project to any version of VS with support for c#. This was created when I was drunk and depressed, be wary of potential bugs.   

License
----
MIT

