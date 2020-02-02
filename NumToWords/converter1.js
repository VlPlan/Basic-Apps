function numToWord (num) {
   

let oneDigit=['','one','two','three','four','five','six','seven','eight','nine'];
let tens=['','','twenty','thirty','forty','fifty','sixty','seventy','eighty','ninety'];
let twoDigits=['ten','eleven','twelve','thirteen','fourteen','fifteen','sixteen','seventeen','eighteen','nineteen'];


function trillion (num) {
    if (num >= 1000000000000) {
        return trillion(Math.floor(num / 1000000000000)) + " trillion" + million(num % 1000000000000);
    }
    else {
        return million(num);
    }
}

function million (num) {
    if (num >= 1000000) {
        return million(Math.floor(num / 1000000)) + " million " + thousand(num % 1000000);
    }
    else {
        return thousand(num);
    }
}

function thousand (num) {
    if (num >= 1000) {
        return hundred(Math.floor(num / 1000)) + " thousand " + hundred(num % 1000);
    }
    else {
        return hundred(num);
    }
}

function hundred (num) {
    if (num > 99) {
        return oneDigit [Math.floor(num / 100)] + " hundred " + tensToWord (num % 100);
    }
    else {
        return tensToWord (num);
    }
}

function tensToWord (num) {
    if (num < 10) return oneDigit [num];
    else if (num >= 10 && num < 20) return twoDigits[num - 10];
    else {
        return tens[Math.floor(num / 10)] + " " + oneDigit[num % 10];
    }
}

function convert (num) {
    if (num === 0) return "zero";
    else return trillion (num);
}


return convert(num);
}