function valid() {
    loi = true;
    //Email
    email = document.getElementById("emaildangnhap").value;
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

    //Password 
    pass = document.getElementById("passworddangnhap").value;
    loiPass = document.getElementById("loiPass");
   
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

    return loi;
}