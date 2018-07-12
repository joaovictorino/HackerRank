'use strict';

var stdin = process.openStdin();

stdin.addListener("data", function(d) {
    greeting(d.toString().trim());
});

function greeting(parameterVariable) {
    // This line prints 'Hello, World!' to the console:
    console.log('Hello, World!');

    // Write a line of code that prints parameterVariable to stdout using console.log:
    console.log(parameterVariable);

    process.exit(0);
}