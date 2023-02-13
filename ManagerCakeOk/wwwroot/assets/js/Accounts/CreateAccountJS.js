$(document).ready(function () {
    LoadData();
});

//load data
function LoadData() {
    //empty form error
    $("#ErrorMarriage").empty();
    $("#ErrorCity").empty();
    $("#ErrorDistrict").empty();
    $("#ErrorGender").empty();
    $("#ErrorStaffChef").empty();
    $("#ErrorRole").empty();

    //-------------------------
    $("#Select_Marriage").empty();
    $("#Select_City").empty();
    $("#Select_Gender").empty();
    $("#Select_StaffChef").empty();
    $("#Select_Role").empty();
    $.ajax({
        url: "/Account/CreateAccountGet",
        type: "get",
        success: function (result) {
            //marriage
            var HtmlMarraige = '';
            HtmlMarraige = '<option selected value="0">Vui lòng chọn</option>';
            $("#Select_Marriage").append(HtmlMarraige);
            $.each(result.l_Marriage, function (key, item) {
                var Html = '';
                Html = '<option value="' + item.id + '">' + item.name + '</option>';
                $("#Select_Marriage").append(Html);
            });

            //City
            var HtmlCity = '';
            HtmlCity = '<option selected value="0">Vui lòng chọn</option>';
            $("#Select_City").append(HtmlCity);
            $.each(result.l_City, function (key, item) {
                var Html = '';
                Html = '<option value="' + item.id + '">' + item.nameCity + '</option>';
                $("#Select_City").append(Html);
            });

            //Gender
            var HtmlGender = '';
            HtmlGender = '<option selected value="0">Vui lòng chọn</option>';
            $("#Select_Gender").append(HtmlGender);
            $.each(result.l_Gender, function (key, item) {
                var Html = '';
                Html = '<option value="' + item.id + '">' + item.name + '</option>';
                $("#Select_Gender").append(Html);
            });

            //Staff or Chef
            var HtmlStaffChef = '';
            HtmlStaffChef = '<option selected value="0">Vui lòng chọn</option>';
            $("#Select_StaffChef").append(HtmlStaffChef);
            $.each(result.l_StaffChef, function (key, item) {
                var Html = '';
                Html = '<option value="' + item.id + '">' + item.name + '</option>';
                $("#Select_StaffChef").append(Html);
            });

            //Role
            var HtmlRole = '';
            HtmlRole = '<option selected value="0">Vui lòng chọn</option>';
            $("#Select_Role").append(HtmlRole);
            $.each(result.l_Role, function (key, item) {
                var Html = '';
                Html = '<option value="' + item.iDRole + '">' + item.nameRole + '</option>';
                $("#Select_Role").append(Html);
            });
        }
    })
}

//validate data input
function Vali_Marriage() {
    var Item = $("#Select_Marriage").val();
    if (Item == 0) {
        return false;
    } else {
        return true;
    }
}
function Vali_City() {
    var Item = $("#Select_City").val();
    if (Item == 0) {
        return false;
    } else {
        return true;
    }
}
function Vali_Gender() {
    var Item = $("#Select_Gender").val();
    if (Item == 0) {
        return false;
    } else {
        return true;
    }
}
function Vali_StaffChef() {
    var Item = $("#Select_StaffChef").val();
    if (Item == 0) {
        return false;
    } else {
        return true;
    }
}
function Vali_Role() {
    var Item = $("#Select_Role").val();
    if (Item == 0) {
        return false;
    } else {
        return true;
    }
}

//Validate Infomation Account
function Vali_Email() {
    var item = $("#TxtEmail").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}
function Vali_PassWord() {
    var item = $("#TxtPassWord").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}
function Vali_PassWordConFirm() {
    var item = $("#TxtPassWordConfirm").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}
function Vali_Phone() {
    var item = $("#TxtPhone").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}
function Vali_File() {
    var item = $("#TxtFile").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}

//validate infomation staff
function Vali_NameStaff() {
    var item = $("#TxtNameSatff").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}
function Vali_BirthdayStaff() {
    var item = $("#TxtBirthday").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}
function Vali_AddressStaff() {
    var item = $("#TxtAddress").val();
    if (item.length == 0 || item == '') {
        return false;
    } else {
        return true;
    }
}

//validate selection 
$("#Select_Marriage").change(function () {
    $("#ErrorMarriage").empty();
    var item = $("#Select_Marriage").val();
    if (item == 0) {
        $("#ErrorMarriage").append("Vui Lòng Chọn Tình Trạng Hôn Nhân!");
    }
    return;
});

$("#Select_City").change(function () {
    $("#ErrorCity").empty();
    var item = $("#Select_City").val();
    if (item == 0) {
        $("#ErrorDistrict").empty();
        $("#ErrorCity").append("Vui Lòng Chọn Tỉnh/Tp!");
        $("#Select_District").empty();
        $("#Select_District").prop("disabled", true);
        var HtmlDefaul = '<option selected value="0">Vui lòng chọn</option>';
        $("#Select_District").append(HtmlDefaul);
    } else {
        //call all distric by this city
        $.ajax({
            url: "/Districts/GetAllDistricById",
            type: "get",
            data: {
                IdCity: item
            },
            success: function (result) {
                $("#Select_District").empty();
                $("#Select_District").prop("disabled", false);
                var HtmlDefaul = '<option selected value="0">Vui lòng chọn</option>';
                $("#Select_District").append(HtmlDefaul);
                $.each(result, function (key, item) {
                    var Html = "";
                    Html += '<option value="' + item.id + '">' + item.name + '</option>';
                    $("#Select_District").append(Html);
                })
            }
        })
    }
    return;
})

$("#Select_District").change(function () {
    $("#ErrorDistrict").empty();
    var item = $("#Select_District").val();
    if (item == 0) {
        $("#ErrorDistrict").append("Vui Lòng Chọn Quận/Huyện!");
    }
    return;
})

$("#Select_Gender").change(function () {
    $("#ErrorGender").empty();
    var item = $("#Select_Gender").val();
    if (item == 0) {
        $("#ErrorGender").append("Vui Lòng Chọn Giới Tính!");
    }
    return;
})

$("#Select_StaffChef").change(function () {
    $("#ErrorStaffChef").empty();
    var item = $("#Select_StaffChef").val();
    if (item == 0) {
        $("#ErrorStaffChef").append("Vui Lòng Chọn Nhân Viên Hoặc Đầu Bếp!");
    }
    return;
})

$("#Select_Role").change(function () {
    $("#ErrorRole").empty();
    var item = $("#Select_Role").val();
    if (item == 0) {
        $("#ErrorRole").append("Vui Lòng Chọn Quyền!");
    }
    return;
})

//Show Password
function ShowPassword() {
    var x = document.getElementById("TxtPassWord");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}

function ShowPasswordConfirm() {
    var x = document.getElementById("TxtPassWordConfirm");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}

//Check password special character
function CheckSpecialCharacter() {
    var Item = $("#TxtPassWord").val();
    var R_Expression = /^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{6,16}$/;
    if (!R_Expression.test(Item)) {
        EmptyNotification();
        $("#ErrorPassword").append("Mật khẩu phải có chứa số và ký tự đặt biệt");
        return false;
    } else {
        return true;
    }
}

//Empty Notification Error
function EmptyNotification() {
    $("#ErrorEmail").empty();
    $("#ErrorPassword").empty();
    $("#ErrorPasswordConfirm").empty();
    $("#ErrorPhone").empty();
    $("#ErrorFile").empty();
};

//Create Staff
$("#Btn_Create").click(function () {
    //Empty Notification Error
    EmptyNotification()

    //Check Validate Infomation Account
    var Email = Vali_Email();
    if (Email == false) {
        $("#ErrorEmail").append("Vui lòng không bỏ trống");
        return;
    }
});