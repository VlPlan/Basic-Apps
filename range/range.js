function check(first,last){
let arr=[];

    if(first<last){
        for (i=first;i<=last;i++){
            arr.push(i);
        }
    }
 else if(first>last){
     for(i=first;i>=last;i--){
         arr.push(i);
     }
 }
 console.log(arr)
}

check(3,11);

check(14,2);