var randomNumber;
function generateButton(e)
{
    var allButton = "";
    for (var i = 1; i < e; i++)
    {
        allButton += `<button type="button" id="box${i}" onClick="changeButtonColor(${i})" style=background-color:gery;width:3%;height:600%;padding:10px></button>&nbsp;`
    }
    buttonContainer.innerHTML = allButton;
    var text = document.getElementById("btn")
    text.style.visibility = 'hidden'
    generateRadomNumber();

}
function generateRadomNumber()
{
    randomNumber = Math.floor((Math.random() * 50) + 1);
    //console.log(randomNumber);


}
var noOfAttempt = 0;
function changeButtonColor(number)
{
    noOfAttempt += 1;
    console.log(number)
    console.log(randomNumber)
    var button = document.querySelector("#box" + number)
    if (number == randomNumber)
    {
        //console.log("equal")   
        //button = document.querySelector("#button")
        button.style.backgroundImage = "url('nemo.jpg')";
        //button.style.backgroundColor="green";
        button.style.backgroundSize = "cover";
        /*  var result = document.querySelector("#buttonContainer");
         result.innerHTML=`You win in total ${noOfAttempt} attempt.`; */

    } else if (number < randomNumber)
    {
        button.style.backgroundColor = "yellow";
    }
    else
    {
        button.style.backgroundColor = "red";
    }


}