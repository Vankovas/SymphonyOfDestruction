<?php  
session_start();
include 'connection.php';

if (isset($_POST['addPersonsHut'])){

    $currentHut = $_POST["hutIDgenInput"];
    $firstPersonTicket = $_POST["person1"];
    $secondPersonTicket = $_POST["person2"];
    $thirdPersonTicket = $_POST["person3"];
    $forthPersonTicket = $_POST["person4"];


    if ($firstPersonTicket != 0 && $firstPersonTicket != $secondPersonTicket && $firstPersonTicket != $thirdPersonTicket && $firstPersonTicket != $forthPersonTicket){
        $sql1 = "UPDATE `hut_res` SET `ticket1` = '$firstPersonTicket' WHERE `hut_res`.`hutID` = '$currentHut' AND `hut_res`.`userID` = '$_SESSION[u_idnum]';";
        mysqli_query($conn,$sql1);
    }
    if ($secondPersonTicket != 0 && $firstPersonTicket != $secondPersonTicket && $secondPersonTicket != $thirdPersonTicket && $secondPersonTicket != $forthPersonTicket){
        $sql2 = "UPDATE `hut_res` SET `ticket2` = '$secondPersonTicket' WHERE `hut_res`.`hutID` = '$currentHut' AND `hut_res`.`userID` = '$_SESSION[u_idnum]';";
        mysqli_query($conn,$sql2);
    }
    if ($thirdPersonTicket != 0 && $firstPersonTicket != $thirdPersonTicket && $secondPersonTicket != $thirdPersonTicket && $thirdPersonTicket != $forthPersonTicket){
        $sql3 = "UPDATE `hut_res` SET `ticket3` = '$thirdPersonTicket' WHERE `hut_res`.`hutID` = '$currentHut' AND `hut_res`.`userID` = '$_SESSION[u_idnum]';";
        mysqli_query($conn,$sql3);
    }
    if ($forthPersonTicket != 0 && $firstPersonTicket != $forthPersonTicket && $secondPersonTicket != $forthPersonTicket && $thirdPersonTicket != $forthPersonTicket){
        $sql4 = "UPDATE `hut_res` SET `ticket4` = '$forthPersonTicket' WHERE `hut_res`.`hutID` = '$currentHut' AND `hut_res`.`userID` = '$_SESSION[u_idnum]';";
        mysqli_query($conn,$sql4);
    }
    

    for ($i = 1; $i <= 4; $i++){
        if (!is_numeric($_POST["person".$i])){
        $sql11 = "UPDATE `hut_res` SET `ticket$i` = NULL WHERE `hut_res`.`hutID` = '$currentHut' AND `hut_res`.`userID` = '$_SESSION[u_idnum]';";
        mysqli_query($conn,$sql11);
        }
    }
    
    header("Location: ../account.php");
    
} elseif (isset($_POST['addPersonsCamp'])){
    
    
    $currentCamp = $_POST["campIDgenInput"];
    $firstPersonTicketCamp = $_POST["firstPCamp"];
    $secondPersonTicketCamp = $_POST["secondPCamp"];
    
    if ($firstPersonTicketCamp != 0 && $firstPersonTicketCamp != $secondPersonTicketCamp){
        $sql5 = "UPDATE `camping_res` SET `ticket1` = '$firstPersonTicketCamp' WHERE `camping_res`.`campingID` = '$currentCamp' AND `camping_res`.`userID` = '$_SESSION[u_idnum]';";
        mysqli_query($conn,$sql5);
    }
    if ($secondPersonTicketCamp != 0 && $secondPersonTicketCamp != $firstPersonTicketCamp){
        $sql6 = "UPDATE `camping_res` SET `ticket2` = '$secondPersonTicketCamp' WHERE `camping_res`.`campingID` = '$currentCamp' AND `camping_res`.`userID` = '$_SESSION[u_idnum]';";
        mysqli_query($conn,$sql6);
    }

    
    if (!is_numeric($_POST["firstPCamp"])){

        $sql1 = "UPDATE `camping_res` SET `ticket1` = NULL WHERE `camping_res`.`campingID` = '$currentCamp' AND `camping_res`.`userID` = '$_SESSION[u_idnum]';";
        mysqli_query($conn,$sql1);
    }
    if (!is_numeric($_POST["secondPCamp"])){

        $sql1 = "UPDATE `camping_res` SET `ticket2` = NULL WHERE `camping_res`.`campingID` = '$currentCamp' AND `camping_res`.`userID` = '$_SESSION[u_idnum]';";
        mysqli_query($conn,$sql1);
    }
    
    
    header("Location: ../account.php");
    
}
?>
