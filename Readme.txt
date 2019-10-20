Everything that I wrote in this text file have been implemented. 

The tool Menue have two options one for controlling the random and the second option is to setup the Universe size and the colors. 

You can by open a file from life lexicon and import the patterns using the open botom.

Render Conway’s Game of Life in a .NET application. A grid should be rendered representing the individual cells. Cells can be turned on and off by clicking on them with the mouse. Once a group of cells are turned on and the game runs they should live or die according the 4 rules of the game.

Start, Pause and Next menu items and tool strip buttons. The game should start running by clicking on a Start menu item or a tool strip button. The game should be pause by clicking on a Pause menu item or a tool strip button. If currently paused, the game can be advanced 1 generation by clicking on a Next menu item or a tool strip button. 

Randomizing the universe. The current universe can be randomly populated from time or from a seed variable. The user should be able to edit the seed variable through a dialog box. Randomizing should occur when a menu item is clicked on. 

Emptying the universe. The universe should be emptied of all living cells through a New or Clear menu item. 

Saving the current universe to a text file. The current state and size of the universe should be able to be saved in PlainText file format. The file name should be chosen by the user with a save file dialog box. 

Opening a previously saved universe. A previously saved PlainText file should be able to be read in and assigned to the current universe. Opening should also resize the current universe to match the size of the file being read. 

Show the current generation. The current generation should be able to be displayed in a status strip. 

Show the current number of living cells. The current number of living cells should be displayed in a status strip. 

Controlling how many milliseconds between new generations. The number of milliseconds between new generations should be adjustable through a dialog box. 

Controlling the current size of the universe. The width and height of the current universe should be able to be chosen through a modal dialog box. 

Displaying the neighbor count in each cell. Render the neighbor count for each individual cell. The user should be able to toggle this feature on and off using the View menu. 


ADVANCED FEATURES 

-Importing patterns downloaded from Life Lexicon. PlainText life patterns can be down loaded from the Life Lexicon website and then imported into the current universe. Importing differs from Opening in that the size of he current universe is not changed based on the size of the file being imported. Also, importing will not empty the universe before it read in the file.
-Game Colors. The user should be able to select individual colors for the grid, the background and living cells through a modal dialog box.
-Universe boundary behavior. The user should choose how the game is going to treat the edges of the universe through a modal dialog box. The two basic options would be toroidal (the edges wrap around to the other side) or finite (cells outside the universe are considered dead.) Note: the demo implements a 3rd boundary type called infinite. This is not a feature you are responsible for! 