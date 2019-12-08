
<template>
    <keep-alive>
        <div class="header">
            <div class="TopPart">
                <div class="title">

                    <router-link to="/"><img src="@/assets/Pics/Guldtand.jpg" alt="Guldtand" tag="button" /></router-link>
                    <router-link to="/"><h1 class="headerName">GuldTand</h1></router-link>
                    <div class="loginDiv">
                        <template v-if="!LoggedIn">
                            <input class="input usernameinput" type="text" placeholder="Indtast email" v-model="email" name="uname" required />
                            <button class="login" @click="Login">Login</button>
                            <input class="input passwordinput" type="password" placeholder="Indtast kodeord" v-model="password" name="psw" required />
                            <router-link to="/CreateUser" class="create_user" tag="button">Opret bruger</router-link>
                        </template>
                        <template v-if="LoggedIn">
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
                <br style="clear:both" />
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
                LoggedIn: false
            }
        },
        methods: {
            LoginHandleErrors: function (response) {
                if (!response.ok) {
                    alert("Forkert login eller password")
                    throw Error(response.statusText);
                }
                this.LoggedIn = true
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
                fetch('https://localhost:44324/api/Account/Login', {
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
                fetch('https://localhost:44324/api/Account/Logout', {
                    method: 'POST',
                    headers: new Headers({
                        'Content-Type': 'application/json'
                    })
                }).then(this.LogoutHandleErrors)
                    .then(response => console.log(response))
                    .catch(error => console.log(error));
            },


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
        ;
    }

    .btnlast {
        margin-right: 0px;
    }

    .btn a {
        display: block;
        padding: 15px 32px;
    }

    .btn:active {
        /*background-color: white;*/
        border-bottom: 2px solid#666;
    }

    .btn:hover {
        cursor: grab; /* Ændre musen når den holdes over en knap */
        border-bottom: 5px solid grey;
        /*margin-bottom: -5px;*/
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

    .usernameinput {
    }

    .passwordinput {
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

    /*.logout:hover {
        background-color: #DF5C40;
    }*/

    .MyPage {
        display: block;
        position: relative;
        float: right;
    }

    /*.SearchBar {
        float: left;
        display: inline-block;
        color: black;
        font-size: 24px;
        font-family: verdana;
        text-align: left;
        margin-top: 0px;
        float: left;
        margin: 0px;
        line-height: 40px;
    }

    .SearchBarBtn {
        float: left;
        display: block;
        color: black;
        font-size: 24px;
        float: left;
        margin: 6px;
        padding-right: 15px;
        padding-bottom: 10px;
    }*/


    .router-link-active {
        color: black;
        text-decoration: none;
    }

    .router-link-exact-active {
        border-bottom: 5px solid var(--accent-color);
    }
</style>

