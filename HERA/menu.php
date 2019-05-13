<?php session_start(); ?>
<link rel="stylesheet" type="text/css" href="css/menu.css">
<div class="menu non-printable">
  <div class="navBar">
    <ul class="nav">
      <li class="navBtn">
        <a href="index.php">
                        HOME
                    </a>
      </li>
      <li class="navBtn">
        <a href="gallery.php">
                        GALLERY
                    </a>
      </li>
      <li class="navBtn">
        <?php if(isset($_SESSION['u_id'])){ ?>
        <a href="buy.php">
                        PURCHASE
                </a>
        <?php }else{ ?>
        <a onclick="document.getElementById('id01').style.display='block'">
                        PURCHASE
                </a>
        <?php } ?>
      </li>
      <li class="navBtn">
        <a href="location.php">
                        LOCATION
                </a>
      </li>
      <li class="navBtn">
        <a href="about.php">
                        ABOUT
                </a>
      </li>
      <?php if(isset($_SESSION['u_id'])){ ?>
      <li class="navBtn">
        <a href="account.php">
                        ACCOUNT
                    </a>
      </li>
      <?php }?>
      <?php if(!isset($_SESSION['u_id'])){ ?>
      <li class="navBtn loginBTN">
        <a onclick="document.getElementById('id01').style.display='block'">
                        LOGIN
                </a>
      </li>
      <?php }else{ ?>
      <li class="navBtn logoutBTN">
        <a href="includes/logout.php">
                        LOGOUT
                </a>
      </li>
      <?php } ?>
    </ul>
  </div>
</div>
<div class="login-register non-printable" id="id01">
  <span onclick="document.getElementById('id01').style.display='none'" class="close" title="Close login-register">&times;</span>
  <form class="loginForm animate" action="includes/login_action.php" method="post">
    <div class="loginContainer">
      <label class="text-input" for="uname"><b>E-mail</b></label>
      <input type="text" placeholder="Enter Username" name="useremail" required>

      <label class="text-input" for="psw"><b>Password</b></label>
      <input type="password" placeholder="Enter Password" name="psw" required>

      <button id="buttonsRegForms" type="submit" name="login-btn">Login</button>
      <button type="button" id="buttonsRegForms2" class="registerbtn" onclick="document.getElementById('id02').style.display='block'; document.getElementById('id01').style.display='none'">Register</button>
      <button type="button" class="cancelbtn" onclick="document.getElementById('id01').style.display='none'">Cancel</button>
    </div>
  </form>
</div>
<div class="registerWrapper non-printable" id="id02">
  <span onclick="document.getElementById('id02').style.display='none'" class="close" title="Close registerWrapper">&times;</span>
  <form class="registerForm animate" action="includes/register_action.php" method="post">
    <div class="loginContainer">
      <label class="text-input" for="email"><b>E-mail</b></label>
      <input type="email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$" placeholder="Enter Email" name="email" required>

      <label class="text-input" for="psw"><b>Password</b></label>
      <input type="password" placeholder="Enter Password" name="psw" required>

      <label class="text-input" for="rp-psw"><b>Repeat Password</b></label>
      <input type="password" placeholder="Repeat Password" name="rp-psw" required>

      <label class="text-input" for="firstname"><b>First Name</b></label>
      <input type="text" placeholder="Enter First Name" name="firstname" required>

      <label class="text-input" for="lastname"><b>Last Name</b></label>
      <input type="text" placeholder="Enter Last Name" name="lastname" required>

      <button id="buttonsRegForms3" type="submit" name="register-btn">Sign up</button>
      <button type="button" onclick="document.getElementById('id02').style.display='none'" class="cancelbtn">Cancel</button>
    </div>
  </form>
</div>

<div class="problemPopup non-printable" id="probPop">
  <div class="popup">
    <label class="message" id="probMessage">Oops. Try again.</label>
    <button class="okButton" type="button" onclick="document.getElementById('probPop').style.display='none'">OK</button>
  </div>
</div>
<div class="successPopup non-printable" id="succPop">
  <div class="popup">
    <label class="message">Successful!</label>
    <button class="okButton" type="button" onclick="document.getElementById('succPop').style.display='none'">OK</button>
  </div>
</div>

<?php 

if(isset($_SESSION["errorCheck"])){
if($_SESSION["errorCheck"] == 1){
   ?>
<script>
  document.getElementById('probPop').style.display = 'block';
  document.getElementById('probMessage').innerHTML = "There is no such username."

</script>
<?php
    $_SESSION["errorCheck"] = 10;
}
elseif($_SESSION["errorCheck"] == 2){
   ?>
  <script>
    document.getElementById('probPop').style.display = 'block';
    document.getElementById('probMessage').innerHTML = "Invalid password."

  </script>
  <?php
    $_SESSION["errorCheck"] = 10;
}
elseif($_SESSION["errorCheck"] == 3){
   ?>
    <script>
      document.getElementById('succPop').style.display = 'block';

    </script>
    <?php
    $_SESSION["errorCheck"] = 10;
}
elseif($_SESSION["errorCheck"] == 4){
       ?>
      <script>
        document.getElementById('probPop').style.display = 'block';
        document.getElementById('probMessage').innerHTML = "Unknown error."

      </script>
      <?php
    $_SESSION["errorCheck"] = 10;
}
elseif($_SESSION["errorCheck"] == 5){
       ?>
        <script>
          document.getElementById('probPop').style.display = 'block';
          document.getElementById('probMessage').innerHTML = "Invalid e-mail."

        </script>
        <?php
    $_SESSION["errorCheck"] = 10;
}
elseif($_SESSION["errorCheck"] == 6){
       ?>
          <script>
            document.getElementById('probPop').style.display = 'block';
            document.getElementById('probMessage').innerHTML = "User already taken."

          </script>
          <?php
    $_SESSION["errorCheck"] = 10;
}
elseif($_SESSION["errorCheck"] == 7){
       ?>
            <script>
              document.getElementById('probPop').style.display = 'block';
              document.getElementById('probMessage').innerHTML = "Passwords do not match."

            </script>
            <?php
    $_SESSION["errorCheck"] = 10;
}
elseif($_SESSION["errorCheck"] == 8){
       ?>
              <script>
                document.getElementById('probPop').style.display = 'block';
                document.getElementById('probMessage').innerHTML = "You need to have at least 1 ticket in order to add additional huts or camping spots."

              </script>
              <?php
    $_SESSION["errorCheck"] = 10;
}}
?>
