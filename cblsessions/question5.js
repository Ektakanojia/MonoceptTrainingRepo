/*create a function alternating_sum(int array) returns int array here this function will return 
an array of all the sum of even indices and odd indices
ex : console.log(alternating_sum([50,60,60,45,70]) => [180,105]
    console.log(alternating_sum([50,60,60]) => [110,60]
    console.log(alternating_sum([50,60]) => [50,60]*/


    function alternating_sum(array)
    {
        var oddSum=0;
        var evensum=0;
        if(array.length===1){
            return array;
        }
        for(let i=0;i<array.length;i++){
            if(i%2===0){
                evensum+=array[i]
            }else{
                oddSum+=array[i]
            }
        }
        return [evensum ,oddSum]
    }   
    console.log(alternating_sum([50,60,60,45,70]));
    console.log(alternating_sum([50,60,60])); [110,60]
    console.log(alternating_sum([50,60])); [50,60]
    console.log(alternating_sum([30])); [50,60]