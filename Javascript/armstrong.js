
function power(x, y)
    {
        if( y == 0)
            return 1;
        if (y % 2 == 0)
            return power(x, parseInt(y / 2, 10)) *
                   power(x, parseInt(y / 2, 10));
                      
        return x * power(x, parseInt(y / 2, 10)) *
                   power(x, parseInt(y / 2, 10));
    }
  
  function order(x)
  {
      let n = 0;
      while (x != 0)
      {
          n++;
          x = parseInt(x / 10, 10);
      }
      return n;
  }
  
  function isArmstrong(x)
{
       
    
    let n = order(x);
    let temp = x, sum = 0;
    while (temp != 0)
    {
        let r = temp % 10;
        sum = sum + power(r, n);
        temp = parseInt(temp / 10, 10);
    }

    return (sum == x);
}
 
let x = 153;
if(isArmstrong(x))
{
    console.log("True" + "</br>");
}
else{
    console.log("False" + "</br>");
}
x = 1253;
if(isArmstrong(x))
{
    console.log("True");
}
else{
    console.log("False");
}