<?php
  
  $firstName = $_REQUEST['firstname'];
  $lastName = $_REQUEST['lastname'];
  $email = $_REQUEST['emailClient'];
  $message = $_REQUEST['subject'];
  $country = $_REQUEST['country'];
  $from="From: $firstName $lastName <$email>\r\nReturn-path: $email $country";
  $subject="Symphony of Destruction - Contact";
  mail("ivan.vasilev@student.fontys.nl", $subject, $message, $from);
  header ("Location: ../index.php");

?>
