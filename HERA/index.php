<html>
<head>
    <link rel="stylesheet" type="text/css" href="css/home.css">
</head>

<body>

   <div class="image-background-block" id="image-background">
       
<?php include('menu.php'); ?>
       
            <hr>

            <div style="text-align:center">
              <span class="dot" onclick="currentSlide(1)"></span>
              <span class="dot" onclick="currentSlide(2)"></span>
              <span class="dot" onclick="currentSlide(3)"></span>
            </div>

            <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
            <a class="next" onclick="plusSlides(1)">&#10095;</a>
  </div>

  <hr>
    
  <div class="content">
    <div class="leftWrapper">
      <article class="left">
        <div class="leftImage"><a href="http://www.kornofficial.com"><img src="img/korn.jpg"></a></div>
        <div class="leftText">
          <h1>KOЯN</h1>
          <p>Korn (stylized as KoЯn) is an American nu metal band from Bakersfield, California, formed in 1993. The band's current lineup includes founding members James "Munky" Shaffer (rhythm guitar), Reginald "Fieldy" Arvizu (bass), Brian "Head" Welch (lead guitar, backing vocals), and Jonathan Davis (lead vocals, bagpipes), with the addition of Ray Luzier (drums), who replaced the band's original member, David Silveria in 2007. Korn was formed by three of the members of the band L.A.P.D.</p>
        </div>
      </article>
    </div>

    <div class="rightWrapper">
      <article class="right">
        <div class="rightText">
          <h1>DISTURBED</h1>
          <p>Disturbed is an American heavy metal band from Chicago, Illinois, formed in 1994. The band includes vocalist David Draiman, bassist John Moyer, guitarist/keyboardist Dan Donegan, and drummer Mike Wengren. Former band members are vocalist Erich Awalt and bassist Steve Kmak.The band has released six studio albums, five of which have consecutively debuted at number one on the Billboard 200.</p>
        </div>
        <div class="rightImage"><a href="http://www.disturbed1.com/"><img src="img/disturbed.jpg"></a>
        </div>
      </article>
    </div>

    <div class="leftWrapper">
      <article class="left">
        <div class="leftImage"><a href="http://systemofadown.com/"><img src="img/sod.jpg"></a></div>
        <div class="leftText">
          <h1>SYSTEM OF A DOWN</h1>
          <p>System of a Down, sometimes shortened to System and abbreviated as SOAD, is an Armenian-American heavy metal band from Glendale, California, formed in 1994. The band currently consists of Serj Tankian (lead vocals, keyboards), Daron Malakian (vocals, guitar), Shavo Odadjian (bass, backing vocals) and John Dolmayan (drums). The band achieved commercial success with the release of five studio albums, three of which debuted at number one on the Billboard 200. </p>
        </div>
      </article>
    </div>
  </div>
  <hr>
    
<?php include('footer.php'); ?>
    
<script type="text/javascript" src="js/home.js"></script>
</body>

</html>
