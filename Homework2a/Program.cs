using Cards2;

// loop while there's more input
//string input = Console.ReadLine();

// Add your code between this comment
// and the comment below. You can of
// course add more space between the
// comments as needed

// declare a deck variables and create a deck object
// DON'T SHUFFLE THE DECK
Deck deck = new Deck();

// deal 2 cards each to 4 players (deal properly, dealing
// the first card to each player before dealing the
// second card to each player)
List<Card>[] playerHands = new List<Card>[4];
for (int i = 0; i < 2; i++)
{
    foreach (List<Card> playerHand in playerHands)
        playerHand.Add(deck.TakeTopCard());
}

// deal 1 more card to players 2 and 3
playerHands[1].Add(deck.TakeTopCard());
playerHands[2].Add(deck.TakeTopCard());

// flip all the cards over


// print the cards for player 1


// print the cards for player 2


// print the cards for player 3


// print the cards for player 4