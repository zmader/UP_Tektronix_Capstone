# This python script generates a random integer ranging from 0 to 100.
# By: Kyle Sanchez

import random

def generateRandomInt():
    # Create a randomInt variable from the range 0 to 100
    randomInt = random.randint(0, 100)

    print(randomInt)
    #return randomInt

# Call the randomInt function defined above
if __name__ == '__main__':
    generateRandomInt()
   
