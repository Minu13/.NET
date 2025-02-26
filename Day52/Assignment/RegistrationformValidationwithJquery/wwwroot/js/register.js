$(document).ready(function () {
    $("#registrationForm").validate({
        rules: {
            firstName: {
                required: true
            },
            lastName: {
                required: true
            }
        },
        messages: {
            firstName: {
                required: "First name is required"
            },
            lastName: {
                required: "Last name is required"
            }
        },
        submitHandler: function (form) {
            form.submit();
        }

    });

});