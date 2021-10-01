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

function theHackathon(n, m, a, b, f, s, t) {
    // Participant code here

}

function main() {
    const inputdata = readLine().split(' ');

    const n = parseInt(inputdata[0], 10);

    const m = parseInt(inputdata[1], 10);

    const a = parseInt(inputdata[2], 10);

    const b = parseInt(inputdata[3], 10);

    const f = parseInt(inputdata[4], 10);

    const s = parseInt(inputdata[5], 10);

    const t = parseInt(inputdata[6], 10);

    theHackathon(n, m, a, b, f, s, t);
}
