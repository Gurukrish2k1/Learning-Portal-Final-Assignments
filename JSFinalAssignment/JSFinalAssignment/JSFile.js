

function BookValidate()
{
    var ele = document.getElementById("bookname").value;
    var i=0;
    var flag = true;
    for(i=0; i<ele.length;i++)
    {
        if(ele[i] == " ")
        {
            document.getElementById("Text").innerHTML = "Empty space is not allowed";
            document.getElementById("bookname").style.border = "5px solid red";
            flag= false;
            break;
        }
        else if(ele[i] == Number(ele[i])){
            document.getElementById("Text").innerHTML = "Numeric values are not allowed";
            document.getElementById("bookname").style.border = "5px solid red";
            flag= false;
            break;
        }
    }
    if(flag)
    {
        if(ele.length >= 50)
        {
            if(ele == "")
            {
                document.getElementById("bookname").style.border = "solid 5px darkblue";
                document.getElementById("Text").innerHTML = "";
            }
            else{
                document.getElementById("Text").innerHTML = "Book Name should not exceed 50 characters";
                document.getElementById("bookname").style.border = "5px solid red";
            }
            
        }
        else
        {
            document.getElementById("bookname").style.border = "solid 5px darkblue";
            document.getElementById("Text").innerHTML = "";
            console.log(ele);      
        }
    }
    
}
function NameValidate()
{
    var name = document.getElementById("name").value;
    var i=0;
    var regex = /[!@#$%^&*()_\-+=\[\]{};':"\\|,.<>\/?~ ]+$/; 

    var flag = true;
    for(i=0; i<name.length;i++)
    {
        if(name[i] == Number(name[i])){
                document.getElementById("AuthorName").innerHTML = "Numeric values are not allowed";
                document.getElementById("name").style.border = "5px solid red";
                flag= false;
                break;
            }
    }
    if(flag)
    {
        if(name.length >= 50)
        {
            if(name == "")
            {
                document.getElementById("name").style.border = "solid 5px darkblue";
                document.getElementById("AuthorName").innerHTML = "";
            }
            else{
                document.getElementById("AuthorName").innerHTML = "Author Name should not exceed 50 characters";
                document.getElementById("name").style.border = "5px solid red";
            }
            
        }
        else if(regex.test(name))
        {
            document.getElementById("AuthorName").innerHTML = "Special Characters are not allowed";
            document.getElementById("name").style.border = "5px solid red";
        }
        else
        {
            document.getElementById("name").style.border = "solid 5px darkblue";
            document.getElementById("AuthorName").innerHTML = "";
            console.log(name);      
        }
    }

}

function MailValidate()
{
    var ele1 = document.getElementById("mail").value;
    var domain = ["com", "in"];
    var i=0, count1=0, count2=0;
    var flag1, flag2;
    for(i=0; i<ele1.length;i++)
    {
        if(ele1[i] == '@')
        {
            count1++;
            if(count1==1)
            {
                flag1 = true;
            }
            
        }
        if(ele1[i] == '.')
        {
            count2++;
            if(count2==1)
            {
                flag2 = true;
            }
        }
          
    }
    if(!(flag1 && flag2))
    {
        if(ele1 == "")
        {
            document.getElementById("mail").style.border = "solid 5px darkblue";
            document.getElementById("mailID").innerHTML = "";
        }
        else
        {
            document.getElementById("mail").style.border = "solid 5px red";
            document.getElementById("mailID").innerHTML = "Invalid Email ID";
        }
    }
    else
    {
        document.getElementById("mail").style.border = "solid 5px darkblue";
        document.getElementById("mailID").innerHTML = "";
        console.log(ele1);      
    }
    
}


function DateValidate()
{
    var date = document.getElementById("published").value;
    var cDate = new Date(date);
    var today = new Date();


    if(cDate >= today)
    {
        document.getElementById("published").style.border = "solid 5px red";
        document.getElementById("Date").innerHTML = "Please enter valid Published year";
    }
    else
    {
        document.getElementById("published").style.border = "solid 5px darkblue";
        document.getElementById("Date").innerHTML = "";
    }
}


function PriceValidate()
{
    var price = document.getElementById("price").value;
    var i=0;
    console.log(price);

    if(!isNaN(price))
    {
        document.getElementById("price").style.border = "solid 5px darkblue";
        document.getElementById("Amount").innerHTML = ""; 
    }
    else
    {
        if(price.length ==0)
        {
            document.getElementById("price").style.border = "solid 5px darkblue";
            document.getElementById("Amount").innerHTML = "";
        }
        else{
            document.getElementById("price").style.border = "solid 5px red";
            document.getElementById("Amount").innerHTML = "Alphabet values are not allowed";
        }
        
    }
}

function Reset()
{
    document.getElementById("price").style.border = "solid 5px darkblue";
    document.getElementById("Amount").innerHTML = "";

    document.getElementById("published").style.border = "solid 5px darkblue";
    document.getElementById("Date").innerHTML = "";

    document.getElementById("mail").style.border = "solid 5px darkblue";
    document.getElementById("mailID").innerHTML = "";

    document.getElementById("name").style.border = "solid 5px darkblue";
    document.getElementById("AuthorName").innerHTML = "";

    document.getElementById("bookname").style.border = "solid 5px darkblue";
    document.getElementById("Text").innerHTML = "";
}

function Save()
{
    var bookname = document.getElementById("bookname").value;
    var mail = document.getElementById("mail").value;
    var name = document.getElementById("name").value;
    var published = document.getElementById("published").value;    
    var price = document.getElementById("price").value;
    var flag = true;
    var i=0;
    var array = [bookname, mail, name, published, price];
    var array2 = ["bookname", "mail", "name", "published", "price"];
    var array3 = ["Text", "mailID", "AuthorName", "Date", "Amount"];
    for( i =0;i<array.length;i++)
    {
        if(array[i].length == 0)
        {
            flag = false;
            var id = array2[i];
            var id2 = array3[i];
            document.getElementById(id).style.border = "solid 5px red";
            document.getElementById(id2).innerHTML = "Field should not be empty";   
        }
    }
    if(flag)
    {
        var BookName = document.getElementById("bookname").value;
        var AuthorName = document.getElementById("name").value;
        var AuthorMail = document.getElementById("mail").value;
        var Published = document.getElementById("published").value;
        var Price = document.getElementById("price").value;
        var Category = document.getElementById("dept").value;

        localStorage.setItem('BookName', BookName);
        localStorage.setItem('AuthorName', AuthorName);
        localStorage.setItem('AuthorEMail', AuthorMail);
        localStorage.setItem('Published', Published);
        localStorage.setItem('Price', Price);
        localStorage.setItem('Category', Category);
    }
}

