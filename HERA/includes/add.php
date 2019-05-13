<?php 
session_start();
//Target Path
$target = "../img/profile/"; 
$target = $target . basename( $_FILES['photo']['name']);
//Retrieve Info
$pic=($_FILES['photo']['name']);
//Connect
include "connection.php";
//Add to database
$userID = $_SESSION['u_idnum'];
$sql = "UPDATE `visitor` SET `picture` = '$pic' WHERE `visitor`.`userID` = '$userID';";
mysqli_query($conn,$sql);
//Move pic to server
if(move_uploaded_file($_FILES['photo']['tmp_name'],$target)) 
{
  header("Location: ../account.php");
}
else {
  ?>
<script>
  alert("There was a problem");

</script>
<?php
  header("Location: ../account.php");
}
?>
