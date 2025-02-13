Joseph Collado<br>
Homework 2 Part A for CSC 350H @ BMCC

Assignment Instructions:
  1. Download the following code: <a href="https://drive.google.com/file/d/1QNsAy9lvVEtayRuP-fpy5LrKGQ4hJuVG/view?usp=sharing">Program.cs</a>
  2. Replace the program.cs in your class project (with the DLL file) with the above code.
  3. Follow the instructions to complete the implementation.

Code Instructions:
  1. Create a Deck Object
  2. Deal 2 cards each to 4 players (round robin style)
  3. Deal an extra card to players 2 and 3
  4. Flip over everyone's cards
  5. Print out each player's hand

Implementation:
- Used an array of lists of Cards to store each player's hand
  - The amount of cards in a player's hand varies over time and per player, so a List is appropriate
  - The amount of players is constant (4), so an array is appropriate.
- Used foreach loops to iterate through both each player and each player's hand
