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

const PI = Math.PI;

function area(raio) {
    return PI * Math.pow(raio, 2);
}

function perimeter(raio) {
    return 2 * PI * raio;
}

function main() {
    let raio = parseFloat(readLine());
    
    console.log(area(raio));
    console.log(perimeter(raio));

    process.exit(0);
}