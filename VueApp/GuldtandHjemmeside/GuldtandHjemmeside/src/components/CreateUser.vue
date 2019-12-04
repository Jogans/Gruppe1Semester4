<template>
    <div class="Login">
        <div class="container">
            <h1>Tilmeld</h1>
            <p> Udfyld venligst denne formular for at oprette en konto.</p>
            <hr>

            <label for="email"><b>Email</b></label>
            <input type="text" v-model="email" placeholder="Skriv Email" name="email" required>



            <label for="psw">
                <b>Adgangskode</b><br />
                Adgangskoden skal indeholde mindst et tal, <br />
                Adgangskoden skal indeholde mindst en karakter med sm&#229; bogstav, <br />
                Adgangskoden skal indeholde mindst en karakter med stort bogstav, <br />
                Adgangskoden skal indeholde mindst have en l&#230;ngde p&#229; mindst 6 karakterer, <br />
                Adgangskoden skal indeholde mindst en unik karakter
            </label>

            <input type="password" v-model="password" placeholder="Skriv Adgangskode" name="psw" required>

            <label for="psw-repeat"><b>Gentag Adgangskode</b></label>
    <input type="password" placeholder="Gentag Adgangskode" name="psw-repeat" required>

            <label>
                <input type="checkbox" checked="checked" name="remember" style="margin-bottom:15px"> Husk mig
            </label>

            <p>By creating an account you agree to our <a href="#" style="color:dodgerblue">Terms & Privacy</a>.</p>

            <div class="clearfix">
                <button type="button" class="cancelbtn">Annuler</button>
                <button class="signupbtn" @click="created">Tilmeld</button>
            </div>
        </div>
    </div>

</template>

<script>
    export default {
        name: 'CreateUser',
        props: {
        },
        data: function () {
            return {
                email: null,
                name: null,
                password: null,
                info: null
            }
        },
        methods: {
            HandleErrors: function (response) {
                if (!response.ok) {
                    throw Error(response.statusText);
                }
                VueRouter.push()
                
            },
            created() {
               fetch('https://localhost:44324/api/Account/Register', {
                    method: 'POST',
                   body: JSON.stringify({
                        Email: this.email,
                        Password: this.password
                    }),
                    headers: new Headers({
                        'Content-Type': 'application/json'
                    })
               }).then(this.HandleErrors)
                    .then(response => console.log(response))
                    .catch(error => console.log(error));
            },
        }
    };

</script>

<style scoped>
    body {
        font-family: Arial, Helvetica, sans-serif;
    }

    * {
        box-sizing: border-box
    }

    /* Full-width input fields */
    input[type=text], input[type=password] {
        width: 100%;
        padding: 15px;
        margin: 5px 0 22px 0;
        display: inline-block;
        border: none;
        background: #f1f1f1;
    }

        input[type=text]:focus, input[type=password]:focus {
            background-color: #ddd;
            outline: none;
        }

    hr {
        border: 1px solid #f1f1f1;
        margin-bottom: 25px;
    }

    /* Set a style for all buttons */
    button {
        background-color: #4CAF50;
        color: white;
        padding: 14px 20px;
        margin: 8px 0;
        border: none;
        cursor: pointer;
        width: 100%;
        opacity: 0.9;
    }

        button:hover {
            opacity: 1;
        }

    /* Extra styles for the cancel button */
    .cancelbtn {
        padding: 14px 20px;
        background-color: #f44336;
    }

    /* Float cancel and signup buttons and add an equal width */
    .cancelbtn, .signupbtn {
        float: left;
        width: 50%;
    }

    /* Add padding to container elements */
    .container {
        padding: 16px;
    }

    /* Clear floats */
    .clearfix::after {
        content: "";
        clear: both;
        display: table;
    }

    .Login {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }

    /* Change styles for cancel button and signup button on extra small screens */
    @media screen and (max-width: 300px) {
        .cancelbtn, .signupbtn {
            width: 100%;
        }
    }
</style>