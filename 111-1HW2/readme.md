# 第2次作業題目-作業-HW2
[deadline 2022/10/12 00:00:00](#)
>撰寫前請注意

1. 請[點選](https://github.com/altoliaw3/111-1HW2.git)該連結連結至題目之倉庫，並對該倉庫進行fork
2. 再藉由上述所提供的連結，把該fork至自己帳號的倉庫clone至本機端，
再進行程式撰寫與文件撰寫

> 正題

請解決下面問題。請於該專案下新增一個Web表單(網頁表單)名稱為Bomb， 根據課堂所述，會產生三個附檔名的檔案，其中一個是.aspx，另兩個是.cs。 請在Bomb.cs的Page_Load事件下，寫下以下功能：
1. 生成一個整數2維陣列變數大小為10* 10，名稱為ia_Map。
2. 生成一個整數1維陣列變數大小為10，名稱為ia_MIndex。
在ia_Map，即10*10的二維陣列中，其索引值從0至99。今有10個地雷儲存於ia_MIndex，其生成點於索引值0至99中，若今有輸入10個，請完成圖中應有的數字。
如：輸入 0 7 13 28 44 62 74 75 87 90  (存於ia_MIndex內，由左至右，由上至下，索引由0開始)
輸出為下面陣列(*為炸彈)。為了顯示地雷位置，因此在除了地雷的格子外，需要以要判斷的格子為中心，判斷九宮格內的炸彈的個數。如下圖所示。

<?xml version="1.0" encoding="UTF-8"?>
<svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" width="171pt" height="125pt" viewBox="0 0 171 125" version="1.1">
<defs>
<g>
<symbol overflow="visible" id="glyph0-0">
<path style="stroke:none;" d="M 2.609375 -5.125 C 3.09375 -4.765625 3.84375 -4.203125 3.890625 -4.171875 C 3.953125 -4.140625 3.984375 -4.109375 4.0625 -4.109375 C 4.21875 -4.109375 4.328125 -4.265625 4.328125 -4.390625 C 4.328125 -4.5 4.28125 -4.578125 4.109375 -4.671875 L 2.71875 -5.328125 L 4.09375 -5.984375 C 4.28125 -6.078125 4.328125 -6.140625 4.328125 -6.265625 C 4.328125 -6.390625 4.21875 -6.546875 4.0625 -6.546875 C 3.984375 -6.546875 3.96875 -6.546875 3.703125 -6.34375 L 2.609375 -5.53125 L 2.75 -7.234375 C 2.75 -7.375 2.625 -7.484375 2.5 -7.484375 C 2.328125 -7.484375 2.21875 -7.359375 2.21875 -7.234375 C 2.21875 -7.125 2.359375 -5.75 2.375 -5.53125 L 1.140625 -6.4375 C 1 -6.546875 0.984375 -6.546875 0.921875 -6.546875 C 0.75 -6.546875 0.640625 -6.390625 0.640625 -6.265625 C 0.640625 -6.15625 0.6875 -6.078125 0.859375 -5.984375 L 2.265625 -5.328125 L 0.875 -4.671875 C 0.6875 -4.578125 0.640625 -4.515625 0.640625 -4.390625 C 0.640625 -4.375 0.640625 -4.109375 0.984375 -4.109375 L 2.375 -5.125 L 2.21875 -3.421875 C 2.21875 -3.28125 2.359375 -3.1875 2.484375 -3.1875 C 2.640625 -3.1875 2.75 -3.296875 2.75 -3.421875 C 2.75 -3.53125 2.625 -4.90625 2.609375 -5.125 Z M 2.609375 -5.125 "/>
</symbol>
<symbol overflow="visible" id="glyph0-1">
<path style="stroke:none;" d="M 2.9375 -6.375 C 2.9375 -6.625 2.9375 -6.640625 2.703125 -6.640625 C 2.078125 -6 1.203125 -6 0.890625 -6 L 0.890625 -5.6875 C 1.09375 -5.6875 1.671875 -5.6875 2.1875 -5.953125 L 2.1875 -0.78125 C 2.1875 -0.421875 2.15625 -0.3125 1.265625 -0.3125 L 0.953125 -0.3125 L 0.953125 0 C 1.296875 -0.03125 2.15625 -0.03125 2.5625 -0.03125 C 2.953125 -0.03125 3.828125 -0.03125 4.171875 0 L 4.171875 -0.3125 L 3.859375 -0.3125 C 2.953125 -0.3125 2.9375 -0.421875 2.9375 -0.78125 Z M 2.9375 -6.375 "/>
</symbol>
<symbol overflow="visible" id="glyph0-2">
<path style="stroke:none;" d="M 1.265625 -0.765625 L 2.328125 -1.796875 C 3.875 -3.171875 4.46875 -3.703125 4.46875 -4.703125 C 4.46875 -5.84375 3.578125 -6.640625 2.359375 -6.640625 C 1.234375 -6.640625 0.5 -5.71875 0.5 -4.828125 C 0.5 -4.28125 1 -4.28125 1.03125 -4.28125 C 1.203125 -4.28125 1.546875 -4.390625 1.546875 -4.8125 C 1.546875 -5.0625 1.359375 -5.328125 1.015625 -5.328125 C 0.9375 -5.328125 0.921875 -5.328125 0.890625 -5.3125 C 1.109375 -5.96875 1.65625 -6.328125 2.234375 -6.328125 C 3.140625 -6.328125 3.5625 -5.515625 3.5625 -4.703125 C 3.5625 -3.90625 3.078125 -3.125 2.515625 -2.5 L 0.609375 -0.375 C 0.5 -0.265625 0.5 -0.234375 0.5 0 L 4.203125 0 L 4.46875 -1.734375 L 4.234375 -1.734375 C 4.171875 -1.4375 4.109375 -1 4 -0.84375 C 3.9375 -0.765625 3.28125 -0.765625 3.0625 -0.765625 Z M 1.265625 -0.765625 "/>
</symbol>
</g>
</defs>
<g id="surface1">
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.65625 1240 L 1701.367188 1240 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.695312 1118.359375 L 7.695312 1237.96875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-0" x="6.74297" y="9.573"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 177.109375 1118.359375 L 177.109375 1237.96875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="23.6809" y="9.573"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 346.484375 1118.359375 L 346.484375 1237.96875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="40.6188" y="9.573"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 515.859375 1118.359375 L 515.859375 1237.96875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="57.5566" y="9.573"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 685.15625 1118.359375 L 685.15625 1237.96875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="74.4945" y="9.573"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 854.53125 1118.359375 L 854.53125 1237.96875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1023.90625 1118.359375 L 1023.90625 1237.96875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="108.362" y="9.573"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1193.28125 1118.359375 L 1193.28125 1237.96875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-0" x="125.3" y="9.573"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1362.65625 1118.359375 L 1362.65625 1237.96875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="142.238" y="9.573"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1532.03125 1118.359375 L 1532.03125 1237.96875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1701.328125 1118.359375 L 1701.328125 1237.96875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.65625 1116.445312 L 1701.367188 1116.445312 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.695312 994.882812 L 7.695312 1114.492188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="6.74297" y="21.93"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 177.109375 994.882812 L 177.109375 1114.492188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="23.6809" y="21.93"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 346.484375 994.882812 L 346.484375 1114.492188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="40.6188" y="21.93"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 515.859375 994.882812 L 515.859375 1114.492188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-0" x="57.5566" y="21.93"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 685.15625 994.882812 L 685.15625 1114.492188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="74.4945" y="21.93"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 854.53125 994.882812 L 854.53125 1114.492188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1023.90625 994.882812 L 1023.90625 1114.492188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="108.362" y="21.93"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1193.28125 994.882812 L 1193.28125 1114.492188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-2" x="125.3" y="21.93"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1362.65625 994.882812 L 1362.65625 1114.492188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-2" x="142.238" y="21.93"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1532.03125 994.882812 L 1532.03125 1114.492188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="159.175" y="21.93"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1701.328125 994.882812 L 1701.328125 1114.492188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.65625 992.851562 L 1701.367188 992.851562 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.695312 871.328125 L 7.695312 990.9375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 177.109375 871.328125 L 177.109375 990.9375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 346.484375 871.328125 L 346.484375 990.9375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="40.6191" y="34.2781"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 515.859375 871.328125 L 515.859375 990.9375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="57.557" y="34.2781"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 685.15625 871.328125 L 685.15625 990.9375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="74.4949" y="34.2781"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 854.53125 871.328125 L 854.53125 990.9375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1023.90625 871.328125 L 1023.90625 990.9375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1193.28125 871.328125 L 1193.28125 990.9375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="125.3" y="34.2781"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1362.65625 871.328125 L 1362.65625 990.9375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-0" x="142.238" y="34.2781"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1532.03125 871.328125 L 1532.03125 990.9375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="159.176" y="34.2781"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1701.328125 871.328125 L 1701.328125 990.9375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.65625 869.375 L 1701.367188 869.375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.695312 747.734375 L 7.695312 867.34375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 177.109375 747.734375 L 177.109375 867.34375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 346.484375 747.734375 L 346.484375 867.34375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 515.859375 747.734375 L 515.859375 867.34375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="57.557" y="46.6352"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 685.15625 747.734375 L 685.15625 867.34375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="74.4949" y="46.6352"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 854.53125 747.734375 L 854.53125 867.34375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="91.4328" y="46.6352"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1023.90625 747.734375 L 1023.90625 867.34375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1193.28125 747.734375 L 1193.28125 867.34375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="125.3" y="46.6352"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1362.65625 747.734375 L 1362.65625 867.34375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="142.238" y="46.6352"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1532.03125 747.734375 L 1532.03125 867.34375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="159.176" y="46.6352"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1701.328125 747.734375 L 1701.328125 867.34375 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.65625 745.820312 L 1701.367188 745.820312 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.695312 624.257812 L 7.695312 743.867188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 177.109375 624.257812 L 177.109375 743.867188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 346.484375 624.257812 L 346.484375 743.867188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 515.859375 624.257812 L 515.859375 743.867188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="57.557" y="58.9918"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 685.15625 624.257812 L 685.15625 743.867188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-0" x="74.4949" y="58.9918"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 854.53125 624.257812 L 854.53125 743.867188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="91.4328" y="58.9918"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1023.90625 624.257812 L 1023.90625 743.867188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1193.28125 624.257812 L 1193.28125 743.867188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1362.65625 624.257812 L 1362.65625 743.867188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1532.03125 624.257812 L 1532.03125 743.867188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1701.328125 624.257812 L 1701.328125 743.867188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.65625 622.304688 L 1701.367188 622.304688 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.695312 500.703125 L 7.695312 620.3125 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 177.109375 500.703125 L 177.109375 620.3125 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="23.6809" y="71.3398"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 346.484375 500.703125 L 346.484375 620.3125 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="40.6188" y="71.3398"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 515.859375 500.703125 L 515.859375 620.3125 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-2" x="57.5566" y="71.3398"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 685.15625 500.703125 L 685.15625 620.3125 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="74.4945" y="71.3398"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 854.53125 500.703125 L 854.53125 620.3125 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="91.4324" y="71.3398"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1023.90625 500.703125 L 1023.90625 620.3125 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1193.28125 500.703125 L 1193.28125 620.3125 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1362.65625 500.703125 L 1362.65625 620.3125 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1532.03125 500.703125 L 1532.03125 620.3125 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1701.328125 500.703125 L 1701.328125 620.3125 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.65625 498.75 L 1701.367188 498.75 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.695312 377.226562 L 7.695312 496.835938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 177.109375 377.226562 L 177.109375 496.835938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="23.6809" y="83.6969"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 346.484375 377.226562 L 346.484375 496.835938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-0" x="40.6188" y="83.6969"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 515.859375 377.226562 L 515.859375 496.835938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-2" x="57.5566" y="83.6969"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 685.15625 377.226562 L 685.15625 496.835938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-2" x="74.4945" y="83.6969"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 854.53125 377.226562 L 854.53125 496.835938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-2" x="91.4324" y="83.6969"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1023.90625 377.226562 L 1023.90625 496.835938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="108.361" y="83.6969"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1193.28125 377.226562 L 1193.28125 496.835938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1362.65625 377.226562 L 1362.65625 496.835938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1532.03125 377.226562 L 1532.03125 496.835938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1701.328125 377.226562 L 1701.328125 496.835938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.65625 375.195312 L 1701.367188 375.195312 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.695312 253.632812 L 7.695312 373.242188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 177.109375 253.632812 L 177.109375 373.242188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="23.6809" y="96.0539"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 346.484375 253.632812 L 346.484375 373.242188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="40.6188" y="96.0539"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 515.859375 253.632812 L 515.859375 373.242188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-2" x="57.5566" y="96.0539"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 685.15625 253.632812 L 685.15625 373.242188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-0" x="74.4945" y="96.0539"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 854.53125 253.632812 L 854.53125 373.242188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-0" x="91.4324" y="96.0539"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1023.90625 253.632812 L 1023.90625 373.242188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-2" x="108.361" y="96.0539"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1193.28125 253.632812 L 1193.28125 373.242188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="125.299" y="96.0539"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1362.65625 253.632812 L 1362.65625 373.242188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="142.237" y="96.0539"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1532.03125 253.632812 L 1532.03125 373.242188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1701.328125 253.632812 L 1701.328125 373.242188 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.65625 251.71875 L 1701.367188 251.71875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.695312 130.078125 L 7.695312 249.6875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="6.74297" y="108.402"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 177.109375 130.078125 L 177.109375 249.6875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="23.6809" y="108.402"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 346.484375 130.078125 L 346.484375 249.6875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 515.859375 130.078125 L 515.859375 249.6875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="57.557" y="108.402"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 685.15625 130.078125 L 685.15625 249.6875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-2" x="74.4949" y="108.402"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 854.53125 130.078125 L 854.53125 249.6875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-2" x="91.4328" y="108.402"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1023.90625 130.078125 L 1023.90625 249.6875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-2" x="108.362" y="108.402"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1193.28125 130.078125 L 1193.28125 249.6875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-0" x="125.3" y="108.402"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1362.65625 130.078125 L 1362.65625 249.6875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="142.238" y="108.402"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1532.03125 130.078125 L 1532.03125 249.6875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1701.328125 130.078125 L 1701.328125 249.6875 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.65625 128.125 L 1701.367188 128.125 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.695312 6.601562 L 7.695312 126.210938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-0" x="6.74297" y="120.75898"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 177.109375 6.601562 L 177.109375 126.210938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="23.6809" y="120.75898"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 346.484375 6.601562 L 346.484375 126.210938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 515.859375 6.601562 L 515.859375 126.210938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 685.15625 6.601562 L 685.15625 126.210938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 854.53125 6.601562 L 854.53125 126.210938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1023.90625 6.601562 L 1023.90625 126.210938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="108.362" y="120.75898"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1193.28125 6.601562 L 1193.28125 126.210938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="125.3" y="120.75898"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1362.65625 6.601562 L 1362.65625 126.210938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<g style="fill:rgb(0%,0%,0%);fill-opacity:1;">
  <use xlink:href="#glyph0-1" x="142.238" y="120.75898"/>
</g>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1532.03125 6.601562 L 1532.03125 126.210938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 1701.328125 6.601562 L 1701.328125 126.210938 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
<path style="fill:none;stroke-width:4.05;stroke-linecap:butt;stroke-linejoin:miter;stroke:rgb(0%,0%,0%);stroke-opacity:1;stroke-miterlimit:10;" d="M 7.65625 4.570312 L 1701.367188 4.570312 " transform="matrix(0.1,0,0,-0.1,0,125)"/>
</g>
</svg>


> 補充說明 (以下各項全需滿足，才會進行評分)

1. 請將完成程式後，撰寫書面內容寫於answer.md
2. 將將該answer.md檔藉由markdown editor 顯示部分，按右鍵進行列印成pdf檔案，
檔名需為answer.md.pdf
3. 將answer.md.pdf檔於[CleverPDF](https://www.cleverpdf.com/zh-tw/encrypt-pdf)進行**防拷貝**，
並將防拷貝後的answer.md.pdf放置至專案下並拖入VS community IDE內的「**方案總管**」
4. 將answer.md使用winrar加密打包，請自己記住密碼，
並於VS community IDE內的「**方案總管**」刪除answer.md檔案
5. 將專案執行git add、commit、push至github後，並於
[google sheet(點我)](https://docs.google.com/spreadsheets/d/1x_GfVISrublmnrn1S43wtEt_XPEKV2AqirTlMZPLCK4/edit#gid=345458270)中找尋相對應之試算表，
並於該位同學位置註記同學之倉庫的url

>該次作業完成預計所需時間 (實作與文件撰寫所需要完成時間) 

* 70 mins 以下：專精
* 介於 70 至 100 mins：熟練
* 介於 100 至 180 mins：平均
* 超過 180 mins：不熟，請多花心思在課業上

