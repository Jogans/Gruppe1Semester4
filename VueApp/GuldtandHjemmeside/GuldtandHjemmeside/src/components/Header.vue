
<template>
    <keep-alive>
        <div class="header">

            <div class="title">
                <router-link to='/'><h1>Guldtand</h1></router-link>
            </div>

            <div class="UserBtn">
                <button class="Login" type="button">Login</button>
                <router-link to="/CreateUser" class="Create_user" tag="button">Opret bruger</router-link>
                <router-link to="/ProfilePage" class="MyPage" tag="button">Profile</router-link>

            </div>

            <br style="clear:both" />
            <br style="clear:both" />
            <br style="clear:both" />
            <br style="clear:both" />

            <div class="SearchBar">
                <input style="height: 32px; width: 704px;" type="text" placeholder="Search..." required>
            </div>

            <div class="SearchBarBtn">
                <button class="SearchRecepie" style="height: 32px;" type="button">S&#248;g opskrift</button>
                <button style="height: 32px;" type="button">S&#248;g ingrediens</button>
            </div>

            <br style="clear:both" />
            <br style="clear:both" />

            <div class="Buttons2">
                <router-link to="/TopPage" class="btn_Top" tag="button">Top retter</router-link>
                <router-link to="/NewPage" class="btn_New" tag="button">Nye retter</router-link>
                <router-link to="/SUPage" class="btn_Su" tag="button">SU-retter</router-link>
                <router-link to="/VegiPage" class="btn_Vegi" tag="button">Vegetar retter</router-link>
                <router-link to="/ClassicPage" class="btn_Classic" tag="button">Klassiske retter</router-link>
                <router-link to="/StorePage" class="btn_Store" tag="button">V&#230;lg Butik</router-link>
                <router-link to="/HomemadePizzaTest" class="btn_Pizza" tag="button">Test</router-link>
            </div>
        </div>
    </keep-alive>
</template>

<script>
    export default {
        name: 'Header',
        props: {
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

    .header {
        width: 100%;
        height: 120px;
        background-color: white;
        max-width: 65%;
        margin: auto;
        position: relative;
    }

    .title {
        float: left;
        position: relative;
    }

    .UserBtn {
    }

    .Login {
        display: block;
        position: relative;
        float: right;
    }


    .Create_user {
        display: block;
        position: relative;
        float: right;
        top: auto;
    }

    .MyPage {
        display: block;
        position: relative;
        float: right;
    }

    .SearchBar {
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
    }

    .btn_Top {
        background-color: white;
        border: 2px solid #555555;
        color: black;
        padding: 16px;
        text-align: center;
        text-decoration: none;
        border-radius: 15px; /* Laver den runde kant */
        float: left;
        box-shadow: 0 9px #999;
        display: block;
        margin: 2px;
        font-size: 24px;
    }

        .btn_Top a {
            display: block;
            padding: 15px 32px;
        }

        .btn_Top:active {
            background-color: white;
            box-shadow: 0 5px #666;
            transform: translateY(4px);
        }

    .btn_New {
        background-color: white;
        border: 2px solid #555555;
        color: black;
        padding: 16px;
        text-align: center;
        text-decoration: none;
        border-radius: 15px; /* Laver den runde kant */
        float: left;
        box-shadow: 0 9px #999;
        font-size: 24px;
        margin: 2px;
    }

        .btn_New a {
            display: block;
            padding: 15px 32px;
        }

        .btn_New:active {
            background-color: white;
            box-shadow: 0 5px #666;
            transform: translateY(4px);
        }

    .btn_Su {
        background-color: white;
        border: 2px solid #555555;
        color: black;
        padding: 16px;
        text-align: center;
        text-decoration: none;
        border-radius: 15px; /* Laver den runde kant */
        float: left;
        box-shadow: 0 9px #999;
        font-size: 24px;
        margin: 2px;
    }

        .btn_Su a {
            display: block;
            padding: 15px 32px;
        }

        .btn_Su:active {
            background-color: white;
            box-shadow: 0 5px #666;
            transform: translateY(4px);
        }

    .btn_Vegi {
        background-color: white;
        border: 2px solid #555555;
        color: black;
        padding: 16px;
        text-align: center;
        text-decoration: none;
        border-radius: 15px; /* Laver den runde kant */
        float: left;
        box-shadow: 0 9px #999;
        font-size: 24px;
        margin: 2px;
    }

        .btn_Vegi a {
            display: block;
            padding: 15px 32px;
        }

        .btn_Vegi:active {
            background-color: white;
            box-shadow: 0 5px #666;
            transform: translateY(4px);
        }

    .btn_Classic {
        background-color: white;
        border: 2px solid #555555;
        color: black;
        padding: 16px;
        text-align: center;
        text-decoration: none;
        border-radius: 15px; /* Laver den runde kant */
        float: left;
        box-shadow: 0 9px #999;
        font-size: 24px;
        margin: 2px;
    }

        .btn_Classic a {
            display: block;
            padding: 15px 32px;
        }

        .btn_Classic:active {
            background-color: white;
            box-shadow: 0 5px #666;
            transform: translateY(4px);
        }

    .btn_Store {
        background-color: white;
        border: 2px solid #555555;
        color: black;
        padding: 16px;
        text-align: center;
        text-decoration: none;
        border-radius: 15px; /* Laver den runde kant */
        float: left;
        box-shadow: 0 9px #999;
        font-size: 24px;
        margin: 2px;
    }

        .btn_Store a {
            display: block;
            padding: 15px 32px;
        }

        .btn_Store:active {
            background-color: white;
            box-shadow: 0 5px #666;
            transform: translateY(4px);
        }

    a:hover {
        cursor: pointer; /* Ændre musen når den holdes over en knap */
    }
</style>

