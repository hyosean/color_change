$(document).ready(function() {

    /* 전체창 열기 닫기 */

    $('.products').on('click', function(e) {
        e.preventDefault();

        var aside = $(this).children('a').attr('href');
        console.log(aside);

        $('#aside').stop().fadeIn();

        $('.wrap').removeClass('on');
        $(aside).addClass('on');

        $('.products').removeClass('on');
        $(this).addClass('on');

    });

    $('.close').on('click', function() {
        $('#aside').stop().fadeOut();
        $('.wrap').removeClass('on');
    });


   /* 슬라이드 모션 */

   $('.prev').on('click', function(e) {
       e.preventDefault();

       var hasOn = $('.wrap').hasClass('on');
       if(hasOn) {
        
            $('.idx1').stop().animate({
                'margin-left':'-200%'
            },500,function() {
                $('.idx1').children('li').first().appendTo($('.idx1'));

                $('.idx1').css({
                    'margin-left':'-100%'
                });
            });

            $('.idx2').stop().animate({
                'margin-left':'-200%'
            },500,function() {
                $('.idx2').children('li').first().appendTo($('.idx2'));

                $('.idx2').css({
                    'margin-left':'-100%'
                });
            });

            $('.idx3').stop().animate({
                'margin-left':'-200%'
            },500,function() {
                $('.idx3').children('li').first().appendTo($('.idx3'));

                $('.idx3').css({
                    'margin-left':'-100%'
                });
            });

            $('.idx4').stop().animate({
                'margin-left':'-200%'
            },500,function() {
                $('.idx4').children('li').first().appendTo($('.idx4'));

                $('.idx4').css({
                    'margin-left':'-100%'
                });
            });
       }
    });

   $('.next').on('click', function(e) {
        e.preventDefault();

        var hasOn = $('.wrap').hasClass('on');
        if(hasOn) {
            $('.idx1').stop().animate({
                'margin-left':'0%'
            },500,function() {
                $('.idx1').children('li').last().prependTo($('.idx1'));
    
                $('.idx1').css({
                    'margin-left':'-100%'
                });
            });

            $('.idx2').stop().animate({
                'margin-left':'0%'
            },500,function() {
                $('.idx2').children('li').last().prependTo($('.idx2'));
    
                $('.idx2').css({
                    'margin-left':'-100%'
                });
            });

            $('.idx3').stop().animate({
                'margin-left':'0%'
            },500,function() {
                $('.idx3').children('li').last().prependTo($('.idx3'));
    
                $('.idx3').css({
                    'margin-left':'-100%'
                });
            });

            $('.idx4').stop().animate({
                'margin-left':'0%'
            },500,function() {
                $('.idx4').children('li').last().prependTo($('.idx4'));
    
                $('.idx4').css({
                    'margin-left':'-100%'
                });
            });
        }
       
    });

});