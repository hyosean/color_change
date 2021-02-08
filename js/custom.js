$(document).ready(function(){	

    var menuOpen = $('.menuBtnWrap');
    var menuClose = $('.gnb_menu .menuBtnClose');
     
    /*------- 상단 네비 탭 버튼 --------*/

	$('.nav>li>a').on('click', function(e) {
        e.preventDefault();

        var target = $(this).attr('href');
        var i = $(this).parent('li').index();

        menu_off();
        var_move();

        $('.nav>li>a').removeClass('on');
        $(this).addClass('on');
        $('.contents').removeClass('on');
        $(target).addClass('on');

        $('.img_wrap>.imgs').removeClass('on');
        $('.img_wrap>.imgs').eq(i).addClass('on');
        
        $('.img_wrap>.preview').removeClass('on');
        $('.img_wrap>.preview').eq(i).addClass('on');

    });

    /*------- 이미지 영역 하단 다음이미지 넘김버튼 --------*/
 
    $('.preview').on('click', function() {
        var target2 = $(this).attr('data');
        var idx = $(target2).index(); 

        menu_off();
        var_move();
        
        /*------- 글씨 컨텐츠 영역 활성화--------*/
        $('.contents').removeClass('on');
        $(target2).addClass('on');

        /*------- 상단 네비 탭 버튼 활성화--------*/
        $('.nav>li>a').removeClass('on');
        $('.nav>li').eq(idx).children('a').addClass('on');  

        /*------- 우측 이미지 영역 활성화 --------*/
        $('.img_wrap>.imgs').removeClass('on');
        $('.img_wrap>.imgs').eq(idx).addClass('on');

        $('.preview').removeClass('on');
        $('.preview').eq(idx).addClass('on');
        
    });

    /*------- 메뉴버튼 --------*/

    menuOpen.on('click', function() {
        menu_on();
    }); 

    menuClose.on('click', function() {
        menu_off();
    });

    /*------- 로그인 버튼 --------*/
    $('#sign_in').on('click', function(e) {
        e.preventDefault();

        menu_off();
        $('.img_wrap').addClass('sign_in');
        $('.sign_in_form').addClass('on');
    });

    function menu_on() {
        //사이드 GNB 배경색상 변수
        var backColor = $('.contents.on .products').css('background-color');

        $('.gnb_menu').css({
            'left' : 0,
            'background-color' : backColor
        });

        $('.menu_contents>ul>li').mouseenter(function() {
            $(this).children('a').css({'color':backColor});
            $(this).find('i').css({'color':backColor});
        });
        $('.menu_contents>ul>li').mouseleave(function() {
            $(this).children('a').css({'color': '#efefef'});
            $(this).find('i').css({'color': '#efefef'});
        });
        
    }

    function menu_off() {
        $('.gnb_menu').css({
            'left' : '-320px'
        });
    }

    function var_move() {
        $('.var>div').children('span').stop().animate({
            'width':'100%'
        },1000, function() {
            $(this).animate({
                'width':'0%'
            },10);
        });
    }
});	

