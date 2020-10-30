## Classes and Objects

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
		

		
4) It supports:- <br/>
     1) <h3>Constructors </h3>
     2) <h3>Inheritance	 </h3>
     3) <h3>Encapsulation</h3>
     4) <h3>Abstaction</h3>


5) #### Static Keyword
   1) Static Class and Static Class members
   2) To represent the concept of <b><i><a href="singleton">Singleton Pattern</a></i></b> <br/>
   2)  
   


   
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


## Object Oriented Programming Concepts (OOP)
1) Inheritance: (Somewhat done)
2) Encapsulation:
     1) Hiding details and providing common interfaces is called encapsulation
     2) Sub-Topics
          1) Getters and Setters
				1) What is use of Getters and Setters?<br/>
                   Ans: If a class variable are defined as private we cannot
						modify them from outside of that class, we use 
						<b>Getters</b> to fetch that variable and <b>Setters</b> 
						to mutate the value of that variable
				
3) Abstraction:
     1) the concept of encapsulation is used to create abstract datatypes 
		 that should be possible to modify only through their external interface
	
	### Abstraction vs Encapsulation

4) Inner Classes (Basically Nested classes)
   5) 
	 


