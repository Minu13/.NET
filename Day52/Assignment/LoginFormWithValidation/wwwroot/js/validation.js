$(document).ready(function () {
    $("#loginForm").submit(function (event) {
        var username = $("#username").val();
        var password = $("#password").val();
        var isValid = true;

        $("#usernameError").text("");
        $("#passwordError").text("");

        if (username === "") {
            $("#usernameError").text("Username is required.");
            isValid = false;
        }

        if (password === "") {
            $("#passwordError").text("Password is required.");
            isValid = false;
        }

        if (!isValid) {
            event.preventDefault();
        }
    });
});