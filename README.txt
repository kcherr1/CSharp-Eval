What is C# Eval?
CSharp Eval uses .NET Reflection to allow the user to execute arbitrary C# statements at runtime. It has access to the current environment and allows using variables and methods within that environment. It is comparable to having an eval function that comes with most scripting languages. CSharp eval can be used in any .NET project regardless of the language, however, it will only evaluate a string formatted as C# code. The ANTLR engine is used along with a custom grammar file designed to interpret many common C# constructs as well as some useful extensions to the language. This project can be used as is with minimal effort or as part of a larger project such as our XNA version, XNA Debug Terminal. Please note any license restrictions before using, however.

Who developed this and when?
CSharp Eval was developed by myself, Kevin Cherry, back in 2009. My friend and now co-owner, Timothy Wright, joined in 2010. It basically started with me learning .net reflections and knowing a lot about parsers and compilers. I started out just seeing if I could pull up the value of an arbitrary variable given as a string containing the name of the identifier, e.g. "sum" and "counter". Once I could pull up the value of any field I wanted from within the current scope, I set out to do more. Tim and I have now developed our own custom lexer, grammar, and framework for parsing many C# expressions. CSharp Eval started out as XNA Debug Terminal and now it is a separate component that can be used in any .Net application. So those using Visual Basic .Net and managed C++ are able to benefit from this project just fine.

Who can use it?
Anyone using Visual Studio may use this project. Note that this was designed in Visual Studio 2010 and hasn't been tested in other versions.

License Information
This program is protected under the Apache License Version 2.0. A copy of this license is also included in all version downloads in a file called COPYING.
