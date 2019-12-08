<template>
    <div class="body">
        <br style="clear:both" />
        <h2>Brugernavn: </h2>

        <button class="resetPassword">&#230;ndre adgangskode</button>
        <br style="clear:both" />
        <div class="Pref">
            <h2>Indstillinger</h2>
            For at &#230;ndre indstillinger i forhold til butikker bruges sidebaren til venstre.
        </div>
    </div>
</template>

<script>
    export default {
        name: 'ProfilePage',
        data() {
            return {
                recepie: {
                }
            }
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    /*.body {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }*/

    img {
        display: block;
        position: absolute;
        width: 350px;
        height: 200px;
}
    .viewOfRecepie {
        width: 900px;
        height: 200px;
        border: 2px solid;
        padding: 2px;
        margin: 20px;
    }

    .textForPrice{
        display: block;
        position: relative;
        float: left;
        margin-left: 355px;
        font-size: 20px;
    }

</style>

