# Pierre's Bakery

#### Test-Driven Development with C# Exercise for Epicodus 07.17.2020

### By Kate Skorija

## Description

This is a C# console application that takes a user's order for bread and pastries from Pierre's Bakery. The application returns the total cost of the order, taking into account any deals that may be available.

## Specifications

**Behavior**: Program will offer a welcome message to the user that describes the cost of bread and pastries from Pierre's Bakery.
  * Input: `dotnet run`
  * Output: "Welcome to Pierre's Bakery. Loaves of bread cost $5, and pastries cost $2 each."

**Behavior**: Program will take an input for how many loaves of bread the user would like.
  * Output: "How many loaves of bread would you like?"
  * Input: "2"

**Behavior**: Program will take an input for how many pastries the user would like.
  * Output: "How many pastries would you like?"
  * Input: "3"

**Behavior**: Program will return the total cost of the order.
  * Input: "2" & "3"
  * Output: "Your total comes to $16."

**Behavior**: Program will offer a Buy 3 for $5 Deal for pastries.
  * Input: "2" & "3"
  * Output: "With our Buy 3 for $5 Pastry Deal, your revised total is $15."

**Behavior**: Program will allow user to add more loaves or pastries before 'checkout'.
  * Output: "Would you like to add anything to your order?"
  * Input: "0" & "1"

**Behavior**: At checkout, program will add any extra loaves of bread, since for every 2 loaves they get one for free.
  * Input: User is finished ordering.
  * Output: Loaves of Bread is updated from 2 to 3. 

**Behavior**: After user is finished adding any additional items, program will display total loaves, pastries, and price.
  * Input: User is finished ordering.
  * Output: "Loaves of Bread: 3, Pastries: 3, Total Price: $15"


## Setup/Installation Requirements

1.  Navigate to the [Bakery.Solution respository](https://github.com/kate-skorija/Bakery.Solution) or open your terminal

2. Clone this project using the GitHub button or the command:
`$ git clone https://github.com/kate-skorija/Bakery.Solution.git`

3. Navigate to the `Bakery.Solution` directory in your editor of choice, or use [Visual Studio Code](https://code.visualstudio.com/)

5. Within the project, navigate to the Bakery directory, and type `dotnet run`. This will open the interactive console app. There will be several lines of introductory material. Press 'Enter' to navigate through the welcome information.

6. If you wish to test the code, navigate to the Bakery.Tests directory. In the terminal type `dotnet restore`, then `dotnet test`.

## Known Bugs

There are no known bugs at this time.

## Support and Contact Details

If there are any issues or questions, please reach out to me through [my GitHub account](https://github.com/kate-skorija).

## Technologies Used

*  [Visual Studio Code](https://code.visualstudio.com/)
*  [Markdown](https://daringfireball.net/projects/markdown/)
*  [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)

### License

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright (c) 2020 **_Kate Skorija_** 