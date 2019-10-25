//EasyCode Azerbaijani Core
//Do not change anything.Else can be some problems

//#region Independent functions
function yaz(str) {
    document.write(str);
    write_status = "write";
}

function yyaz(str) {
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

function mesaj(str){
    window.alert(str);
}

function tarix(format,seperator){ 
    format = format || 'gai';
    seperator = seperator || "/";
    date_day = date_object.getDate();
    date_day_of_week = date_object.getDay();
    date_month = date_object.getMonth();
    date_year = date_object.getFullYear();
    
    for (var i = 0; i < format.length;i++){
        if (format[i]=="g") {
            full_date_string+=date_day;
        }
        else if (format[i]=="a") {
            full_date_string+=date_month;
        }
        else if (format[i]=="i") {
            full_date_string+=date_year;
        }
        else if (format[i]=="h") {
            full_date_string+=date_day_of_week;
        }
        if (i != format.length-1) {
            full_date_string+=seperator;
        }
    }
    return full_date_string;
}

function temizle(){
    document.querySelector("body").innerHTML = "<div id=\"added\"></div><script type=\"text/javascript\" src=\"script.js\"></script>"
}
//#endregion


const stil = {
    arxaplanRengi:function (value) {
        document.querySelector("body").style.backgroundColor = value;
    },
    srift:{
        reng:function (value) {
            document.querySelector("body").style.color = value;
        },
        stil:function (value) {
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
    arxaplanSekli: function (imgurl,size) {
        size = size || "cover";
        document.querySelector("body").style.backgroundImage = "url("+imgurl+")";
        switch (size) {
            case "tut":
                document.querySelector("body").style.backgroundSize = "cover";       
                break;
            case "normal":
                document.querySelector("body").style.backgroundSize = "normal";
                break;
            default:
                break;
        }
    },
}

const dizayn = {
    elave: {
        yaz:function(text,color,size,manual_css){
            manual_css = manual_css || "font-family:Arial;";
            createLabel(text,color,size,manual_css);
        },
        naviqasiya: function (arr, cl) {
            cl = cl || "default";
            switch (cl) {
                case "defolt":
                    cl = "default"
                    break;
            
                case "qara":
                    cl = "dark";
                    break;

                default:
                    break;
            }
            createNavbar(cl,arr);
        },
    },
}



// Color translator from Azerbaijani
function rengaz(color){
    switch (color) {
        case "":
            return "";

        case "":
            return "";

        case "":
            return "";

        case "":
            return "";

        case "":
            return "";

        case "":
            return "";

        default:
            break;
    }
}