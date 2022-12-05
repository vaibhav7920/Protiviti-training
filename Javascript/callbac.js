function report(data){
    console.log(data);
}

function calc(x,y){
    let sum = x+y;
    return sum;
}

let result=calc(65,67);

report(result);

function mycalc(x,y,report){
    let sum=x+y;

    report("using call back" +sum);
}