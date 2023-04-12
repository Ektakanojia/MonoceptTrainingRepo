var itemArray= new Array();
function storeUserInput(){
   
    var itemName = document.getElementById("title").value
    itemArray.push(itemName);
    console.log("Item Name :"+itemArray.join(","));
    alert("item added to the list")
    displayItem()
}
function displayItem(){
    var content="<b>list of items:</b><br>"
    for(var i=0;i<itemArray.length;i++){
        content+=itemArray[i]+"<br>";
    }
    document.getElementById("display").innerHTML=content;
}   