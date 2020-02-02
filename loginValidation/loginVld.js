let userData = [{
        email: 'knorr@live.com',
        password: 'ksGuQbzYPpW'
    },
    {
        email: 'rddesign@msn.com',
        password: '9Q6urHqy'
    },
    {
        email: 'chaffar@yahoo.ca',
        password: '4xaz2pyk'
    },
    {
        email: 'fatelk@mac.com',
        password: 'TAePJSb2ACX'
    },
    {
        email: 'luebke@me.com',
        password: 'EyFY8uhX'
    },
    {
        email: 'amichalo@mac.com',
        password: 'c7muQ6bxcA9QJKS'
    },
    {
        email: 'mallanmba@yahoo.ca',
        password: 'NqCGLmGtcFU'
    },
    {
        email: 'isaacson@att.net',
        password: 'PMjRGUug7Ff73Kt'
    },
    {
        email: 'aracne@aol.com',
        password: 'sBJU7JJR7Qx6f55'
    },
    {
        email: 'boser@comcast.net',
        password: 'DMXQRNj7BHZ'
    },
    {
        email: 'gtaylor@verizon.net',
        password: 'AbefrKfkbxHbP3u'
    },
    {
        email: 'firstpr@comcast.net',
        password: 'PGWPUtcwP'
    },
    {
        email: 'sumdumass@sbcglobal.net',
        password: '2DrCpjkk9mm8bjW'
    },
    {
        email: 'campbell@yahoo.com',
        password: 'ZmYZgaDq6'
    },
    {
        email: 'wetter@me.com',
        password: 'ppTG3pGAe'
    },
    {
        email: 'british@verizon.net',
        password: '67SbpGYvPJ2'
    }
]



checkLgn = 0;


function CheckMail() {
    let user = document.getElementById('email');
    let pass = document.getElementById('pass');
    if (checkLgn < 3) {
        for (i = 0; i < userData.length; i++) {



            if ((user.value === userData[i].email) && (pass.value != userData[i].password)) {
                alert('Incorrect password');
                checkLgn++;
                return;
            }



            if ((user.value === userData[i].email) && (pass.value === userData[i].password)) {

                return document.getElementById('root').innerHTML = '<h1>CORRECT! YOU ENTERED !!</h1><input type="button" id="logout" value="logout" style="margin:50px;" />';



            }


        }
        for (i = 0; i < userData.length; i++)
            if (user.value != userData[i].email) {
                alert('Wrong email');
                checkLgn++;
                return;
            }
    } else alert('ERROR');
}




document.getElementById('loginBtn').addEventListener('click', CheckMail);


