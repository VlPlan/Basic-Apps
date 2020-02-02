function getNumberStats(number) {
    getNumberDigits(number);
    isNumberEvenOROdd(number);
    isNumberPositive(number);
    
    console.log(number+' has '+getNumberDigits(number)+' digits, '+' ['+numberDigits(number)+'], '+isNumberEvenOROdd(number)+' '+isNumberPositive(number));

}



function getNumberDigits(number) {

    if (isNumberPositive(number) === ' and is positive ') {
        return number.toString('').length;
    }
    else if (isNumberPositive(number) === ' and is negative ')
    return number.toString('').length-1;

}

function numberDigits(number) {
   
    let NumDigits = [];
    for (i = 0; i < number.length; i++) {
        while (number != 0) {
            digit = number % 10;
            number = Math.floor(number / 10);
            NumDigits.push(digit);

        }
    }
    return (NumDigits.reverse().join(','));
}


function isNumberEvenOROdd(number) {
   
    if (number % 2 === 0) {
        return ('number is even');
    }
    if (number % 2 != 0) {
        return ('number is odd');
    }
}


function isNumberPositive(number) {

    if (number > 0) {
        return (' and is positive ');
    }
    if (number < 0) {
        return (' and is negative ');
    }
}


console.log(getNumberStats(prompt('enter number')));



function onClick() {

  return getNumberStats(document.getElementById('textarea').value);
    
 }

document.getElementById('button').addEventListener('click', onClick);