'use strict';


process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.replace(/\s*$/, '')
        .split('\n')
        .map(str => str.replace(/\s*$/, ''));

    main();
});

function readLine() {
    return inputString[currentLine++];
}

function totalPairs(n, values) {

    // Complete the bankersAndClients function below.
    return -1;
}

function main() {
    const n = parseInt(readLine().trim(), 10);
    const values = readLine().replace(/\s+$/g, '').split(' ').map(aTemp => parseInt(aTemp, 10));
    var result = totalPairs(n, values);
    // Do not remove below line
    console.log(result);
    // Do not print anything after this line
}