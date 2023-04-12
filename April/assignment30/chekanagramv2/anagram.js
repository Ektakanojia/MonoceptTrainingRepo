function checkAnagram()
{
  var string1 = document.getElementById("string1").value;
  var string2 = document.getElementById("string2").value;
  if (string1.length !== string2.length)
  {
    alert("No")
    document.getElementById("button").style.backgroundColor = "#FC2947";
    document.getElementById("button").textContent = "No";
  }
  else
  {

    var newstring1 = string1.toUpperCase().split("").sort().join();
    var newstring2 = string2.toUpperCase().split("").sort().join();
   
    for (var i = 0; i < newstring1.length; i++)
    {
      if (newstring1[i] != newstring2[i])
      {
        alert("No");
        document.getElementById("button").style.backgroundColor = "#FC2947";
        document.getElementById("button").textContent = "No it is not a anagram";
        break;
      }

    }
    alert("Yes");
    document.getElementById("button").style.backgroundColor="#7AA874";
    document.getElementById("button").textContent="Yes It a anagram";
  }
}
/* function validateString(newstring1,newstring2){
  if(newstring1.toUpperCase()!=newstring1 && newstring2.toUpperCase()!= newstring2){
     alert("Enter valid string in uppercase only");
  }else if(newstring1.toLowerCase()!= newstring1 && newstring2.toLowerCase()!=newstring2){
    alert("Enter valid string in lower case only");
  }
} */
