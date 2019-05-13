<html>

<head>
    <link rel="stylesheet" type="text/css" href="css/gallery.css">
</head>

<body>
    <div class="image-background-block">
        <?php include('./menu.php'); ?>
    </div>
    <hr>
    <div class="animate_gallery_background">
        <div class="gallery_background"></div>
    </div>
    <hr>
    <div class="content">
        <div class="image_band">
            <img src="img/gallery_1.jpg" onclick="openModal(1)" class="img_band">
            <div class="middle">
                <div class="text">AN THEOS</div>
            </div>
        </div>
        <div class="image_band">
            <img src="img/gallery_2.jpg" onclick="openModal(2)" class="img_band">
            <div class="middle">
                <div class="text">MAYHEM</div>
            </div>
        </div>
        <div class="image_band">
            <img src="img/gallery_3.jpg" onclick="openModal(3)" class="img_band">
            <div class="middle">
                <div class="text">DARK FUNERAL</div>
            </div>
        </div>
        <div class="image_band">
            <img src="img/gallery_4.jpg" onclick="openModal(4)" class="img_band">
            <div class="middle">
                <div class="text">DECAPITATED</div>
            </div>
        </div>
        <div class="image_band">
            <img src="img/gallery_5.jpg" onclick="openModal(5)" class="img_band">
            <div class="middle">
                <div class="text">OBSIDIAN SEA</div>
            </div>
        </div>
        <div class="image_band">
            <img src="img/gallery_6.jpg" onclick="openModal(6)" class="img_band">
            <div class="middle">
                <div class="text">THEM FREQUENCIES</div>
            </div>
        </div>
        <div class="image_band">
            <img src="img/gallery_7.jpg" onclick="openModal(7)" class="img_band">
            <div class="middle">
                <div class="text">POWERWOLF</div>
            </div>
        </div>
        <div class="image_band">
            <img src="img/gallery_8.jpg" onclick="openModal(8)" class="img_band">
            <div class="middle">
                <div class="text">KREATOR</div>
            </div>
        </div>
        <div class="image_band">
            <img src="img/gallery_9.jpg" onclick="openModal(9)" class="img_band">
            <div class="middle">
                <div class="text">DIARY OF DREAMS</div>
            </div>
        </div>

        <div id="myModal" class="gallery-modal">
            <span class="close cursor" onclick="closeModal()">&times;</span>
            <div class="modal-content">
                <div class="mySlides">
                    <div class="numbertext">1 / 4</div>
                    <img id="first" style="width:100%">
                </div>
                <div class="mySlides">
                    <div class="numbertext">2 / 4</div>
                    <img id="second" style="width:100%">
                </div>
                <div class="mySlides">
                    <div class="numbertext">3 / 4</div>
                    <img id="third" style="width:100%">
                </div>
                <div class="mySlides">
                    <div class="numbertext">4 / 4</div>
                    <img id="forth" style="width:100%">
                </div>
                <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
                <a class="next" onclick="plusSlides(1)">&#10095;</a>

                <div class="smallImages">
                    <img class="small_img cursor" id="smallFirst" style="width:100%" onclick="currentSlide(1)">
                </div>
                <div class="smallImages">
                    <img class="small_img cursor" id="smallSecond" style="width:100%" onclick="currentSlide(2)">
                </div>
                <div class="smallImages">
                    <img class="small_img cursor" id="smallThird" style="width:100%" onclick="currentSlide(3)">
                </div>
                <div class="smallImages">
                    <img class="small_img cursor" id="smallForth" style="width:100%" onclick="currentSlide(4)">
                </div>
            </div>
        </div>
    </div>
    <hr>

    <?php include('./footer.php'); ?>
    <script type="text/javascript" src="js/gallery.js"></script>
</body>

</html>
