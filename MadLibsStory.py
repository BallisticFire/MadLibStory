#Init Variables
theMatrix = "" 
system = ""
neo= ""
enemy = ""
inside = ""
save = ""
unplugged = ""
fight = ""
profession =["","","",""]
adj =["",""]
#Get input from user
#Getting neo variable from user
print("Welcome user!")
print("Lets play a game of madLibs")
neo = input("Please share with me your name?\n")
#Getting matrix variable from user
theMatrix = input(f"Hello {neo} are you ready?\nWhat is something you want to know more about?\n")
print(f"Oooh! You want to learn more about {theMatrix} huh?")
#Getting system variable from user
system = input(f"Okay well first, tell me what you already know about {theMatrix} in one word (noun)\n")
#Getting enemy variable from user
enemy=input(f"Okay give me a opposing noun to {system}\n")
#Getting inside variable from user
inside = input(f"Now give me any relaxing noun (present tense)\n")
#Getting professions array from user
print(f"Okay, now I need four professions pertaining to {system}\n")
for i in range(len(profession)):#number they are on     #out of total
    profession[i]= input(f"Profession (plural) {i + 1} / {len(profession)}:\n")
# Getting the save variable
save = input(f"Give me a hero-related verb (present tense):\n")

# Getting the unplugged variable
unplugged = input(f"Now give me a verb that makes you think about relief (past tense):\n")

# Getting the adjectives
print(f"Lastly I need 2 dystopian adjectives:\n")

for i in range(len(adj)):
                #number they are on     #out of total
    adj[i] = input(f"Adjective {i+1} / {len(adj)}:\n ")
    
# Getting the fight variable
fight = input(f"& a verb:\n")
#Init story
madLibStory = (f"{theMatrix} is a {system}, {neo}.\n"+
f"That {system} is our {enemy}.\n"+
f"But when you're {inside}, you look around, what do you see?\n"+
f"{profession[0]}, {profession[1]}, {profession[2]}, {profession[3]}.\n"+
f"The very minds of the people we are trying to {save}.\n"+
f"But until we do, these people are still a part of that {system} and that makes them our {enemy}.\n"+
f"You have to understand, most of these people are not ready to be {unplugged}.\n"+
f"And many of them are so {adj[0]}, so hopelessly {adj[1]} on the {system}, that they will {fight} to protect it.\n")
#Print Story
print(madLibStory)
input()
