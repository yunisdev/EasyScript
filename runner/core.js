//EasyCode Core
//Do not change anything.Else can be some problems

//#region GLOBALS
let newLine = "<br>";
let write_status = "none";
const date_object = new Date();

//----DATE
let date_day;
let date_day_of_week;
let date_year;
let date_month;
let full_date_string = "";

//#endregion

//#region Independent functions
function write(str) {
  document.write(str);
  write_status = "write";
}

function writeln(str) {
  str = str || "<br>";
  if (str != "<br>") {
    if (write_status == "none") {
      document.write(str + "<br>");
      write_status = "writeln";
    } else if (write_status == "write") {
      document.write("<br>" + str + "<br>");
      write_status = "writeln";
    } else if (write_status == "writeln") {
      document.write(str + "<br>");
      write_status = "writeln";
    }
  } else {
    document.write("<br>");
    write_status = "writeln";
  }
}

function msbox(str) {
  window.alert(str);
}

function getDate(format, seperator) {
  format = format || "dmy";
  seperator = seperator || "/";
  date_day = date_object.getDate();
  date_day_of_week = date_object.getDay();
  date_month = date_object.getMonth();
  date_year = date_object.getFullYear();

  for (var i = 0; i < format.length; i++) {
    if (format[i] == "d") {
      full_date_string += date_day;
    } else if (format[i] == "m") {
      full_date_string += date_month;
    } else if (format[i] == "y") {
      full_date_string += date_year;
    } else if (format[i] == "w") {
      full_date_string += date_day_of_week;
    }
    if (i != format.length - 1) {
      full_date_string += seperator;
    }
  }
  return full_date_string;
}

function clear() {
  document.querySelector("body").innerHTML =
    '<div id="added"></div><script type="text/javascript" src="script.js"></script>';
}

//#endregion

function setbackcolor(value) {
  document.querySelector("body").style.backgroundColor = value;
}
function setbackimage(imgurl, size) {
  size = size || "cover";
  document.querySelector("body").style.backgroundImage = "url(" + imgurl + ")";
  switch (size) {
    case "cover":
      document.querySelector("body").style.backgroundSize = "cover";
      break;
    case "normal":
      document.querySelector("body").style.backgroundSize = "normal";
      break;
    default:
      break;
  }
}
function lineargradientforback(value1, value2, value3) {
  value3 = value3 || "90deg";
  document
    .querySelector("body")
    .setAttribute(
      "style",
      "background-image: linear-gradient(" +
        value3 +
        ", " +
        value1 +
        ", " +
        value2 +
        ")"
    );
}

//#region Style object
var body = document.querySelector("body");
const style = {
  setBack: function(type, value) {
    switch (type) {
      case "color":
        setbackcolor(value);
        break;

      case "img":
        if (typeof value == "string") {
          setbackimage(value);
        } else {
          setbackimage(value[0], value[1]);
        }
        break;

      case "lg":
        lineargradientforback(value[0], value[1], value[2]);
        break;
      default:
        clear();
        return "type could not found!!!";
    }
  },

  setFont: {
    color: function(value) {
      document.querySelector("body").style.color = value;
    },
    style: function(value) {
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
    }
  }
};
//#endregion

//#region Doc object
const doc = {
  add: {
    p: function(text, cl, style, display) {
      cl = cl || "none-class";
      style = style || "";
      display = display || "inline-block";
      document.querySelector("#added").innerHTML +=
        "<p class='" +
        cl +
        "' style='display:" +
        display +
        ";" +
        style +
        ";'>" +
        text +
        "</p>";
    },
    html: function(code) {
      document.querySelector("#added").innerHTML += code;
    },
    css: function(selector, code) {
      var coded = document.querySelector(selector).getAttribute("style");
      document
        .querySelector(selector)
        .setAttribute("style", coded + ";" + code + ";");
    },
    block: function(id) {
      document.querySelector("#added").innerHTML +=
        "<div style id='" + id + "'></div>";
    }
  },
  hide: function(selector) {
    document.querySelector(selector).style.display = "none";
  },
  show: function(selector) {
    document.querySelector(selector).style.display = "inherit";
  }
};
//#endregion

//#region Math Object
const math = {
  pi: 3.14,
  PI: 3.1415926535897932384626433832795,
  power: function(int1, int2) {
    var result = 1;
    for (var i = 1; i <= int2; i++) {
      result = result * int1;
    }
    return result;
  },
  factorial: function(integer) {
    var result = 1;
    for (var i = integer; i > 0; i--) {
      result *= i;
    }
    return result;
  },
  sqrt: function(int) {
    Math.sqrt(int);
  },
  cos: function(int) {
    return Math.abs(Math.cos(int));
  },
  sin: function(int) {
    return Math.abs(Math.sin(int));
  },
  tg: function(int) {
    return Math.abs(Math.tan(int));
  },
  ctg: function(int) {
    return Math.abs(1 / this.tg(int));
  }
};
//#endregion

const design = {
  add: {
    label: function(text, color, size, manual_css) {
      manual_css = manual_css || "font-family:Arial;";
      createLabel(text, color, size, manual_css);
    },
    navbar: function(arr, cl) {
      cl = cl || "default";
      createNavbar(cl, arr);
    }
  }
};

//#region OTHERS FOR DESIGN
let navbar_status;
let added_inner;
function createNavbar(cl, arr) {
  var inner = "";
  for (var i = 0; i < arr.length; i++) {
    if (i == arr.length - 1 && arr.length % 2 == 1) {
      inner += '<li class="last-item-of-navbar"><a>' + arr[i] + "</a></li>";
      break;
    }
    inner += "<li><a>" + arr[i] + "</a></li>";
  }
  added_inner = document.querySelector("#added").innerHTML;
  document.querySelector("#added").innerHTML =
    '<nav id="autogeneratednavbar" class="auto-navbar-' +
    cl +
    ' "><ul>' +
    inner +
    "</ul ></nav >" +
    added_inner;
  navbar_status = "created";
}
function createLabel(text, color, size, manual_css) {
  document.querySelector("#added").innerHTML +=
    '<label style="' +
    manual_css +
    ";color:" +
    color +
    ";font-size:" +
    size +
    ';">' +
    text +
    "</label>";
}
//#endregion

const nl = "<br>";
function foreach(arr, seperator) {
  for (var i = 0; i <= arr.length - 1; i++) {
    write(arr[i]);
    write(seperator);
  }
}
