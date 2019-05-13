/*global document*/

function openModal(m) {

  document.getElementById('myModal').style.display = "block";
    
  if (m == 1){
      document.getElementById("first").src="img/an_theos1.jpg";
      document.getElementById("second").src="img/an_theos2.jpg";
      document.getElementById("third").src="img/an_theos3.jpg";
      document.getElementById("forth").src="img/an_theos4.jpg";
      
      document.getElementById("smallFirst").src="img/an_theos1.jpg";
      document.getElementById("smallSecond").src="img/an_theos2.jpg";
      document.getElementById("smallThird").src="img/an_theos3.jpg";
      document.getElementById("smallForth").src="img/an_theos4.jpg";
  }
  else if (m == 2) {
      document.getElementById("first").src="img/mayhem1.jpg";
      document.getElementById("second").src="img/mayhem2.jpg";
      document.getElementById("third").src="img/mayhem3.jpg";
      document.getElementById("forth").src="img/mayhem4.jpg";
      
      document.getElementById("smallFirst").src="img/mayhem1.jpg";
      document.getElementById("smallSecond").src="img/mayhem2.jpg";
      document.getElementById("smallThird").src="img/mayhem3.jpg";
      document.getElementById("smallForth").src="img/mayhem4.jpg";
  }
    else if (m == 3) {
      document.getElementById("first").src="img/dark_funeral2.jpg";
      document.getElementById("second").src="img/dark_funeral3.jpg";
      document.getElementById("third").src="img/dark_funeral4.jpg";
      document.getElementById("forth").src="img/dark_funeral5.jpg";
        
      document.getElementById("smallFirst").src="img/dark_funeral2.jpg";
      document.getElementById("smallSecond").src="img/dark_funeral3.jpg";
      document.getElementById("smallThird").src="img/dark_funeral4.jpg";
      document.getElementById("smallForth").src="img/dark_funeral5.jpg";
  }
      else if (m == 4) {
      document.getElementById("first").src="img/decapitated1.jpg";
      document.getElementById("second").src="img/decapitated2.jpg";
      document.getElementById("third").src="img/decapitated3.jpg";
      document.getElementById("forth").src="img/decapitated4.jpg";
      
      document.getElementById("smallFirst").src="img/decapitated1.jpg";
      document.getElementById("smallSecond").src="img/decapitated2.jpg";
      document.getElementById("smallThird").src="img/decapitated3.jpg";
      document.getElementById("smallForth").src="img/decapitated4.jpg";
  }
      else if (m == 5) {
      document.getElementById("first").src="img/obsidian_sea1.jpg";
      document.getElementById("second").src="img/obsidian_sea2.jpg";
      document.getElementById("third").src="img/obsidian_sea3.jpg";
      document.getElementById("forth").src="img/obsidian_sea4.jpg";
          
      document.getElementById("smallFirst").src="img/obsidian_sea1.jpg";
      document.getElementById("smallSecond").src="img/obsidian_sea2.jpg";
      document.getElementById("smallThird").src="img/obsidian_sea3.jpg";
      document.getElementById("smallForth").src="img/obsidian_sea4.jpg";
  }
      else if (m == 6) {
      document.getElementById("first").src="img/them_frequencies1.jpg";
      document.getElementById("second").src="img/them_frequencies2.jpg";
      document.getElementById("third").src="img/them_frequencies3.jpg";
      document.getElementById("forth").src="img/them_frequencies4.jpg";
          
      document.getElementById("smallFirst").src="img/them_frequencies1.jpg";
      document.getElementById("smallSecond").src="img/them_frequencies2.jpg";
      document.getElementById("smallThird").src="img/them_frequencies3.jpg";
      document.getElementById("smallForth").src="img/them_frequencies4.jpg";
  }
      else if (m == 7) {
      document.getElementById("first").src="img/powerwolf1.jpg";
      document.getElementById("second").src="img/powerwolf2.jpg";
      document.getElementById("third").src="img/powerwolf3.jpg";
      document.getElementById("forth").src="img/powerwolf4.jpg";
          
      document.getElementById("smallFirst").src="img/powerwolf1.jpg";
      document.getElementById("smallSecond").src="img/powerwolf2.jpg";
      document.getElementById("smallThird").src="img/powerwolf3.jpg";
      document.getElementById("smallForth").src="img/powerwolf4.jpg";
  }
      else if (m == 8) {
      document.getElementById("first").src="img/kreator1.jpg";
      document.getElementById("second").src="img/kreator2.jpg";
      document.getElementById("third").src="img/kreator3.jpg";
      document.getElementById("forth").src="img/kreator4.jpg";
          
      document.getElementById("smallFirst").src="img/kreator1.jpg";
      document.getElementById("smallSecond").src="img/kreator2.jpg";
      document.getElementById("smallThird").src="img/kreator3.jpg";
      document.getElementById("smallForth").src="img/kreator4.jpg";
  }
      else{
      document.getElementById("first").src="img/diary_of_dreams1.jpg";
      document.getElementById("second").src="img/diary_of_dreams2.jpg";
      document.getElementById("third").src="img/diary_of_dreams3.jpg";
      document.getElementById("forth").src="img/diary_of_dreams4.jpg";
          
      document.getElementById("smallFirst").src="img/diary_of_dreams1.jpg";
      document.getElementById("smallSecond").src="img/diary_of_dreams2.jpg";
      document.getElementById("smallThird").src="img/diary_of_dreams3.jpg";
      document.getElementById("smallForth").src="img/diary_of_dreams4.jpg";
  }
}

function closeModal() {
  document.getElementById('myModal').style.display = "none";
}

var slideIndex = 1;
showSlides(slideIndex);

function plusSlides(n) {
  showSlides(slideIndex += n);
}

function currentSlide(n) {
  showSlides(slideIndex = n);
}

function showSlides(n) {
  var i;
  var slides = document.getElementsByClassName("mySlides");
  var dots = document.getElementsByClassName("small_img");
  
  if (n > slides.length) {slideIndex = 1}
  if (n < 1) {slideIndex = slides.length}
  for (i = 0; i < slides.length; i++) {
      slides[i].style.display = "none";
  }
  for (i = 0; i < dots.length; i++) {
      dots[i].className = dots[i].className.replace(" active", "");
  }
  slides[slideIndex-1].style.display = "block";
  dots[slideIndex-1].className += " active";
}
