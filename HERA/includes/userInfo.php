<?php 
include "connection.php";
$user = $_SESSION['u_idnum'];
$sql = "SELECT * FROM visitor WHERE userID = '$_SESSION[u_idnum]';";
$result = mysqli_query($conn,$sql);
$userTable = mysqli_fetch_all($result,MYSQLI_BOTH);


$_SESSION['userInfoEmail'] = $userTable[0]['email'];
$_SESSION['userInfoFirstName'] =$userTable[0]['firstName'];
$_SESSION['userInfoLastName'] = $userTable[0]['lastName'];
$_SESSION['userInfoBalance'] = $userTable[0]['balance'];
$_SESSION['userInfoPicture'] = ("img/profile/" . $userTable[0]['picture']);
//echo $email; echo $firstName; echo $lastName; echo $balance; echo $picture;
?>
<script src="../js/jquery-3.3.1.min.js"></script>
<script>
  <?php
    $email = json_encode($_SESSION['userInfoEmail']);
    echo "var email = ". $email . ";\n";

    $firstName = json_encode($_SESSION['userInfoFirstName']);
    echo "var firstName = ". $firstName . ";\n";

    $lastName = json_encode($_SESSION['userInfoLastName']);
    echo "var lastName = ". $lastName . ";\n";

    $balance = json_encode($_SESSION['userInfoBalance']);
    echo "var balance = ". $balance . ";\n";
    
    $picture = json_encode($_SESSION['userInfoPicture']);
    echo "var picture = ". $picture . ";\n";
  
  ?>
  $(document).ready(function() {
    $('.firstName').text(firstName);
    $('.lastName').text(lastName);
    $('.email').text(email);
    $('.balance').text(balance);
    if (picture != "img/profile/") {
      $("#userImage").attr("src", picture);
    }
  });

</script>
