
<template>
    <keep-alive>
        <div class="header">
            <div class="TopPart">
                <div class="title">

                    <router-link to="/"><img src="@/assets/Pics/Guldtand.jpg" alt="Guldtand" tag="button" /></router-link>
                    <router-link to="/"><h1 class="headerName">GuldTand</h1></router-link>
                    <div class="loginDiv">
                        <template v-if="!LoggedIn">
                            <input class="input usernameinput" type="text" placeholder="Indtast brugernavn" v-model="email" name="uname" required />
                            <button class="login" @click="Login">Login</button>
                            <input class="input passwordinput" type="password" placeholder="Indtast kodeord" v-model="password" name="psw" required />
                            <router-link to="/CreateUser" class="create_user" tag="button">Opret bruger</router-link>
                        </template>
                        <template v-if="LoggedIn">
                            <span><strong>Hej {{ username }}</strong></span>
                            <!--<router-link to="/ProfilePage" class="MyPage" tag="button">Profile</router-link>-->
                            <button class="btn btn-r logout" @click="Logout">Log ud</button>
                        </template>
                    </div>

                </div>
                <br style="clear:both" />
                <div class="Buttons2">
                    <router-link to="/" class="btn btnfirst" tag="button">Forside</router-link>
                    <router-link to="/TopPage" class="btn" tag="button">Top retter</router-link>
                    <router-link to="/AllRecipes" class="btn" tag="button">Alle retter</router-link>
                    <!--<router-link to="/VegiPage" class="btn btn_Vegi" tag="button">Vegetar retter</router-link>-->
                    <router-link to="/SearchBar" class="btn" tag="button">S&#248;g</router-link>
                    <!--<router-link to="/SUPage" class="btn btn_Su" tag="button">SU-retter</router-link>-->
                    <!--<router-link to="/Recipe/ShowRecipe" class="btn btn_Classic" tag="button">Klassiske retter</router-link>-->
                    <!--<router-link to="/StorePage" class="btn btn_Store" tag="button">V&#230;lg Butik</router-link>-->

                    <template v-if="LoggedIn">
                        <router-link to="/ProfilePage" class="btn btn-r MyPage" tag="button">Profil</router-link>
                        <router-link to="/CreateRecipe" class="btn btn-r btn_CreateRecipe" tag="button">Opret Opskrift</router-link>
                    </template>

                    <!--<br style="clear:both" />-->
                    <!--<router-link to="/TestCalculator" class="btn_TestCalculator" tag="button">Calculator Test</router-link>-->
                </div>
            </div>
        </div>
    </keep-alive>
</template>

<script>
    export default {
        name: 'Header',
        props: {
        },
        data: function () {
            return {
                email: null,
                password: null,
                info: null,
                LoggedIn: false,
                username: null
            }
        },
        methods: {
            LoginHandleErrors: function (response) {
                if (!response.ok) {
                    alert("Forkert login eller password")
                    throw Error(response.statusText);
                }
                this.LoggedIn = true,
                this.getCookie()
                return this.$router.push(this.$route.query.redirect || '/ProfilePage');
            },

            LogoutHandleErrors: function (response) {
                if (!response.ok) {
                    throw Error(response.statusText);
                }
                this.LoggedIn = false
                return this.$router.push(this.$route.query.redirect || '/');
            },

            Login() {
                fetch('https://nyguldtand.azurewebsites.net/api/Account/Login', {
                    method: 'POST',
                    body: JSON.stringify({
                        Email: this.email,
                        Password: this.password
                    }),
                    headers: new Headers({
                        'Content-Type': 'application/json'
                    })
                }).then(this.LoginHandleErrors)
                    .then(response => console.log(response))
                    .catch(error => console.log(error));
            },
            Logout() {
                fetch('https://nyguldtand.azurewebsites.net/api/Account/Logout', {
                    method: 'POST',
                    headers: new Headers({
                        'Content-Type': 'application/json'
                    })
                }).then(this.LogoutHandleErrors)
                    .then(response => console.log(response))
                    .catch(error => console.log(error));
            },
            getCookie() {
                var name;
                var decodedCookie = decodeURIComponent(document.cookie);
                var ca = decodedCookie.split('=');
                for (var i = 0; i < ca.length; i++) {
                    var c = ca[i];
                    while (c.charAt(0) == ' ') {
                        c = c.substring(1);
                    }
                    if (c.indexOf(name) == 0) {
                        return c.substring(name.length, c.length);
                    }
                }
                this.username = c;
                return this.username;
            }                  

            },


        

    };



</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

    img {
        position: static;
        float: left;
        height: 10%;
        width: 10%;
        display: block;
        overflow: auto;
    }

    .header {
        width: 100%;
        max-width: 65%;
        height: auto;
        background-color: white;
        margin: auto;
        position: relative;
    }

    .TopPart {
        padding: 20px 0;
    }

    .title {
        float: left;
        display: block;
        position: relative;
    }

    .headerName {
        display: block;
        position: relative;
        float: left;
        padding-left: 20px;
        text-size-adjust: 80%;
    }

    .UserBtn {
        display: block;
        position: relative;
        clear: left;
        float: right;
    }

    .btn {
        border: none;
        color: black;
        padding: 15px 20px;
        text-align: center;
        text-decoration: none;
        float: left;
        display: block;
        margin: 4px;
        font-size: 20px;
    }

    .btn-r {
        float: right;
    }

    .btnfirst {
        margin-left: 0px;
    }

    .btnlast {
        margin-right: 0px;
    }

    .btn a {
        display: block;
        padding: 15px 32px;
    }

    .btn:active {
        border-bottom: 2px solid#666;
    }

    .btn:hover {
        cursor: grab;
        border-bottom: 5px solid grey;
    }

    .loginDiv {
        width: 270px;
        display: block;
        position: relative;
        float: right;
        padding-top: 20px;
    }


    .input {
        width:150px;
        display: block;
        position: relative;
        float: left;
        border: none;
        padding: 5px;
        background-color: #f1f1f1;
        margin-bottom: 5px;
    }

        .input:focus {
            background-color: lightblue;
            outline: none
        }

    .login {
        display: block;
        position: relative;
        float: right;
        width: 100px;
        height: 25px;
        font-size:12px;
    }

    .create_user {
        display: block;
        position: relative;
        float: right;
        width: 100px;
        height: 25px;
        font-size:12px;
    
    }

    .logout {
        color: #DF5C40;
    }

    .MyPage {
        display: block;
        position: relative;
        float: right;
    }

    .router-link-active {
        color: black;
        text-decoration: none;
    }

    .router-link-exact-active {
        border-bottom: 5px solid var(--accent-color);
    }
</style>

