function valid() {
    var loi = true;
    //UserName
    name = document.getElementById("namedangky").value;
    loiName = document.getElementById("loiName");

    if (name.trim() == "") {
        loiName.innerHTML = "Tên không được để trống!";
        loi = false;
    } else {
        for (var i = 0; i < name.length; i++) {
            if (isNaN(name[i])) {
                loiName.innerHTML = "";
            } else {
                loiName.innerHTML = "Tên sai định dạng!";
                loi = false;
            }
        }
    }

    //Email
    email = document.getElementById("emaildangky").value;
    loiEmail = document.getElementById("loiEmail");

    if (email == "") {
        loiEmail.innerHTML = "Email không được để trống!";
        loi = false;
    } else {
        if (email.indexOf("@") > 0 && email.lastIndexOf(".") > email.lastIndexOf("@")) {
            loiEmail.innerHTML = "";
        } else {
            loiEmail.innerHTML = "Email sai định dạng!";
            loi = false;
        }
    }

    //Password && Repass
    pass = document.getElementById("passdangky").value;
    loiPass = document.getElementById("loiPass");
    repass = document.getElementById("repassdangky").value;
    loiRepass = document.getElementById("loiRepass");

    if (pass == "") {
        loiPass.innerHTML = "Mật khẩu không được để trống!";
        loi = false;
    } else {
        if (pass.length < 6) {
            loiPass.innerHTML = "Mật khẩu cẩn nhiều hơn 6 kí tự! ";
            loi = false;
        } else {
            loiPass.innerHTML = "";
        }
    }

    if (repass == "") {
        loiRepass.innerHTML = "Mật khẩu không được để trống!";
        loi = false;
    } else {
        if (repass.length < 6) {
            loiRepass.innerHTML = "Mật khẩu cẩn nhiều hơn 6 kí tự! ";
            loi = false;
        } else {
            loiRepass.innerHTML = "";
        }
    }


    return loi;
}