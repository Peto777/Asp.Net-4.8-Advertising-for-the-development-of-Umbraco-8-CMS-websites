$(document).ready(function () {
    // Contact
    ContactFormApi();
});

/* contact */
function ContactFormApi() {
    if ($('.api-password-group').length > 0) {
        $.ajax('/Umbraco/TvorbaWebu/TvorbaWebuApi/ContactFormApiKey',
            {
                type: 'POST',
                success: function (data) {
                    $('.api-password-group #Password').val(data.MainKey);
                    $('.api-password-group #ConfirmPassword').val(data.SubKey);
                }
            });
    }
}