var itemArray =[];
//var time= moment().format('LTS');
//var time =moment().format('LT');  
//var time =moment().startOf('hour').FromNow(); 
var time =moment().format('MMMM Do YYYY, h:mm:ss a');    
function storeUserInput(){
   //const date= new Date().toJSON();
   var itemName = document.getElementById("title").value
    itemArray.push(itemName);
    itemArray.push(time);
    console.log("Item Name :"+itemArray.join(","));
    console.log("Item Created Time :"+itemArray.join(","));
    alert("item added to the list")
}
function displayItem(){
    var content="<b>list of items:</b><br>"
    for(var i=0;i<itemArray.length;i++){
        content+=itemArray[i]+"<br>";
    }
    document.getElementById("display").innerHTML=content;
    //document.getElementById("time").innerHTML=time;
}   