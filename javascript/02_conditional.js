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

function getGrade(score) {
    let grade;

    if(score > 25 && score <= 30)
        grade = 'A';
    else if(score > 20 && score <= 25)
        grade = 'B';
    else if(score > 15 && score <= 20)
        grade = 'C';
    else if(score > 10 && score <= 15)
        grade = 'D';
    else if(score > 5 && score <= 10)
        grade = 'E';
    else
        grade = 'F';
    
    return grade;
}

function main() {
    const score = +(readLine());
    
    console.log(getGrade(score));

    process.exit(0);
}