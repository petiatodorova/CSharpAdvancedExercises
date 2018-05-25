# Problem 1. Rage Expenses
==========================

As a MOBA challenger player, Pesho has the bad habit to trash his PC when he loses a game and rage quits. His gaming setup consists of headset, mouse, keyboard and display. You will receive Pesho`s lost games count. 
Every second lost game, Pesho trashes his headset.
Every third lost game, Pesho trashes his mouse.
When Pesho trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
Every second time, when he trashes his keyboard, he also trashes his display. 
You will receive the price of each item in his gaming setup. Calculate his rage expenses for renewing his gaming equipment. 
Input / Constraints
On the first input line - lost games count – integer in the range [0, 1000].
On the second line – headset price - floating point number in range [0, 1000]. 
On the third line – mouse price - floating point number in range [0, 1000]. 
On the fourth line – keyboard price - floating point number in range [0, 1000]. 
On the fifth line – display price - floating point number in range [0, 1000]. 
Output
As output you must print Pesho`s total expenses: "Rage expenses: {expenses} lv."
Allowed working time / memory: 100ms / 16MB.

## Examples
### Input
7
2
3
4
5

### Output
Rage expenses: 16.00 lv.

### Comments
Trashed headset -> 3 times
Trashed mouse -> 2 times
Trashed keyboard -> 1 time
Total: 6 + 6 + 4 = 16.00 lv;

### Input
23
12.50
21.50
40
200

### Output
Rage expenses: 608.00 lv.




# Second Task
=============


# Problem 3. Tseam Account
==========================

As a gamer, Pesho has Tseam Account. He loves to buy new games. You are given Pesho`s account with all of his games-> strings, separated by space. Until you receive "Play!" you will be receiving commands which Pesho does with his account.
You may receive the following commands:
Install {game}
Uninstall {game}
Update {game}
Expansion {game}-{expansion}
If you receive Install command, you should add the game at last position in the account, but only if it isn`t installed already.
If you receive Uninstall command, delete the game if it exists.
If you receive Update command, you should update the game if it exists and place it on last position.
If you receive Expansion command, you should check if the game exists and insert after it the expansion in the following format: "{game}:{expansion}";
Input
On the first input line you will receive Pesho`s account – sequence of game names, separated by space.
Until you receive "Play!" you will be receiving commands. 
Output
As output you must print Pesho`s Tseam account. 
Constraints
The command will always be valid.
The game and expansion will be strings and will contain any character, except '-'.
Allowed working time / memory: 100ms / 16MB.

## Examples

### Input
CS WoW Diablo
Install LoL
Uninstall WoW
Update Diablo
Expansion CS-Go
Play!

### Output
CS CS:Go LoL Diablo

### Comments
We receive the account => CS, WoW, Diablo
We Install LoL => CS, WoW, Diablo, LoL
Uninstall WoW => CS, Diablo, LoL
Update Diablo => CS, LoL, Diablo
We add expansion => CS, CS:Go, LoL, Diablo
We print the account.

### Input
CS WoW Diablo
Uninstall XCOM
Update PeshoGame
Update WoW
Expansion Civ-V
Play!

### Output
CS Diablo WoW




# Problem 4. MOBA Challenger
============================

Pesho is a pro MOBA player, he is struggling to become master of the Challenger tier. So he watches carefully the statistics in the tier.
You will receive several input lines in one of the following formats:
"{player} -> {position} -> {skill}"
"{player} vs {player}"
The player and position are strings, the given skill will be an integer number. You need to keep track of every player. 
When you receive a player and his position and skill, add him to the player pool, if he isn`t present, else add his position and skill or update his skill, only if the current position skill is lower than the new value.
If you receive "{player} vs {player}" and both players exist in the tier, they duel with the following rules:
Compare their positions, if they got at least one in common, the player with better total skill points wins and the other is demoted from the tier -> remove him. If they have same total skill points, the duel is tie and they both continue in the Season.
If they don`t have positions in common, the duel isn`t happening and both continue in the Season.
You should end your program when you receive the command "Season end". At that point you should print the players, ordered by total skill in desecending order, then ordered by player name in ascending order. Foreach player print their position and skill, ordered desecending by skill, then ordered by position name in ascending order.
Input / Constraints
The input comes in the form of commands in one of the formats specified above.
Player and position will always be one word string, containing no whitespaces.
Skill will be an integer in the range [0, 1000].
There will be no invalid input lines.
The programm ends when you receive the command "Season end".
Output
The output format for each player is:
"{player}: {totalSkill} skill"
"- {position} <::> {skill}"


## Examples
### Input
Pesho -> Adc -> 400
Gosho -> Jungle -> 300
Stamat -> Mid -> 200
Stamat -> Support -> 250
Season end

### Output
Stamat: 450 skill
- Support <::> 250
- Mid <::> 200
Pesho: 400 skill
- Adc <::> 400
Gosho: 300 skill
- Jungle <::> 300

### Comments
We order the players by total skill points descending, then by name. We print every position along its skill ordered descending by skill, then by position name.

### Input
Pesho -> Adc -> 400
Bush -> Tank -> 150
Faker -> Mid -> 200
Faker -> Support -> 250
Faker -> Tank -> 250
Pesho vs Faker
Faker vs Bush
Faker vs Hide
Season end

### Output
Faker: 700 skill
- Support <::> 250
- Tank <::> 250
- Mid <::> 200
Pesho: 400 skill
- Adc <::> 400

### Comments
Faker and Pesho don`t have common position, so the duel isn`t valid.
Faker wins vs Bush /common position: "Tank". Bush is demoted.
Hide doesn`t exist so the duel isn`t valid.
We print every player left in the tier.

