### Game.cs
Entry point into the game

### PlayGame.cs
- **PlayGame()**: This will create an instance of the battleship game and runs the functionality of the game by combinding all necessary methods

### BaseShip.cs
This is the base class for all ships within the game
- **Property ShipHealth:** Sets the health of the ship, basically the amount of times it can be hit before destoryed, set to protected because no one outside this class needs to alter it
- **Property ShipType:** For displaying the type to the user, user does not need to set this
- **Property AbbrShipType:** For displaying the placement on the board, user does not need to set this
- **ShipDestroyed();** Will determin if a ship is destoryed or not, needs to be implemented
- ShipHit(); Decrements the ship's health to 0 on each successful hit, needs to be implemented

### Battleship.cs
A subclass to BaseShip.cs
- **Property ShipHealth:** Set to protection so only the class can access it, and override so it can set its own health
- **Property ShipType:** Overrides to its proper ship type
- **Property AbbrShipType:** Overrides to its proper type

### Board.cs
Handles the drawing of the board, holds the placement of ship, and holds all the hits and misses a player makes.
- **Board():** When the object is instantiated it automatically formats the array to the proper game board design
- **SetCoordinate():** Called when the specific array index needs to be set with the ship, a hit, or a miss
- **Playerboard():** Draws a board for the player to see where their ships are and to see their hits and misses

### Carrier.cs
A subclass to BaseShip.cs
- **Property ShipHealth:** Set to protection so only the class can access it, and override so it can set its own health
- **Property ShipType:** Overrides to its proper ship type
- **Property AbbrShipType**: Overrides to its proper type

### Cruiser.cs
A subclass to BaseShip.cs
- **Property ShipHealth:** Set to protection so only the class can access it, and override so it can set its own health
- **Property ShipType:** Overrides to its proper ship type
- **Property AbbrShipType:** Overrides to its proper type
   - Marked with a lower case c to differentiate more clearly from carrier ship
   
### Destroyer.cs
 A subclass to BaseShip.cs
- **Property ShipHealth:** Set to protection so only the class can access it, and override so it can set its own health
- **Property ShipType:** Overrides to its proper ship type
- **Property AbbrShipType:** Overrides to its proper type

### Menu.cs
Presents the user a list of choices
- **StartGameChoice():** If yes it returns true, if no the game will exit

### Player.cs
This is where methods are made for players to interact in the game
- **SetShip():** Takes four parameters, two ints to hold the array index, the charater for the array to hold and display on the screen, then a direction for the ship to be created, this shortens the amount of user input byt simply setting the intial spot on the map and saying which way the way the ship to go.
- **FireOnShip():** Players will be punching in coordinates to set the array index, and if that array idex hold a value other than ~ then it's a hit.
   - Still needs implementing 

### Submarine.cs
 A subclass to BaseShip.cs
- **Property ShipHealth:** Set to protection so only the class can access it, and override so it can set its own health
- **Property ShipType:** Overrides to its proper ship type
- **Property AbbrShipType:** Overrides to its proper type

### UserInput.cs
Used to obtain strings and ints from the user

### WriteText.cs
Handles are the text being displayed to the screen
