function solve() {
    let isCompany = false;
    setEventHandlers();

    function setEventHandlers() {
        $('#registerForm').submit(function (e) {
            e.preventDefault();
            validate();
        });

        $('#company').on("change", function () {
           if ($('#company').is(":checked")) {
               $('#companyInfo').show();
               isCompany = true;
           } else {
               $('#companyInfo').hide();
               isCompany = false;
           }
        });
    }


    function validate() {
        let isValid = true;

        let username = $('#username').val();
        if (!username.match(/^[a-zA-Z0-9]{3,20}$/)) {
            $('#username').css('border-color', 'red');
            isValid = false;
        } else {
            $('#username').css('border', 'none');
        }

        let email = $('#email').val();
        if (!email.match(/^.*@.*\..*$/)) {
            $('#email').css('border-color', 'red');
            isValid = false;
        } else {
            $('#email').css('border', 'none');
        }

        let password = $('#password').val();
        let confirmPassword = $('#confirm-password').val();
        if (!password.match(/^[\w]{5,15}$/) ||
            !confirmPassword.match(/^[\w]{5,15}$/) ||
            password != confirmPassword) {
            $('#password').css('border-color', 'red');
            $('#confirm-password').css('border-color', 'red');
            isValid = false;
        } else {
            $('#password').css('border', 'none');
            $('#confirm-password').css('border', 'none');
        }

        if (isCompany) {
            let companyNumber = $('#companyNumber').val();
            if (companyNumber < 1000 || 9999 < companyNumber) {
                $('#companyNumber').css('border-color', 'red');
                isValid = false;
            } else {
                $('#companyNumber').css('border', 'none');
            }
        }

        if (isValid) {
            $('#valid').show();
        }
    }

}