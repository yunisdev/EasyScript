<head>
    <!--<link rel="icon" type="image/png" href=""> -->
<style>
.page-header{
    background-color:linear-gradient(120deg, #155799, #159957);
}

</style>
</head>
EasyScript is a simple JavaScript based programming language for beginners which is created by Yunis Huseynzade.
JavaScript,C#,HTML and CSS has used for this project.
Core of library has written in JavaScript . But UI and some little functions written in C# . HTML and CSS is used for visual output . 

## Hello World
```javascript
write("Hello World!!!");
//or
writeln("Hello World!!!");
```

## Basic Syntax
Syntax of EasyScript is not hard to learn . Mostly looks like JavaScript.
Example:
```javascript
function hello(a,b){
    if(a>b){
        msbox("Hello. You had entered "+a+" and "+b);
    }
}
```
## Objects , functions and methods

#### msbox() function
msbox() function shows a message box on the screen.
There is only one parameter : **text**

**text** - accepts string.Example "Hello World!!!"
```javascript
msbox("Test"); //Show an alert which has "Test"text
```

#### getDate() function
getDate() function returns current date
```javascript
//We will accept default date as 21 October 2019
writeln(getDate()); //Output: 21/10/2019
```
There are two optional parameters : **format** and **seperator**

**format** - accepts string . Example: "dmy". <br>
You can use *y*(year) , *m*(month) , *d*(day) , *w*(day of week with an integer) letters for this parameter.
Example *"dmy"* means *day,month,year*.
```javascript
writeln(getDate("mdy")); //Output: 10/21/2019
//or you can get only one date
writeln(getDate("y"));   //Output: 2019
```
**seperator** - accept string . Example: "/".
```javascript
writeln(getDate("dmy",":")); //Output: 21:10:2019
```

## math object
With math object you can...
##### ...get value of pi
```javascript
writeln(math.PI); //Output: 3.1415926535897932384626433832795

writeln(math.pi); //Output: 3.14
```
##### ...find factorial
```javascript
writeln(math.factorial(5)); //Output: 120
```
##### ...power
```javascript
writeln(math.power(2,3)); //Output: 8
```
##### ...find square root
```javascript
writeln(math.sqrt(4));  //Output: 2
```
##### ...get value of sin,cos,tg,ctg
```javascript
writeln(math.sin(45));  //Output: 0.8509035245341184
writeln(math.cos(45));  //Output: 0.5253219888177297
writeln(math.tg(45));   //Output: 1.6197751905438615
writeln(math.ctg(45));  //Output: 0.6173696237835551
```

## style object
