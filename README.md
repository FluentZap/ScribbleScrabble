# _Scrabble Word Score_

#### _Testing class practice, 04.25.2019_

#### By _**Lindsey Baker & Todd Aden**_

## Description

_This application will take a word and return the amount of points that it is worth based on the game Scrabble_

## Setup/Installation Requirements

* _Clone Repository_
* _Compile in C# .Net Core 2.2_

Build a Dictionary with char letter and int score as a lookup table.

Go through BDD and make sure it passes all tests

Test for incorrect inputs and handle them send error message but still return first word. Convert to lowercase for testing. Hyphens count as a space.

A for loop to check each char in the string and add the score to a value. return value to user.

|Letter|Score|
|-|-|
|A, E, I, O, U, L, N, R, S, T | 1 |
|D, G | 2|
|B, C, M, P | 3|
|F, H, V, W, Y | 4|
|K | 5|
|J, X | 8|
|Q, Z | 10|


|Behavior|Input|Output|
|-|-|-|
|User sends a letter and gets back a score|"F"| 4 |
|Input a letter and return regardless of case |"f"|4|
|Input a string of letters |"apple"|9|
|Input ignores special characters | "H@xz0r3z"|33|
|Input stops at a space and only returns the first word| "Apple Juice"|9|
|Input treats a hyphen as a space| "Apple-juice"|9|


## Known Bugs

__

## Support and contact details

_Please contact us with any questions_

## Technologies Used

_C# .NET Core 2.2_


### License

*This software is licensed under the MIT license.*
Copyright (c) 2019 **Lindsey Baker & Todd Aden**
