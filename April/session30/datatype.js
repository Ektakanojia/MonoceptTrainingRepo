var x;
console.log(typeof x);

x=10;
console.log(typeof x);

x="hello";
console.log(typeof x);

x=function()
{
console.log(typeof x);
}
x={
    name:"ekta",
    company:"Monocept"
}
console.log(typeof x);
x= null;
console.log(typeof x);
console.log(this)
console.log(this == window)