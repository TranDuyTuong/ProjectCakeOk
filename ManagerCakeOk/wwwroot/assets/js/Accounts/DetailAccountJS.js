$(document).ready(function () {
    ko.applyBindings(AccountStaff, $("html")[0]);
    //get infomation account
    CallApi()
});
var Country = function (name, population) {
    this.countryName = name;
    this.countryPopulation = population;
};
//Model View Model
var AccountStaff = {
    Email: ko.observable(),
    CoustomerStaff: ko.observable(),
    DateCreate: ko.observable(),
    StaffChef: ko.observable(),
    IdStaff: ko.observable(),
    availableCountries: ko.observableArray([
        new Country("VN", 2000),
        new Country("US", 2000),
        new Country("EN", 2000)
    ]),
    selectedCountry: ko.observable(),

    InfoAccout: function () {
        GetInfoStaff();
    },
    ChangeAccount: function () {

    },
    ChangeInfoAccout: function () {

    },
    SaveAccount: function () {

    },
    BlockAccount: function () {

    },
};
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
                AccountStaff.Email(result.email);
                AccountStaff.CoustomerStaff(result.nameCustomerOfStaff);
                AccountStaff.DateCreate(result.createDate);
                AccountStaff.StaffChef(result.nameStaffOrChef);
                AccountStaff.IdStaff(result.idStaff);
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

