/*global document*/

function slide1(){
    var imageUrl= "url(img/home_1.png)"
    document.getElementById("image-background").style.backgroundImage = imageUrl;
}   
function slide2(){
    var imageUrl= "url(img/home_2.jpg)"
    document.getElementById("image-background").style.backgroundImage = imageUrl;
}   
function slide3(){
    var imageUrl= "url(img/home_3.jpg)"
    document.getElementById("image-background").style.backgroundImage = imageUrl;
}   

var slideIndex = 1;
showSlides(slideIndex);

// Next/previous controls
function plusSlides(n) {
  showSlides(slideIndex += n);
}

// Thumbnail image controls
function currentSlide(n) {
  showSlides(slideIndex = n);
}

function showSlides(n) {
  var i;
  var dots = document.getElementsByClassName("dot");
  
  if (n > dots.length) {slideIndex = 1} 
  if (n < 1) {slideIndex = dots.length}
  for (i = 0; i < dots.length; i++) {
      dots[i].className = dots[i].className.replace(" active", "");
  }
  dots[slideIndex-1].className += " active";
if (slideIndex == 1){
    slide1();
}
else if (slideIndex == 2){
    slide2();
}
else {
    slide3();
}
}