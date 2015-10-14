$(document).ready(function () {
    $("#btnSave").click(function () {
        profileManager.saveProfileInfo();
    });
});

var profileManager = {
    saveProfileInfo: function () {
        var jsonParam = 'user=' + login + '&pass=' + pass;
        var serviceUrl = "Service1.svc/Login/";
        AjaxManager.GetJson(serviceUrl, jsonParam, function (data) { alert(data); }, function (data) { alert(data); });

    }
};

var profileHelper = {

};