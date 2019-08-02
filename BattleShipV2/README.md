#### Game.cs
Entry point into the game

#### PlayGame.cs
- PlayGame(): This will create an instance of the battleship game and runs the functionality of the game by combinding all necessary methods

#### BaseShip.cs
This is the base class for all ships within the game
- Property ShipHealth: Sets the health of the ship, basically the amount of times it can be hit before destoryed, set to protected because no one outside this class needs to alter it
- Property ShipType: For displaying the type to the user, user does not need to set this
- Property AbbrShipType: For displaying the placement on the board, user does not need to set this
- ShipDestroyed(); Will determin if a ship is destoryed or not, needs to be implemented
- ShipHit(); Decrements the ship's health to 0 on each successful hit, needs to be implemented

#### Battleship.cs
A subclass to BaseShip.cs
- Property ShipHealth: Set to protection so only the class can access it, and override so it can set its own health
- Property ShipType: Overrides to its proper ship type
- Property AbbrShipType: Overridesto its proper type

#### Board.cs
Handles the drawing of the board, holds the placement of ship, and holds all the hits and misses a player makes.
- Board(): When the object is instantiated it automatically formats the array to the proper game board design
- SetCoordinate(): Called when the specific array index needs to be set with the ship, a hit, or a miss
- Playerboard(): Draws a board for the player to see where their ships are and to see their hits and misses
