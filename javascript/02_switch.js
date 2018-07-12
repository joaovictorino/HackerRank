'use strict';

let inputString = new Array();
let currentLine = 0;

var stdin = process.openStdin();

stdin.addListener('data', inputStdin => {
    inputString[currentLine] = inputStdin;

    if(currentLine == 0){
        main();
    }

    currentLine++;
});

function readLine() {
    return inputString[currentLine++];
}

function getLetter(s) {
    let letter;
    // Write your code here
    
    return letter;
}

function main() {
    const s = readLine();
    
    console.log(getLetter(s));

    process.exit(0);
}