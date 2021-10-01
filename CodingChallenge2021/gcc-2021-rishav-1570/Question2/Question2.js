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

function securitiesBuying(z,security_value) {
    var no_of_stocks=0;
     // Participant code here
    
    return no_of_stocks;
    
}

function main() {
    var z = parseInt(readLine());

    var security_value = readLine().split(' ').map(Number);
  
    var no_of_stocks_purchased = securitiesBuying(z,security_value);
    
    console.log(no_of_stocks_purchased);
}
