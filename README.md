# Word Counter Application
## by Porter Savage

## Description
An application that allows the user to enter a word, then a sentace. The application will determine if the sentence the user entered has any matching words with the first word the user entered.

## Specifications

#### Behavior: "Checks if user input is a string"
* Input: "A"
* Output: True
* Input: 2
* Output: False
* This is if the user inputs anything other than a string, The program will not work.

#### Behavior: "takes user input, then takes user input for sentence." (single letters)
* Input: User inputs "A", User Inputs "A"
* Output: Match = 1
* This is if the user only enters one letter for the sentence input portion with only one possible match for the word input.

#### Behavior: "takes user input, then takes user input for sentence." (multiple words)
* Input: User inputs "A", User Inputs "At A park with A friend."
* Output: Match = 2
* This is if the user enters a small sentence for the sentence input portion with only a couple matches to the original word input.

#### Behavior: "takes user input, then takes user input for sentence." (full sentence with multiple matches)
* Input: User inputs "A", User Inputs "At A park with A friend then going to A movie." 
* Output: Match = 3
* This is if the user enters a long sentence with multiple matches to the original word input.

### Requirements Software

* Download .NET Core 1.1.4 SDK and .NET Core Runtime 1.1.2 and install them. Download Mono and install it.

### Setup Instructions
* Clone this repository: $ git clone repo name
* Change into the work directory:: $ cd WordCounter.Solution
To edit the project, open the project in your preferred text editor.

* To run the program, first navigate to the location of the WordCounter.cs file     then compile and execute: $ cd WordCounter/Models $ mcs WordCounter.cs; mono        WordCounter.exe;

* To run the tests, use these commands: $ cd WordCounter.Tests $ dotnet test

### Known Bugs
* no known bugs

### Languages/Libraries Used
* C#



Copyright (c) 2019 Porter Savage.
