let onDisplay = document.querySelector(`#display`);

document.getElementById('seven').addEventListener(`click`,function(){
   calculator.onDisplay.value+=this.innerHTML;  
})

document.getElementById('eight').addEventListener(`click`,function(){
   calculator.onDisplay.value+=this.innerHTML;
})

document.getElementById('nine').addEventListener(`click`,function(){
   calculator.onDisplay.value+=this.innerHTML;
})

document.getElementById('four').addEventListener(`click`,function(){
   calculator.onDisplay.value+=this.innerHTML;
})

document.getElementById('five').addEventListener(`click`,function(){
   calculator.onDisplay.value+=this.innerHTML;
})

document.getElementById('six').addEventListener(`click`,function(){
   calculator.onDisplay.value+=this.innerHTML;
})

document.getElementById('one').addEventListener(`click`,function(){
   calculator.onDisplay.value+=this.innerHTML;
})

document.getElementById('two').addEventListener(`click`,function(){
   calculator.onDisplay.value+=this.innerHTML;
})

document.getElementById('three').addEventListener(`click`,function(){
   calculator.onDisplay.value+=this.innerHTML;
})

document.getElementById('zero').addEventListener(`click`,function(){
   calculator.onDisplay.value+=this.innerHTML;
})

document.getElementById('clear').addEventListener(`click`,function(){
   calculator.onDisplay.value=document.getElementById('display').innerHTML;
})

document.getElementById('erase').addEventListener(`click`,function(){
   calculator.onDisplay.value=(calculator.onDisplay.value).slice(0,-1);
})

document.getElementById('divide').addEventListener(`click`,function(){
   calculator.onDisplay.value+=this.innerHTML;
 
})


document.getElementById('multiply').addEventListener(`click`,function(){
   calculator.onDisplay.value+='*'
})

document.getElementById('minus').addEventListener(`click`,function(){
   calculator.onDisplay.value+='-'
})

document.getElementById('plus').addEventListener(`click`,function(){
   calculator.onDisplay.value+='+'
})


document.getElementById('dot').addEventListener(`click`,function(){
let string=calculator.onDisplay.value;
      if(!string.includes('.')){
      
      calculator.onDisplay.value+='.'
      }
 
})

document.getElementById('plusMinus').addEventListener(`click`,function(){

      calculator.onDisplay.value*=-1;
})

document.getElementById('equal').addEventListener(`click`,function(){
  calculator.onDisplay.value=eval(calculator.onDisplay.value);

})


 


