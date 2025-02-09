// Calculator logic
$('#calculate-btn').on('click', function () {
    var hours = parseFloat($('#hours').val());
    if (isNaN(hours) || hours <= 0) {
        $('#hours-error').text('Please enter a positive number');//update the error message
        return;
    } //check if hours is a number and greater than 0
    var rate = parseFloat($('#rate').val());
    var total = hours * rate;
    $('#total').val(`$${total.toFixed(2)}`);//update the total
    $('#total').css('color', '#000');//update the total color
    $('#hours-error').text('');//clear the error message if any
    return false;
});

// Animation
$(document).ready(function () {
    // Hide the images
    $("#char1, #char2, #char3").css("opacity", 0);

    // Fade in the images one at a time
    var images = $("#char1, #char2, #char3");
    var delay = 0;
    images.each(function () {
        $(this).delay(delay).fadeTo(2000, 1);
        delay += 350; // increase the delay by 500ms for each image
    });
});

$(document).ready(function () {
    // Hide the images
    $("#char1-name, #char2-name, #char3-name").css("opacity", 0);

    // Fade in the images one at a time
    var images = $("#char1-name, #char2-name, #char3-name");
    var delay = 1000;
    images.each(function () {
        $(this).delay(delay).fadeTo(2000, 1);
        delay += 350; // increase the delay by 500ms for each image
    });
});