$(document).ready(function () {
    // Autocomplete off
    $(".form-item input").attr("autocomplete", "off");
    $("input.no-autocomplete").attr("autocomplete", "off");
    // Submenu
    $('ul.nav li.dropdown').hover(
        function () { $(this).addClass('open'); },
        function () { $(this).removeClass('open'); }
    );
});


function twSendQuote() {
    $('.quote-send-btn').addClass('hidden');
    $('.quote-send-pending').removeClass('hidden');
    document.getElementById('submitButton').click();
    setTimeout(function () {
        $('.quote-send-pending').addClass('hidden');
        $('.quote-send-btn').removeClass('hidden');
    }, 500);
}

