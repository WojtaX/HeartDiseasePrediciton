﻿var context;
var cntText;
var cnt=0;
var start=0;
var mydata = [160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190,
                160,130,190,130,160,130,190,160,130,160,190,160,130,,160,190];

function init()
{
 context= myCanvas.getContext('2d');
 cntText=document.getElementById("data");
 context.fillStyle = "#737373";
 context.fill();



    var j=0;
    var lastx=0;
    var lasty=160;
 for(i=0;i<600;i++)
 {
    var p=j*5;
    drawLine(lastx,lasty,p,mydata[j],"#FF00FF");
    lastx=p;
    lasty=mydata[j];
    i=i+4;
    j++;
 }
 move();
 alert(mydata.length);
}
function drawLine(x1,y1,x2,y2,color)
{
    context.beginPath();
    //context.fillStyle="#00E600";
    context.moveTo(x1,y1);
    context.lineTo(x2,y2);
    context.strokeStyle = color;
    context.lineWidth = 0.2;
    context.stroke();
}


function move()
{
     var j=0;
    var lastx=0;
    var lasty=160;
    var pos=0;
    //cnt=100;
    cleareData();
    start=cnt;
    if(cnt>120)
    {
        start=120;
        pos=cnt-120;
    }
    for(i=0;i<start;i++)
    {
        var p=i*5;
        drawLine(lastx,lasty,p,mydata[pos],"#FF00FF");
        lastx=p;
        lasty=mydata[pos];
        pos++;
    }
    //alert(cnt);
    //cntText.value=cnt;
    cnt=cnt+1;
}

function cleareData()
{
    context.clearRect(0, 0, 600, 600);
    for(i=0;i<600;i++)
     {

        drawLine(i,0,i,300,"#CCCCCC");
        i=i+19
     }

     for(i=0;i<300;i++)
     {

        drawLine(0,i,600,i,"#CCCCCC");
        i=i+19
     }
     drawLine(0,160,600,160,"#FF00FF");
 }
setInterval(move, 120);