## Jim's Group Coding Task

Solution consists of 5 projects including 2 unit test projects.

Aim is to get right with the design. 
Aware of the fact that this is not a contest to build state of art or bullet proof calculator.

Application designed keeping following priciples inn mind. 
Take what varies and 'Encapsulate' it so it won't affect the Rest of the code.

Always program to an interface

## 1) CalculatorTest :30 min
Started with this application by writting unit tests first (TDD). 

## 2) Calculator:  45 min
Designed this to keep it as loose coupled as possible. Big fan of easy to extend and maintanable solution.

## 3) Lambda Function : 1:30
Did bit of browsing to go through some best practices and accessed online resources to build Lambda function.

Implemented dependancy injection by following below article.
https://garywoodfine.com/dependency-injection-in-aws-lambda/

Configured API Gateway as trigger to lambda function.

## 4) Lambda FunctionTest : 30 min
Straingt forward unit test, did not bothered add more tests as I am running out of time.

## 5) Console application : 10 min
Quick http client call demonstration

##Cons: 
More comments in the code and more unit tests with edge case scenarios.

Build pipeline to deploy Serverless function. 
Calculator commands are not user friendly. 
Calculator functionality is not bullet proof. No exception handling and logging.
Variable naming conventions are not consistent.
