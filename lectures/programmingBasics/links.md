# Links

Js loops
https://dev.to/sylwiavargas/cheatsheet-js-loops-foreach-for-in-for-of-3hj2

## Codepen
[JS Playground](https://codepen.io/WolfsVeteran/pen/mdmpbNK)
[Variables 101](https://codepen.io/WolfsVeteran/pen/VwLjEzw?editors=0010)


# Mac
Open .zshrc (located at root folder (usually your mac's named folder))
Add the following to the bottom of the file (or create the file)
autoload -Uz vcs_info
zstyle ':vcs_info:*' enable git svn
zstyle ':vcs_info:git*' formats "- (%b) "
precmd() {
    vcs_info
}
setopt prompt_subst
prompt='HoneyBee@iMac 🐝: %~/ ${vcs_info_msg_0_}> '

# pythontutor links

cities forloop and conditional from main.js
https://pythontutor.com/visualize.html#code=var%20cities%20%3D%20%5B%22Birmingham%22,%20%22Austin%22,%20%22Seattle%22,%20%22Orlando%22%5D%0A%0A%0Afor%28var%20i%20%3D%200%3B%20i%20%3C%20cities.length%3B%20i%2B%2B%29%20%7B%20%0A%20%20%20%20if%28cities%5Bi%5D%20%3D%3D%20%22Austin%22%29%20%7B%0A%20%20%20%20%20%20%20%20console.log%28'4th%20loop%201st%20conditional',%20cities%5Bi%5D,%22Welcome%20to%20Texas%22%29%0A%20%20%20%20%7D%20%0A%20%20%20%20else%20if%20%28cities%5Bi%5D%20%3D%3D%20%22Seattle%22%29%7B%0A%20%20%20%20%20%20%20%20console.log%28'4th%20loop%201st%20conditional',%20cities%5Bi%5D,'Get%20ready%20for%20the%20rain'%29%0A%20%20%20%20%7Delse%20%7B%0A%20%20%20%20%20%20%20%20console.log%28'4th%20loop%201st%20conditional',%20cities%5Bi%5D,%22You%20have%20left%20the%20great%20state%20of%20Texas%22%29%0A%20%20%20%20%7D%0A%7D&cumulative=false&curInstr=22&heapPrimitives=nevernest&mode=display&origin=opt-frontend.js&py=js&rawInputLstJSON=%5B%5D&textReferences=false


for loop with sum example
https://pythontutor.com/visualize.html#code=var%20newSum%20%20%3D%200%0Afor%28var%20i%20%3D%201%3B%20i%20%3C%3D20%3B%20i%2B%3D2%29%20%7B%0A%20%20%20%20newSum%20%3D%20newSum%20%2B%20i%0A%20%20%20%20console.log%28'current%20value%20of%20i%20is%3A',%20i,%20'current%20sum%20is%3A',%20newSum%29%0A%7D&cumulative=false&curInstr=27&heapPrimitives=nevernest&mode=display&origin=opt-frontend.js&py=js&rawInputLstJSON=%5B%5D&textReferences=false


# Array isArray
https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/isArray


# Js practice Links
leetcode
hackerank
codewars
freecodecamp


# Functions
https://www.programiz.com/javascript/function


# Changing mysql password
https://linuxhint.com/change-mysql-root-password-ubuntu/


https://www.w3schools.com/nodejs/nodejs_mysql_select.asp


