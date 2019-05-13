<script src="../js/jquery-3.3.1.min.js"></script>
<?php

include "connection.php";
//Select all the tickets of the signed in user, and for all of them we check if they have access to any huts/campingSpots
$sql = "SELECT `ticketID` FROM `ticket` WHERE `userID` = '$_SESSION[u_idnum]';";
$result = mysqli_query($conn,$sql);
$ticket_rows = mysqli_num_rows($result);
$ticketIDTable = mysqli_fetch_all($result,MYSQLI_BOTH);

$sql1 = "SELECT hutID FROM hut_res WHERE userID = '$_SESSION[u_idnum]';";
$result1 = mysqli_query($conn,$sql1);
$hut_rows1 = mysqli_num_rows($result1);

$sql2 = "SELECT campingID FROM camping_res WHERE userID = '$_SESSION[u_idnum]';";
$result2 = mysqli_query($conn,$sql2);
$camp_rows2 = mysqli_num_rows($result2);

  for ($i = 0; $i <$ticket_rows; $i++) {
    $current_ticket = $ticketIDTable[$i]['ticketID'];
    //Get Huts
    $inner_sql = "SELECT `hutID` FROM `hut_res` WHERE `ticket1` = '$current_ticket' OR `ticket2` = '$current_ticket' OR `ticket3` = '$current_ticket' OR `ticket4` = '$current_ticket' ";
    //Add huts to array
    $hut_result = mysqli_query($conn,$inner_sql);
    $hut_rows = mysqli_num_rows($hut_result);
    $hut_table = mysqli_fetch_all($hut_result,MYSQLI_BOTH);
    //Get CampingSpots
    $inner_sql_camping = "SELECT `campingID` FROM `camping_res` WHERE `ticket1` = '$current_ticket' OR `ticket2` = '$current_ticket'";
    //Add camping to array
    $camping_result = mysqli_query($conn,$inner_sql_camping);
    $camping_rows = mysqli_num_rows($camping_result);
    $camping_table = mysqli_fetch_all($camping_result,MYSQLI_BOTH);
    
    if($hut_rows > 0) {
      for($y = 0; $y < $hut_rows; $y++) {
        //We include the template HTML
        include "res-box-template.php";
        ?>
  <script>
    <?php
        //We send the counters and query results to JS
        $yCounterJS = json_encode($y);
        echo "var yCounter =".$yCounterJS.";\n";
        $iCounterJS = json_encode($i);
        echo "var iCounter =".$iCounterJS.";\n";
        $ticketIDJS = json_encode($ticketIDTable);
        echo "var ticketID =".$ticketIDJS.";\n";
        $hutIDJS = json_encode($hut_table);
        echo "var hutID = ". $hutIDJS . ";\n";
          ?>
    //Call function right after generating to process the HTML
    reservationHut();

    function reservationHut() {
      var resArray = $('.res-box-wrapper');
      if (resArray.length > 0) {
        //Gets Last element added, which is the one we need because we execute this after we add the element we need :)
        $(resArray).eq(resArray.length - 1).find('.res-type').text("Hut Number : " + hutID[yCounter]['hutID']);
        $(resArray).eq(resArray.length - 1).find('.res-ticketID').text("TicketID : " + ticketID[iCounter]['ticketID']);
      }
    }

  </script>
  <?php
      }
    }
    if($camping_rows > 0) {
      for($j = 0; $j < $camping_rows; $j++) {
        //We include the template HTML
        include "res-box-template.php";
        ?>
    <script>
      <?php
        //We send the counters and query results to JS
          $jCounterJS = json_encode($j);
          echo "var jCounter =".$jCounterJS.";\n";
          $iCounterJS = json_encode($i);
          echo "var iCounter =".$iCounterJS.";\n";
          $ticketIDJS = json_encode($ticketIDTable);
          echo "var ticketID =".$ticketIDJS.";\n";
          $campingIDJS = json_encode($camping_table);
          echo "var campingID = ". $campingIDJS . ";\n";
        ?>
      //Call function right after generating to process the HTML
      reservationCamping();

      function reservationCamping() {
        var resArray = $('.res-box-wrapper');
        if (resArray.length > 0) {
          //Gets Last element added, which is the one we need because we execute this after we add the element we need :)
          $(resArray).eq(resArray.length - 1).find('.res-box').css("background-image", "url('../img/camp_img.jpg')");
          $(resArray).eq(resArray.length - 1).find('.res-type').text("Camping Number : " + campingID[jCounter]['campingID']);
          $(resArray).eq(resArray.length - 1).find('.res-ticketID').text("TicketID : " + ticketID[iCounter]['ticketID']);
        }
      }

    </script>
    <?php
      }
    }
  }
    //Get ParkingSpots
    $inner_sql_parking = "SELECT `parkingID` FROM `parking_res` WHERE `userID` = '$_SESSION[u_idnum]'";
    //Add parking to array
    $parking_result = mysqli_query($conn,$inner_sql_parking);
    $parking_rows = mysqli_num_rows($parking_result);
    $parking_table = mysqli_fetch_all($parking_result,MYSQLI_BOTH);

    if($parking_rows > 0) {
      for($p = 0; $p < $parking_rows; $p++) {
        //We include the template HTML
        include "res-box-template.php";
        ?>
      <script>
        <?php
        //We send the counters and query results to JS
          $pCounterJS = json_encode($p);
          echo "var pCounter =".$pCounterJS.";\n";
          $parkingIDJS = json_encode($parking_table);
          echo "var parkingID = ".$parkingIDJS.";\n";
          $userIDJS = json_encode($_SESSION['u_idnum']);
          echo "var userID = ". $userIDJS. ";\n";
        ?>
        //Call function right after generating to process the HTML
        reservationParking();

        function reservationParking() {
          var resArray = $('.res-box-wrapper');
          if (resArray.length > 0) {
            //Gets Last element added, which is the one we need because we execute this after we add the element we need :)
            $(resArray).eq(resArray.length - 1).find('.res-box').css("background-image", "url('../img/park_img.jpg')");
            $(resArray).eq(resArray.length - 1).find('.res-type').text("Parking Number : " + parkingID[pCounter]['parkingID']);
            $(resArray).eq(resArray.length - 1).find('.res-ticketID').text("UserID : " + userID);
          }
        }

      </script>
      <?php
      }
    }
?>
