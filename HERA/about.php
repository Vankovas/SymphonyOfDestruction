<html>

<head>
  <link rel="stylesheet" type="text/css" href="css/about.css">
</head>

<body>
  <div class="image-background-block">
    <?php include('./menu.php'); ?>
  </div>
  <hr>
  <div class="content_about">
    <div class="about_text">
      <h1>About Us</h1>
      <p>We are a commercial company specialized in organizing events. We have been a part of various other companies. However, we have decided to go solo from now on. We have assigned a skillful team of programmers to help us bring this event to you.
      </p>
    </div>

  </div>
  <hr>
  <div class="content_contact">
    <h2>Contact us</h2>
    <div class="contact_form">
      <div class="container">
        <form action="includes/contact-form-function.php" method="post">
          <label for="femail">Your e-mail: </label>
          <input pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$" class="contact-input" type="email" name="emailClient" placeholder="Your e-mail" required>
          <label for="fname">First Name</label>
          <input class="contact-input" type="text" id="fname" name="firstname" placeholder="Your name.." required>
          <label for="lname">Last Name</label>
          <input class="contact-input" type="text" id="lname" name="lastname" placeholder="Your last name.." required>

          <label for="country">Country</label>
          <select id="country" name="country">
            <option value="australia">Netherlands</option>
            <option value="canada">Bulgaria</option>
            <option value="usa">USA</option>
          </select>

          <label for="subject">Message</label>
          <textarea class="contact-input-message" id="subject" name="subject" placeholder="Write your message here.." style="height:200px" required></textarea>
          <input class="contact-btn" type="submit" value="Submit" name="submitBtn">
        </form>
      </div>
    </div>
  </div>

  <hr>
  <?php include('./footer.php'); ?>
  <script src="js/jquery-3.3.1.min.js"></script>
  <script src="js/contact.js"></script>
</body>

</html>
