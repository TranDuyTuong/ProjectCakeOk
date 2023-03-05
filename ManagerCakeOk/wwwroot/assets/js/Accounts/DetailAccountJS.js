//Model View Model
function AccountStaff() {
    var _self = this;
    _self.Email = ko.observable('duytuong@gmail.com');
    _self.CoustomerStaff = ko.observable('');
    _self.DateCreate = ko.observable('');
    _self.RoleName = ko.observable('');
    _self.StaffChef = ko.observable('');

    _self.InfoAccout = function () {

    };
    _self.ChangeAccount = function () {

    };
    _self.ChangeInfoAccout = function () {

    };
    _self.SaveAccount = function () {

    };
    _self.BlockAccount = function () {

    };
    ////get infomation account
    //var Id = $('#IdAccount');
    //CallApi(Id);
}

//Call Api
//function CallApi(IdAccount) {
//    var Id = $('#IdAccount');
//    if (Id.lenght == 0 || Id == '') {
//        toastr.error("Thông Báo Lỗi", "Id không chính xác hoặc bị bỏ trống!");
//    } else {
//        $.ajax({
//            url: "/Account/DetailAccountPost",
//            type: "post",
//            data: {
//                IdAccount: Id
//            },
//            success: function (result) {
//                var Model_R = (new AccountStaff());
//                Model_R.Email = result.email;
//            }
//        })
//    }
//    return;
//}

