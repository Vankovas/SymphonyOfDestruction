<?php
session_start();
    
if (isset($_POST['submit'])) {
    
include 'connection.php';
    
$nuTicketsCookie = $_COOKIE['nuTicketsCookie'];
$numberofHutsCookie = $_COOKIE['numberofHutsCookie'];
$numberofCampsCookie = $_COOKIE['numberofCampsCookie'];
$isParkIncludedCookie = $_COOKIE['isParkIncludedCookie'];
$totalPriceCookie = $_COOKIE['totalPriceCookie'];
$buyOnlySpotsCookie = $_COOKIE['buyOnlySpotsCookie'];

$userIdNum = mysqli_real_escape_string($conn, $_SESSION['u_idnum']);

$query = "SELECT ticketID FROM ticket WHERE userID = '$userIdNum'; ";
$resultquery = mysqli_query($conn, $query);
$row = mysqli_fetch_assoc($resultquery);

 
    // if the user tries to buy only campings spots without having a ticket
    if ($buyOnlySpotsCookie == "true" && $row == NULL){
        
        $_SESSION["errorCheck"] = 8;
        header("Location: ../buy.php");
        
    }elseif($buyOnlySpotsCookie == "true" && $row != NULL){ // if the user tries to buy only camping spots - having at least 1 ticket
        
        if($isParkIncludedCookie == "true"){
                
                $sql = "SELECT p.parkingID FROM parking p WHERE p.parkingID NOT IN ( SELECT pr.parkingID FROM parking_res pr)"; 
                $result = mysqli_query($conn, $sql);
                $row = mysqli_fetch_assoc($result);
                $availParkID = $row['parkingID'];  
                $sql1 = "INSERT INTO `parking_res` (`parkingID`, `userID`) VALUES ('$availParkID', '$userIdNum')";
                mysqli_query($conn, $sql1);                 
            }   
        
        
        if($numberofCampsCookie != 0){  

            for ($x = 0; $x < $numberofCampsCookie; $x++){
                $sql = "SELECT c.campingID FROM camping c WHERE c.campingID NOT IN ( SELECT cr.campingiD FROM camping_res cr)"; 
                $result = mysqli_query($conn, $sql);
                $row = mysqli_fetch_assoc($result);
                $availCampID = $row['campingID'];  
                $sql1 = "INSERT INTO `camping_res` (`campingID`, `userID`) VALUES ('$availCampID', '$userIdNum')";
                mysqli_query($conn, $sql1);  
            }        
        }elseif($numberofHutsCookie != 0){

            for ($x = 0; $x < $numberofHutsCookie; $x++){
                $sql = "SELECT h.hutID FROM hut h WHERE h.hutID NOT IN ( SELECT hr.hutID FROM hut_res hr)"; 
                $result = mysqli_query($conn, $sql);
                $row = mysqli_fetch_assoc($result);
                $availHutID = $row['hutID'];  
                $sql1 = "INSERT INTO `hut_res` (`hutID`, `userID`) VALUES ('$availHutID', '$userIdNum')";
                mysqli_query($conn, $sql1);
            }
        } 
        $_SESSION["errorCheck"] = 3;
        header("Location: ../account.php");
    }
    
    if($buyOnlySpotsCookie == "false"){// normal ticket buy
        
            if($isParkIncludedCookie == "true"){
                
                $sql = "SELECT p.parkingID FROM parking p WHERE p.parkingID NOT IN ( SELECT pr.parkingID FROM parking_res pr)"; 
                $result = mysqli_query($conn, $sql);
                $row = mysqli_fetch_assoc($result);
                $availParkID = $row['parkingID'];  
                $sql1 = "INSERT INTO `parking_res` (`parkingID`, `userID`) VALUES ('$availParkID', '$userIdNum')";
                mysqli_query($conn, $sql1);                 
            }   
            for ($x = 0; $x < $nuTicketsCookie; $x++) {
                $sql = "INSERT INTO `ticket` (`ticketID`, `braceletID`, `days`, `userID`) VALUES (NULL, 'NULL', '15-07-2018 to 18-07-2018', '$userIdNum')"; 
                mysqli_query($conn, $sql);
            } 
            if($numberofCampsCookie != 0){  

                for ($x = 0; $x < $numberofCampsCookie; $x++){
                    $sql = "SELECT c.campingID FROM camping c WHERE c.campingID NOT IN ( SELECT cr.campingiD FROM camping_res cr)"; 
                    $result = mysqli_query($conn, $sql);
                    $row = mysqli_fetch_assoc($result);
                    $availCampID = $row['campingID'];  
                    $sql1 = "INSERT INTO `camping_res` (`campingID`, `userID`) VALUES ('$availCampID', '$userIdNum')";
                    mysqli_query($conn, $sql1);  
                }        
            }elseif($numberofHutsCookie != 0){

                for ($x = 0; $x < $numberofHutsCookie; $x++){
                    $sql = "SELECT h.hutID FROM hut h WHERE h.hutID NOT IN ( SELECT hr.hutID FROM hut_res hr)"; 
                    $result = mysqli_query($conn, $sql);
                    $row = mysqli_fetch_assoc($result);
                    $availHutID = $row['hutID'];  
                    $sql1 = "INSERT INTO `hut_res` (`hutID`, `userID`) VALUES ('$availHutID', '$userIdNum')";
                    mysqli_query($conn, $sql1);
                }
            }
            $_SESSION["errorCheck"] = 3;
            header("Location: ../account.php");
    }

    
// sending email with information of the payment
    
    $cardname = $_POST['cardname'];
    $cardnumber = $_POST['cardnumber'];
    $expmonth = $_POST['expmonth'];
    $expyear = $_POST['expyear'];
    $cvv = $_POST['cvv'];
    $customerEmail = $_SESSION['u_id']; // this session variable is the email/username of the user
    $firstName = $_SESSION['u_lastname'];
    $lastName = $_SESSION['u_firstname'];
    
    
    $email_subject = "New payment";
    $email_body = "You have received new payment from user $firstName $lastName.\nemail address / username: $customerEmail\nBank details:\nName on card: $cardname IBAN: $cardnumber\nExp month: $expmonth Exp year: $expyear cvv: $cvv\nTotal Price: $totalPriceCookie";
    
    $to = "valentin.spasovvv@gmail.com";
    
    mail($to, $email_subject, $email_body);
    
//====================    
    
  $sql = "SELECT hutID FROM hut_res WHERE userID = '$_SESSION[u_idnum]';";
  $result = mysqli_query($conn,$sql);
  $hut_rows = mysqli_num_rows($result);
  $hutTable = mysqli_fetch_all($result,MYSQLI_BOTH);

  $sql1 = "SELECT `ticketID` FROM `ticket` WHERE `userID` = '$_SESSION[u_idnum]';";
  $result1 = mysqli_query($conn,$sql1);
  $ticket_rows = mysqli_num_rows($result1);
  $ticketIDTable = mysqli_fetch_all($result1,MYSQLI_BOTH);
    
  $sql2 = "SELECT campingID FROM camping_res WHERE userID = '$_SESSION[u_idnum]';";
  $result2 = mysqli_query($conn,$sql2);
  $camp_rows = mysqli_num_rows($result2);
  $campTable = mysqli_fetch_all($result2,MYSQLI_BOTH);

    
$ticketCounter = $ticket_rows;
$counter = 0;
  
    for ($i = 0; $i < $hut_rows; $i++){

        for ($j = 1; $j <= 4; $j++ ){

            if($ticketCounter > 0){
                
                $ticketNum = "ticket".$j;
                $hutNum = $hutTable[$i]['hutID'];
                $currentTicketId = $ticketIDTable[$counter]['ticketID'];
                $inner_sql = "UPDATE `hut_res` SET `$ticketNum` = '$currentTicketId' WHERE `hut_res`.`hutID` = '$hutNum' AND `hut_res`.`userID` = '$_SESSION[u_idnum]';";
                mysqli_query($conn,$inner_sql);
                $counter++;
                $ticketCounter--;
            }
        }  
    }  
    
    for ($i = 0; $i < $camp_rows; $i++){

        for ($j = 1; $j <= 2; $j++ ){

            if($ticketCounter > 0){
                
                $ticketNum = "ticket".$j;
                $campNum = $campTable[$i]['campingID'];
                $currentTicketId = $ticketIDTable[$counter]['ticketID'];
                $inner_sql = "UPDATE `camping_res` SET `$ticketNum` = '$currentTicketId' WHERE `camping_res`.`campingID` = '$campNum' AND `camping_res`.`userID` = '$_SESSION[u_idnum]';";
                mysqli_query($conn,$inner_sql);
                $counter++;
                $ticketCounter--;
            }
        }  
    }  
    
    
  }

?>