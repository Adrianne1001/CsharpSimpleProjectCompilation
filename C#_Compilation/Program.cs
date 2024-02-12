using C__Compilation.Lesson10_OOPBasics;
using C__Compilation.Lesson2_Variables_DataTypes;
using C__Compilation.Lesson3_BasicInput_Output;
using C__Compilation.Lesson4_Operators_Expressions;
using C__Compilation.Lesson5_ConditionalStatements;
using C__Compilation.Lesson6_SwitchStatements;
using C__Compilation.Lesson7_Loops;
using C__Compilation.Lesson8_Arrays;
using C__Compilation.Lesson9_Functions;



char choice;

VariablesDataTypes variablesDataTypes = new VariablesDataTypes();
BasicIO basicIO = new BasicIO();
OperatorsExpressions operatorsExpressions = new OperatorsExpressions();
ConditionalStatements conditionalStatements = new ConditionalStatements();
SwitchStatements switchStatements = new SwitchStatements();
Loops loops = new Loops();
Arrays arrays = new Arrays();
Functions functions = new Functions();
OOPBasics oOPBasics = new OOPBasics();





Console.WriteLine("-----------------------------------");
Console.WriteLine("C# Programming Tutorial Compilation");
Console.WriteLine("-----------------------------------");

Console.WriteLine("Please select what Specific topic you want to run");
Console.WriteLine("A.) Variables and Data Types");
Console.WriteLine("B.) Basic Input and Output");
Console.WriteLine("C.) Operators and Expressions");
Console.WriteLine("D.) Conditional Statements");
Console.WriteLine("E.) Switch Statements");
Console.WriteLine("F.) Loops");
Console.WriteLine("G.) Arrays");
Console.WriteLine("H.) Functions");
Console.WriteLine("I.) OOP Basics");


Console.Write("\nChoice : ");
choice = Convert.ToChar(Console.ReadLine());
Console.WriteLine("\n");


switch (choice.ToString().ToUpper())
{
    case "A":
        variablesDataTypes.main();
        break;

    case "B":
        basicIO.main();
        break;
    case "C":
        operatorsExpressions.main(); 
        break;
    case "D":
        conditionalStatements.main();
        break;
    case "E":
        switchStatements.main();
        break;
    case "F":
        loops.main();
        break;
    case "G":
        arrays.main();
        break;
    case "H":
        functions.main();
        break;
    case "I":
        oOPBasics.main();
        break;
    default:
        Console.WriteLine("Invalid Choice!");
        break;

}