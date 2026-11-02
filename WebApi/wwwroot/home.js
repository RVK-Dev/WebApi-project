const progress = document.querySelector("progress")

const post = async () => {
    const name = document.querySelector("#name").value
    const lastName = document.querySelector("#lastName").value
    const email = document.querySelector("#email").value
    const password = document.querySelector("#password").value




    const user = {
        name,
        lastName,
        email,
        password
    };
   
    try {
        if (progress.value < 3) {
            throw Error("your password is not strong enagh")
        }
        const response = await fetch('api/Users',
            {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(user)

            }

        );
        if (response.ok)
        {
            const data = await response.json();
            alert("your sign was successed");
           
        }
        else {
            throw Error("your sign was failed");
            
        }
    }
    catch (e) {
        alert(e.message)
    }
    
};


const get = async () => {


    const Email = document.querySelector("#email1").value
    const Password = document.querySelector("#password1").value

    const UserLogin = {

        Email,
        Password
    };
    try {
    const response = await fetch('api/Users/login',
        {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(UserLogin)

        }

        );
     if (response.ok) {
         const currentUser = await response.json();
         sessionStorage.setItem("currentUser", JSON.stringify(currentUser))
         window.location.href="UserDetails.html"
             
         
 
    }
        else {

        throw Error("your details arent found");
        console.log("")
    }
       }
        catch (e) {
        alert(e.message)
    }


}

const validPassword = async () => {
    const password = document.querySelector("#password").value

    try {
        const response = await fetch('api/Password',
            {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(password)

            }

        );
        if (response.ok) {
            const numOfPass = await response.json();
            progress.value = numOfPass
            if (numOfPass < 2) {
                alert("your password is not strong enagh")
            }
            

        }

    }
    catch (e) {
        alert(e.message)
    }
        

}