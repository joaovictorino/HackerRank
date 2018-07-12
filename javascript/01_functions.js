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

function factorial(value) {
    if(value > 1)
        return value * factorial(--value);
    else
        return 1;
}

function main() {
    const n = +(readLine());
    
    console.log(factorial(n));

    process.exit(0);
}