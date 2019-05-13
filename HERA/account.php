<html>
<head>
  <link rel="stylesheet" type="text/css" href="css/account.css">
</head>

<body>
  <div class="image-background-block non-printable">
    <?php include('./menu.php'); 
     if(!isset($_SESSION['u_id'])){ header("Location: /index.php");}?>
  </div>
  <hr non-printable>

  <!--CONTENT-->

  <div class="contentWrapper">
    <div class="userBoxWrapper non-printable">
      <div class="userBox">
        <div class="userImage">
          <img id="userImage" src="img/user.jpg">
        </div>
        <div class="userInfo">
          <div class="userInfoBox underline">
            <div class="titleWrapper">
              <div class="title">
                <p class="userTextStyle">First Name:</p>
              </div>
            </div>
            <div class="infoWrapper">
              <div class="info">
                <p class="firstName userTextStyle">Ella</p>
              </div>
            </div>
          </div>
          <div class="userInfoBox underline">
            <div class="titleWrapper">
              <div class="title">
                <p class="userTextStyle">Last Name:</p>
              </div>
            </div>
            <div class="infoWrapper">
              <div class="info">
                <p class="lastName userTextStyle">Audrey</p>
              </div>
            </div>
          </div>
          <div class="userInfoBox underline">
            <div class="titleWrapper">
              <div class="title">
                <p class="userTextStyle">Email:</p>
              </div>
            </div>
            <div class="infoWrapper">
              <div class="info">
                <p class="email userTextStyle">ella.audrey@gmail.com</p>
              </div>
            </div>
          </div>
          <div class="userInfoBox underline">
            <div class="titleWrapper">
              <div class="title">
                <p class="userTextStyle">Balance:</p>
              </div>
            </div>
            <div class="infoWrapper">
              <div class="info">
                <p class="balance userTextStyle">0 EUR</p>
              </div>
            </div>
          </div>
          <form class="editProfile" enctype="multipart/form-data" action="includes/add.php" method="POST">
            <input type="file" name="photo" id="file" class="inputfile" data-multiple-caption="{count} files selected" multiple />
            <label id="choosePhoto" for="file" for="file">Change Profile Picture</label>
            <button class="resetPage" href="account.php">Cancel Changes</button>
            <input class="uploadPhoto" type="submit" value="Save Changes"> </form>
        </div>
      </div>
    </div>
    <hr non-printable/>
    <?php include "includes/userInfo.php" ?>
    <div class="tickets printable">
      <h1 class="ticketHeadline non-printable">My Tickets</h1>

      <!--      TICKETS      -->
      <a class="noTickets non-printable" href="buy.php">Purchase Tickets</a>
      <?php include "includes/ticketLoad.php";?>
      <!--      TICKETS ENDING       -->
      <button class="print-btn non-printable" onclick="window.print();">Print All Tickets</button>
    </div>
  </div>
  <hr non-printable>
  <h1 class="ticketHeadline non-printable">Manage Huts and Camping spots</h1>
  <div class="wrapper non-printable">
    <?php include('includes/hutsCampsLoad.php'); ?>
  </div>
  <hr non-printable>
  <?php include "includes/reservationsStructure.php" ?>
  <hr non-printable/>
  <?php include('./footer.php'); ?>
  <script src="js/jquery-3.3.1.min.js"></script>
  <script src="js/profilePicture.js"></script>
</body>

</html>
