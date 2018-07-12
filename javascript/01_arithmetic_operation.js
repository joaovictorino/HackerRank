'use strict';

let inputString = new Array();
let currentLine = 0;

var stdin = process.openStdin();

stdin.addListener('data', inputStdin => {
    inputString[currentLine] = inputStdin;

    if(currentLine == 1){
        currentLine = 0;
        main();
    }

    currentLine++;
});

function readLine() {
    return inputString[currentLine++];
}

/**
*   Calculate the area of a rectangle.
*
*   length: The length of the rectangle.
*   width: The width of the rectangle.
*   
*	Return a number denoting the rectangle's area.
**/
function getArea(length, width) {
    let area = length * width;
    // Write your code here

    return area;
}

/**
*   Calculate the perimeter of a rectangle.
*	
*	length: The length of the rectangle.
*   width: The width of the rectangle.
*   
*	Return a number denoting the perimeter of a rectangle.
**/
function getPerimeter(length, width) {
    let perimeter = 2 * (length + width);
    // Write your code here
    
    return perimeter;
}

function main() {
    const length = +(readLine());
    const width = +(readLine());
    
    console.log(getArea(length, width));
    console.log(getPerimeter(length, width));

    process.exit(0);
}