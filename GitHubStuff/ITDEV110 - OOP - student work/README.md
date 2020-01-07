ITDEV110 Introduction to Object-Oriented Programming
------
### MATC Fall 2017

This course introduces the fundamental concepts of programming from an object-oriented perspective.  Topics include class design, simple data types, control structures, storage allocation, scope, and simple data structures (arrays).  Students will develop algorithms to solve programming problems and use debugging techniques to test their solutions.  The course emphasizes good software engineering principles while developing fundamental programming skills in the context of a language that supports the object-oriented paradigm.  Emphasis will be placed on class design, implementation and problem solving.

Assignments
------
[<img src="https://github.com/favicon.ico" alt="Assignment 1" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_MyFirstApp/dalsantoMyFirstApp "Assignment 1")&nbsp;
**My First App**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*C# Hello World*

[<img src="https://github.com/favicon.ico" alt="Assignment 2" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_Assignment2/dalsanto_Assignment2 "Assignment 2")&nbsp;
**Assignment 2**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Constructors, Methods & DateTime*

[<img src="https://github.com/favicon.ico" alt="Assignment 3" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_Tipper/dalsanto_Tipper "Assignment 3")&nbsp;
**Tipper**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Very basic Tip calculation app.*

[<img src="https://github.com/favicon.ico" alt="Assignment 4" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_VTipper/dalsanto_VTipper "Assignment 4")&nbsp;
**VTipper**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*More advanced Tip app.  Demonstrates what we've learned about variable manipulation thus far.*

[<img src="https://github.com/favicon.ico" alt="Assignment 5" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_PracticeObjects/dalsanto_PracticeObjects "Assignment 5")&nbsp;
**Practice Objects**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*App demonstrating how Class Objects work.*

[<img src="https://github.com/favicon.ico" alt="Assignment 6" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_InsertFunOO/dalsanto_InsertFunOO "Assignment 6")&nbsp;
**Insert Fun**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Mad Libs.  The console UI turned out really well.  This is the first opportunity I had to play with console UI design after discovering how to use Console.ReadKey().*

[<img src="https://github.com/favicon.ico" alt="Midterm" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_MidTerm/dalsanto_MidTerm "Midterm")&nbsp;
**Midterm App**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Bowling Scores app with sound.  Demonstration of MVC: Model, View, Control.*

[<img src="https://github.com/favicon.ico" alt="Assignment 7" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_HighLow/dalsanto_HighLow "Assignment 7")&nbsp;
**High Low**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Guess the number type app.*

[<img src="https://github.com/favicon.ico" alt="Assignment 8" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_HighLow%202/dalsanto_HighLow "Assignment 8")&nbsp;
**High Low 2**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Adds the ability to bet on your guess to the previous assignment.*

[<img src="https://github.com/favicon.ico" alt="Assignment 9" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_Bester/dalsanto_Bester "Assignment 9")&nbsp;
**Bester**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Dice rolling game.  UI mimics dice rolling with James Bond themed sound.*

[<img src="https://github.com/favicon.ico" alt="Assignment 10" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_GuessTheWord/dalsanto_GuessTheWord "Assignment 10")&nbsp;
**Guess the Word**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Hangman type game.*

[<img src="https://github.com/favicon.ico" alt="Individual Project" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_cSHARPalaga/ProjectConceptApp "Individual Project")&nbsp;
**Individual Project - C#alaga**

<table border="0" cellspacing="0" cellpadding="0">
  <tr> 
    <td width="200">
      <p align="left">
        <b>YouTube Demo Video</b><br>
        <a href="https://www.youtube.com/watch?v=90sr2_ausbM" title="YouTube C#alaga Demo"><img src="https://img.youtube.com/vi/90sr2_ausbM/0.jpg" alt="YouTube C#alaga Demo" height="150" width="200"></a>
      </p>
    </td>
    <td valign="top">
      <p>
        <br>
        <i>Galaga imitation written in C# console.  This took about 1 1/2 months to write.  The program relies on quite a few parallel arrays as we weren't shown object arrays in the course.  The inspiration for it was to create an app that allowed for asynchronous tasks(this wasn't shown in the course and was pieced together from Microsoft docs and the odd Stack Overflow entry.)</i>
      </p>
    </td>
  </tr>
</table>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*The game itself runs on it's own task while a keyboard listener runs on another.  The game is run from a game class that is instatiated from the base class that monitors keystroaks and passes them to the main game loop.  The main game loop uses Unix Epoch based timer throttles to operate events in one task while it waits for a user to enter input via the keyboard.  Collision logic is factored by assigning each actor an x/y position that determines their console writeline position and gives them a 'hitbox' to allow for actors to have more than one character representing them.  Each actor(besides the player) behaves differently and independantly depending on an index number given to it(enemies, powerups, projectiles).  Cumbersome, but works with what logic was made available in the course.*

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*App as it is needs refactoring, but I can't understate how proud I was to get this thing working.*

[<img src="https://github.com/favicon.ico" alt="Final" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming/tree/master/dalsanto_FinalExam/dalsanto_FinalExam "Final")&nbsp;
**Final App**\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;*Student 'database' with console UI.*

<br/>

Milwaukee Area Technical College
------
### IT, Web and Software Developer
#### Fall 2017
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="ITDEV110 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/ITDEV110-Intro-to-Object-Oriented-Programming "ITDEV110 GitHub Repository")&nbsp;
ITDEV110 - *Introduction to Object-Oriented Programming*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="ITDEV117 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/ITDEV117-Logic-and-Problem-Solving "ITDEV117 GitHub Repository")&nbsp;
ITDEV117 - *Logic and Problem Solving*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="IT107 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/IT107-Social-Networking-and-Business "IT107 GitHub Repository")&nbsp;
IT107 - *Social Networking and Business*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="VICOM128 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/VICOM128-Web-Development-with-HTML-CSS "VICOM128 GitHub Repository")&nbsp;
VICOM128 - *Web Development with HTML/CSS*

#### Spring 2018
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ECON201 - *Principles of Microeconomics*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="ITDEV115 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/ITDEV115-Intermediate-Object-Oriented-Programming "ITDEV115 GitHub Repository")&nbsp;
ITDEV115 - *Intermediate Object-Oriented Programming*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="ITDEV140 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/ITDEV140-Programming-with-Java "ITDEV140 GitHub Repository")&nbsp;
ITDEV140 - *Programming with Java*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="ITDEV150 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/ITDEV150-Database-Management-with-SQL "ITDEV150 GitHub Repository")&nbsp;
ITDEV150 - *Database Management with SQL*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="ITDEV160 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/ITDEV160-Web-Programming-With-Scripts-JavaScript "ITDEV160 GitHub Repository")&nbsp;
ITDEV160 - *Web Programming with Scripts JavaScript*

#### Fall 2018
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="ITDEV161 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/ITDEV161-Web-Programming-1 "ITDEV161 GitHub Repository")&nbsp;
ITDEV161 - *Web Programming 1*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="ITDEV162 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/ITDEV162-Client-Server-and-E-Commerce-Implementation "ITDEV162 GitHub Repository")&nbsp;
ITDEV162 - *Client/Server & E-Commerce Implementation*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="ITDEV177 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/ITDEV177-Systems-Analysis-and-Design "ITDEV177 GitHub Repository")&nbsp;
ITDEV177 - *Systems Analysis and Design*

#### Spring 2019
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ITDEV198 - *Internship([iStream Financial Services](https://www.istreamfs.com/ "iStream Financial Services"))*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="ITDEV154 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/ITDEV154-Data-Structures-and-Programming "ITDEV154 GitHub Repository")&nbsp;
ITDEV154 - *Data Structures and Programming*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="ITDEV164 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/ITDEV164-Web-Programming-2 "ITDEV164 GitHub Repository")&nbsp;
ITDEV164 - *Web Programming 2*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[<img src="https://github.com/favicon.ico" alt="ITDEV199 GitHub Repository" width="18" height="18">](https://github.com/sudoSanto/ITDEV199-Integrated-Project "ITDEV199 GitHub Repository")&nbsp;
ITDEV199 - *Integrated Project*

#### University of Milwaukee Transfer Credits
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SPEECH212 - *Introduction to Theater*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;MATH202 - *Trigonometry*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;NATSCI184 - *Plant Biology*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;PSYCH231 - *Introductory Psychology*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;SOCSCI299 - *Elective - UWM, ARTHIST470 - Topics in American Art: American Woman Artists*\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;COMART103 - *Creative Design & Composition*

---
[<img src="https://github.com/sudoSanto/sudoSantoMedia/blob/master/sudoSantoLogoFull.png" alt="Portfolio" height="75">](https://sudosanto.github.io/ "Portfolio")
[<img src="https://github.com/sudoSanto/sudoSantoMedia/blob/master/linkedInIconL.png" alt="LinkedIn" width="25" height="25">](https://www.linkedin.com/in/matthew-j-dalsanto/ "LinkedIn")&nbsp;
[<img src="https://github.com/sudoSanto/sudoSantoMedia/blob/master/twitterIconL.png" alt="@sudoSanto" width="25" height="25">](https://twitter.com/sudoSanto "@sudoSanto")&nbsp;
