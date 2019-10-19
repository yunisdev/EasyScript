//EasyCode Core
//Do not change anything.Else can be some problems

//GLOBALS
const newLine = "<br>";
let write_status = "none";





//#region Independent functions
function write(str) {
    document.write(str);
    write_status = "write";
}
function writeln(str) {
    if (write_status == "none") {
        document.write(str + "<br>");
        write_status = "writeln";
    }
    else if (write_status == "write") {
        document.write("<br>" + str + "<br>");
        write_status = "writeln";
    }
    else if (write_status == "writeln") {
        document.write(str + "<br>");
        write_status = "writeln";
    }
}
function msbox(str){
    window.alert(str);
}
//#endregion


//#region Style object
var body = document.querySelector("body");
const style = {
    setBack:(value)=>{
        document.querySelector("body").style.backgroundColor = value;
    },
    setFont:{
        color:(value)=>{
            document.querySelector("body").style.color = value;
        },
        style:(value)=>{
            switch (value) {
                case "italic":
                    document.querySelector("body").style.fontStyle = "italic";
                    break;
                case "bold":
                    document.querySelector("body").style.fontWeight = "bold";
                    break;
                case "underline":
                    document.querySelector("body").style.textDecoration = "underline";
                    break;
            
                default:
                    break;
            }

        },
    },
    setBackImg:(imgurl,size = "cover")=>{
        document.querySelector("body").style.backgroundImage = "url("+imgurl+")";
        switch (size) {
            case "cover":
                document.querySelector("body").style.backgroundSize = "cover";       
                break;
            case "normal":
                document.querySelector("body").style.backgroundSize = "normal"
                break;
            default:
                break;
        }

    },
}
//#endregion


//#region Doc object
const doc = {
    add:{
        p:(text,cl="none-class",style="",display="inline-block")=>{
            document.querySelector("#added").innerHTML += "<p class='"+cl+"' style='display:"+display+";"+style+";'>"+text+"</p>"
        },
        html:(code)=>{
            document.querySelector("#added").innerHTML += code;
        },
        css:(selector,code)=>{
            var coded = document.querySelector(selector).getAttribute("style")
            document.querySelector(selector).setAttribute("style",coded +";"+code+";")
        },
        block:(id)=>{
            document.querySelector("#added").innerHTML += "<div style id='"+ id +"'></div>";
        },
    },
    hide:(selector)=>{
        document.querySelector(selector).style.display="none";
    },
    show:(selector)=>{
        document.querySelector(selector).style.display="inherit";
    },
}
//#endregion


//#region Math object
const math = {
    pi:3.14,
    PI: 3.1415926535897932384626433832795,
    power:(int1,int2)=>{
        return int1**int2;
    },
    factorial:(integer)=>{
        var result = 1;
        for(var i = integer;i>0;i--){
            result *= i;
        }
        return result;
    },
}
//#endregion