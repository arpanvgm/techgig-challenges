Game Center (100 Marks)
You and your friend go to a game arcade where you choose to play the game Lucky Pick. In the game, there is a square grid and on each block, some money is placed on it. When a player chooses a block, the machine randomly chooses a block from the neighboring ones and the chosen block (consider 8 neighborhood). The player is awarded the money that is placed on the block that the machine selects. Your friend needs help choosing the block.

Your job is to return the block position(s) that will maximize the minimum amount your friend will win for sure. If there are more than one such block positions then the output must return for all these positions.

Input Format
You will be given the Grid Description as -
The first line consists of the size of the square grid (N)
The next N lines each containing N numbers separated by '#', each number representing the amount of money put on that block


Constraints
1 < N < 500

Output Format
You need to print the array of string containing the position(s) of a block choosing which will give the maximum amount of money which your friend will definitely win.
