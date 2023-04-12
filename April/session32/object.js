var names = []
console.log(names)

names.push("Ekta")
names.push("Vikrant")
names.push("Anekant")
names.push("shefali")
console.log(names) 

names.unshift("Monocept")
console.log(names)

names.forEach((n)=>console.log(n.toUpperCase()))

var names_with_a= names.filter((names)=>names.includes("V"));
console.log(names_with_a)

var strNos=["10","20","30","40"]
 strNos.map(no=>console.log(parseInt(no)+parseInt(no)))

 var sum= strNos.map(no=>{return parseInt(no)}).reduce((a,b)=>a+b)
 console.log(sum)

 var user=[{id:101, name:'Ekta',salary:1000},{id:102,name:'Ankit',salary:2000}]
 user.forEach((u)=>console.log(u.id,u.name,u.salary))