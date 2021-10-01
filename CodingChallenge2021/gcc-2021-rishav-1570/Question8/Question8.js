'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.replace(/\s*$/, '')
        .split('\n')
        .map(str => str.replace(/\s*$/, ''));

    main();
});

function readLine() {
    return inputString[currentLine++];
}

// You may change this function parameters
function calculatedMaximizedReturns(n, k, d, m, returns){
    // Participant's code
    return -1;
}

function main() {
    const firstLine = readLine().split(" ");
    const secondLine = readLine().split(" ");

    const n = parseInt(firstLine[0], 10);
    const k = parseInt(firstLine[1], 10);
    const d = parseInt(firstLine[2], 10);
    const m = parseInt(firstLine[3], 10);
    const returns = secondLine.map(x => parseInt(x, 10));

    const result = calculatedMaximizedReturns(n, k, d, m, returns);

    // Please do not remove the below line.
    console.log(result)
    // Do not print anything after this line
}