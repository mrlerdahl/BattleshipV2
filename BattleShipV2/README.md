##### Game.cs
Entry point into the game

##### PlayGame.cs
- PlayGame(): This will create an instance of the battleship game and runs the functionality of the game by combinding all necessary methods

##### BaseShip.cs
This is the base class for all ships within the game
- Property ShipHealth: Sets the health of the ship, basically the amount of times it can be hit before destoryed
- Property ShipType: For displaying the type to the user, user does not need to set this
- Property AbbrShipType: For displaying the placement on the board, user does not need to set this
- ShipDestroyed(); Will determin if a ship is destoryed or not, needs to be implemented
- ShipHit(); Decrements the ship's health to 0 on each successful hit, needs to be implemented
