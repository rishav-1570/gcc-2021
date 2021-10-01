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

function bankersAndClients(c, b, time) {

    // Complete the bankersAndClients function below.
    return -1;
}

function main() {
    var ar = readLine().split(' ').map(Number);
    var c = ar[0];
    var b = ar[1];
    var time = [];
    for (var i = 0; i < b; i++) {
        time[i] = readLine().split(' ');
        time[i] = time[i].map(Number);
    }

    var result = bankersAndClients(c, b, time);
    // Do not remove below line
    console.log(result);
    // Do not print anything after this line
}