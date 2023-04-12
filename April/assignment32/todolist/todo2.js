var itemArray =[];
function storeUserInput(){
    const date= new Date().toJSON();
    var itemName = document.getElementById("title").value
    itemArray.push(itemName);
    itemArray.push(date);
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
}   