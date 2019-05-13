<html>
<head>
    <link rel="stylesheet" type="text/css" href="css/buy.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
</head>

<body>
    <div class="image-background-block">
        <?php include('./menu.php'); 
        if(!isset($_SESSION['u_id'])){ header("Location: /index.php");}?>
    </div>
    <hr>

    <div class="content">
        <div class="text_savemoney">
            <h5>Buy tickets online and save 10€</h5>
        </div>
        <form id="regForm" name="form" action="includes/buy_tickets_action.php" method="post">

            <div class="progress_circles">
                <ul class="progressbar">
                    <li class="circle">Purchase</li>
                    <li class="circle">Camping Spot</li>
                    <li class="circle">Finalize</li>
                </ul>
            </div>

            <!-- One "tab" for each step in the form -->
            <div class="tab">
                <div class="wrapper">
                    <div class="select">
                        <h4 id="select-text">Buy tickets:</h4>
                        <div class="custom-select">
                            <select id="select0" onchange="calculateTickets(this.value); calculateSum(); "> 
                              <option value="0">Ticket amount:</option>
                              <option value="1">1 Ticket</option>
                              <option value="2">2 Tickets</option>
                              <option value="3">3 Tickets</option>
                              <option value="4">4 Tickets</option>
                              <option value="5">5 Tickets</option>
                              <option value="6">6 Tickets</option>
                              <option value="7">7 Tickets</option>
                              <option value="8">8 Tickets</option>
                              <option value="9">9 Tickets</option>
                              <option value="10">10 Tickets</option>
                            </select>
                        </div>
                        <label id="lbHaveTicket">If you have tickets and would like to add only <i>huts</i> or <i>camping spots</i> click below.</label>
                        <label class="container" style="color: white; border: 5px; border-color: black;" id="container-alreadyhaveticket">Skip ticket purchase.
                              <input type="checkbox" id="cbHaveTicket" onchange="alreadyHaveTicket(checked);">
                              <span class="checkmark"></span>
                        </label>
                    </div>
                    <div class="informationTickets" id="informTickets">
                        <div class="bill">
                            <h4>Price for 1 ticket: 20 €</h4>
                        </div>
                        <div class="bill">
                            <h4>Number of tickets: </h4><label id="numberTickets">0</label></div>
                        <hr>
                        <div class="bill">
                            <h4>Sum: </h4><label id="sum">0 €</label></div>
                    </div>
                </div>
            </div>
            <div class="tab">
                <div class="wrapper">
                    <div class="select">
                        <label class="container" style="color: white; border: 5px; border-color: black; padding-bottom: 20px;" id="container-parking"> Parking Spot
                              <input type="checkbox" id="cbParking" onchange="addParking(checked); calculateParking();"> 
<!--                            calculateSum();-->
                              <span class="checkmark" id="parkingCheckbox"></span>
                        </label>
                        <label class="container">None
                              <input type="radio" id="rbNone" name="radio" checked onclick="disableCampSpots();">
                              <span class="checkmark2"></span>
                            </label>
                        <label class="container">Camping spot
                              <input type="radio"  id="rbCamp" name="radio" onchange="onlyCamp();">
                              <span class="checkmark2"></span>
                            </label>
                        <label class="container">Hut
                              <input type="radio" id="rbHut" name="radio" onchange="onlyHut();">
                              <span class="checkmark2"></span>
                            </label>
                        <label id="dropDownText">How many camping spots?</label>
                        <div class="custom-select" style="width:200px;" id="campDropdown">
                            <select id="select1" disabled onchange="calculateCamps(this.value); calculateTotalcamp(); calculateSum2camp(); ">
                                  <option value="0">Select Camping spots</option>
                                  <option value="1">1</option>
                                  <option value="2">2</option>
                                  <option value="3">3</option>
                                  <option value="4">4</option>
                                  <option value="5">5</option>
                            </select>
                        </div>
                        <div class="custom-select2" style="width:200px;" id="hutDropdown">
                            <select id="select2" onchange="calculateHuts(this.value); calculateTotalhut(); calculateSum2hut(); ">
                                  <option value="0">Select Huts</option>
                                  <option value="1">1</option>
                                  <option value="2">2</option>
                                  <option value="3">3</option>
                                </select>
                        </div>
                    </div>
                    <div class="informationTickets">

                        <div class="bill">
                            <h4>Camping spot / Hut: </h4><label id="spotPrice">NONE</label></div>
                        <hr>
                        <div class="bill">
                            <h4>Sum: </h4><label id="sum2">0 €</label></div>
                        <hr>
                        <div class="bill">
                            <h4>Parking spot: </h4><label id="parkingSpot">NO PARKING SPOT</label></div>
                        <div class="bill">
                            <h4>Total: </h4><label id="total">0 €</label></div>


                    </div>
                </div>
            </div>

            <div class="tab">

                <div class="wrapper">
                    <div class="col-75">
                        <div class="col-50">
                            <h3 id="creditcard_text">Credit Card Info</h3>
                            <label for="adr"><i class="fa fa-address-card-o"></i> Address</label>
                            <input type="text" id="adr" name="address" placeholder="De Lampendriessen 31">
                            <label for="city"><i class="fa fa-institution"></i> City</label>
                            <input type="text" id="city" name="city" placeholder="Eindhoven">
                            <label for="fname">Accepted Cards</label>
                            <div class="icon-container">
                                <div class="icons-background">
                                    <i class="fa fa-cc-visa" style="color:navy;"></i>
                                    <i class="fa fa-cc-amex" style="color:blue;"></i>
                                    <i class="fa fa-cc-mastercard" style="color:red;"></i>
                                    <i class="fa fa-cc-discover" style="color:orange;"></i>
                                </div>
                            </div>
                        </div>


                        <div class="col-50">
                            <label for="cname">Name on Card</label>
                            <input type="text" id="cname" name="cardname" placeholder="John More Doe">
                            <label for="ccnum">Credit card number</label>
                            <input type="text" id="ccnum" name="cardnumber" placeholder="1111-2222-3333-4444">
                            <label for="expmonth">Exp Month</label>
                            <input type="text" id="expmonth" name="expmonth" placeholder="September">
                            <label for="expyear">Exp Year</label>
                            <input type="text" id="expyear" name="expyear" pattern="[0-9]{4}" placeholder="2018" title="Numeric year">
                            <label for="cvv">CVV</label>
                            <input type="text" id="cvv" name="cvv" pattern="[0-9]{3}" placeholder="352" title="3 numbers only">

                        </div>

                    </div>
                </div>


            </div>

            <div style="padding-top: 10px;">
                <div style="display: flex; justify-content: space-around;">
                    <button type="button" id="prevBtn" onclick="window.location.href='buy.php'">Previous</button>
                    <button type="button" id="nextBtn" onclick="checkContinue()">Next</button>
                    <button type="submit" id="submitBtn" name="submit">Submit</button>
                </div>
            </div>

            <!-- Circles which indicates the steps of the form -->
            <div style="text-align:center;margin-top:40px;">
                <span class="step"></span>
                <span class="step"></span>
                <span class="step"></span>
            </div>
        </form>
    </div>
    <hr>



    <?php include('./footer.php'); ?>
    <script type="text/javascript" src="js/buy.js"></script>
</body>

</html>
