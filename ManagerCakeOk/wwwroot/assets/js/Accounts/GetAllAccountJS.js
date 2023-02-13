$(document).ready(function () {
    LoadDataAccount()
});
var PageIndex = 1;
var PageSize = 10;

//load data account
function LoadDataAccount() {
    $("#BodyData").empty();
    $("#TotalAccount").empty();
    $("#PageItem").empty();
    $("#ItemInPage").empty();
    var count = 0;
    $.ajax({
        url: "/Account/GetAllAccountStaff",
        type: "get",
        success: function (result) {
            $.each(result.l_Account, function (key, item) {
                count++;
                var Html = '';
                Html += '<tr id="' + item.idAccount + '">';
                Html += '<th scope="row">' + count + '</th>';
                Html += '<td>' + item.fullname + '</td>';
                Html += '<td>' + item.email + '</td>';
                Html += '<td>' + item.createDate + '</td>';
                Html += '<td><a href="/Citys/PageDetailCity/?Id=' + item.id + '" data-bs-toggle="tooltip" data-bs-placement="top" title="Xem Quận/Huyện Thuộc">'
                    + '<i class="fas fa-folder-open"></i></a> | '
                    + ' <button style="border: none; background: none; color: blue;" name="BtnEditCity" data-bs-toggle="tooltip" data-bs-placement="top" title="Cập Nhật" />'
                    + '<i class="fas fa-edit"></i></a> | '
                    + ' <button style="border: none; background: none; color: blue;" name="BtnEditStatus" data-bs-toggle="tooltip" data-bs-placement="top" title="Đổi Trạng Thái" />'
                    + '<i class="fas fa-cog"></i></a>'
                    + '</td>';
                Html += '</tr>';
                $("#BodyData").append(Html);
            })
            $("#PageItem").append(PageIndex);
            $("#ItemInPage").append(count);
            $("#TotalAccount").append(result.total);
            //paing
            paging(Result.total, function () {
                LoadDataAccount();
            })
        }
    })
}

//----------------------------------------------
//paing
function paging(totalRoll, callback) {
    var totalPage = Math.ceil(totalRoll / PageSize);
    $('#pagination').twbsPagination({
        totalPages: (totalPage == 0) ? 1 : totalPage,
        first: "Đầu",
        next: "Tiếp",
        last: "Cuối",
        prev: "Trước",
        visiblePages: 10,
        onPageClick: function (event, page) {
            PageIndex = page;
            setTimeout(callback, 200);
        }
    });
}