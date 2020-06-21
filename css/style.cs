@charset "UTF-8";
@import url("https://fonts.googleapis.com/css?family=Anaheim|Changa|Cormorant+SC|DM+Serif+Display|Do+Hyeon|Krona+One|Roboto|Roboto+Condensed|Titillium+Web&display=swap");
* {
  margin: 0;
  padding: 0; }

ul, ol, li {
  list-style: none; }

a, img {
  vertical-align: top;
  text-decoration: none;
  outline: 1; }

/*--- 버튼 클릭시 숨겨진영역 ---*/
#aside {
  position: fixed;
  width: 100%;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background: rgba(0, 0, 0, 0.8);
  z-index: 9;
  display: none; }
  #aside .btn .prev {
    position: absolute;
    left: 7%;
    opacity: 0.5;
    top: 50%;
    margin-top: -40px;
    width: 80px;
    height: 80px;
    background: url(../img/btn/btn_prev.png) no-repeat center center/cover; }
  #aside .btn .next {
    position: absolute;
    right: 7%;
    opacity: 0.5;
    top: 50%;
    margin-top: -40px;
    width: 80px;
    height: 80px;
    background: url(../img/btn/btn_next.png) no-repeat center center/cover; }
  #aside .btn .close {
    position: absolute;
    bottom: 6%;
    right: 7%;
    width: 55px;
    height: 55px;
    background: url(../img/btn/close.png) no-repeat center center/cover; }
    #aside .btn .close::after {
      content: 'CLOSE';
      display: block;
      font-size: 20px;
      color: #fff;
      margin-left: -55px;
      opacity: 0.45;
      margin-top: 13px;
      letter-spacing: 2px; }
  #aside .wrap {
    overflow: hidden;
    position: absolute;
    top: 50%;
    transform: translateY(-50%);
    width: 100%;
    display: none; }
    #aside .wrap.on {
      display: block; }
      #aside .wrap.on ul {
        width: 300%;
        margin-left: -100%; }
        #aside .wrap.on ul li {
          float: left;
          display: block;
          width: 33.333%;
          height: 65vh; }
        #aside .wrap.on ul.idx1 .img1 {
          background: url(../img/product/a1.jpg) no-repeat 50% 55%/cover; }
        #aside .wrap.on ul.idx1 .img2 {
          background: url(../img/product/a2.jpg) no-repeat 50% 20%/cover; }
        #aside .wrap.on ul.idx1 .img3 {
          background: url(../img/product/a3.jpg) no-repeat 50% 40%/cover; }
        #aside .wrap.on ul.idx2 .img1 {
          background: url(../img/product/b1.jpg) no-repeat 50% 40%/cover; }
        #aside .wrap.on ul.idx2 .img2 {
          background: url(../img/product/b2.jpg) no-repeat 50% 50%/cover; }
        #aside .wrap.on ul.idx2 .img3 {
          background: url(../img/product/b3.jpg) no-repeat 50% 40%/cover; }
        #aside .wrap.on ul.idx3 .img1 {
          background: url(../img/product/c1.jpg) no-repeat 50% 55%/cover; }
        #aside .wrap.on ul.idx3 .img2 {
          background: url(../img/product/c2.jpg) no-repeat 50% 20%/cover; }
        #aside .wrap.on ul.idx3 .img3 {
          background: url(../img/product/c3.jpg) no-repeat 50% 35%/cover; }
        #aside .wrap.on ul.idx4 .img1 {
          background: url(../img/product/d1.jpg) no-repeat center center/cover; }
        #aside .wrap.on ul.idx4 .img2 {
          background: url(../img/product/d2.jpg) no-repeat 50% 30%/cover; }
        #aside .wrap.on ul.idx4 .img3 {
          background: url(../img/product/d3.jpg) no-repeat center center/cover; }

#wrap {
  display: flex;
  position: fixed;
  left: 0;
  right: 0;
  top: 0;
  bottom: 0;
  /* right imgBox */ }
  #wrap .inner {
    width: 60%;
    height: 100%;
    box-sizing: border-box;
    padding: 60px 0 60px 120px;
    position: relative;
    /*----------컨텐츠 색상 지정 -----------*/ }
    #wrap .inner .hideMenu {
      position: absolute;
      left: -300px;
      top: 0;
      width: 310px;
      height: 100vh;
      transition: all 0.3s;
      z-index: 5; }
      #wrap .inner .hideMenu .wrap {
        padding: 110px 35px; }
        #wrap .inner .hideMenu .wrap .menuBtnWrap {
          position: absolute;
          top: 70px; }
          #wrap .inner .hideMenu .wrap .menuBtnWrap .menuBtn {
            display: inline-block;
            width: 28px;
            height: 5px; }
            #wrap .inner .hideMenu .wrap .menuBtnWrap .menuBtn::after {
              content: '';
              width: 28px;
              height: 5px;
              transform: translateY(15px) rotate(45deg);
              background: #fff;
              position: absolute;
              left: 0;
              top: -10px; }
            #wrap .inner .hideMenu .wrap .menuBtnWrap .menuBtn::before {
              content: '';
              width: 28px;
              height: 5px;
              transform: translateY(-5px) rotate(-45deg);
              background: #fff;
              position: absolute;
              left: 0;
              top: 10px; }
        #wrap .inner .hideMenu .wrap .menu_header {
          height: 20vh;
          box-sizing: border-box;
          border-bottom: 1px solid #efefef; }
          #wrap .inner .hideMenu .wrap .menu_header .user {
            margin: 0 auto;
            width: 90px;
            height: 90px;
            border-radius: 50%;
            background: #efefef;
            position: relative;
            margin-bottom: 10px; }
            #wrap .inner .hideMenu .wrap .menu_header .user i {
              position: absolute;
              top: 50%;
              left: 50%;
              transform: translate(-50%, -50%);
              color: #ddd;
              font-size: 50px; }
            #wrap .inner .hideMenu .wrap .menu_header .user::after {
              content: '';
              display: block;
              width: 95px;
              height: 95px;
              border-radius: 50%;
              border: 1.5px solid #efefef;
              transform: translate(-4px, -4px); }
          #wrap .inner .hideMenu .wrap .menu_header .user_name {
            text-align: center;
            color: #efefef;
            font-family: '';
            font-size: 17px; }
        #wrap .inner .hideMenu .wrap .menu_contents {
          height: 40vh;
          box-sizing: border-box;
          border-bottom: 1px solid #efefef; }
          #wrap .inner .hideMenu .wrap .menu_contents ul {
            padding: 30px; }
            #wrap .inner .hideMenu .wrap .menu_contents ul li {
              height: 40px;
              margin-bottom: 10px;
              width: 100%;
              display: inline-block;
              line-height: 40px; }
              #wrap .inner .hideMenu .wrap .menu_contents ul li i {
                padding-left: 11px;
                color: #efefef;
                font-size: 15px; }
              #wrap .inner .hideMenu .wrap .menu_contents ul li a {
                padding-left: 14px;
                color: #efefef;
                font-size: 19px;
                font-family: 'Titillium Web';
                letter-spacing: 1px; }
              #wrap .inner .hideMenu .wrap .menu_contents ul li.on {
                background: #efefef;
                border-radius: 3px; }
              #wrap .inner .hideMenu .wrap .menu_contents ul li:hover {
                background: #efefef;
                border-radius: 3px; }
        #wrap .inner .hideMenu .wrap .menu_footer {
          height: 10vh;
          box-sizing: border-box;
          padding: 25px 20px;
          display: flex;
          justify-content: space-around; }
          #wrap .inner .hideMenu .wrap .menu_footer .bell {
            color: #efefef;
            display: flex;
            width: 31%;
            height: 18px;
            border-right: 1.2px solid #efefef; }
            #wrap .inner .hideMenu .wrap .menu_footer .bell i {
              line-height: 0.9;
              margin: 0 5px 0 15px;
              font-size: 20px; }
            #wrap .inner .hideMenu .wrap .menu_footer .bell p {
              line-height: 1;
              font-size: 15px; }
          #wrap .inner .hideMenu .wrap .menu_footer .wish {
            color: #efefef;
            display: flex;
            width: 50%; }
            #wrap .inner .hideMenu .wrap .menu_footer .wish p {
              font-size: 15px;
              line-height: 0.8; }
            #wrap .inner .hideMenu .wrap .menu_footer .wish i {
              line-height: 1.2;
              font-size: 14px;
              padding-right: 10px; }
    #wrap .inner nav {
      width: 100%;
      height: 35px;
      position: relative;
      z-index: 4; }
      #wrap .inner nav .menuBtnWrap {
        position: absolute;
        top: 50%; }
        #wrap .inner nav .menuBtnWrap .menuBtn {
          display: inline-block;
          width: 28px;
          height: 5px;
          background: #555;
          left: 0;
          transition: all 0.1s; }
          #wrap .inner nav .menuBtnWrap .menuBtn::after {
            content: '';
            width: 28px;
            height: 5px;
            background: #555;
            position: absolute;
            left: 0;
            top: -10px;
            transition: all 0.3s; }
          #wrap .inner nav .menuBtnWrap .menuBtn::before {
            content: '';
            width: 28px;
            height: 5px;
            background: #555;
            position: absolute;
            left: 0;
            top: 10px;
            transition: all 0.3s; }
      #wrap .inner nav .nav {
        width: 50%;
        position: absolute;
        left: 45%;
        top: 0;
        display: flex;
        justify-content: space-between; }
        #wrap .inner nav .nav li a {
          display: inline-block;
          line-height: 35px;
          width: 50px;
          text-align: center;
          font-family: 'Titillium Web';
          color: #555;
          font-weight: bold; }
          #wrap .inner nav .nav li a::after {
            content: '';
            display: block;
            width: 0%;
            height: 1.5px;
            background: #aaa;
            transition: all 0.3s; }
          #wrap .inner nav .nav li a.on::after {
            width: 100%; }
    #wrap .inner .contents {
      position: absolute;
      z-index: 1;
      top: 50%;
      opacity: 0;
      transform: translateY(-60%);
      transition: all 0.3s;
      /*----------컨텐츠 모션 -----------*/ }
      #wrap .inner .contents h2 {
        padding: 35px 0;
        line-height: 1.2;
        font-size: 4vw;
        transition: all 0.3s;
        opacity: 0;
        transform: translateY(-20px); }
        #wrap .inner .contents h2::after {
          content: 'HELLO';
          display: block;
          position: absolute;
          top: -5%;
          z-index: -1;
          letter-spacing: -5px;
          color: #e7e7e7;
          font-size: 115px;
          opacity: 0;
          transition: all 0.3s 0.3s;
          transform: translateY(-20px); }
        #wrap .inner .contents h2::before {
          content: '';
          display: block;
          position: absolute;
          top: 110%;
          left: 45%;
          z-index: -1;
          letter-spacing: -5px;
          color: #e7e7e7;
          opacity: 0;
          font-size: 200px;
          transition: all 0.3s 0.3s;
          transform: translateY(20px); }
      #wrap .inner .contents p {
        width: 55%;
        font-size: 12px;
        color: #888;
        margin-bottom: 60px;
        opacity: 0;
        transition: all 0.3s 0.1s;
        transform: translateY(-20px); }
      #wrap .inner .contents .btn {
        display: flex; }
        #wrap .inner .contents .btn .products {
          width: 200px;
          height: 35px;
          background: #f3b700;
          text-align: center;
          box-shadow: 20px 30px 40px #ffc80062;
          transition: all 0.3s 0.3s;
          opacity: 0;
          transform: translateY(15px); }
          #wrap .inner .contents .btn .products a {
            display: inline-block;
            width: 100%;
            height: 100%;
            font-size: 13px;
            line-height: 35px;
            color: #fff;
            letter-spacing: 1px;
            text-transform: uppercase;
            transition: all 0.3s; }
        #wrap .inner .contents .btn .promo {
          width: 200px;
          height: 35px;
          margin-left: 45px;
          display: flex;
          cursor: pointer; }
          #wrap .inner .contents .btn .promo a {
            display: inline-block;
            width: 35px;
            height: 35px;
            border-radius: 50%;
            border: 1.5px solid #ffc700;
            text-align: center;
            font-size: 20px;
            transition: all 0.3s 0.3s;
            opacity: 0;
            transform: translateY(10px); }
            #wrap .inner .contents .btn .promo a span {
              margin-left: 3px;
              line-height: 33px;
              color: #ffc700;
              transition: all 0.3s 0.3s;
              opacity: 0;
              transform: translateY(10px); }
          #wrap .inner .contents .btn .promo p {
            font-size: 17px;
            line-height: 35px;
            color: #f3b700;
            margin-left: 22px;
            transition: all 0.3s 0.4s;
            opacity: 0;
            transform: translateY(10px); }
      #wrap .inner .contents.on {
        opacity: 1;
        z-index: 2; }
        #wrap .inner .contents.on h2 {
          opacity: 1;
          transform: translateY(0px); }
          #wrap .inner .contents.on h2::after {
            transform: translateY(0px);
            opacity: 0.4; }
          #wrap .inner .contents.on h2::before {
            transform: translateY(0px);
            opacity: 0.4; }
        #wrap .inner .contents.on p {
          opacity: 1;
          transform: translateY(0); }
        #wrap .inner .contents.on .btn .products {
          opacity: 1;
          transform: translateY(0); }
        #wrap .inner .contents.on .btn .promo a {
          opacity: 1;
          transform: translateY(0); }
          #wrap .inner .contents.on .btn .promo a span {
            opacity: 1;
            transform: translateY(0); }
        #wrap .inner .contents.on .btn .promo p {
          opacity: 1;
          transform: translateY(0); }
    #wrap .inner #con1 h2 {
      color: #ffc700; }
      #wrap .inner #con1 h2::before {
        content: 'Basic'; }
    #wrap .inner #con1 .btn .products {
      background: #f3b700;
      box-shadow: 20px 30px 40px #ffc80062; }
    #wrap .inner #con1 .btn .promo a {
      border: 1.5px solid #ffc700; }
      #wrap .inner #con1 .btn .promo a span {
        color: #ffc700; }
    #wrap .inner #con1 .btn .promo p {
      color: #f3b700; }
    #wrap .inner #con2 h2 {
      color: #fc90a7; }
      #wrap .inner #con2 h2::before {
        content: 'Special'; }
    #wrap .inner #con2 .btn .products {
      background: #fc90a7;
      box-shadow: 20px 30px 40px #fc90a779; }
    #wrap .inner #con2 .btn .promo a {
      border: 1.5px solid #fc90a7; }
      #wrap .inner #con2 .btn .promo a span {
        color: #fc90a7; }
    #wrap .inner #con2 .btn .promo p {
      color: #fc90a7; }
    #wrap .inner #con3 h2 {
      color: #99c9ba; }
      #wrap .inner #con3 h2::before {
        content: 'Branch'; }
    #wrap .inner #con3 .btn .products {
      background: #99c9ba;
      box-shadow: 20px 30px 40px #99c9baa1; }
    #wrap .inner #con3 .btn .promo a {
      border: 1.5px solid #99c9ba; }
      #wrap .inner #con3 .btn .promo a span {
        color: #99c9ba; }
    #wrap .inner #con3 .btn .promo p {
      color: #99c9ba; }
    #wrap .inner #con4 h2 {
      color: #aab4ed; }
      #wrap .inner #con4 h2::before {
        content: 'Award'; }
    #wrap .inner #con4 .btn .products {
      background: #aab4ed;
      box-shadow: 20px 30px 40px #aab4ed78; }
    #wrap .inner #con4 .btn .promo a {
      border: 1.5px solid #aab4ed; }
      #wrap .inner #con4 .btn .promo a span {
        color: #aab4ed; }
    #wrap .inner #con4 .btn .promo p {
      color: #aab4ed; }
    #wrap .inner .footer {
      display: flex;
      position: relative;
      top: 90%;
      width: 98%; }
      #wrap .inner .footer .sns a > i {
        font-size: 17px;
        color: #777;
        margin-right: 22px; }
      #wrap .inner .footer .var {
        display: flex;
        justify-content: space-between;
        position: absolute;
        right: 50px; }
        #wrap .inner .footer .var i {
          color: #aaa;
          font-size: 10px;
          line-height: 22px; }
        #wrap .inner .footer .var div {
          width: 220px;
          height: 2px;
          background: #eaeaea;
          margin: 10px; }
          #wrap .inner .footer .var div span {
            display: block;
            width: 0%;
            height: 2.5px;
            background: #aaa;
            transition: all 0.5s; }
  #wrap .img_wrap {
    width: 40%;
    height: 100vh;
    box-sizing: border-box;
    position: relative;
    /* ------------우측 이미지 배치----------- */
    /* ----------우측 하단 이미지 배치-------- */ }
    #wrap .img_wrap .imgs {
      width: 100%;
      height: 100%;
      opacity: 0;
      position: absolute;
      transition: all 0.5s; }
      #wrap .img_wrap .imgs::after {
        content: '';
        width: 400px;
        height: 0px;
        position: absolute;
        top: 47%;
        right: 55%;
        transform: translateY(0%);
        transition: all 0.5s;
        opacity: 0;
        box-shadow: 5px 5px 20px rgba(0, 0, 0, 0.3); }
      #wrap .img_wrap .imgs.on {
        opacity: 1; }
        #wrap .img_wrap .imgs.on::after {
          transform: translateY(-50%);
          height: 400px;
          opacity: 1; }
    #wrap .img_wrap #img1 {
      background: url(../img/backImg1.jpg) no-repeat center bottom;
      background-size: cover; }
      #wrap .img_wrap #img1::after {
        background: url(../img/img1.jpg) no-repeat center top;
        background-size: cover; }
    #wrap .img_wrap #img2 {
      background: url(../img/backImg2.jpg) no-repeat 50% 10%;
      background-size: cover; }
      #wrap .img_wrap #img2::after {
        background: url(../img/img2.jpg) no-repeat 10% 70%;
        background-size: cover; }
    #wrap .img_wrap #img3 {
      background: url(../img/backImg3.jpg) no-repeat center bottom;
      background-size: cover;
      filter: saturate(65%); }
      #wrap .img_wrap #img3::after {
        background: url(../img/img3.jpg) no-repeat center 10%;
        background-size: cover; }
    #wrap .img_wrap #img4 {
      background: url(../img/backImg4.jpg) no-repeat center top;
      background-size: cover; }
      #wrap .img_wrap #img4::after {
        background: url(../img/img4.jpg) no-repeat center top;
        background-size: cover; }
    #wrap .img_wrap .aside {
      position: absolute;
      justify-content: space-between;
      display: flex;
      top: 9%;
      right: 20%;
      width: 18%; }
      #wrap .img_wrap .aside a > i {
        color: #fff; }
    #wrap .img_wrap .preview {
      position: absolute;
      width: 100%;
      height: 15vh;
      bottom: 0;
      background: rgba(0, 0, 0, 0.1);
      cursor: pointer;
      opacity: 0;
      display: none;
      transition: all 0.5s; }
      #wrap .img_wrap .preview .prev_img {
        width: 17%;
        height: 100%;
        opacity: 0.5; }
      #wrap .img_wrap .preview .prev1 {
        background: url(../img/backImg2.jpg) no-repeat center center;
        background-size: cover; }
      #wrap .img_wrap .preview .prev2 {
        background: url(../img/backImg3.jpg) no-repeat center center;
        background-size: cover; }
      #wrap .img_wrap .preview .prev3 {
        background: url(../img/backImg4.jpg) no-repeat center center;
        background-size: cover; }
      #wrap .img_wrap .preview .prev4 {
        background: url(../img/backImg1.jpg) no-repeat center center;
        background-size: cover; }
      #wrap .img_wrap .preview a {
        position: absolute;
        top: 50%;
        transform: translateY(-50%);
        color: rgba(255, 255, 255, 0.7);
        font-family: 'Titillium Web';
        font-size: 20px;
        left: 20%;
        right: 50%; }
        #wrap .img_wrap .preview a::after {
          content: '';
          position: absolute;
          top: 51%;
          left: 90%;
          display: block;
          width: 50%;
          height: 1px;
          background: #fff;
          opacity: 0.3; }
      #wrap .img_wrap .preview .arrow {
        position: absolute;
        top: 50%;
        right: 20%;
        transform: translateY(-50%);
        display: inline-flex;
        width: 30px;
        height: 1px;
        background: #fff; }
        #wrap .img_wrap .preview .arrow::after {
          content: '';
          display: block;
          position: absolute;
          top: -7px;
          left: 13px;
          width: 20px;
          height: 1px;
          background: #fff;
          transform: rotate(45deg); }
        #wrap .img_wrap .preview .arrow::before {
          content: '';
          display: block;
          position: absolute;
          top: 7px;
          left: 13px;
          width: 20px;
          height: 1px;
          background: #fff;
          transform: rotate(-45deg); }
      #wrap .img_wrap .preview.on {
        opacity: 1;
        display: block; }

/* 타블렛 아이패드 */
@media screen and (max-width: 770px) {
  #wrap {
    /* right imgBox */ }
    #wrap .inner {
      width: 100%;
      padding: 60px 120px;
      position: absolute;
      /*----------컨텐츠 색상 지정 -----------*/ }
      #wrap .inner .hideMenu {
        width: 310px; }
      #wrap .inner nav {
        position: fixed; }
        #wrap .inner nav .menuBtnWrap {
          left: -30px; }
          #wrap .inner nav .menuBtnWrap .menuBtn {
            background: #fff; }
            #wrap .inner nav .menuBtnWrap .menuBtn::after {
              background: #fff; }
            #wrap .inner nav .menuBtnWrap .menuBtn::before {
              background: #fff; }
        #wrap .inner nav .nav {
          width: 45%;
          position: absolute;
          left: 30%; }
          #wrap .inner nav .nav li a {
            font-size: 18px; }
      #wrap .inner .contents {
        /*----------컨텐츠 모션 -----------*/ }
        #wrap .inner .contents h2 {
          position: absolute;
          top: -135%;
          left: 35%;
          font-size: 7.5vmax;
          line-height: 1.1; }
          #wrap .inner .contents h2::after {
            position: absolute;
            top: 10%;
            left: -50%;
            font-size: 160px;
            transform: translateY(-20px) rotate(-90deg); }
          #wrap .inner .contents h2::before {
            top: 110%;
            left: 7%;
            font-size: 215px;
            transform: translateY(20px) rotate(90deg); }
        #wrap .inner .contents p {
          width: 45%;
          color: rgba(255, 255, 255, 0.486);
          transform: translateY(195px); }
        #wrap .inner .contents .btn {
          margin-left: 35%;
          transform: translateY(195px); }
          #wrap .inner .contents .btn .products {
            width: 350px;
            height: 65px; }
            #wrap .inner .contents .btn .products a {
              font-size: 20px;
              line-height: 65px; }
          #wrap .inner .contents .btn .promo {
            position: absolute;
            top: -250%;
            right: 35%;
            width: 210px; }
        #wrap .inner .contents.on h2::after {
          transform: translateY(0px) rotate(-90deg); }
        #wrap .inner .contents.on h2::before {
          transform: translateY(0px) rotate(90deg); }
        #wrap .inner .contents.on p {
          opacity: 1;
          transform: translateY(185px); }
        #wrap .inner .contents.on .btn .products {
          opacity: 1; }
        #wrap .inner .contents.on .btn .promo a {
          opacity: 1;
          transform: translateY(0); }
          #wrap .inner .contents.on .btn .promo a span {
            opacity: 1;
            transform: translateY(0); }
        #wrap .inner .contents.on .btn .promo p {
          opacity: 1;
          transform: translateY(0); }
      #wrap .inner #con1 h2::before {
        content: 'Basic';
        left: 25%; }
      #wrap .inner .footer .sns {
        display: none; }
      #wrap .inner .footer .var {
        display: none; }
    #wrap .img_wrap {
      /* ------------우측 이미지 배치----------- */
      /* ----------우측 하단 이미지 배치-------- */ }
      #wrap .img_wrap .imgs::after {
        display: none; }
      #wrap .img_wrap .aside {
        display: none; }
      #wrap .img_wrap .preview {
        position: fixed; } }
/* 모바일 */
@media screen and (max-width: 539px) {
  #wrap {
    /* right imgBox */ }
    #wrap .inner {
      /*----------컨텐츠 색상 지정 -----------*/ }
      #wrap .inner .contents {
        /*----------컨텐츠 모션 -----------*/ }
        #wrap .inner .contents.on {
          opacity: 1; }
          #wrap .inner .contents.on h2 {
            opacity: 1;
            transform: translateY(0px); }
            #wrap .inner .contents.on h2::after {
              transform: translateY(0px);
              opacity: 0.4; }
            #wrap .inner .contents.on h2::before {
              transform: translateY(0px);
              opacity: 0.4; }
          #wrap .inner .contents.on p {
            opacity: 1;
            transform: translateY(0); }
          #wrap .inner .contents.on .btn .products {
            opacity: 1;
            transform: translateY(0); }
          #wrap .inner .contents.on .btn .promo a {
            opacity: 1;
            transform: translateY(0); }
            #wrap .inner .contents.on .btn .promo a span {
              opacity: 1;
              transform: translateY(0); }
          #wrap .inner .contents.on .btn .promo p {
            opacity: 1;
            transform: translateY(0); }
      #wrap .inner #con1 h2 {
        color: #ffc700; }
        #wrap .inner #con1 h2::before {
          content: 'Basic'; }
      #wrap .inner #con1 .btn .products {
        background: #f3b700;
        box-shadow: 20px 30px 40px #ffc80062; }
      #wrap .inner #con1 .btn .promo a {
        border: 1.5px solid #ffc700; }
        #wrap .inner #con1 .btn .promo a span {
          color: #ffc700; }
      #wrap .inner #con1 .btn .promo p {
        color: #f3b700; }
      #wrap .inner #con2 h2 {
        color: #fc90a7; }
        #wrap .inner #con2 h2::before {
          content: 'Special'; }
      #wrap .inner #con2 .btn .products {
        background: #fc90a7;
        box-shadow: 20px 30px 40px #fc90a779; }
      #wrap .inner #con2 .btn .promo a {
        border: 1.5px solid #fc90a7; }
        #wrap .inner #con2 .btn .promo a span {
          color: #fc90a7; }
      #wrap .inner #con2 .btn .promo p {
        color: #fc90a7; }
      #wrap .inner #con3 h2 {
        color: #99c9ba; }
        #wrap .inner #con3 h2::before {
          content: 'Branch'; }
      #wrap .inner #con3 .btn .products {
        background: #99c9ba;
        box-shadow: 20px 30px 40px #99c9baa1; }
      #wrap .inner #con3 .btn .promo a {
        border: 1.5px solid #99c9ba; }
        #wrap .inner #con3 .btn .promo a span {
          color: #99c9ba; }
      #wrap .inner #con3 .btn .promo p {
        color: #99c9ba; }
      #wrap .inner #con4 h2 {
        color: #aab4ed; }
        #wrap .inner #con4 h2::before {
          content: 'Award'; }
      #wrap .inner #con4 .btn .products {
        background: #aab4ed;
        box-shadow: 20px 30px 40px #aab4ed78; }
      #wrap .inner #con4 .btn .promo a {
        border: 1.5px solid #aab4ed; }
        #wrap .inner #con4 .btn .promo a span {
          color: #aab4ed; }
      #wrap .inner #con4 .btn .promo p {
        color: #aab4ed; }
    #wrap .img_wrap {
      /* ------------우측 이미지 배치----------- */
      /* ----------우측 하단 이미지 배치-------- */ }
      #wrap .img_wrap .imgs.on {
        opacity: 1; }
        #wrap .img_wrap .imgs.on::after {
          transform: translateY(-50%);
          height: 400px;
          opacity: 1; }
      #wrap .img_wrap #img1 {
        background: url(../img/backImg1.jpg) no-repeat center bottom;
        background-size: cover; }
        #wrap .img_wrap #img1::after {
          background: url(../img/img1.jpg) no-repeat center top;
          background-size: cover; }
      #wrap .img_wrap #img2 {
        background: url(../img/backImg2.jpg) no-repeat 50% 10%;
        background-size: cover; }
        #wrap .img_wrap #img2::after {
          background: url(../img/img2.jpg) no-repeat 10% 70%;
          background-size: cover; }
      #wrap .img_wrap #img3 {
        background: url(../img/backImg3.jpg) no-repeat center bottom;
        background-size: cover;
        filter: saturate(65%); }
        #wrap .img_wrap #img3::after {
          background: url(../img/img3.jpg) no-repeat center 10%;
          background-size: cover; }
      #wrap .img_wrap #img4 {
        background: url(../img/backImg4.jpg) no-repeat center top;
        background-size: cover; }
        #wrap .img_wrap #img4::after {
          background: url(../img/img4.jpg) no-repeat center top;
          background-size: cover; }
      #wrap .img_wrap .preview .prev1 {
        background: url(../img/backImg2.jpg) no-repeat center center;
        background-size: cover; }
      #wrap .img_wrap .preview .prev2 {
        background: url(../img/backImg3.jpg) no-repeat center center;
        background-size: cover; }
      #wrap .img_wrap .preview .prev3 {
        background: url(../img/backImg4.jpg) no-repeat center center;
        background-size: cover; }
      #wrap .img_wrap .preview .prev4 {
        background: url(../img/backImg1.jpg) no-repeat center center;
        background-size: cover; }
      #wrap .img_wrap .preview .arrow::after {
        content: '';
        display: block;
        position: absolute;
        top: -7px;
        left: 13px;
        width: 20px;
        height: 1px;
        background: #fff;
        transform: rotate(45deg); }
      #wrap .img_wrap .preview .arrow::before {
        content: '';
        display: block;
        position: absolute;
        top: 7px;
        left: 13px;
        width: 20px;
        height: 1px;
        background: #fff;
        transform: rotate(-45deg); }
      #wrap .img_wrap .preview.on {
        opacity: 1;
        display: block; } }

/*# sourceMappingURL=style.cs.map */
