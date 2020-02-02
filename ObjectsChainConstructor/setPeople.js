function People() {

};

People.prototype.SetPeopleSpecs = function (name, hairColor, eyeColor, living, eating) {
    this.name = name;
    this.hair = hairColor;
    this.eye = eyeColor;
    this.live = living;
    this.eat = eating;

}

People.prototype.GetPeopleSpecs = function () {
    return this.name, this.hair, this.eye, this.live, this.eat;
}

People.prototype.name = null;
People.prototype.hair = null;
People.prototype.eye = null;
People.prototype.live = null;
People.prototype.eat = null;


let Vladimir = new People;
Vladimir.SetPeopleSpecs('Vladimir', 'black', 'brown', 'alive', 'eated');


let Marko = new People;
Marko.SetPeopleSpecs('Marko', 'brown', 'blue', 'alive', 'not');

let Maja = new People;
Maja.SetPeopleSpecs('Maja', 'black', 'green', 'alive', 'eated');

let Mia = new People;
Mia.SetPeopleSpecs('Mia', 'blond', 'blue', 'alive', 'not');

let Viktor = new People;
Viktor.SetPeopleSpecs('Viktor', 'black', 'brown', 'dead', '/');

let Monika = new People;
Monika.SetPeopleSpecs('Monika', 'red', 'black', 'alive', 'not');

let Stefan = new People;
Stefan.SetPeopleSpecs('Stefan', 'blond', 'brown', 'dead', '/');

let persons = [];

persons.push(Vladimir, Marko, Maja, Mia, Viktor, Monika, Stefan);
console.log(persons)



let Name = document.getElementsByClassName('name').innerHTML;
let Hair = document.getElementsByClassName('hair').innerHTML;
let Eye = document.getElementsByClassName('eye').innerHTML;
let Live = document.getElementsByClassName('live').innerHTML;
let Eat = document.getElementsByClassName('eat').innerHTML;


function displayTable(people) {
    let table = document.getElementById('table');
    for (i = 0; i < people.length; i++) {
        let person = people[i];
        let newPerson = document.createElement('tr');
        let stats = ['name', 'hair', 'eye', 'live', 'eat', ];
        for (j = 0; j < stats.length; j++) {
            let stat = document.createElement('td');
            stat.innerHTML = person[stats[j]];
            stat.className = person[stats[j]];
            newPerson.appendChild(stat);

        }
        table.appendChild(newPerson);
    }
}

displayTable(persons);
console.log(persons)



function setColor() {
    let blackColor = document.getElementsByClassName('black');
    let brownColor = document.getElementsByClassName('brown');
    let blondColor = document.getElementsByClassName('blond');
    let redColor = document.getElementsByClassName('red');
    let blueColor = document.getElementsByClassName('blue');
    let greenColor = document.getElementsByClassName('green');
    for (j = 0; j < blackColor.length; j++) {

        blackColor[j].style = "background-color:black;color:white";
    }
    for (j = 0; j < brownColor.length; j++) {
        brownColor[j].style = "background-color:brown;color:white";
    }
    for (j = 0; j < blondColor.length; j++) {
        blondColor[j].style = "background-color:yellow;color:white";
    }
    for (j = 0; j < redColor.length; j++) {
        redColor[j].style = "background-color:red;color:white";
    }
    for (j = 0; j < blueColor.length; j++) {
        blueColor[j].style = "background-color:blue;color:white";
    }
    for (j = 0; j < greenColor.length; j++) {
        greenColor[j].style = "background-color:green;color:white"
    }
}

setColor()


function setEmojis() {

    let living = document.getElementsByClassName('alive');
    let dead = document.getElementsByClassName('dead');
    let eated = document.getElementsByClassName('eated');
    let notEated = document.getElementsByClassName('not');

    for (j = 0; j < living.length; j++) {
        let alive = document.createElement('div');
        let leftEye = document.createElement('div');
        let rightEye = document.createElement('div');
        let mouth = document.createElement('div');

        alive.style = "position:relative; display:inline-block; width:30px; height:30px; margin:20px; text-align:center; line-height:30px; border:2px solid green; border-radius:100%; background-color:green;";
        leftEye.style="position:absolute; left:5px; top:6px; width:3px; height:3px; background-color:white; border-radius:100%; border: 1px solid green;";
        rightEye.style="position:absolute; right:5px; top:6px; width:3px; height:3px; background-color:white; border-radius:100%; border: 1px solid green;";
        mouth.style="position:absolute; left:7px; width:15px; height:8px; border: 1px solid green; background-color:white; border-bottom-right-radius:30px; border-bottom-left-radius:30px; border-top-right-radius:0px; border-top-left-radius:0px; bottom:5px;"
        living[j].style = "text-align:center; font-family:arial;font-weight:bold;background-color:#a3a375;"
        living[j].appendChild(alive);
        alive.appendChild(leftEye);
        alive.appendChild(rightEye);
        alive.appendChild(mouth);
    }
    for (j = 0; j < dead.length; j++) {
        let notAlive = document.createElement('div');
        let leftEyeDead = document.createElement('div');
        let rightEyeDead = document.createElement('div');
        let mouthDead = document.createElement('div');


        notAlive.style = "position:relative; display:inline-block; width:30px; height:30px; margin:20px; text-align:center; line-height:30px; border:2px solid red; border-radius:100%; background-color:red;";
        leftEyeDead.style="position:absolute; left:5px; top:6px; width:3px; height:5px; background-color:white; border-radius:100%; border: 1px solid red;";
        rightEyeDead.style="position:absolute; right:5px; top:6px; width:3px; height:5px; background-color:white; border-radius:100%; border: 1px solid red;";
        mouthDead.style="position:absolute; left:7px; width:15px; height:8px; border: 1px solid red; background-color:white; border-bottom-right-radius:0px; border-bottom-left-radius:0px; border-top-right-radius:50px; border-top-left-radius:50px; bottom:5px;"

        dead[j].style = "text-align:center; font-family:arial;font-weight:bold; background-color:#a3a375;"
        dead[j].appendChild(notAlive);
        notAlive.appendChild(leftEyeDead);
        notAlive.appendChild(rightEyeDead);
        notAlive.appendChild(mouthDead);
    }
    for (j = 0; j < eated.length; j++) {
        let donnut1 = document.createElement('div');
        let donnut2 = document.createElement('div');
        let donnut3 = document.createElement('div');
        let fill1 = document.createElement('div');
        let fill2 = document.createElement('div');
        let fill3 = document.createElement('div');
        let fill4 = document.createElement('div');
        let fill5 = document.createElement('div');
        let fill6 = document.createElement('div');
        let fill7 = document.createElement('div');
        let fill8 = document.createElement('div');

        
        donnut1.style = "position:relative; display:inline-block; width:40px; height:40px; margin:20px; text-align:center; line-height:30px; border:2px solid #ffef96; border-radius:100%; background-color:#ffef96;";
        donnut2.style="position:relative; display:inline-block; width:40px; height:40px; margin:20px; text-align:center; line-height:30px; border:2px solid #ff0097; border-radius:100%; bottom:25px; right:23px; background-color:#ff0097;";
        donnut3.style="position:relative; display:inline-block; width:15px; height:15px; margin:5px; text-align:center; line-height:30px; border:1px solid #00aba9; border-radius:100%; top:4px;background-color:#00aba9;";
       fill1.style="position:relative; display:inline-block; width:3px; height:1px; margin:5px; border:1px solid white;  bottom:20px; right:8px; background-color:white;";
        fill2.style="position:relative; display:inline-block; width:3px; height:1px; margin:5px; border:1px solid black;  bottom:45px; right:7px; background-color:black;";;
       fill3.style="position:relative; display:inline-block; width:3px; height:1px; margin:5px; border:1px solid white;  bottom:44px; left:7px; background-color:white;";;
        fill4.style="position:relative; display:inline-block; width:3px; height:1px; margin:5px; border:1px solid black;  bottom:54px; left:10px; background-color:black;";
        fill5.style="position:relative; display:inline-block; width:3px; height:1px; margin:5px; border:1px solid white;  bottom:80px; left:14px; background-color:white;";
        fill6.style="position:relative; display:inline-block; width:3px; height:1px; margin:5px; border:1px solid black;  bottom:100px; left:4px; background-color:black;";
        fill7.style="position:relative; display:inline-block; width:3px; height:1px; margin:5px; border:1px solid white;  bottom:130px; right:4px; background-color:white;";
        fill8.style="position:relative; display:inline-block; width:3px; height:1px; margin:5px; border:1px solid black;  bottom:120px; right:25px; background-color:black;";
        
        
        eated[j].style = "text-align:center; font-family:arial;font-weight:bold; background-color:#00aba9;"
        eated[j].appendChild(donnut1);
        donnut1.appendChild(donnut2);
        donnut2.appendChild(donnut3);
        donnut2.appendChild(fill1);
        donnut2.appendChild(fill2);
        donnut2.appendChild(fill3);
        donnut2.appendChild(fill4);
        donnut2.appendChild(fill5);
        donnut2.appendChild(fill6);
        donnut2.appendChild(fill7);
        donnut2.appendChild(fill8);
      
    }
    for (j = 0; j < notEated.length; j++) {
        //   redColor[j].style="background-color:red;color:white";
    }

}

setEmojis()


function setAvatars() {
    let vladimir= document.getElementsByClassName('Vladimir');
    let marko= document.getElementsByClassName('Marko');
    let maja = document.getElementsByClassName('Maja');
    let mia = document.getElementsByClassName('Mia');
    let viktor = document.getElementsByClassName('Viktor');
    let monika = document.getElementsByClassName('Monika');
    let stefan = document.getElementsByClassName('Stefan');

    for (j = 0; j < vladimir.length; j++) {
        let avatar1 = new Image();
        avatar1.src="data:image/jpeg;base64,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";
         


        avatar1.style="position:relative; display:block; width:130px; height:130px; margin:20px; text-align:center; line-height:30px; border:2px solid black; border-radius:100%;"
       vladimir[j].style = "text-align:center; font-family:arial;font-weight:bold;"
        vladimir[j].appendChild(avatar1);
    }
    for (j = 0; j < marko.length; j++) {
        let avatar2 = new Image();
        avatar2.src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRE8sCk33iCYqweI2sKJ1uBSBTOo21kittLBJdWJLxLTXV9TcNa";
         
        avatar2.style="position:relative; display:block; width:130px; height:130px; margin:20px; text-align:center; line-height:30px; border:2px solid black; border-radius:100%;"
       marko[j].style = "text-align:center; font-family:arial;font-weight:bold;"
        marko[j].appendChild(avatar2);
    }

    for (j = 0; j < maja.length; j++) {
        let avatar3 = new Image();
        avatar3.src="data:image/jpeg;base64,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";
         
        avatar3.style="position:relative; display:block; width:130px; height:130px; margin:20px; text-align:center; line-height:30px; border:2px solid black; border-radius:100%;"
       maja[j].style = "text-align:center; font-family:arial;font-weight:bold;"
        maja[j].appendChild(avatar3);
    }

    for (j = 0; j < mia.length; j++) {
        let avatar4 = new Image();
        avatar4.src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTeTpx3CFewUVEeTE5BC0HsgUPFGnBn5ifMO5EZfyIdQ9xAU1hR";
         
        avatar4.style="position:relative; display:block; width:130px; height:130px; margin:20px; text-align:center; line-height:30px; border:2px solid black; border-radius:100%;"
       mia[j].style = "text-align:center; font-family:arial;font-weight:bold;"
        mia[j].appendChild(avatar4);
    }

    for (j = 0; j < viktor.length; j++) {
        let avatar5 = new Image();
        avatar5.src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSkBL4S_nJbJVawGQKGTux33SAAJgq40ELumkTdc8WAOSHKxNrJpQ";
         
        avatar5.style="position:relative; display:block; width:130px; height:130px; margin:20px; text-align:center; line-height:30px; border:2px solid black; border-radius:100%;"
       viktor[j].style = "text-align:center; font-family:arial;font-weight:bold;"
        viktor[j].appendChild(avatar5);
    }

    for (j = 0; j < monika.length; j++) {
        let avatar6 = new Image();
        avatar6.src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSQKnR5lVJyr2D0rX5FZaD6Xh0nec8KWknbfbGwjh28U9KvmUYK";
         
        avatar6.style="position:relative; display:block; width:130px; height:130px; margin:20px; text-align:center; line-height:30px; border:2px solid black; border-radius:100%;"
       monika[j].style = "text-align:center; font-family:arial;font-weight:bold;"
        monika[j].appendChild(avatar6);
    }

    for (j = 0; j < stefan.length; j++) {
        let avatar7 = new Image();
        avatar7.src="data:image/jpeg;base64,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";
         
        avatar7.style="position:relative; display:block; width:130px; height:130px; margin:20px; text-align:center; line-height:30px; border:2px solid black; border-radius:100%;"
       stefan[j].style = "text-align:center; font-family:arial;font-weight:bold;"
        stefan[j].appendChild(avatar7);
    }

}

setAvatars();