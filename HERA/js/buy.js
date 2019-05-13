/*global document*/

var currentTab = 0; 
showTab(currentTab); 

function showTab(n) {
  var x = document.getElementsByClassName("tab");
  x[n].style.display = "block";
  if (n == (x.length - 1)) {
    document.getElementById("nextBtn").style.display = "none";
    jsVariablesCookies();
    document.getElementById("submitBtn").style.display = "block";
  } 
  fixStepIndicator(n);
  fixCircleIndicator(n);
}

function nextPrev(n) {
  var x = document.getElementsByClassName("tab");
    
  if (n == 1 && !validateForm()) return false;
  x[currentTab].style.display = "none";
  currentTab = currentTab + n;
  showTab(currentTab);
}
function validateForm() {

  var x, y, i, valid = true;
  x = document.getElementsByClassName("tab");
  y = x[currentTab].getElementsByTagName("input");
  for (i = 0; i < y.length; i++) {
    if (y[i].value == "") {
      y[i].className += " invalid";
      valid = false;
    }
  }
  if (valid) {
    document.getElementsByClassName("step")[currentTab].className += " finish";
    document.getElementsByClassName("circle")[currentTab].className += " finish";
  }
  return valid;
}

function fixStepIndicator(n) {
  var i, x = document.getElementsByClassName("step");
  for (i = 0; i < x.length; i++) {
    x[i].className = x[i].className.replace(" active", "");
  }
  x[n].className += " active";
}
function fixCircleIndicator(n) {
  var i, x = document.getElementsByClassName("circle");
  for (i = 0; i < x.length; i++) {
    x[i].className = x[i].className.replace(" active", "");
  }
  x[n].className += " active";
}

var ticketPrice = 0;
var parkingIncluded = 0;
var hutPrice = 0;
var campPrice = 0;
var nuTickets = 0;
var numberofHuts = 0;
var numberofCamps = 0;
var isParkIncluded = false;
var totalPrice = 0;
var buyOnlySpots = false;

function calculateTickets(numberoftickets){
    if (numberoftickets != 0){
        document.getElementById("numberTickets").innerHTML = numberoftickets;
        ticketPrice = 20;
        ticketPrice *= numberoftickets;
        nuTickets = numberoftickets;
    }
    else{
        document.getElementById("numberTickets").innerHTML = "0";  
        ticketPrice = 20;
        nuTickets = 0;
    }
}

function addParking(isCheckedParking){
    
    if(isCheckedParking){
        document.getElementById("parkingSpot").innerHTML = "+10 €";
        parkingIncluded += 10;
        isParkIncluded = true;
    }else{
        document.getElementById("parkingSpot").innerHTML = "NO PARKING SPOT";
        parkingIncluded -= 10;
        isParkIncluded = false;
    }
    
}

function calculateSum(){ 
    document.getElementById("sum").innerHTML = ticketPrice  + " €";
    document.getElementById("total").innerHTML = ticketPrice  + " €";
    totalPrice = ticketPrice ;
}

function calculateParking(){
    document.getElementById("total").innerHTML = ticketPrice + parkingIncluded + hutPrice + campPrice + " €";
    totalPrice = parkingIncluded + ticketPrice + hutPrice + campPrice;
}

function disableCampSpots(){
    numberofHuts = 0;
    numberofCamps = 0;
    hutPrice = 0;
    campPrice = 0;
    totalPrice = ticketPrice + parkingIncluded;
    document.getElementById("select1").selectedIndex = "0";
    document.getElementById("select2").selectedIndex = "0";  
    document.getElementById("select1").disabled=true;
    document.getElementById("select2").disabled=true;
    document.getElementById("select1").style.backgroundColor="darkgrey";
    document.getElementById("select2").style.backgroundColor="darkgrey";
    document.getElementById("spotPrice").innerHTML = "NONE";
    document.getElementById("total").innerHTML = ticketPrice + parkingIncluded + " €";
    document.getElementById("sum2").innerHTML = "0 €";
}
function onlyCamp(){
    numberofHuts = 0;
    hutPrice = 0;
    totalPrice = ticketPrice + parkingIncluded;
    document.getElementById("select2").selectedIndex = "0";
    document.getElementById("total").innerHTML = ticketPrice + parkingIncluded + " €";
    document.getElementById("sum2").innerHTML = "0 €";
    document.getElementById("spotPrice").innerHTML = "NONE";
    document.getElementById("campDropdown").style.display = "block";
    document.getElementById("select1").disabled=false;
    document.getElementById("select1").style.backgroundColor="darkmagenta";
    document.getElementById("dropDownText").innerHTML = "How many camping spots?";
    document.getElementById("hutDropdown").style.display = "none";
}
function onlyHut(){
    numberofCamps = 0;  
    campPrice = 0;
    totalPrice = ticketPrice + parkingIncluded;
    document.getElementById("select1").selectedIndex = "0";
    document.getElementById("total").innerHTML = ticketPrice + parkingIncluded + " €";
    document.getElementById("sum2").innerHTML = "0 €";
    document.getElementById("spotPrice").innerHTML = "NONE";
    document.getElementById("hutDropdown").style.display = "block";
    document.getElementById("select2").disabled=false;
    document.getElementById("select2").style.backgroundColor="darkmagenta";
    document.getElementById("dropDownText").innerHTML = "How many huts?";
    document.getElementById("campDropdown").style.display = "none"; 
}


function calculateHuts(numberHuts){
    hutPrice = 50;
    hutPrice *= numberHuts;
    numberofHuts = numberHuts;
    document.getElementById("spotPrice").innerHTML = numberofHuts + " hut(s): " + hutPrice + " €";
}

function calculateCamps(numberCamps){
    campPrice = 30;
    campPrice *= numberCamps;
    numberofCamps = numberCamps;
    document.getElementById("spotPrice").innerHTML = numberofCamps + " camping spot(s): " + campPrice + " €";
}

function calculateTotalhut(){
    document.getElementById("total").innerHTML = ticketPrice + parkingIncluded + hutPrice + " €";
    totalPrice = ticketPrice + parkingIncluded + hutPrice;
}
function calculateTotalcamp(){
    document.getElementById("total").innerHTML = ticketPrice + parkingIncluded + campPrice + " €";
    totalPrice = ticketPrice + parkingIncluded + campPrice;
}

function calculateSum2hut(){
     document.getElementById("sum2").innerHTML = hutPrice + " €";
}
function calculateSum2camp(){
     document.getElementById("sum2").innerHTML = campPrice + " €";
}

function alreadyHaveTicket(isChecked){
    if(isChecked == true){
    document.getElementById("select0").style.display = "none";  
    document.getElementById("informTickets").style.display="none";
    document.getElementById("lbHaveTicket").style.display="none";
    document.getElementById("select-text").innerHTML = "Click 'Next' to continue."
    buyOnlySpots = true;
    ticketPrice = 0;
    nuTickets = 0;
    parkingIncluded = 0;
    isParkIncluded = false;
    document.getElementById("sum").innerHTML = 0 + " €";
    document.getElementById("total").innerHTML = 0 + " €";
    }
    else{
        location.reload();
    }
}

function checkContinue(){
    var firstValueSelect1 = document.getElementById("select1");
    var firstValueSelect2 = document.getElementById("select2");
    
    var selectedValue1 = firstValueSelect1.options[firstValueSelect1.selectedIndex].value;
    var selectedValue2 = firstValueSelect2.options[firstValueSelect2.selectedIndex].value;
    
    var rbHutSelected = rbHut.checked;
    var rbCampSelected = rbCamp.checked;
    var cbAlreadyHaveTicket = cbHaveTicket.checked;
    var cbParkingJS = cbParking.checked;
    
    if (currentTab === 0){
        
        var firstValueSelect0 = document.getElementById("select0");
        var selectedValue0 = firstValueSelect0.options[firstValueSelect0.selectedIndex].value;
        
        if(selectedValue0 == "0" && cbAlreadyHaveTicket == false){
                document.getElementById('probPop').style.display = 'block';
                document.getElementById('probMessage').innerHTML = "Please select how much tickets you would like.";
           }
        else{
           nextPrev(1);
        }
    }else if(currentTab === 1){
            if(selectedValue1 == "0" && rbCampSelected == true){
                document.getElementById('probPop').style.display = 'block';
                document.getElementById('probMessage').innerHTML = "Please select how many camping spots you would like.";
            }else if(selectedValue2 == "0" && rbHutSelected == true){
                document.getElementById('probPop').style.display = 'block';
                document.getElementById('probMessage').innerHTML = "Please select how many huts you would like.";
            }else if(cbAlreadyHaveTicket == true && rbHutSelected == false && rbCampSelected == false && cbParkingJS == false){
                document.getElementById('probPop').style.display = 'block';
                document.getElementById('probMessage').innerHTML = "Please select huts or camping spots.";
            }else{
        nextPrev(1);
            }
        }else if(currentTab === 2){
        nextPrev(1);
    }
}

// nuTickets       is the number of the purchased tickets.
// numberofHuts        is the number of reserved huts.
// numberofCamps      is the number of reserved camps.
// isParkIncluded      bool is the parking spot selected.
// totalPrice         is the total bill.
// buyOnlySpots      bool to check if user selected to buy only huts or camping spots.

function jsVariablesCookies(){
    document.cookie = "nuTicketsCookie =" + nuTickets
    document.cookie = "numberofHutsCookie =" + numberofHuts
    document.cookie = "numberofCampsCookie =" + numberofCamps 
    document.cookie = "isParkIncludedCookie =" + isParkIncluded
    document.cookie = "totalPriceCookie =" + totalPrice
    document.cookie = "buyOnlySpotsCookie =" + buyOnlySpots
}
