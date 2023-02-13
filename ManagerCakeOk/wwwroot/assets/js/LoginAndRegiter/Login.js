

$("#Btn_Login").click(function(){
    $("#ErrorEmail").empty();
    $("#ErrorPassword").empty();

    var GetEmail;
    var GetPassword;

    var EmailVali = CheckEmailVali();
    if(EmailVali == true){
        GetEmail = $("#yourUsername").val();
    }else{
        $("#ErrorEmail").append("Vui lòng nhập vào Email");
        return;
    }

    var PasswordVali = CheckPasswordVali();
    if(PasswordVali == true){
        GetPassword = $("#yourPassword").val();
    }else{
        $("#ErrorPassword").append("Vui lòng nhập mật khẩu");
        return;
    }
    $("#modal_LoadingSignIn").show();
});

//validate Email
function CheckEmailVali(){
    var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
    var Acccount = $("#yourUsername").val();
    if(Acccount.match(mailformat)){
        return true;
    }else{
        return false;
    }
}

//Validate Password
function CheckPasswordVali(){
    var yourPassword = $("#yourPassword").val();
    if(yourPassword == ""){
        return false;
    }else{
        return true;
    }
}