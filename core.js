//EasyCode Core
//Do not change anything.Else can be some problems

//GLOBALS
const newLine = "<br>";
let write_status = "none";





// Independent functions
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


// Style object
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


// Doc object
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



// Math object

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
    convert:(type,from,to,value=1)=>{
        //Convert function
        switch (type) {
            case "area":
                //#region AREA
                if (from=="m2") {
                    if (to=="km2") {
                        return value / 1000000;
                    }
                    else if (to=="mm2") {
                        return value * 1000000;
                    }
                    else if (to=="sm2" || to=="cm2"){
                        return value * 10000
                    }
                    else{
                        return "to parameter is wrong"
                    }
                }
                else if(from=="km2"){
                    if (to == "m2") {
                        return value * 1000000;
                    }
                    else if (to == "mm2") {
                        return value * 1000000000000;
                    }
                    else if (to == "sm2" || to == "cm2") {
                        return value * 10000000000;
                    }
                    else {
                        return "to parameter is wrong"
                    }
                }
                else if (from == "cm2" || from=="sm2") {
                    if (to == "m2") {
                        return value /10000;
                    }
                    else if (to == "mm2") {
                        return value * 100;
                    }
                    else if (to == "km2") {
                        return value / 10000000000;
                    }
                    else {
                        return "to parameter is wrong"
                    }
                }
                else if (from == "mm2") {
                    if (to == "m2") {
                        return value / 1000000;
                    }
                    else if (to == "km2") {
                        return value / 1000000000000;
                    }
                    else if (to == "sm2" || to == "cm2") {
                        return value / 100;
                    }
                    else {
                        return "to parameter is wrong"
                    }
                }else{
                    return "from parameter is wrong";
                }
                //#endregion
            
            case "length":
                //#region LENGTH
                if (from == "m") {
                    if (to == "km") {
                        return value / 1000;
                    }
                    else if (to == "mm") {
                        return value * 1000;
                    }
                    else if (to == "sm" || to == "cm") {
                        return value * 100
                    }
                    else {
                        return "to parameter is wrong"
                    }
                }
                else if (from == "km") {
                    if (to == "m") {
                        return value * 1000;
                    }
                    else if (to == "mm") {
                        return value * 1000000;
                    }
                    else if (to == "sm" || to == "cm") {
                        return value * 100000;
                    }
                    else {
                        return "to parameter is wrong"
                    }
                }
                else if (from == "cm" || from == "sm") {
                    if (to == "m") {
                        return value / 100;
                    }
                    else if (to == "mm") {
                        return value * 10;
                    }
                    else if (to == "km") {
                        return value / 100000;
                    }
                    else {
                        return "to parameter is wrong"
                    }
                }
                else if (from == "mm") {
                    if (to == "m") {
                        return value / 1000;
                    }
                    else if (to == "km") {
                        return value / 1000000;
                    }
                    else if (to == "sm" || to == "cm") {
                        return value / 10;
                    }
                    else {
                        return "to parameter is wrong"
                    }
                } else {
                    return "from parameter is wrong";
                }
                //#endregion

            case "currency":
                break;

            case "speed":
                //#region SPEED
                if (from=="km/h") {
                    return value/3.6;
                }
                else if (from=="m/s") {
                    return value*3.6;
                }
                else{
                    return "from parameter is wrong";
                }
                //#endregion

            case "angle":
                break;

            case "data":
                break;

            case "weight":
                break;

            case "temperature":
                break;

            default:
                return "type parameter is wrong";
        }











    },

}