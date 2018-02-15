$(function () {
    $("#head-title").typed({
        strings: ["We are developers^1000", "We can get things done!^1000", "24/7 available for hire^1000"],
        typeSpeed: 100,
        loop: true,
        startDelay: 100
    });
});
$(function () {
    $("#btnSendMail").click(function () {
        var data = $("form").serializeArray();
        console.log(data);
        toggleLoader();
        $.ajax({
            type: "GET",
            data: data,
            url: "Home/SendMail",
            success: function (result) {
                toggleLoader();
                if (result && result.isSuccess) {
                    popupShow(result.Message)
                }
                else {
                    popupShow(result.Message)
                }
            },
            error: function (result) {
                toggleLoader();
                popupShow(result.Message)
            }
        });
    });
});
$(document).ready(function () {
    var owl = $('.testimonial');
    owl.owlCarousel({
        items: 1,
        loop: true,
        margin: 100,
        autoplay: true,
        autoplayTimeout: 3000,
        dots: true,
    });
})
function fnFacebookClick() {
    window.open('http://www.facebook.com/sharer.php?u=https://www.facebook.com/Codebbed-849208365280211/', 'popwin', 'width=640, height=480');
}
function fnLinkedClick() {
    window.open('https://www.linkedin.com/shareArticle?url=https://www.linkedin.com/company/codebbed', 'popwin', 'width=640, height=480');
}

function popupShow(message) {
    $('#popup').modal('show');
    $("#message").text(message);
}

function toggleLoader() {
    if ($("html").hasClass("hide-scroll")) {
        $("#overlay").hide();
        $("html").removeClass("hide-scroll");
    }
    else {
        $("#overlay").show();
        $("html").addClass("hide-scroll");
    }
}

function fnToggleSideBar() {
    //debugger;
    //if ($('#toggleSideBar').hasClass('fa fa-angle-double-left')) {
    //    $('#toggleSideBar').removeClass('fa fa-angle-double-left');
    //    $('#toggleSideBar').addClass('fa fa-angle-double-right');
    //    $('#socialLinksSideBar').css('display', 'none');
    //}
    //else {
    //    $('#toggleSideBar').removeClass('fa fa-angle-double-right');
    //    $('#toggleSideBar').addClass('fa fa-angle-double-left');
    //    $('#socialLinksSideBar').css('display', 'block');
    //}
    if ($('#socialLinksSideBar').css('display') == 'block') {
        $('#socialLinksSideBar').css('display', 'none');
    }
    else {

        $('#socialLinksSideBar').css('display', 'block');
    }
}
