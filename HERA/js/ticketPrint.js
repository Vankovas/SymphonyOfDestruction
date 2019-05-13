(function () {
  var printClass = 'section-to-print';

  $('.ticketImage').on('click', function () {
    var parent = $(this).parents('.ticketWrapper').first();

    $('.ticketWrapper').removeClass(printClass);
    $(parent).addClass(printClass);
  });
});
