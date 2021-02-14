$(document).ready(function () {

   /*------- 로그인 버튼 --------*/
    var backColor = $('.on .colorBtn').css('background-color');

    $('.sign_tab >li.on').css({
        'background-color': backColor
    });

    $('.colorBtnInput').css({
        'background-color': backColor
    });

    $('.sign_in >.imgs').eq(i).addClass('on');
});