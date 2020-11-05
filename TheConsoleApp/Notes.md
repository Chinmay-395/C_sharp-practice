# Classes and Objects

1) Explaination: https://www.geeksforgeeks.org/c-sharp-class-and-object/
2) Important:- <br/>
	<ol>
		<li>Pascal-Case: Naming conventions for classes and functions</li>
		<li>Camel-Case:  Naming conventions for function parameters</li>
	</ol>	

3) C# doesn't support pointers in order to maintain type safety and security.<br/>
	<b>BUT: </b> by using the unsafe keyword, you can define an unsafe context in which pointers can be used.
	for more info: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/unsafe-code-pointers/#:~:text=To%20maintain%20type%20safety%20and,which%20pointers%20can%20be%20used.&text=If%20you%20use%20unsafe%20code,security%20risks%20or%20pointer%20errors.

	### Pointers VS Reference
	https://www.geeksforgeeks.org/is-there-any-concept-of-pointers-in-java/#:~:text=C%2FC%2B%2B%20allows%20pointer%20arithmetic,to%20point%20to%20arbitrary%20addresses.&text=In%20Java%2C%20a%20reference%20points%20to%20one%20thing%20only.

4) It supports:- 
     1) Constructors 
     2) Inheritance	 
     3) Encapsulation
     4) Abstaction


5) #### Static Keyword
   1) Static Class and Static Class members
   2) To represent the concept of <b><i><a href="singleton">Singleton Pattern</a></i></b> <br/>
    
6) #### Classes and Structs in C#
    A <b><i>class</i></b> is a user-defined blueprint or prototype from which objects are created. Basically, a class combines the fields and methods(member function which defines actions) into a single unit.<br/>
	A <b><i>structure</i></b> is a collection of variables of different data types under a single unit. It is almost similar to a class because both are user-defined data types and both hold a bunch of different data types.<br/>
	for more info: https://www.geeksforgeeks.org/difference-between-class-and-structure-in-c-sharp/


<br/> <hr/>

## Methods
1) method overloading ==> same name diff parameters
2) #### What if you have varying number of paramters:-
	1) Then you can use arrays
    2) ###### The <b><i>param</i></b> modifer
       
	```
		public class Calculator
		{
			public int Add(param int[]numbers){}
		}

		//How to call
		var result = calculator.Add(new int[]{1,2,3,4});
		var result = calculator.Add(1,2,3,4);
	```
3) #### The Ref modifier
	When a variable is defined it belongs to a certain code-block
	but if we need to refernce a value from a particular method 
	we use this keyword
	<i>Note: Only use in a special circumstances</i>
	<br/>
	https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref#:~:text=When%20used%20in%20a%20method's,is%20made%20on%20the%20argument.
	<br/>
4) #### The Out modifier
   This is similar to "Ref Modifier" but this doesn't have to be initialized,
	it can return value thats of the modified parameter that has been 
	passed to it to a function when the function returns a value.
	<i>Note: Only use in a special circumstances</i>
	<br/>

<br/> <hr/>

# Object Oriented Programming Concepts (OOP)
1) ### Inheritance: 
	 1) <b><i>Note:</i></b> C# only supports single inheritance and not multiple.
	     Because of "Diamond Problem".(In python language 'super' keyword is used to solve this problem)
	 2) <b>BUT</b> we can still do multiple inheritance, we need to use [Interfaces](#interface).
         
2) ### Encapsulation:
     1) Hiding details and providing common interfaces is called encapsulation
     2) Sub-Topics
          1) Getters and Setters
				1) What is use of Getters and Setters?<br/>
                   Ans: If a class variable are defined as private we cannot
						modify them from outside of that class, we use 
						<b>Getters</b> to fetch that variable and <b>Setters</b> 
						to mutate the value of that variable
				
3) ### Abstraction:
     1) the concept of encapsulation is used to create abstract datatypes 
		 that should be possible to modify only through their external interface
	 2) Sub-Topics
		   1) ##### <a href="interface"><i>Interface</i>.</a>
				1) An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies)
				2) A language construct that is similar to a class (in terms of syntax)
					but is fundamentally different.
				3) It used to build loosely-coupled applications.
				4) by convention we name the interface starting with 'I'.
				5) Syntax:
					```
		   			// interface
		   			public interface Animal 
		   			{
		   				void animalSound(); // interface method (does not have a body)
		   				void run(); // interface method (does not have a body)
		   			}
					```			
				6) We need to create loosely-coupled applications, since if we need
					to change some elements of that classes then it has minimal
		   			impact on other classes
			2) ##### Abstract class
				1) An abstact class is incomplete and hence cannot be instantiated
                2) Abstract class can only be used as base class
                3) Abstract class cannot be sealed
                4) An abstract class may contain abstract members(methods,properties, indexers,events) but not mandatory
                5) <b><i>Note</i></b> A non-Abstract class derived from an abstract class must provide implementation for all inherited abstract memeber
                6) If a class inherits an abstract class, then;
                   7) Provide implementations for all the abstract members inheritde from base abstract
                   7) If the class does not wish to provide implementation for all the abstract members
						inherited from abstract class, then the class has to be marked as abstract.
			3) ###### Abstract classes vs Interfaces
				1) Abstract classes can have implementations for some of its members(Methods), but the interface can't have implementation for any of its memeber
                2) Interfaces cannot have fields whereas an abstract class can have fields.
                3) An interface can inherit from another interface only and cannot inherit from an abstract class, whereas an abstract class can inherit from another abstract class or another interface
                4) A class inherit from multiple interfaces at the same time, whereas a class cannot inherit from multiple classes at the same time.
                5) Abstract class members can have access modifiers whereas interface members cannot have access modifiers.
	### Abstraction vs Encapsulation

4) Inner Classes (Basically Nested classes)
   5) 
	 
<br/><hr/>
5) Topics that needs to be covered
   1) Anonymous function
   2) Lambda expression
   3) Arrow operator
   4) Type-Casting

