$(document).ready(function () {
    LoadData();
});

//load data
function LoadData() {
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