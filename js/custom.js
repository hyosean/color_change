$(document).ready(function () {

    var menuOpen = $('.menuBtnWrap');
    var menuClose = $('.gnb_menu .menuBtnClose');

    /*------- 상단 네비 비쥬얼 컨텐츠 버튼 --------*/

    $('.contants_lnb li>a').on('click', function () {

        var target = $(this).attr('href');
        var i = $(this).parent('li').index();

        menu_off();
        var_move();

        $('.contants_lnb li>a').removeClass('on');
        $(this).addClass('on');
        $('.contents').removeClass('on');
        $(target).addClass('on');

        $('.img_wrap>.imgs').removeClass('on');
        $('.img_wrap>.imgs').eq(i).addClass('on');

        $('.img_wrap>.preview').removeClass('on');
        $('.img_wrap>.preview').eq(i).addClass('on');

    });

    /*------- 이미지 영역 하단 다음이미지 넘김버튼 --------*/

    $('.preview').on('click', function () {
        var target2 = $(this).attr('data');
        var idx = $(target2).index();

        menu_off();
        var_move();

        /*------- 글씨 컨텐츠 영역 활성화--------*/
        $('.contents').removeClass('on');
        $(target2).addClass('on');

        /*------- 상단 네비 탭 버튼 활성화--------*/
        $('.contants_lnb>li>a').removeClass('on');
        $('.contants_lnb>li').eq(idx).children('a').addClass('on');

        /*------- 우측 이미지 영역 활성화 --------*/
        $('.img_wrap>.imgs').removeClass('on');
        $('.img_wrap>.imgs').eq(idx).addClass('on');

        $('.preview').removeClass('on');
        $('.preview').eq(idx).addClass('on');

    });

    /*------- 서브페이지 탭 모바일 상단 lnb 슬라이드시 그림자 --------*/
    
    $(window).on('scroll', function() {
         $('.sub_inner > nav').css({
                    'box-shadow': 'none'
                })
        if($(window).width() < 1000) { 
            var navTop = $('.sub_inner > nav').offset().top;
            console.log(navTop);
            if( navTop > 30) {
                $('.sub_inner > nav').css({
                    'box-shadow':'0px 0px 7px rgb(0,0,0,0.3)'
                })
            }else {
                $('.sub_inner > nav').css({
                    'box-shadow': 'none'
                })
            }
        } 
    });

    /*------- 사이드 gnb 메뉴버튼 --------*/
    //사이드 메뉴열기
    menuOpen.on('click', function () {
        menu_on();
    });
    //사이드메뉴 닫기
    menuClose.on('click', function () {
        menu_off();
    });
    //사이드 메뉴 이동시
    // $('.menu_contents li>a').on('click', function() {
    // });

    /*------- 로그인 버튼 --------*/
    $('.signInBtn').on('click', function () {
        menu_off();
        $('.img_wrap').addClass('sign_in');
        $('.sign_in_form').addClass('on');

        var backColor = $('.contents.on .colorBtn').css('background-color');

        $('.sign_tab >li.on').css({
            'background-color': backColor
        });

        $('.colorBtnInput').css({
            'background-color': backColor
        });
    });

    /*------- 로그인 & 회원가입 탭 버튼 --------*/
    $('.sign_tab li').on('click', function () {
        $('.sign_tab li').removeClass('on');
        $(this).addClass('on');

        var backColor = $('.colorBtnInput').css('background-color');
        var hasClass = $('.sign_tab li').hasClass('on');
        var idx = $('.sign_tab >li.on').index();
        if (hasClass) {
            console.log(idx);
            $('.sign_tab >li').css({
                'background-color': '#efefef'
            });
            $('.sign_tab >li.on').css({
                'background-color': backColor
            });
            $('.sign_in_wrap').removeClass('on');
            $('.sign_in_wrap').eq(idx).addClass('on');
        }

    });
    /*------- 인풋 링크 버튼 --------*/
    $('.input_link_text').on('mouseover', function () {
        var backColor = $('.colorBtnInput').css('background-color');
        $(this).css({
            'color': backColor
        })
    });
    $('.input_link_text').on('mouseleave', function () {
        $(this).css({
            'color': '#777'
        })
    });


    /*------- 색상 함수 --------*/
    function menu_on() {
        //사이드 GNB 배경색상 변수
        var backColor = $('.on .colorBtn').css('background-color');

        $('.gnb_menu').css({
            'left': 0,
            'background-color': backColor
        });

        $('.menu_contents>ul>li').mouseenter(function () {
            $(this).children('a').css({
                'color': backColor
            });
            $(this).find('i').css({
                'color': backColor
            });
        });
        $('.menu_contents>ul>li').mouseleave(function () {
            $(this).children('a').css({
                'color': '#efefef'
            });
            $(this).find('i').css({
                'color': '#efefef'
            });
        });
    }

    function menu_off() {
        $('.gnb_menu').css({
            'left': '-320px'
        });
    }

    function var_move() {
        $('.var>div').children('span').stop().animate({
            'width': '100%'
        }, 1000, function () {
            $(this).animate({
                'width': '0%'
            }, 10);
        });
    }
});