$(document).ready(function () {
    $("#btnSave").click(function () {
        profileManager.saveProfileInfo();
    });
});

var profileManager = {
    saveProfileInfo: function () {


        var jsonParam = profileHelper.createObjOfProfile();
        var serviceUrl = "Service1.svc/SaveOrUpdateProfile/";
        AjaxManager.GetJson(serviceUrl, jsonParam, function (data) { alert(data); }, function (data) { alert(data); });

    }
};

var profileHelper = {
    createObjOfProfile: function () {
        var obj = new Object();
        obj.ProfileId = ("#ProfileId").val();
        obj.FirstName = ("#FirstName").val();
        obj.LastName = ("#LastName").val();
        obj.MiddleName = ("#MiddleName").val();
        obj.Birthday = ("#Birthday").val();
        obj.Gender = ("#Gender").val();
        obj.BloodGroup = ("#BloodGroup").val();
        obj.Religious = ("#Religious").val();
        obj.Nationality = ("#Nationality").val();
        obj.NationalId = ("#NationalId").val();
        obj.BirthCertificate = ("#BirthCertificate").val();
        obj.PassportNo = ("#PassportNo").val();
        obj.SocialId = ("#SocialId").val();
        obj.About = ("#About").val();

        return obj;

    }
};