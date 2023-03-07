$(document).ready(function () {
    ko.applyBindings(staffdata, $("html")[0]);
    //get infomation account
    /*    CallApi()*/
});
function StudentModel(Count, FullName) {
    var _Self = this;
    _Self.Count = ko.observable(Count);
    _Self.FullName = ko.observable(FullName);
    _Self.FullNamesData = ko.observable(FullName.lastName + " " + FullName.fistName);
}
//Model View Model
function staffdata() {
    var _Self = this;
    _Self.Email = ko.observable();
    _Self.CoustomerStaff = ko.observable();
    _Self.DateCreate = ko.observable();
    _Self.StaffChef = ko.observable();
    _Self.IdStaff = ko.observable();
    _Self.FollowData = ko.observable();
    _Self.Detail = [
        { fistName: "Tuong", lastName: "Tran" },
        { fistName: "Duong", lastName: "Nguyen" },
        { fistName: "Nhu", lastName: "Huynh" },
    ]
    _Self.ListStudent = [];

    _Self.Detail.forEach(function (item, index) {
        var DataItem = new StudentModel(index, item);
        _Self.ListStudent.unshift(DataItem);
    })

    _Self.InfoAccout = function () {
        GetInfoStaff();
    };
    _Self.ChangeAccount = function () {

    };
    _Self.ChangeInfoAccout = function () {

    };
    _Self.SaveAccount = function () {

    };
    _Self.BlockAccount = function () {

    }
    //var Id = $("#IdAccount").val();
    //if (Id.lenght == 0 || Id == '') {
    //    toastr.error("Thông Báo Lỗi", "Id không chính xác hoặc bị bỏ trống!");
    //} else {
    //    $.ajax({
    //        url: "/Account/DetailAccountPost",
    //        type: "post",
    //        data: {
    //            IdAccount: Id
    //        },
    //        success: function (result) {
    //            _Self.FollowData.subscribe(function () {
    //                _Self.Email = result.email;
    //                _Self.CoustomerStaff = result.nameCustomerOfStaff;
    //                _Self.DateCreate = result.createDate;
    //                _Self.StaffChef = result.nameStaffOrChef;
    //                _Self.IdStaff = result.idStaff;
    //                console.log(_Self.Email);
    //            })
    //        }
    //    });
    //    return;
    //}

}
//var AccountStaff = function (){
//    Email: ko.observable(),
//    CoustomerStaff: ko.observable(),
//    DateCreate: ko.observable(),
//    StaffChef: ko.observable(),
//    IdStaff: ko.observable(),

//    InfoAccout: function () { 
//        GetInfoStaff();
//    },
//    ChangeAccount: function () {

//    },
//    ChangeInfoAccout: function () {

//    },
//    SaveAccount: function () {

//    },
//    BlockAccount: function () {

//    },
//};
//Call Api
function CallApi() {
    var Id = $("#IdAccount").val();
    if (Id.lenght == 0 || Id == '') {
        toastr.error("Thông Báo Lỗi", "Id không chính xác hoặc bị bỏ trống!");
    } else {
        $.ajax({
            url: "/Account/DetailAccountPost",
            type: "post",
            data: {
                IdAccount: Id
            },
            success: function (result) {
                var Vm = new staffdata();
                Vm.Email = result.email;
                Vm.CoustomerStaff(result.nameCustomerOfStaff);
                Vm.DateCreate(result.createDate);
                Vm.StaffChef(result.nameStaffOrChef);
                Vm.IdStaff(result.idStaff);
            }
        });
        return;
    }
}

//get info staff by id
function GetInfoStaff() {
    var Id = $("#Txt_IdStaff").val();
    console.log(Id);
};

