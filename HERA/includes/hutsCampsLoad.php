<?php
  
  include "connection.php";
  $sql = "SELECT hutID FROM hut_res WHERE userID = '$_SESSION[u_idnum]';";
  $result = mysqli_query($conn,$sql);
  $hut_rows = mysqli_num_rows($result);
  $hutTable = mysqli_fetch_all($result,MYSQLI_BOTH);

  $sql2 = "SELECT campingID FROM camping_res WHERE userID = '$_SESSION[u_idnum]';";
  $result2 = mysqli_query($conn,$sql2);
  $camp_rows = mysqli_num_rows($result2);
  $campTable = mysqli_fetch_all($result2,MYSQLI_BOTH);

  if ($hut_rows >= 1) {
    for ($i = 1; $i <= $hut_rows; $i++ ) {
      include "owned_hutStructure.php";
    }
    ?>

    <script src="../js/jquery-3.3.1.min.js"></script>
    <script>
        $(document).ready(function() {
            var hutArray = $('.hutbox');
            if (hutArray.length > 0) {

        <?php
          $hutTableJS = json_encode($hutTable);
          echo "var hutTABLEArray = ". $hutTableJS . ";\n";
        ?>

                for (var y = 0; y < hutArray.length; y++) {

                    $(hutArray).eq(y).find('.hutIDgen').text(hutTABLEArray[y]['hutID']);
                    $(hutArray).eq(y).find('.hiddenInput').val(hutTABLEArray[y]['hutID']);
                }
            }
        });

    </script>
    <?php
  }  

  if ($camp_rows >= 1) {
      for ($i = 1; $i <= $camp_rows; $i++) {
          include "owned_campStructure.php";
      }
      ?>
        <script src="../js/jquery-3.3.1.min.js"></script>
        <script>
            $(document).ready(function() {
                var campArray = $('.campbox');
                if (campArray.length > 0) {

                    <?php
          $campTableJS = json_encode($campTable);
          echo "var campTABLEArray = ". $campTableJS . ";\n";
        ?>

                    for (var y = 0; y < campArray.length; y++) {

                        $(campArray).eq(y).find('.campIDgen').text(campTABLEArray[y]['campingID']);
                        $(campArray).eq(y).find('.hiddenInputCamp').val(campTABLEArray[y]['campingID']);

                    }
                }
            });

        </script>
        <?php
  }  

                ?>   
                <script src="../js/jquery-3.3.1.min.js"></script>
                <?php 

$sql1 = "SELECT `ticketID` FROM `ticket` WHERE `userID` = '$_SESSION[u_idnum]';";
$result1 = mysqli_query($conn,$sql1);
$ticket_rows = mysqli_num_rows($result1);
$ticketIDTable = mysqli_fetch_all($result1,MYSQLI_BOTH);

    for ($i = 0; $i < $hut_rows; $i++){

        for ($j = 1; $j <= 4; $j++ ){
                
                $ticketNum = "ticket".$j;
                $hutNum = $hutTable[$i]['hutID'];
                $inner_sql = "SELECT $ticketNum FROM hut_res WHERE userID = '$_SESSION[u_idnum]' AND hutID = '$hutNum';";
                $result0 = mysqli_query($conn,$inner_sql);
                $tickedIDhut_res = mysqli_fetch_all($result0,MYSQLI_BOTH);
                    
                ?>
                
                <script>
                    
                    <?php 
                
                        $jCounter = json_encode($j);
                        echo "var jCounter =".$jCounter.";\n";
                        $tickedIDhut = json_encode($tickedIDhut_res);
                        echo "var tickedID_hut_res_Array =".$tickedIDhut.";\n";
                        $ticketNumJS = json_encode($ticketNum);
                        echo "var ticketNumJS =".$ticketNumJS.";\n";
                        $iCounter = json_encode($i);
                        echo "var iCounter =".$iCounter.";\n";
                        
                    ?>
                    addTicketIDs();
                    function addTicketIDs(){
                        var hutSpotArray = $('.hutbox');
                        var inputStr = ".inputN" + jCounter;
                        $(hutSpotArray).eq(iCounter).find(inputStr).val(tickedID_hut_res_Array[0][ticketNumJS]);

                    }
                </script>
                
                <?php
            }
    } 
    
    for ($i = 0; $i < $camp_rows; $i++){

        for ($j = 1; $j <= 2; $j++ ){
                
                $ticketNum = "ticket".$j;
                $campNum = $campTable[$i]['campingID'];
                $inner_sql = "SELECT $ticketNum FROM camping_res WHERE userID = '$_SESSION[u_idnum]' AND campingID = '$campNum';";
                $result0 = mysqli_query($conn,$inner_sql);
                $tickedIDcamp_res = mysqli_fetch_all($result0,MYSQLI_BOTH);
                    
                ?>
                
                <script src="../js/jquery-3.3.1.min.js"></script>
                <script>
                    
                    <?php 
                
                        $jCounter = json_encode($j);
                        echo "var jCounter =".$jCounter.";\n";
                        $tickedIDcamp = json_encode($tickedIDcamp_res);
                        echo "var tickedID_camp_res_Array =".$tickedIDcamp.";\n";
                        $ticketNumJS = json_encode($ticketNum);
                        echo "var ticketNumJS =".$ticketNumJS.";\n";
                        $iCounter = json_encode($i);
                        echo "var iCounter =".$iCounter.";\n";
                        
                    ?>
                    addTicketIDsCamp();
                    function addTicketIDsCamp(){
                        var campSpotArray = $('.campbox');
                        var inputStr = ".inputNcamp" + jCounter;
                        $(campSpotArray).eq(iCounter).find(inputStr).val(tickedID_camp_res_Array[0][ticketNumJS]);

                    }
                </script>
                
                <?php
            }
    }  

?>
