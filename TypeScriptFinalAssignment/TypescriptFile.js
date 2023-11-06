var Billionaires = /** @class */ (function () {
    function Billionaires(name, url) {
        this.Name = name;
        this.URL = url;
    }
    Billionaires.prototype.names = function () {
        return this.Name;
    };
    Billionaires.prototype.urls = function () {
        return this.URL;
    };
    return Billionaires;
}());
var billArray = [new Billionaires("1.Elon Musk", "images/Elon.jpg"), new Billionaires("2.Bernard Arnault", "images/Bernard.jpg"), new Billionaires("3.Jeff Bezos", "images/Jeff.jpg"), new Billionaires("4.Bill Gates", "images/Bill.jpg"), new Billionaires("5.Larry Ellison", "images/Larry.jpg"), new Billionaires("6.Steve Ballmer", "images/Ballmer.jpg"), new Billionaires("7.Warren Buffet", "images/WarrenBuffet.jpg"), new Billionaires("8.Larry Page", "images/LaryPage.jpg"), new Billionaires("9.Sergey Brin", "images/Brin.jpg"), new Billionaires("10.Mark Zuckerberg", "images/MetaMark.jpg")];
var count = -1;
function Next() {
    if (count == billArray.length - 1) {
        count = -1;
    }
    count++;
    var caption = document.getElementById("caption");
    caption === null || caption === void 0 ? void 0 : caption.innerText = billArray[count].Name;
    var photos = document.getElementById("image");
    photos.setAttribute("src", billArray[count].URL);
}
function Previous() {
    count--;
    if (count < 0) {
        count = billArray.length - 1;
    }
    var caption = document.getElementById("caption");
    caption === null || caption === void 0 ? void 0 : caption.innerText = billArray[count].Name;
    var photos = document.getElementById("image");
    photos.setAttribute("src", billArray[count].URL);
}
