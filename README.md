# Static Testing

#####Check of Code Conventions in my code.
*Changelog*

<pre>
- Added dots at the end of comments.
- Capitalized some of the comments.
- Added exception handling, for values outside of scope. (Negative or 0 length for sides).
- Removed instance field _type in Triangle. Ended up not using it.
</pre>

#####Result of Calculated Code Metrics Analysis.

<pre>
Project: Triangles
Configuration: Debug
Scope: Project
Assembly: C:\...\Projects\Triangles\Triangles\bin\Debug\Triangles.exe
Maintainability Index: 77
Cyclomatic Complexity: 20
Depth of Inheritance: 1
Class Coupling: 3
Lines of Code: 32
</pre>

####Søren's Review
<pre>
<b>Review of Martin’s code</b>
<i>Nice, readable and well commented.</i>

<b>Triangle (5D, 5D, 5)</b>
<i>I was able to create a triangle with the sides 5D, 5D & 5, thinking this have to do with using doubles in
order to have decimal numbered sides.
I’m not sure it’s an issue, but I thought I’d mention it. A person without programming experience might
get confused by it.</i>
<b>Redundant else-statements</b>
<i>- In GetTriangleType() each statement contains a return, meaning that boolean true would would exit the
method. Since the method ends upon entering the proper bool, there’s no need for else if/else, and it
could be made to if instead.</i>
<b>No readline?</b>
<i>You ask much of me to click ctrl + F5 and run it without debugger for it not to close, too much good sir!</i>
</pre>

##### Code Standard Documentation
<pre>
Generally follow Microsoft Coding Conventions for C#:
https://msdn.microsoft.com/en-us/library/ff926074.aspx

<i>Most importantly follow Naming and Layout Conventions</i>
</pre>



>Below is original Readme before revisions

# Test Cases (on paper)

## Test cases for Triangles. 
>Rules:
<pre>
 **scalene** No sides are equal length
 **isosceles** 2 out of 3 sides are equal length
 **equilateral** all sides are equal length
 </pre>

###Successful

<pre>
<b>Triangle1:</b>  SideA:5 SideB:5 SideC:5  <i>Result: equilateral</i>
<b>Triangle2:</b>  SideA: 3 SideB: 10 SideC: 3 <i>Result: isosceles </i>
<b>Triangle3:</b>  SideA: 5 SideB: 6 SideC: 1  <i>Result: scalene </i>
<b>Triangle4:</b>  SideA: 1,5 SideB: 2 SideC: 1  <i>Result: scalene </i>
</pre>
###Unsuccessful
>These would be incorrect results of test

<pre>
<b>Triangle5:</b>  SideA: 1,5 SideB: 1,7 SideC: 5  <i>Result: isosceles</i> <b><i> Should be scalene</b></i>
<b>Triangle6:</b>  SideA: 10 SideB: 10,0 SideC: 10,00  <i>Result: scalene</i> <b><i> Should be equilateral</b></i>
<b>Triangle7:</b>  SideA: 11 SideB: 1,1 SideC: 1,1  <i>Result: equilateral</i> <b><i>Should be isosceles </b></i>
</pre>

