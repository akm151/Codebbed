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
        var data = JSON.stringify($("form").serializeObject());
        //console.log(data);
        toggleLoader();
        $.ajax({
            type: "POST",
            data: data,
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            url: "Home/SendMail",
            success: function (result) {
                toggleLoader();
                if (result && result.Message) {
                    popupShow(result.Message)
                } else {
                    popupShow("Some error occurred");
                }
            },
            error: function (xhr, ex) {
                toggleLoader();
                popupShow("Some error occurred");
                console.log(JSON.parse(xhr.responseText)["Data"]);
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
    if ($('#socialLinksSideBar').css('display') == 'block') {
        $('#socialLinksSideBar').css('display', 'none');
    }
    else {

        $('#socialLinksSideBar').css('display', 'block');
    }
}

$.fn.serializeObject = function () {
    var o = {};
    var a = this.serializeArray();
    $.each(a, function () {
        if (o[this.name] !== undefined) {
            if (!o[this.name].push) {
                o[this.name] = [o[this.name]];
            }
            o[this.name].push(this.value || '');
        } else {
            o[this.name] = this.value || '';
        }
    });
    return o;
};

function adjustMobileHeader() {
    if ($('#home').hasClass('home-margin-top')) {
        $('#home').removeClass('home-margin-top');
    }
    else {
        $('#home').addClass('home-margin-top');
    }
}

function removeExtraMargin() {
    if ($('button#open-menu').css('display') == 'none') {
        $('#home').removeClass('home-margin-top');
    }
}