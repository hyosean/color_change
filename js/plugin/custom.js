$(document).ready(function () {
    var $grid;
    setTimeout(function () {
        $grid = $('.img_list_inner').isotope({ //모션적용될 박스의 부모태그 선택자
            itemSelector: '.sorting_img', //모션적용될 박스 선택자
            columnWidth: '.sorting_img', //모션적용될 박스 선택자
            transitionDuration: '0.5s', //모션 시간
            percentPosition: true //박스넓이값을 퍼센트일떄 true, 고정 false
        });

        $('.img_list').addClass('on');
    }, 1000);


    $('.img_list_btn li').on('click', function (e) { //버튼 선택자
        e.preventDefault();

        var sort = $(this).children('a').attr('href');

        $grid.isotope({
            filter: sort
        })
        //버튼 색상
        $('.img_list_btn li').removeClass('on');
        $(this).addClass('on');
    })


});