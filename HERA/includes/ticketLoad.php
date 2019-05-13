<?php
  
  include "connection.php";
  $sql = "SELECT * FROM ticket WHERE userID = '$_SESSION[u_idnum]';";
  $result = mysqli_query($conn,$sql);
  $ticket_rows = mysqli_num_rows($result);
  $ticketTable = mysqli_fetch_all($result,MYSQLI_BOTH);
  if ($ticket_rows >= 1) {
    for ($i = 1; $i <= $ticket_rows; $i++ ) {
      include "ticketStructure.php";
    }
    ?>
  <div id="qrcode"></div>
  <script src="../js/jquery-3.3.1.min.js"></script>
  <script src="../js/qrcode.js"></script>
  <script>
    $(document).ready(function() {
      var ticketArray = $('.ticketWrapper');
      if (ticketArray.length > 0) {
        <?php
          $ticketTableJS = json_encode($ticketTable);
          echo "var ticketTABLEArray = ". $ticketTableJS . ";\n";
        ?>
        for (var y = 0; y < ticketArray.length; y++) {
          $(ticketArray).eq(y).find('#qrcode').attr("id", "qrcode" + y);
          new QRCode(document.getElementById("qrcode" + y), ticketTABLEArray[y]['ticketID']);
          $(ticketArray).eq(y).find('.ticketID').text(ticketTABLEArray[y]['ticketID']);
          $(ticketArray).eq(y).find('.days').text(ticketTABLEArray[y]['days']);
        }
        $('.noTickets').css("display", "none");
        $('.print-btn').css("display", "block");
      }
    });

  </script>
  <?php
  } 
?>

